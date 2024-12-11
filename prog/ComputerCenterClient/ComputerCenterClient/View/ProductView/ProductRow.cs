using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComputerCenterClient.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace ComputerCenterClient.View.ProductView;

public partial class ProductRow : UserControl
{
    private ProductControl mainController;
    private Product product;



    public ProductRow(ProductControl mainController, Product product)
    {
        this.mainController = mainController;
        this.product = product;
  


        InitializeComponent();
        InitializeData();


        
        groupBox1.Click += change_selected_Id;
        groupBox2.Click += change_selected_Id;
        groupBox3.Click += change_selected_Id;
        labelName.Click += change_selected_Id;
        labelNameText.Click += change_selected_Id;
        labelPrice.Click += change_selected_Id;
        labelPriceText.Click += change_selected_Id;
        label1.Click += change_selected_Id;
        label2.Click += change_selected_Id;
        label3.Click += change_selected_Id;
        label4.Click += change_selected_Id;
        label5.Click += change_selected_Id;
        label6.Click += change_selected_Id;
        label7.Click += change_selected_Id;
        label8.Click += change_selected_Id;
        label9.Click += change_selected_Id;
        label10.Click += change_selected_Id;
    }


    private async void InitializeData()
    {
        labelNameText.Text = product.Name;
        labelPriceText.Text = product.Price.ToString();

        Provider provider = await mainController.providerController.GetProviderById(product.Id_Provider);
        Manufacture manufacture= await mainController.manufactureController.GetManufactureById(product.Id_Manufacture);

        label2.Text = provider.Company;
        label3.Text = provider.ContactPerson;
        label5.Text = provider.Phone;
        label7.Text = provider.Email;

        label9.Text = manufacture.Company;
    }


    private void CopyId(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(product.Id.ToString());
    }


    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedProduct = product;
    }


}
