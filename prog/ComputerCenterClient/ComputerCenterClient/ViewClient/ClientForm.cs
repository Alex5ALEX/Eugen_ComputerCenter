using ComputerCenterClient.DTO;
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
using ComputerCenterClient.Controllers;
using ComputerCenterClient.ViewClient.PersonalAccountView;
using ComputerCenterClient.ViewClient.CatalogView;
using ComputerCenterClient.ViewClient.OrderClientView;


namespace ComputerCenterClient.ViewClient;

public partial class ClientForm : Form
{

    public CustomerDTO Customer;
    public Person Person { get; set; }

    public HttpClient httpClient;

    public PersonController personController;

    public CustomerController customerController;

    public PersonalAccountControl personalAccountControl;
    public CatalogControl catalogControl;
    public OrderClientControl orderControl;


    public ClientForm(Person Person)
    {
        this.Person = Person;

        InitializeComponent();
        InitData();

        this.FormClosing += new FormClosingEventHandler(Form_FormClosing);

        buttonMenu.Click += ShowMenuButton;
        groupBoxMenu.Click += HideMenuButton;
        labelMenu.Click += HideMenuButton;

        personOption.Click += InitPersonalControl;
        orderOption.Click += InitOrderControl;
        catalogOption.Click += InitCatalogControl;
    }


    public async void InitData()
    {
        httpClient = new HttpClient();

        Customer = new CustomerDTO();

        personController = new PersonController(httpClient);
        customerController = new CustomerController(httpClient);

        InitCustomer();
    }

    public  async void InitCustomer()
    {
        Customer.Person = await personController.GetByLogin(Person.Login, Person.Password);
        Customer.Customer = await  customerController.GetByIdPerson(Customer.Person.Id);

        InitControls();
    }

    public async void InitControls()
    {
        personalAccountControl = new PersonalAccountControl(this, Customer);
        catalogControl = new CatalogControl(this);
        orderControl = new OrderClientControl(this);

        Controls.Add(personalAccountControl);
        Controls.Add(catalogControl);
        Controls.Add(orderControl);

        HideMainControls();
        HideMenuControl();
    }

    //menu options
    private void InitPersonalControl(object sender, EventArgs e)
    {
        HideAllControls();
        personalAccountControl.Visible = true;
    }
    private void InitOrderControl(object sender, EventArgs e)
    {
        HideAllControls();
        orderControl.Visible = true;
    }

    private void InitCatalogControl(object sender, EventArgs e)
    {
        HideAllControls();
        catalogControl.Visible = true;
    }


    //controls



    private void HideAllControls()
    {
        HideMenuControl();
        buttonMenu.Visible = false;
        pictureBox1.Visible = false;

        HideMainControls();
    }


    private void HideMainControls()
    {
        personalAccountControl.Visible = false;
        catalogControl.Visible = false;
        orderControl.Visible = false;
    }



    //menu
    public void ShowMenuButton(object sender, EventArgs e)
    {
        ShowMenuControl();
    }

    public void HideMenuButton(object sender, EventArgs e)
    {
        HideMenuControl();
    }

    public void ShowMenuControl()
    {
        //groupBoxMenu.BringToFront();
        groupBoxMenu.Visible = true;
    }

    public void HideMenuControl()
    {
        groupBoxMenu.Visible = false;
    }

    //exit
    private void Form_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

}
