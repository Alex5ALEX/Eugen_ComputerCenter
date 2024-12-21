using ComputerCenterClient.Controllers;
using ComputerCenterClient.Logic;
using ComputerCenterClient.Models;
using System.Windows.Forms;
using ComputerCenterClient.DTO;

namespace ComputerCenterClient.View.AdminView;

public partial class AdminControl : UserControl
{
    private MainForm mainForm;
    public AdminController AdminController { get; set; }
    private AdminAdd adminAdd;

    //public List<Customer> customers { get; set; }
    public AdminDTO choisedAdmin { get; set; }



    public AdminControl(MainForm mainForm)
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
        choisedAdmin = new AdminDTO();
        AdminController = new AdminController(mainForm.httpClient);
        adminAdd = new AdminAdd(this);
    }

    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        var admins = await AdminController.GetAll();

        foreach (var admin in admins)
        {
            flowLayoutPanel1.Controls.Add(new AdminRow(this, admin));
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
        groupBoxAction.Controls.Add(adminAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedAdmin.Admin.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new AdminEdit(this, choisedAdmin));
    }



}
