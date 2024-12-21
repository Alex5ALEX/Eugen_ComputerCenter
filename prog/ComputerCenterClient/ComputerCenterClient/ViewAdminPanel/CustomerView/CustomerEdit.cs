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
using ComputerCenterClient.DTO;


namespace ComputerCenterClient.View.CustomerView;

public partial class CustomerEdit : UserControl
{
    private CustomerControl mainController;
    private CustomerDTO customer;
    private Validation validation;



    public CustomerEdit(CustomerControl mainController, CustomerDTO customer)
    {
        this.mainController = mainController;
        this.customer = customer;

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
        textBoxName.Text = customer.Person.Name;
        textBoxSurname.Text = customer.Person.Surname;
        textBoxPhone.Text = customer.Person.Phone;
        textBoxEmail.Text = customer.Person.Email;
        textBoxAddres.Text = customer.Person.Address;
        textBoxLogin.Text = customer.Person.Login;
        textBoxPassword.Text = customer.Person.Password;
    }



    private async void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
        string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxAddres.Text) ||
        string.IsNullOrWhiteSpace(textBoxLogin.Text)||
        string.IsNullOrWhiteSpace(textBoxPassword.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        if (!validation.ValidatePhone(textBoxPhone.Text)) { MessageBox.Show("Телефон введен не верно!"); return; };
        if (!validation.ValidateEmail(textBoxEmail.Text)) { MessageBox.Show("Email введен не верно!"); return; };


        customer.Person.Name = textBoxName.Text;
        customer.Person.Surname = textBoxSurname.Text;
        customer.Person.Phone = textBoxPhone.Text;
        customer.Person.Email = textBoxEmail.Text;
        customer.Person.Address = textBoxAddres.Text;
        customer.Person.Login = textBoxLogin.Text;
        customer.Person.Password = textBoxPassword.Text; 


       
        if (await mainController.CustomerController.Put(customer))
        {
            mainController.UpdateData();
        }
        else
        {
            MessageBox.Show("Login существует");
            return;
        }

    }


    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        var response = mainController.CustomerController.Del(customer);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }
}
