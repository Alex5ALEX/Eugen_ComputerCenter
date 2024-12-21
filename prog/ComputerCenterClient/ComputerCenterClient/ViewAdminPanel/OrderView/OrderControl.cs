using ComputerCenterClient.Controllers;
using ComputerCenterClient.Models;
using ComputerCenterClient.View.ProductView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerCenterClient.View.OrderView;

public partial class OrderControl : UserControl
{
    private MainForm mainForm;
    public OrderController orderController;
    public CustomerController customerController;
    public ProductController productController;
    public ServicesController servicesController;
    public PurchasedProductController purchasedProductController;
    public PurchasedServicesController purchasedServicesController;

    private OrderAdd orderAdd;

    public List<Order> orders;

    public Order choisedOrder;



    public OrderControl(MainForm mainForm)
    {
        this.mainForm = mainForm;


        InitializeComponent();
        InitializeData();
        UpdateData();

        buttonMenu.Click += CallMenu;

        buttonAddNew.Click += AddNew;
        buttonEdit.Click += Edit;
    }

    private void InitializeData()
    {
        choisedOrder = new Order();
        orderController = new OrderController(mainForm.httpClient);
        customerController = new CustomerController(mainForm.httpClient);
        productController = new ProductController(mainForm.httpClient);
        servicesController = new ServicesController(mainForm.httpClient);
        purchasedProductController = new PurchasedProductController(mainForm.httpClient);
        purchasedServicesController = new PurchasedServicesController(mainForm.httpClient);
        orderAdd = new OrderAdd(this);
    }



    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }


    public async void UpdateData()
    {
        flowLayoutPanel.Controls.Clear();

        orders = await orderController.GetAllOrdersAsync();

        foreach (var order in orders)
        {
            flowLayoutPanel.Controls.Add(new OrderRow(this, order));
        }

    }



    //можно добавить функционал
    public void HideActionGroupBox()
    {
        pictureBox1.Visible = true;
        groupBoxAction.Controls.Clear();
    }

    private void AddNew(object? sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        orderAdd.InitData();
        groupBoxAction.Controls.Add(orderAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedOrder.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new OrderEdit(this, choisedOrder));
    }



}
