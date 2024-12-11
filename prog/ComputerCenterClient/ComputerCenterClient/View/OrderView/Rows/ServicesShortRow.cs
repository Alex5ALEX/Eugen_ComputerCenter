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

public partial class ServicesShortRow : UserControl
{
    public Services services;

    public ServicesShortRow(Services services)
    {
        this.services = services;

        InitializeComponent();
        InitData();
    }

    private void InitData()
    {
        label2.Text = services.Name;
        label6.Text = services.Price.ToString("0.00");
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
