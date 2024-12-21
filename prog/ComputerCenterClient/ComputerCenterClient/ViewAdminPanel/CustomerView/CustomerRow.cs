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
using ComputerCenterClient.DTO;

namespace ComputerCenterClient.View.CustomerView;

public partial class CustomerRow : UserControl
{
    private CustomerControl mainController;
    private CustomerDTO customer;



    public CustomerRow(CustomerControl mainController, CustomerDTO customer)
    {
        this.mainController = mainController;
        this.customer = customer;



        InitializeComponent();
        InitializeData();



        groupBox1.Click += change_selected_Id;
        labelName.Click += change_selected_Id;
        labelNameText.Click += change_selected_Id;
        labelSurname.Click += change_selected_Id;
        labelSurnameText.Click += change_selected_Id;
        labelPhone.Click += change_selected_Id;
        labelPhoneText.Click += change_selected_Id;
        labelEmail.Click += change_selected_Id;
        labelEmailText.Click += change_selected_Id;
        labelAddres.Click += change_selected_Id;
        labelAddresText.Click += change_selected_Id;
    }


    private void InitializeData()
    {
        labelNameText.Text = customer.Person.Name;
        labelSurnameText.Text = customer.Person.Surname;
        labelPhoneText.Text = customer.Person.Phone;
        labelEmailText.Text = customer.Person.Email;
        labelAddresText.Text = customer.Person.Address;
    }

    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedCustomer = customer;
    }
}
