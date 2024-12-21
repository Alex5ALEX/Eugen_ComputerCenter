using ComputerCenterClient.DTO;
using ComputerCenterClient.Logic;
using ComputerCenterClient.Models;



namespace ComputerCenterClient.View.AdminView;

public partial class AdminAdd : UserControl
{
    private AdminControl mainController;
    private Validation validation;
    
    public AdminAdd(AdminControl mainController)
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



    private async void AddItem(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
        string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxAddres.Text) ||
        string.IsNullOrWhiteSpace(textBoxLogin.Text) || 
        string.IsNullOrWhiteSpace(textBoxPassword.Text)||
        string.IsNullOrWhiteSpace(textBoxJobtitle.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        if (!validation.ValidatePhone(textBoxPhone.Text)) { MessageBox.Show("Телефон введен не верно!"); return; };
        if (!validation.ValidateEmail(textBoxEmail.Text)) { MessageBox.Show("Email введен не верно!"); return; };

        AdminDTO admin = new AdminDTO(
        new Person()
        {
            Name = textBoxName.Text,
            Surname = textBoxSurname.Text,
            Phone = textBoxPhone.Text,
            Email = textBoxEmail.Text,
            Address = textBoxAddres.Text,
            Login = textBoxLogin.Text,
            Password = textBoxPassword.Text
        },
        new Admin()
        {
            Jobtitle = textBoxJobtitle.Text,
        });


       

        if (await mainController.AdminController.Post(admin))
        {
            mainController.UpdateData();
        }
        else
        {
            MessageBox.Show("Login существует");
            return;
        }

        textBoxSurname.Text = "";
        textBoxName.Text = "";
        textBoxPhone.Text = "";
        textBoxEmail.Text = "";
        textBoxAddres.Text = "";
        textBoxLogin.Text = "";
        textBoxPassword.Text = "";
        textBoxJobtitle.Text = "";



        //throw new NotImplementedException();
    }
}
