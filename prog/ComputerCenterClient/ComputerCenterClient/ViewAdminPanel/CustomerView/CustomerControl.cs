using ComputerCenterClient.Controllers;
using ComputerCenterClient.Logic;
using ComputerCenterClient.Models;
using System.Windows.Forms;
using ComputerCenterClient.DTO;

namespace ComputerCenterClient.View.CustomerView;

public partial class CustomerControl : UserControl
{
    private MainForm mainForm;
    public CustomerController CustomerController { get; set; }
    private CustomerAdd customerAdd;

    //public List<Customer> customers { get; set; }
    public CustomerDTO choisedCustomer { get; set; }



    public CustomerControl(MainForm mainForm)
    {
        this.mainForm = mainForm;

        InitializeComponent();
        InitData();
        UpdateData();

        buttonMenu.Click += mainForm.ShowMenuButton;

        buttonAdd.Click += AddNew;
        buttonEdit.Click += Edit;
    }


    private void InitData()
    {
        choisedCustomer = new CustomerDTO();
        CustomerController = new CustomerController(mainForm.httpClient);
        customerAdd = new CustomerAdd(this);
    }

    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        var customers = await CustomerController.GetAll();

        foreach (var customer in customers)
        {
            flowLayoutPanel1.Controls.Add(new CustomerRow(this, customer));
        }
    }


    //можно добавить функционал
    public void HideActionGroupBox()
    {
        groupBoxAction.Controls.Clear();
        pictureBox1.Visible = true;
    }

    private void AddNew(object? sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(customerAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedCustomer.Customer.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new CustomerEdit(this, choisedCustomer));
    }



}
