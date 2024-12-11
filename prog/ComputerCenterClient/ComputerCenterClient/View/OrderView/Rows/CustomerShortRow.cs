﻿using ComputerCenterClient.View.CustomerView;
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

namespace ComputerCenterClient.View.OrderView.Rows;

public partial class CustomerShortRow : UserControl
{
    public Customer customer;

    private OrderAdd orderAdd;

    private OrderEdit orderEdit;

    public CustomerShortRow(OrderAdd orderAdd, Customer customer)
    {
        this.orderAdd = orderAdd;
        this.customer = customer;

        InitializeComponent();
        InitData();

        groupBox1.Click += selectedAdd;
        label1.Click += selectedAdd;
        label2.Click += selectedAdd;
        label3.Click += selectedAdd;
        label4.Click += selectedAdd;
    }

    public CustomerShortRow(OrderEdit orderEdit, Customer customer)
    {
        this.orderEdit = orderEdit;
        this.customer = customer;

        InitializeComponent();
        InitData();

        groupBox1.Click += selectedEdit;
        label1.Click += selectedEdit;
        label2.Click += selectedEdit;
        label3.Click += selectedEdit;
        label4.Click += selectedEdit;
    }



    private void InitData()
    {
        label2.Text = customer.Name;
        label4.Text = customer.Surname;
    }

    private void selectedAdd(object sender, EventArgs e)
    {
        orderAdd.choisedCustomer = customer;
        orderAdd.ShowCustomer();
    }


    private void selectedEdit(object sender, EventArgs e)
    {
        orderEdit.choisedCustomer = customer;
        orderEdit.ShowCustomer();
    }
}