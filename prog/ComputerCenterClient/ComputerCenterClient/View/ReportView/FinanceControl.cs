using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ComputerCenterClient.Models;

namespace ComputerCenterClient.View.ReportView;

public partial class FinanceControl : UserControl
{
    private ReportControl mainController;

    public FinanceControl(ReportControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();
    
    }

    private void InitData()
    {
        InitLabels();
        InitChart();
    }

    private async void InitChart()
    {
        chart1.Series.Clear();

        Series seriesProd = new Series()
        {
            Name = "ProfitFromProducts",
            Color = System.Drawing.Color.Green,
            ChartType = SeriesChartType.Column 
        };

        Series seriesServices = new Series()
        {
            Name = "ProfitFromServices",
            Color = System.Drawing.Color.Blue,
            ChartType = SeriesChartType.Column 
        };



        List<Order> Orders = await mainController.OrderController.GetAllOrdersAsync();

        Dictionary<int, decimal> prodDict = new Dictionary<int, decimal>();
        Dictionary<int, decimal> servDict = new Dictionary<int, decimal>();

        foreach(var order in Orders)
        {
            List<PurchasedProduct> purProd = await mainController.PurchasedProductController.GetPurchasedProductsByIdOrder(order.Id);
            List<PurchasedServices> purServ = await mainController.PurchasedServicesController.GetPurchasedServicesByIdOrder(order.Id);

            decimal prodProfit = 0;
            decimal servProfit = 0;

            foreach(var pur in purProd)
            {
                Product product = await mainController.ProductController.GetProductById(pur.Id_Product);
                prodProfit += product.Price * pur.Quantity;
            }

            foreach(var pur in purServ)
            {
                Services services = await mainController.ServicesController.GetServicesById(pur.Id_Services);
                servProfit += services.Price * pur.Quantity;
            }

            if (prodDict.ContainsKey(order.Date.Year))
            {
                prodDict[order.Date.Year] += prodProfit;
            }
            else
            {
                prodDict.Add(order.Date.Year, prodProfit);
            }

            if (servDict.ContainsKey(order.Date.Year))
            {
                servDict[order.Date.Year] += servProfit;
            }
            else
            {
                servDict.Add(order.Date.Year, servProfit);
            }

        }

        foreach (var item in prodDict)
        {
            seriesProd.Points.AddXY(item.Key, item.Value);
        }

        foreach (var item in servDict)
        {
            seriesServices.Points.AddXY(item.Key, item.Value);
        }




        chart1.Series.Add(seriesProd);
        chart1.Series.Add(seriesServices);

        // Настройка осей
        chart1.ChartAreas[0].AxisX.Title = "Years";
        chart1.ChartAreas[0].AxisY.Title = "Profit";

        // Заголовок диаграммы
        chart1.Titles.Add("Profit in Year");

    } 




    private async void InitLabels() 
    {
        List<Product> products = [];
        products = await mainController.ProductController.GetAllProductsAsync();

        int ProdQuantity = 0;
        decimal GenProfitProd = 0;

        foreach(var product in products)
        {
            List<PurchasedProduct> purchasedProducts = await mainController.PurchasedProductController.GetPurchasedProductsByIdProduct(product.Id);
            
            foreach(var pur in purchasedProducts)
            {
                ProdQuantity += pur.Quantity;
                GenProfitProd += pur.Quantity * product.Price;
            } 
        }

        label9.Text = ProdQuantity.ToString();
        label5.Text = GenProfitProd.ToString("0.00");


        List<Services> services = await mainController.ServicesController.GetAllServicesAsync();

        int ServQuantity = 0;
        decimal GenProfitServ = 0;

        foreach(var serv in services)
        {
            List<PurchasedServices> purchasedServices = await mainController.PurchasedServicesController.GetPurchasedServicesByIdServices(serv.Id);

            foreach(var pur in purchasedServices)
            {
                ServQuantity += pur.Quantity;
                GenProfitServ += pur.Quantity * serv.Price;
            }
        }

        label11.Text = ServQuantity.ToString();
        label7.Text = GenProfitServ.ToString("0.00");

        label3.Text = (GenProfitServ + GenProfitProd).ToString("0.00");
        label12.Text = (ServQuantity + ProdQuantity).ToString();

    }

}
