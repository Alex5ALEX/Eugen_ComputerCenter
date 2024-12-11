namespace ComputerCenterClient.View.ProductView;

partial class ProductAdd
{
    /// <summary> 
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
        label = new Label();
        labelName = new Label();
        labelType = new Label();
        textBoxType = new TextBox();
        textBoxName = new TextBox();
        groupBox1 = new GroupBox();
        groupBox3 = new GroupBox();
        label4 = new Label();
        label3 = new Label();
        groupBox2 = new GroupBox();
        label8 = new Label();
        label7 = new Label();
        label6 = new Label();
        label5 = new Label();
        label2 = new Label();
        label1 = new Label();
        richTextBox1 = new RichTextBox();
        labelPrice = new Label();
        labelDescription = new Label();
        textBoxPrice = new TextBox();
        tabControl = new TabControl();
        PageProvider = new TabPage();
        flowLayoutPanelProvider = new FlowLayoutPanel();
        tabPageManufacture = new TabPage();
        flowLayoutPanelManufacture = new FlowLayoutPanel();
        buttonBack = new Button();
        buttonAdd = new Button();
        groupBox1.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        tabControl.SuspendLayout();
        PageProvider.SuspendLayout();
        tabPageManufacture.SuspendLayout();
        SuspendLayout();
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 19);
        label.Name = "label";
        label.Size = new Size(165, 37);
        label.TabIndex = 0;
        label.Text = "Add Product";
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(18, 67);
        labelName.Name = "labelName";
        labelName.Size = new Size(55, 21);
        labelName.TabIndex = 1;
        labelName.Text = "Name:";
        // 
        // labelType
        // 
        labelType.AutoSize = true;
        labelType.Font = new Font("Segoe UI", 12F);
        labelType.Location = new Point(18, 123);
        labelType.Name = "labelType";
        labelType.Size = new Size(45, 21);
        labelType.TabIndex = 2;
        labelType.Text = "Type:";
        // 
        // textBoxType
        // 
        textBoxType.Font = new Font("Segoe UI", 12F);
        textBoxType.Location = new Point(18, 147);
        textBoxType.Name = "textBoxType";
        textBoxType.Size = new Size(288, 29);
        textBoxType.TabIndex = 6;
        // 
        // textBoxName
        // 
        textBoxName.Font = new Font("Segoe UI", 12F);
        textBoxName.Location = new Point(18, 91);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(288, 29);
        textBoxName.TabIndex = 7;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(groupBox3);
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Controls.Add(richTextBox1);
        groupBox1.Controls.Add(labelPrice);
        groupBox1.Controls.Add(labelDescription);
        groupBox1.Controls.Add(textBoxPrice);
        groupBox1.Controls.Add(tabControl);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonAdd);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(labelName);
        groupBox1.Controls.Add(labelType);
        groupBox1.Controls.Add(textBoxName);
        groupBox1.Controls.Add(textBoxType);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(680, 615);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(label4);
        groupBox3.Controls.Add(label3);
        groupBox3.Font = new Font("Segoe UI", 12F);
        groupBox3.Location = new Point(16, 479);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(290, 56);
        groupBox3.TabIndex = 62;
        groupBox3.TabStop = false;
        groupBox3.Text = "Manufacture";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(95, 25);
        label4.Name = "label4";
        label4.Size = new Size(0, 21);
        label4.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(9, 25);
        label3.Name = "label3";
        label3.Size = new Size(80, 21);
        label3.TabIndex = 0;
        label3.Text = "Company:";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(label1);
        groupBox2.Font = new Font("Segoe UI", 12F);
        groupBox2.Location = new Point(16, 343);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(290, 130);
        groupBox2.TabIndex = 61;
        groupBox2.TabStop = false;
        groupBox2.Text = "Provider";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(95, 94);
        label8.Name = "label8";
        label8.Size = new Size(0, 21);
        label8.TabIndex = 68;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(9, 94);
        label7.Name = "label7";
        label7.Size = new Size(51, 21);
        label7.TabIndex = 67;
        label7.Text = "Email:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(95, 60);
        label6.Name = "label6";
        label6.Size = new Size(0, 21);
        label6.TabIndex = 66;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(9, 60);
        label5.Name = "label5";
        label5.Size = new Size(57, 21);
        label5.TabIndex = 65;
        label5.Text = "Phone:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(95, 25);
        label2.Name = "label2";
        label2.Size = new Size(0, 21);
        label2.TabIndex = 64;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(9, 25);
        label1.Name = "label1";
        label1.Size = new Size(80, 21);
        label1.TabIndex = 63;
        label1.Text = "Company:";
        // 
        // richTextBox1
        // 
        richTextBox1.Font = new Font("Segoe UI", 12F);
        richTextBox1.Location = new Point(16, 259);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(290, 67);
        richTextBox1.TabIndex = 60;
        richTextBox1.Text = "";
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(16, 179);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(47, 21);
        labelPrice.TabIndex = 57;
        labelPrice.Text = "Price:";
        // 
        // labelDescription
        // 
        labelDescription.AutoSize = true;
        labelDescription.Font = new Font("Segoe UI", 12F);
        labelDescription.Location = new Point(16, 235);
        labelDescription.Name = "labelDescription";
        labelDescription.Size = new Size(92, 21);
        labelDescription.TabIndex = 58;
        labelDescription.Text = "Description:";
        // 
        // textBoxPrice
        // 
        textBoxPrice.Font = new Font("Segoe UI", 12F);
        textBoxPrice.Location = new Point(16, 203);
        textBoxPrice.Name = "textBoxPrice";
        textBoxPrice.Size = new Size(290, 29);
        textBoxPrice.TabIndex = 59;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(PageProvider);
        tabControl.Controls.Add(tabPageManufacture);
        tabControl.Font = new Font("Segoe UI", 12F);
        tabControl.Location = new Point(312, 19);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(362, 593);
        tabControl.TabIndex = 24;
        // 
        // PageProvider
        // 
        PageProvider.Controls.Add(flowLayoutPanelProvider);
        PageProvider.Location = new Point(4, 30);
        PageProvider.Name = "PageProvider";
        PageProvider.Padding = new Padding(3);
        PageProvider.Size = new Size(354, 559);
        PageProvider.TabIndex = 0;
        PageProvider.Text = "Provider";
        PageProvider.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelProvider
        // 
        flowLayoutPanelProvider.AutoScroll = true;
        flowLayoutPanelProvider.Location = new Point(0, 0);
        flowLayoutPanelProvider.Name = "flowLayoutPanelProvider";
        flowLayoutPanelProvider.Size = new Size(354, 560);
        flowLayoutPanelProvider.TabIndex = 0;
        // 
        // tabPageManufacture
        // 
        tabPageManufacture.Controls.Add(flowLayoutPanelManufacture);
        tabPageManufacture.Location = new Point(4, 30);
        tabPageManufacture.Name = "tabPageManufacture";
        tabPageManufacture.Padding = new Padding(3);
        tabPageManufacture.Size = new Size(354, 559);
        tabPageManufacture.TabIndex = 1;
        tabPageManufacture.Text = "Manufacture";
        tabPageManufacture.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelManufacture
        // 
        flowLayoutPanelManufacture.AutoScroll = true;
        flowLayoutPanelManufacture.Location = new Point(0, 0);
        flowLayoutPanelManufacture.Name = "flowLayoutPanelManufacture";
        flowLayoutPanelManufacture.Size = new Size(354, 559);
        flowLayoutPanelManufacture.TabIndex = 0;
        // 
        // buttonBack
        // 
        buttonBack.BackColor = SystemColors.ControlLightLight;
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(6, 562);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(100, 50);
        buttonBack.TabIndex = 14;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = false;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = Color.SpringGreen;
        buttonAdd.FlatStyle = FlatStyle.Flat;
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(207, 562);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(100, 50);
        buttonAdd.TabIndex = 13;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = false;
        // 
        // ProductAdd
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Name = "ProductAdd";
        Size = new Size(680, 615);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        tabControl.ResumeLayout(false);
        PageProvider.ResumeLayout(false);
        tabPageManufacture.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Label label;
    private Label labelName;
    private Label labelType;
    private TextBox textBoxType;
    private TextBox textBoxName;
    private GroupBox groupBox1;
    private Button buttonBack;
    private Button buttonAdd;
    private TabControl tabControl;
    private TabPage PageProvider;
    private FlowLayoutPanel flowLayoutPanelProvider;
    private TabPage tabPageManufacture;
    private FlowLayoutPanel flowLayoutPanelManufacture;
    private RichTextBox richTextBox1;
    private Label labelPrice;
    private Label labelDescription;
    private TextBox textBoxPrice;
    private GroupBox groupBox3;
    private GroupBox groupBox2;
    private Label label4;
    private Label label3;
    private Label label8;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label2;
    private Label label1;
}
