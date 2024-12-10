using ComputerCenterClient.Logic;
using ComputerCenterClient.Models;



namespace ComputerCenterClient.View.ServicesView;

public partial class ServicesAdd : UserControl
{
    private ServicesControl mainController;
    private Validation validation;

    public ServicesAdd(ServicesControl mainController)
    {
        this.mainController = mainController;
        validation = new Validation();


        InitializeComponent();

        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }



    private void AddItem(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxPrice.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        decimal price;

        if (!decimal.TryParse(textBoxPrice.Text, out price))
        {
            MessageBox.Show("Цена введена не корректно.");
            return;
        }


        Services services = new Services()
        {
            Name = textBoxName.Text,
            Price = price,
            Description = richTextBox1.Text
        };



        var response = mainController.ServicesController.PostServices(services);


        textBoxName.Text = "";
        textBoxPrice.Text = "";
        richTextBox1.Text = "";
 

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }

        //throw new NotImplementedException();
    }
}
