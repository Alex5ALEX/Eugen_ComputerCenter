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

public partial class AdminRow : UserControl
{
    private AdminControl mainController;
    private AdminDTO admin;



    public AdminRow(AdminControl mainController, AdminDTO admin)
    {
        this.mainController = mainController;
        this.admin = admin;



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
        labelNameText.Text = admin.Person.Name;
        labelSurnameText.Text = admin.Person.Surname;
        labelPhoneText.Text = admin.Person.Phone;
        labelEmailText.Text = admin.Person.Email;
        labelAddresText.Text = admin.Person.Address;
    }

    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedAdmin = admin;
    }
}
