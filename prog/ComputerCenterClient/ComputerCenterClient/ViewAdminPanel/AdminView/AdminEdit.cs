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


namespace ComputerCenterClient.View.AdminView;

public partial class AdminEdit : UserControl
{
    private AdminControl mainController;
    private AdminDTO admin;
    private Validation validation;



    public AdminEdit(AdminControl mainController, AdminDTO admin)
    {
        this.mainController = mainController;
        this.admin = admin;

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
        textBoxName.Text = admin.Person.Name;
        textBoxSurname.Text = admin.Person.Surname;
        textBoxPhone.Text = admin.Person.Phone;
        textBoxEmail.Text = admin.Person.Email;
        textBoxAddres.Text = admin.Person.Address;
        textBoxLogin.Text = admin.Person.Login;
        textBoxPassword.Text = admin.Person.Password;
        textBoxJobtitle.Text = admin.Admin.Jobtitle;
    }



    private async void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
        string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxAddres.Text) ||
        string.IsNullOrWhiteSpace(textBoxLogin.Text)||
        string.IsNullOrWhiteSpace(textBoxPassword.Text)||
        string.IsNullOrWhiteSpace(textBoxJobtitle.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        if (!validation.ValidatePhone(textBoxPhone.Text)) { MessageBox.Show("Телефон введен не верно!"); return; };
        if (!validation.ValidateEmail(textBoxEmail.Text)) { MessageBox.Show("Email введен не верно!"); return; };


        admin.Person.Name = textBoxName.Text;
        admin.Person.Surname = textBoxSurname.Text;
        admin.Person.Phone = textBoxPhone.Text;
        admin.Person.Email = textBoxEmail.Text;
        admin.Person.Address = textBoxAddres.Text;
        admin.Person.Login = textBoxLogin.Text;
        admin.Person.Password = textBoxPassword.Text; 
        admin.Admin.Jobtitle = textBoxJobtitle.Text;

       
        if (await mainController.AdminController.Put(admin))
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


        var response = mainController.AdminController.Del(admin);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }
}
