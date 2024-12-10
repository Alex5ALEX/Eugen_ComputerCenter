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

namespace ComputerCenterClient.View.ServicesView;

public partial class ServicesRow : UserControl
{
    private ServicesControl mainController;
    private Services services;



    public ServicesRow(ServicesControl mainController, Services services)
    {
        this.mainController = mainController;
        this.services = services;



        InitializeComponent();
        InitializeData();



        groupBox1.Click += change_selected_Id;
        labelName.Click += change_selected_Id;
        labelNameText.Click += change_selected_Id;
        labelDescription.Click += change_selected_Id;
        labelDescriptionText.Click += change_selected_Id;
        labelPrice.Click += change_selected_Id;
        labelPriceText.Click += change_selected_Id;
    }


    private void InitializeData()
    {
        labelNameText.Text = services.Name;
        labelPriceText.Text = services.Price.ToString("0.00");
        
        if(services.Description.Length > 80)
        {
            labelDescriptionText.Text = services.Description.Substring(0, 80) + "...";
        }
        else
        {
            labelDescriptionText.Text = services.Description;
        }

    }



    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedServices = services;
    }
}
