using ComputerCenterClient.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ComputerCenterClient.View.ReportView;

public partial class ReportControl : UserControl
{
    private MainForm mainForm;

    public CustomerController CustomerController;
    public ManufactureController ManufactureController;
    public OrderController OrderController;
    public ProductController ProductController;
    public ProviderController ProviderController;
    public PurchasedProductController PurchasedProductController;
    public PurchasedServicesController PurchasedServicesController;
    public ServicesController ServicesController;

    public ReportControl(MainForm mainForm)
    {
        this.mainForm = mainForm;

        InitializeComponent();
        InitData();

        buttonMenu.Click += CallMenu;
        button1.Click += InitFinanceReport;
        button2.Click += InitStatisticReport;
        button3.Click += HideActionGroupBox;
    }

    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }

    private void InitData()
    {
        //CustomerController = new CustomerController(mainForm.httpClient);
        ManufactureController = new ManufactureController(mainForm.httpClient);
        OrderController = new OrderController(mainForm.httpClient);
        ProductController = new ProductController(mainForm.httpClient);
        ProviderController = new ProviderController(mainForm.httpClient);
        PurchasedProductController = new PurchasedProductController(mainForm.httpClient);
        PurchasedServicesController = new PurchasedServicesController(mainForm.httpClient);
        ServicesController = new ServicesController(mainForm.httpClient);
    }


    public void HideActionGroupBox(object sender, EventArgs e)
    {
        HideActionGroupBox();
    }


    public void HideActionGroupBox()
    {
        groupBox1.Controls.Clear();
       pictureBox1.Visible = true;
    }


    private void InitFinanceReport(object sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBox1.Controls.Clear();
        groupBox1.Controls.Add(new FinanceControl(this));
    }


    private void InitStatisticReport(object sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBox1.Controls.Clear();
        groupBox1.Controls.Add(new StatControl(this));
    }


}
