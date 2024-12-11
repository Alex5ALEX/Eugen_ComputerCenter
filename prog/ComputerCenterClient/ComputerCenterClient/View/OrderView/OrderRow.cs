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

namespace ComputerCenterClient.View.OrderView;

public partial class OrderRow : UserControl
{
    private OrderControl mainController;

    public Order order;

    public OrderRow(OrderControl mainController, Order order)
    {
        this.mainController = mainController;
        this.order = order;

        InitializeComponent();
        InitData();


        groupBox1.Click += select_order;
        groupBox2.Click += select_order;
        label1.Click += select_order;
        label2.Click += select_order;
        label3.Click += select_order;
        label4.Click += select_order;
        label5.Click += select_order;
        label6.Click += select_order;
        label7.Click += select_order;
        label8.Click += select_order;
    }

    private async void InitData()
    {
        label8.Text = order.Date.ToString("dd MM yyyy");

        Customer customer = await mainController.customerController.GetCustomerById(order.Id_Customer);

        label2.Text = customer.Name;
        label4.Text = customer.Surname;
        label6.Text = customer.Phone;
    }


    private void select_order(object sender, EventArgs e)
    {
        mainController.choisedOrder = order;
    }


}
