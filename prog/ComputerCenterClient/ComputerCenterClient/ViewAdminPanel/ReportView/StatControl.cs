using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerCenterClient.Models;

namespace ComputerCenterClient.View.ReportView;

public partial class StatControl : UserControl
{
    private ReportControl mainController;

    public StatControl(ReportControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();
    }

    private void InitData()
    {
        InitLabel();
        InitBox();
    }

    private async void InitBox()
    {
        List<Product> products = await mainController.ProductController.GetAllProductsAsync();

        foreach(var product in products)
        {
            int quantity = 0;

            List<PurchasedProduct> purProd = await mainController.PurchasedProductController.GetPurchasedProductsByIdProduct(product.Id);

            foreach(var pur in purProd)
            {
                quantity += pur.Quantity;
            }

            flowLayoutPanel1.Controls.Add(new ProductRow(product, quantity));
        }


    }


    private async void InitLabel()
    {
        List<Product> products = await mainController.ProductController.GetAllProductsAsync();
        List<Services> services = await mainController.ServicesController.GetAllServicesAsync();
        //List<Customer> customers = await mainController.CustomerController.GetAllCustomersAsync();
        List<Order> orders = await mainController.OrderController.GetAllOrdersAsync();
        List<Provider> providers = await mainController.ProviderController.GetAllProvidersAsync();
        List<Manufacture> manufactures = await mainController.ManufactureController.GetAllManufacturesAsync();

        label3.Text = products.Count.ToString();
        label5.Text = services.Count.ToString();
        //label7.Text = customers.Count.ToString();
        label9.Text = orders.Count.ToString();
        label11.Text = providers.Count.ToString();
        label13.Text = manufactures.Count.ToString();

    }

}
