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

namespace ComputerCenterClient.View.ProductView.Row;

public partial class ProviderShortRow : UserControl
{
    public Provider provider;

    public ProductAdd productAdd;

    public ProductEdit productEdit;

    public ProviderShortRow(ProductAdd productAdd, Provider provider)
    {
        this.provider = provider;
        this.productAdd = productAdd;

        InitializeComponent();
        InitData();


        groupBox1.Click += Select_add;
        label1.Click += Select_add;
        label2.Click += Select_add;
        label3.Click += Select_add;
        label4.Click += Select_add;
        label5.Click += Select_add;
        label6.Click += Select_add;
    }

    public ProviderShortRow(ProductEdit productEdit, Provider provider)
    {
        this.provider = provider;
        this.productEdit = productEdit;

        InitializeComponent();
        InitData();


        groupBox1.Click += Select_edit;
        label1.Click += Select_edit;
        label2.Click += Select_edit;
        label3.Click += Select_edit;
        label4.Click += Select_edit;
        label5.Click += Select_edit;
        label6.Click += Select_edit;
    }


    private void InitData() {
        label2.Text = provider.Company;
        label4.Text = provider.ContactPerson;
        label6.Text = provider.Phone;
    }

    private void Select_add(object sender, EventArgs e)
    {
        productAdd.choised_Provider = provider;
        productAdd.Show_Provider();
    }

    private void Select_edit(object sender,EventArgs e)
    {
        productEdit.choised_Provider = provider;
        productEdit.Show_Provider();
    }




}
