using ComputerCenterClient.Logic;
using ComputerCenterClient.Models;



namespace ComputerCenterClient.View.ManufactureView;

public partial class ManufactureAdd : UserControl
{
    private ManufactureControl mainController;
    private Validation validation;

    public ManufactureAdd(ManufactureControl mainController)
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
        if (string.IsNullOrWhiteSpace(textBoxName.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }




        Manufacture manufacture = new Manufacture()
        {
            Company = textBoxName.Text,
            Description = richTextBox1.Text
        };



        var response = mainController.ManufactureController.PostManufacture(manufacture);


        textBoxName.Text = "";
        richTextBox1.Text = "";
 

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }

        //throw new NotImplementedException();
    }
}
