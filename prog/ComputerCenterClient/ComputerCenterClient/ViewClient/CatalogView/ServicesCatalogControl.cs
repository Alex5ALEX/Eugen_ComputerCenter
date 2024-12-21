using ComputerCenterClient.Models;
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

namespace ComputerCenterClient.ViewClient.CatalogView;

public partial class ServicesCatalogControl : UserControl
{
    private Services services;

    public ServicesCatalogControl(Services services)
    {
        this.services = services;

        InitializeComponent();
        InitData();
    
    }


    private void InitData()
    {
        labelNameText.Text = services.Name;
        labelPriceText.Text = services.Price.ToString("0.00");

        richTextBoxDescription.Text = services.Description;

    }



}
