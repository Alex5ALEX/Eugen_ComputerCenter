using ComputerCenterClient.Controllers;
using ComputerCenterClient.Logic;
using ComputerCenterClient.Models;
using System.Windows.Forms;

namespace ComputerCenterClient.View.ServicesView;

public partial class ServicesControl : UserControl
{
    private MainForm mainForm;
    public ServicesController ServicesController { get; set; }
    private ServicesAdd servicesAdd;

    public List<Services> services { get; set; }
    public Services choisedServices { get; set; }



    public ServicesControl(MainForm mainForm)
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
        choisedServices = new Services();
        ServicesController = new ServicesController(mainForm.httpClient);
        servicesAdd = new ServicesAdd(this);
    }

    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        services = await ServicesController.GetAllServicesAsync();

        foreach (var serv in services)
        {
            flowLayoutPanel1.Controls.Add(new ServicesRow(this, serv));
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
        groupBoxAction.Controls.Add(servicesAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedServices.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new ServicesEdit(this, choisedServices));
    }



}
