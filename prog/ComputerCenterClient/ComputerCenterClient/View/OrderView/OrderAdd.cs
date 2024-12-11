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
using ComputerCenterClient.View.OrderView.Rows;

namespace ComputerCenterClient.View.OrderView;

public partial class OrderAdd : UserControl
{
    private OrderControl mainController;

    private List<CustomerShortRow> customerRow = [];
    private List<ProductShortRow> productRow = [];
    private List<ServicesShortRow> servicesRow = [];

    public Customer choisedCustomer { get; set; } = new Customer();


    public OrderAdd(OrderControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();



        buttonBack.Click += Back;
        buttonAdd.Click += Add;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }


    public void InitData()
    {
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
    
        foreach(Product product in products)
        {
            ProductShortRow productShortRow = new ProductShortRow(product);
            productRow.Add(productShortRow);
            flowLayoutPanelProduct.Controls.Add(productShortRow);
        }
    }


    private async void InitServices()
    {
        flowLayoutPanelServices.Controls.Clear();

        List<Services> services = await mainController.servicesController.GetAllServicesAsync();

        foreach(Services services1 in services)
        {
            ServicesShortRow servicesShortRow = new ServicesShortRow(services1);
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



    private async void Add(object? sender, EventArgs e)
    {
        if(choisedCustomer.Id == Guid.Empty)
        {
            MessageBox.Show("Пожалуйста, выберите покупателя.");
            return;
        }

        Order order = new Order()
        {
            Id = Guid.NewGuid(),
            Date = dateTimePicker1.Value,
            Id_Customer = choisedCustomer.Id
        };


        var response =await mainController.orderController.PostOrder(order);

        if (!response.IsSuccessStatusCode)
        {
            return;
        }

        foreach(var product in productRow)
        {
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
        

        foreach(var services in servicesRow)
        {
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


        dateTimePicker1.Value = DateTime.Now;
        choisedCustomer = new Customer();
        ShowCustomer();
        mainController.UpdateData();
    }


}
