using ComputerCenterClient.Logic;
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

public partial class ManufactureEdit : UserControl
{
    private ManufactureControl mainController;
    private Manufacture manufacture;
    private Validation validation;



    public ManufactureEdit(ManufactureControl mainController, Manufacture manufacture)
    {
        this.mainController = mainController;
        this.manufacture = manufacture;

        validation = new Validation();

        InitializeComponent();
        InitializeData();


        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }




    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }


    private async void InitializeData()
    {
        textBoxName.Text = manufacture.Company;
        richTextBox1.Text = manufacture.Description;
    
    }



    private void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }



        manufacture.Company = textBoxName.Text;
        manufacture.Description = richTextBox1.Text;


        var response = mainController.ManufactureController.PutManufactureById(manufacture);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }
    }


    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }

        var response = mainController.ManufactureController.DelManufacture(manufacture);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }
}
