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

namespace ComputerCenterClient.View.ReportView;

public partial class ProductRow : UserControl
{
    private Product product;
    private int quantity;

    public ProductRow(Product product, int quantity)
    {
        this.product = product;
        this.quantity = quantity;

        InitializeComponent();
        InitData();
    }


    private void InitData()
    {
        label2.Text = product.Name;
        label4.Text = product.Type;
        label6.Text = product.Price.ToString("0,00");
        label8.Text = quantity.ToString();
    }
    
}
