using ComputerCenterClient.Controllers;
using ComputerCenterClient.Logic;
using ComputerCenterClient.Models;
using System.Windows.Forms;

namespace ComputerCenterClient.View.ManufactureView;

public partial class ManufactureControl : UserControl
{
    private MainForm mainForm;
    public ManufactureController ManufactureController { get; set; }
    private ManufactureAdd manufactureAdd;

    public List<Manufacture> manufacture { get; set; }
    public Manufacture choisedManufacture { get; set; }



    public ManufactureControl(MainForm mainForm)
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
        choisedManufacture = new Manufacture();
        ManufactureController = new ManufactureController(mainForm.httpClient);
        manufactureAdd = new ManufactureAdd(this);
    }

    public async void UpdateData()
    {
        flowLayoutPanel1.Controls.Clear();

        manufacture = await ManufactureController.GetAllManufacturesAsync();

        foreach (var man in manufacture)
        {
            flowLayoutPanel1.Controls.Add(new ManufactureRow(this, man));
        }
    }


    //можно добавить функционал
    public void HideActionGroupBox()
    {
        groupBoxAction.Controls.Clear();
        //pictureBox1.Visible = true;
    }

    private void AddNew(object? sender, EventArgs e)
    {
        //pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(manufactureAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedManufacture.Id == Guid.Empty) { return; }

        //pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new ManufactureEdit(this, choisedManufacture));
    }



}
