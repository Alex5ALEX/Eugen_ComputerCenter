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
        labelName.Click += change_selected_Id;
        labelNameText.Click += change_selected_Id;
        labelPrice.Click += change_selected_Id;
        labelPriceText.Click += change_selected_Id;
    }


    private void InitializeData()
    {
        labelNameText.Text = product.Name;
        labelPriceText.Text = product.Price.ToString();
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
