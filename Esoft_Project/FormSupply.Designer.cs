namespace Esoft_Project
{
    partial class FormSupply
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupply));
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxAgent = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxRealEstate = new System.Windows.Forms.ComboBox();
            this.listViewSupplySet = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelRealEstate = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 317);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(195, 20);
            this.textBoxPrice.TabIndex = 0;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxAgent
            // 
            this.comboBoxAgent.FormattingEnabled = true;
            this.comboBoxAgent.Location = new System.Drawing.Point(12, 182);
            this.comboBoxAgent.Name = "comboBoxAgent";
            this.comboBoxAgent.Size = new System.Drawing.Size(195, 21);
            this.comboBoxAgent.TabIndex = 1;
            this.comboBoxAgent.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgent_SelectedIndexChanged);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(12, 222);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(195, 21);
            this.comboBoxClient.TabIndex = 2;
            // 
            // comboBoxRealEstate
            // 
            this.comboBoxRealEstate.FormattingEnabled = true;
            this.comboBoxRealEstate.Location = new System.Drawing.Point(12, 277);
            this.comboBoxRealEstate.Name = "comboBoxRealEstate";
            this.comboBoxRealEstate.Size = new System.Drawing.Size(195, 21);
            this.comboBoxRealEstate.TabIndex = 3;
            // 
            // listViewSupplySet
            // 
            this.listViewSupplySet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewSupplySet.FullRowSelect = true;
            this.listViewSupplySet.GridLines = true;
            this.listViewSupplySet.HideSelection = false;
            this.listViewSupplySet.Location = new System.Drawing.Point(225, 121);
            this.listViewSupplySet.MultiSelect = false;
            this.listViewSupplySet.Name = "listViewSupplySet";
            this.listViewSupplySet.Size = new System.Drawing.Size(563, 216);
            this.listViewSupplySet.TabIndex = 4;
            this.listViewSupplySet.UseCompatibleStateImageBehavior = false;
            this.listViewSupplySet.View = System.Windows.Forms.View.Details;
            this.listViewSupplySet.SelectedIndexChanged += new System.EventHandler(this.listViewSupplySet_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id Риелтора";
            this.columnHeader5.Width = 73;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ФИО Риелтора";
            this.columnHeader6.Width = 94;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id клиента";
            this.columnHeader7.Width = 71;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ФИО Клиента";
            this.columnHeader8.Width = 84;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Id объекта";
            this.columnHeader9.Width = 74;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Адрес объекта";
            this.columnHeader10.Width = 96;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Цена";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(420, 359);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(118, 38);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(544, 359);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(118, 38);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(668, 359);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(113, 38);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Location = new System.Drawing.Point(12, 166);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(57, 13);
            this.labelAgent.TabIndex = 8;
            this.labelAgent.Text = "Риелторы";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(12, 206);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(51, 13);
            this.labelClient.TabIndex = 9;
            this.labelClient.Text = "Клиенты";
            // 
            // labelRealEstate
            // 
            this.labelRealEstate.AutoSize = true;
            this.labelRealEstate.Location = new System.Drawing.Point(9, 261);
            this.labelRealEstate.Name = "labelRealEstate";
            this.labelRealEstate.Size = new System.Drawing.Size(131, 13);
            this.labelRealEstate.TabIndex = 10;
            this.labelRealEstate.Text = "Объекты недвижимости";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(9, 301);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Цена";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 107);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelRealEstate);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewSupplySet);
            this.Controls.Add(this.comboBoxRealEstate);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxAgent);
            this.Controls.Add(this.textBoxPrice);
            this.Name = "FormSupply";
            this.Text = "Предложения";
            this.Load += new System.EventHandler(this.FormSupply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxAgent;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxRealEstate;
        private System.Windows.Forms.ListView listViewSupplySet;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelRealEstate;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}