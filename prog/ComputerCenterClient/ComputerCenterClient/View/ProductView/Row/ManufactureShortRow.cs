using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerCenterClient.Models;

namespace ComputerCenterClient.View.ProductView.Row;

public partial class ManufactureShortRow : UserControl
{
    public Manufacture manufacture {  get; set; }

    private ProductAdd productAdd;

    private ProductEdit productEdit;

    public ManufactureShortRow(ProductAdd productAdd, Manufacture manufacture)
    {
        this.manufacture = manufacture;
        this.productAdd = productAdd;

        InitializeComponent();
        InitData();


        groupBox1.Click += Select_add;
        label1.Click += Select_add;
        label2.Click += Select_add;
        label3.Click += Select_add;
        label4.Click += Select_add;
    }


    private void InitData()
    {
        label2.Text = manufacture.Company;

        if (manufacture.Description.Length > 20)
        {
            label4.Text = manufacture.Description.Substring(0, 20) + "...";
        }
        else
        {
            label4.Text = manufacture.Description;
        }
    }

    private void Select_add(object sender,EventArgs e)
    {
        productAdd.choised_Manufacture = manufacture;
        productAdd.Show_Manufacture();
    }

}
