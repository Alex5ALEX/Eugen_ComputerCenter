using ComputerCenterClient.View.CustomerView;
using ComputerCenterClient.View.ServicesView;
using ComputerCenterClient.View.ProviderView;
using ComputerCenterClient.View.ManufactureView;
using ComputerCenterClient.View.ProductView;

namespace ComputerCenterClient.View;

public partial class MainForm : Form
{
    public HttpClient httpClient { get; set; }

    
    CustomerControl customerControl;
    ServicesControl servicesControl;
    ProviderControl providerControl;
    ManufactureControl manufactureControl;
    ProductControl productControl;
    /*EmployeeControl employeeControl;
    OrderControl orderControl;
    ProductControl productControl;
    ProviderControl providerControl;
    SupplyControl supplyControl;
    ReportControl reportControl;*/


    public MainForm()
    {
        InitializeComponent();
        InitializeData();

        this.FormClosing += new FormClosingEventHandler(Form_FormClosing);

        buttonMenu.Click += ShowMenuButton;
        groupBoxMenu.Click += HideMenuButton;
        labelMenu.Click += HideMenuButton;
        
        customerOption.Click += InitCustomerControl;
        servicesOption.Click += InitServicesControl;
        providerOption.Click += InitProviderControl;
        manufactureOption.Click += InitManufactureControl;
        productOption.Click += InitProductControl;
        /*
        employeeOption.Click += InitEmployeeControl;
        orderOption.Click += InitOrderControl;
        productOption.Click += InitProductControl;
        providerOption.Click += InitProviderControl;
        supplyOption.Click += InitSupplyControl;
        ReportOption.Click += InitReportControl;*/
    }



    private void InitializeData()
    {
        httpClient = new HttpClient();
        
        customerControl = new CustomerControl(this);
        servicesControl = new ServicesControl(this);
        providerControl = new ProviderControl(this);
        manufactureControl = new ManufactureControl(this);
        productControl = new ProductControl(this);
        /*
        employeeControl = new EmployeeControl(this);
        orderControl = new OrderControl(this);
        productControl = new ProductControl(this);
        providerControl = new ProviderControl(this);
        supplyControl = new SupplyControl(this);
        reportControl = new ReportControl(this);*/

        Controls.Add(customerControl);
        Controls.Add(servicesControl);
        Controls.Add(providerControl);
        Controls.Add(manufactureControl);
        Controls.Add(productControl);

        /*
        Controls.Add(employeeControl);
        Controls.Add(orderControl);
        Controls.Add(productControl);
        Controls.Add(providerControl);
        Controls.Add(supplyControl);
        Controls.Add(reportControl);*/

        HideMainControls();
        HideMenuControl();
    }

    
    //menu options
    private void InitCustomerControl(object sender, EventArgs e)
    {
        HideAllControls();
        customerControl.Visible = true;
    }
    private void InitServicesControl(object sender, EventArgs e)
    {
        HideAllControls();
        servicesControl.Visible = true;
    }

    private void InitProviderControl(object sender, EventArgs e)
    {
        HideAllControls();
        providerControl.Visible = true;
    }

    private void InitManufactureControl(object sender, EventArgs e)
    {
        HideAllControls();
        manufactureControl.Visible = true;
    }



    private void InitProductControl(object sender, EventArgs e)
    {
        HideAllControls();
        productControl.Visible = true;
    }
    /*
    private void InitEmployeeControl(object sender, EventArgs e)
    {
        HideAllControls();
        employeeControl.Visible = true;
    }

    private void InitOrderControl(object sender, EventArgs e)
    {
        HideAllControls();
        orderControl.Visible = true;
    }



    private void InitSupplyControl(object sender, EventArgs e)
    {
        HideAllControls();
        supplyControl.Visible = true;
    }

    private void InitReportControl(object sender, EventArgs e)
    {
        HideAllControls();
        reportControl.Visible = true;
    }
    */
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
        customerControl.Visible = false;
        servicesControl.Visible = false;
        providerControl.Visible = false;
        manufactureControl.Visible = false;
        productControl.Visible = false;
        /*
        employeeControl.Visible = false;
        orderControl.Visible = false;
        productControl.Visible = false;
        providerControl.Visible = false;
        supplyControl.Visible = false;
        reportControl.Visible = false;*/
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
