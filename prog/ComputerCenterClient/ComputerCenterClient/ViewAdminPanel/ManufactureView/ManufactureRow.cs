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

namespace ComputerCenterClient.View.ManufactureView;

public partial class ManufactureRow : UserControl
{
    private ManufactureControl mainController;
    private Manufacture manufacture;



    public ManufactureRow(ManufactureControl mainController, Manufacture manufacture)
    {
        this.mainController = mainController;
        this.manufacture = manufacture;



        InitializeComponent();
        InitializeData();



        groupBox1.Click += change_selected_Id;
        labelName.Click += change_selected_Id;
        labelNameText.Click += change_selected_Id;
        labelDescription.Click += change_selected_Id;
        labelDescriptionText.Click += change_selected_Id;
    }


    private void InitializeData()
    {
        labelNameText.Text = manufacture.Company;
        
        if(manufacture.Description.Length > 80)
        {
            labelDescriptionText.Text = manufacture.Description.Substring(0, 80) + "...";
        }
        else
        {
            labelDescriptionText.Text = manufacture.Description;
        }

    }



    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedManufacture = manufacture;
    }
}
