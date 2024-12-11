

using ComputerCenterClient.Controllers;
using ComputerCenterClient.Models;
using ComputerCenterClient.View.ProductView.Row;
namespace ComputerCenterClient.View.ProductView;

public partial class ProductEdit : UserControl
{
    private ProductControl mainController;
    private Product product;

    public Provider choised_Provider { get; set; } = new Provider();
    public Manufacture choised_Manufacture { get; set; } = new Manufacture();


    public ProductEdit(ProductControl mainController, Product product)
    {
        this.mainController = mainController;
        this.product = product;

        InitializeComponent();
        InitData();


        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }




    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }



    public async void InitData()
    {
        textBoxName.Text = product.Name;
        textBoxPrice.Text = product.Price.ToString("0.00");
        textBoxType.Text = product.Type.ToString();
        richTextBox1.Text = product.Description;

        choised_Provider = await mainController.providerController.GetProviderById(product.Id_Provider);
        choised_Manufacture = await mainController.manufactureController.GetManufactureById(product.Id_Manufacture);

        Show_Provider();
        Show_Manufacture();

        InitProvider();
        InitManufacture();
    }


    public async void InitProvider()
    {
        flowLayoutPanelProvider.Controls.Clear();
        List<Provider> providers = await mainController.providerController.GetAllProvidersAsync();

        foreach (Provider provider in providers)
        {
            flowLayoutPanelProvider.Controls.Add(new ProviderShortRow(this, provider));
        }
    }


    public async void InitManufacture()
    {
        flowLayoutPanelManufacture.Controls.Clear();
        List<Manufacture> manufactures = await mainController.manufactureController.GetAllManufacturesAsync();

        foreach (Manufacture manufacture in manufactures)
        {
            flowLayoutPanelManufacture.Controls.Add(new ManufactureShortRow(this, manufacture));
        }

    }



    public void Show_Provider()
    {
        label2.Text = choised_Provider.Company;
        label6.Text = choised_Provider.Phone;
        label8.Text = choised_Provider.Email;
    }


    public void Show_Manufacture()
    {
        label4.Text = choised_Manufacture.Company;
    }





    private void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxPrice.Text)||
        string.IsNullOrWhiteSpace(textBoxType.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        decimal price;

        if(!decimal.TryParse(textBoxPrice.Text, out price))
        {
            MessageBox.Show("Цена введена не корректно.");
            return;
        }


        product.Name = textBoxName.Text;
        product.Price = price;
        product.Type = textBoxType.Text;
        product.Description = richTextBox1.Text;
        product.Id_Manufacture = choised_Manufacture.Id;
        product.Id_Provider = choised_Provider.Id;


        var response = mainController.productController.PutProduct(product);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }
    }


    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        var response = mainController.productController.DelProduct(product);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }


}
