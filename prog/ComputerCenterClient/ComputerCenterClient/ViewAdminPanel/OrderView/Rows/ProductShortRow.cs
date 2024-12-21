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

public partial class ProductShortRow : UserControl
{
    public Product product;

    public ProductShortRow(Product product)
    {
        this.product = product;

        InitializeComponent();
        InitData();
    }


    private void InitData()
    {
        label2.Text = product.Name;
        label4.Text = product.Type;
        label6.Text = product.Price.ToString("0.00");
    }

    public void setQuantity(int quant)
    {
        numericUpDown1.Value = quant;
    }

    public int getQuantity()
    {
        return (int)numericUpDown1.Value;
    }

}
