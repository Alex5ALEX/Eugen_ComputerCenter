
using ComputerCenterClient.Models;
using ComputerCenterClient.View.ProductView.Row;

namespace ComputerCenterClient.View.ProductView;

public partial class ProductAdd : UserControl
{
    private ProductControl mainController;

    public Provider choised_Provider { get; set; } = new Provider();
    public Manufacture choised_Manufacture { get; set; } = new Manufacture();

    public ProductAdd(ProductControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();


        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }


    public void InitData()
    {
        InitProvider();
        InitManufacture();
    }


    public async void InitProvider()
    {
        flowLayoutPanelProvider.Controls.Clear();
        List<Provider> providers = await mainController.providerController.GetAllProvidersAsync();

        foreach (Provider provider in providers) {
            flowLayoutPanelProvider.Controls.Add(new ProviderShortRow(this, provider));
        }
    }


    public async void InitManufacture()
    {
        flowLayoutPanelManufacture.Controls.Clear();
        List<Manufacture> manufactures = await mainController.manufactureController.GetAllManufacturesAsync();

        foreach(Manufacture manufacture in manufactures)
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
        




    private void AddItem(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxType.Text)||
        string.IsNullOrWhiteSpace(textBoxPrice.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        decimal price = 0;

        if (!decimal.TryParse(textBoxPrice.Text, out price))
        {
            MessageBox.Show("Цена введена не корректно.");
            return;
        }


        Product product = new Product()
        {
            Name = textBoxName.Text,
            Type = textBoxType.Text,
            Description = richTextBox1.Text,
            Price = price,
            Id_Provider = choised_Provider.Id,
            Id_Manufacture = choised_Manufacture.Id
        };


        var response = mainController.productController.PostProduct(product);


        textBoxType.Text = "";
        textBoxPrice.Text = "";
        richTextBox1.Text = "";
        textBoxName.Text = "";


        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }

        //throw new NotImplementedException();
    }

}
