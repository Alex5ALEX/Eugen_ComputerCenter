using ComputerCenterClient.Controllers;
using ComputerCenterClient.Logic;
using ComputerCenterClient.Models;

namespace ComputerCenterClient.View.CustomerView;

public partial class CustomerControl : UserControl
{
    private MainForm mainForm;
    public CustomerController CustomerController { get; set; }


    public List<Customer> customers { get; set; }
    public Customer choisedCustomer { get; set; }



    public CustomerControl(MainForm mainForm)
    {
        this.mainForm = mainForm;

        InitializeComponent();
        InitData();
        UpdateData();


    }


    private void InitData()
    {
        choisedCustomer = new Customer();
        CustomerController = new CustomerController(mainForm.httpClient);
    }

    private void UpdateData()
    {

    }
}
