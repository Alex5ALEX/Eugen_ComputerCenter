namespace ComputerCenterClient.View.OrderView
{
    partial class OrderControl
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
            buttonEdit = new Button();
            groupBoxList = new GroupBox();
            flowLayoutPanel = new FlowLayoutPanel();
            labelMenuName = new Label();
            buttonAddNew = new Button();
            buttonMenu = new Button();
            groupBoxAction = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Location = new Point(1051, 9);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(80, 50);
            buttonEdit.TabIndex = 15;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(flowLayoutPanel);
            groupBoxList.Location = new Point(689, 62);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(568, 615);
            groupBoxList.TabIndex = 17;
            groupBoxList.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(9, 19);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(556, 593);
            flowLayoutPanel.TabIndex = 6;
            // 
            // labelMenuName
            // 
            labelMenuName.AutoSize = true;
            labelMenuName.Font = new Font("Segoe UI", 30F);
            labelMenuName.Location = new Point(89, 3);
            labelMenuName.Name = "labelMenuName";
            labelMenuName.Size = new Size(143, 54);
            labelMenuName.TabIndex = 14;
            labelMenuName.Text = "Orders";
            // 
            // buttonAddNew
            // 
            buttonAddNew.FlatStyle = FlatStyle.Flat;
            buttonAddNew.Location = new Point(1164, 9);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(80, 50);
            buttonAddNew.TabIndex = 13;
            buttonAddNew.Text = "Add New";
            buttonAddNew.UseVisualStyleBackColor = true;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = SystemColors.ControlLightLight;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Font = new Font("Segoe UI", 12F);
            buttonMenu.Location = new Point(3, 3);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(80, 55);
            buttonMenu.TabIndex = 12;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = false;
            // 
            // groupBoxAction
            // 
            groupBoxAction.Location = new Point(3, 62);
            groupBoxAction.Name = "groupBoxAction";
            groupBoxAction.Size = new Size(680, 615);
            groupBoxAction.TabIndex = 16;
            groupBoxAction.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.order;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(150, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(pictureBox1);
            Controls.Add(buttonEdit);
            Controls.Add(groupBoxList);
            Controls.Add(labelMenuName);
            Controls.Add(buttonAddNew);
            Controls.Add(buttonMenu);
            Controls.Add(groupBoxAction);
            Name = "OrderControl";
            Size = new Size(1260, 680);
            groupBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEdit;
        private GroupBox groupBoxList;
        private FlowLayoutPanel flowLayoutPanel;
        private Label labelMenuName;
        private Button buttonAddNew;
        private Button buttonMenu;
        private GroupBox groupBoxAction;
        private PictureBox pictureBox1;
    }
}
