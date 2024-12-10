using Newtonsoft.Json.Linq;

using ComputerCenterClient.Controllers;
using ComputerCenterClient.Models;
namespace ComputerCenterClient.View.ProductView;

public partial class ProductControl : UserControl
{
    private MainForm mainForm;
    public  ProductController productController;
    public ProviderController providerController;
    public ManufactureController manufactureController;

    private ProductAdd productAdd;

    public List<Product> products { get; set; }
    public Product choisedProduct { get; set; }




    public ProductControl(MainForm mainForm)
    {
        this.mainForm = mainForm;


        InitializeComponent();
        InitializeData();
        UpdateData();


        buttonMenu.Click += CallMenu;

        buttonAddNew.Click += AddNew;
        buttonEdit.Click += Edit;
    }



    private void InitializeData()
    {
        choisedProduct = new Product();
        productController = new ProductController(mainForm.httpClient);
        providerController = new ProviderController(mainForm.httpClient);
        manufactureController = new ManufactureController(mainForm.httpClient);
        productAdd = new ProductAdd(this);
    }



    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }



    public async void UpdateData()
    {
        flowLayoutPanel.Controls.Clear();

        products = await productController.GetAllProductsAsync();

        foreach (var product in products)
        {
            flowLayoutPanel.Controls.Add(new ProductRow(this, product));
        }

    }


    //можно добавить функционал
    public void HideActionGroupBox()
    {
        //pictureBox1.Visible = true;
        groupBoxAction.Controls.Clear();
    }

    private void AddNew(object? sender, EventArgs e)
    {
        //pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        productAdd.InitData();
        groupBoxAction.Controls.Add(productAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedProduct.Id == Guid.Empty) { return; }

        //pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new ProductEdit(this,choisedProduct));
    }


}
