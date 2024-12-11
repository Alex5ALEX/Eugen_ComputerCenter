using ComputerCenterClient.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerCenterClient.Models;
using System.Diagnostics;
using ComputerCenterClient.View.CustomerView;
using ComputerCenterClient.View.OrderView.Rows;
using ComputerCenterClient.View.ProductView;
using ComputerCenterClient.View.ServicesView;


namespace ComputerCenterClient.View.OrderView;

public partial class OrderEdit : UserControl
{
    private OrderControl mainController;

    private Order order;


    private List<CustomerShortRow> customerRow = [];
    private List<ProductShortRow> productRow = [];
    private List<ServicesShortRow> servicesRow = [];

    public Customer choisedCustomer;

    public OrderEdit(OrderControl mainController, Order order )
    {
        this.mainController = mainController;
        this.order = order;

        InitializeComponent();
        InitData();


        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }

    private async void InitData()
    {
        dateTimePicker1.Value = order.Date;
        choisedCustomer = await mainController.customerController.GetCustomerById(order.Id_Customer);
        ShowCustomer();

        InitCustomers();
        InitProducts();
        InitServices();
    }

    private async void InitCustomers()
    {
        flowLayoutPanelCustomers.Controls.Clear();

        List<Customer> customers = await mainController.customerController.GetAllCustomersAsync();

        foreach (Customer customer in customers)
        {
            CustomerShortRow customerShortRow = new CustomerShortRow(this, customer);
            customerRow.Add(customerShortRow);
            flowLayoutPanelCustomers.Controls.Add(customerShortRow);
        }

    }

    private async void InitProducts()
    {
        flowLayoutPanelProduct.Controls.Clear();

        List<Product> products = await mainController.productController.GetAllProductsAsync();

        List<PurchasedProduct> purProd = await mainController.purchasedProductController.GetPurchasedProductsByIdOrder(order.Id);

        foreach (Product product in products)
        {
            ProductShortRow productShortRow = new ProductShortRow(product);
            
            foreach(var pur in purProd)
            {
                if(pur.Id_Product == product.Id)
                {
                    productShortRow.setQuantity(pur.Quantity);
                }
            }
            
            productRow.Add(productShortRow);
            flowLayoutPanelProduct.Controls.Add(productShortRow);
        }
    }


    private async void InitServices()
    {
        flowLayoutPanelServices.Controls.Clear();

        List<Services> services = await mainController.servicesController.GetAllServicesAsync();

        List<PurchasedServices> purServ = await mainController.purchasedServicesController.GetPurchasedServicesByIdOrder(order.Id);
        
        foreach (Services services1 in services)
        {
            ServicesShortRow servicesShortRow = new ServicesShortRow(services1);
        
            foreach(var pur in purServ)
            {
                if(pur.Id_Services == services1.Id)
                {
                    servicesShortRow.setQuantity(pur.Quantity);
                }
            }

            servicesRow.Add(servicesShortRow);
            flowLayoutPanelServices.Controls.Add(servicesShortRow);
        }

    }



    public void ShowCustomer()
    {
        label2.Text = choisedCustomer.Name;
        label4.Text = choisedCustomer.Surname;
        label6.Text = choisedCustomer.Phone;
        label8.Text = choisedCustomer.Email;
        label10.Text = choisedCustomer.Address;
    }


    private async void Edit(object? sender, EventArgs e)
    {
        order.Date = dateTimePicker1.Value;
        order.Id_Customer = choisedCustomer.Id;


        var response = mainController.orderController.PutOrder(order);

        var purProd = await mainController.purchasedProductController.GetPurchasedProductsByIdOrder(order.Id);

        var purServ = await mainController.purchasedServicesController.GetPurchasedServicesByIdOrder(order.Id);


        //обработка связей
        foreach(var product in productRow)
        {
            bool temp = false;
            foreach(var pur in purProd)
            {
                if(pur.Id_Product == product.product.Id)
                {
                    temp = true;
                    pur.Quantity = product.getQuantity();
                    mainController.purchasedProductController.PutPurchasedProduct(pur);
                }
            }

            if (temp == true)
            {
                continue;
            }

            if(product.getQuantity() > 0)
            {
                PurchasedProduct purchasedProduct = new PurchasedProduct()
                {
                    Id_Order = order.Id,
                    Id_Product = product.product.Id,
                    Quantity = product.getQuantity()
                };

                mainController.purchasedProductController.PostPurchasedProduct(purchasedProduct);
            }

        }

        foreach (var services in servicesRow)
        {
            bool temp = false;
            foreach (var pur in purServ)
            {
                if (pur.Id_Services == services.services.Id)
                {
                    temp = true;
                    pur.Quantity = services.getQuantity();
                    mainController.purchasedServicesController.PutPurchasedServices(pur);
                }
            }

            if (temp == true)
            {
                continue;
            }

            if (services.getQuantity() > 0)
            {
                PurchasedServices purchasedServices = new PurchasedServices()
                {
                    Id_Order = order.Id,
                    Id_Services = services.services.Id,
                    Quantity = services.getQuantity()
                };

                mainController.purchasedServicesController.PostPurchasedServices(purchasedServices);
            }

        }





        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }
    }


    private async void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        var response = mainController.orderController.DelOrder(order);


        var purProd = await mainController.purchasedProductController.GetPurchasedProductsByIdOrder(order.Id);

        var purServ = await mainController.purchasedServicesController.GetPurchasedServicesByIdOrder(order.Id);

        foreach(var pur in purProd)
        {
            mainController.purchasedProductController.DelPurchasedProduct(pur);
        }

        foreach (var pur in purServ) 
        {
            mainController.purchasedServicesController.DelPurchasedServices(pur);
        }




        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }


}
