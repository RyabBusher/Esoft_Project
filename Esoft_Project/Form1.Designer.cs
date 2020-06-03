namespace Esoft_Project
{
    partial class Menu
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenAgents = new System.Windows.Forms.Button();
            this.buttonOpenRealestates = new System.Windows.Forms.Button();
            this.buttonOpenSupplies = new System.Windows.Forms.Button();
            this.buttonOpenDeals = new System.Windows.Forms.Button();
            this.buttonOpenDemands = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(255, 104);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.Location = new System.Drawing.Point(2, 139);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenClients.TabIndex = 1;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseCompatibleTextRendering = true;
            this.buttonOpenClients.UseVisualStyleBackColor = true;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenAgents
            // 
            this.buttonOpenAgents.Location = new System.Drawing.Point(2, 193);
            this.buttonOpenAgents.Name = "buttonOpenAgents";
            this.buttonOpenAgents.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenAgents.TabIndex = 2;
            this.buttonOpenAgents.Text = "Риелторы";
            this.buttonOpenAgents.UseCompatibleTextRendering = true;
            this.buttonOpenAgents.UseVisualStyleBackColor = true;
            this.buttonOpenAgents.Click += new System.EventHandler(this.buttonAgents_Click);
            // 
            // buttonOpenRealestates
            // 
            this.buttonOpenRealestates.Location = new System.Drawing.Point(2, 247);
            this.buttonOpenRealestates.Name = "buttonOpenRealestates";
            this.buttonOpenRealestates.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenRealestates.TabIndex = 3;
            this.buttonOpenRealestates.Text = "Объекты недвижимости";
            this.buttonOpenRealestates.UseCompatibleTextRendering = true;
            this.buttonOpenRealestates.UseVisualStyleBackColor = true;
            this.buttonOpenRealestates.Click += new System.EventHandler(this.buttonOpenRealestates_Click);
            // 
            // buttonOpenSupplies
            // 
            this.buttonOpenSupplies.Location = new System.Drawing.Point(2, 301);
            this.buttonOpenSupplies.Name = "buttonOpenSupplies";
            this.buttonOpenSupplies.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenSupplies.TabIndex = 4;
            this.buttonOpenSupplies.Text = "Предложения";
            this.buttonOpenSupplies.UseCompatibleTextRendering = true;
            this.buttonOpenSupplies.UseVisualStyleBackColor = true;
            this.buttonOpenSupplies.Click += new System.EventHandler(this.buttonOpenSupplies_Click);
            // 
            // buttonOpenDeals
            // 
            this.buttonOpenDeals.Location = new System.Drawing.Point(2, 409);
            this.buttonOpenDeals.Name = "buttonOpenDeals";
            this.buttonOpenDeals.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDeals.TabIndex = 6;
            this.buttonOpenDeals.Text = "Сделки";
            this.buttonOpenDeals.UseCompatibleTextRendering = true;
            this.buttonOpenDeals.UseVisualStyleBackColor = true;
            // 
            // buttonOpenDemands
            // 
            this.buttonOpenDemands.Location = new System.Drawing.Point(2, 355);
            this.buttonOpenDemands.Name = "buttonOpenDemands";
            this.buttonOpenDemands.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDemands.TabIndex = 7;
            this.buttonOpenDemands.Text = "Потребности";
            this.buttonOpenDemands.UseCompatibleTextRendering = true;
            this.buttonOpenDemands.UseVisualStyleBackColor = true;
            this.buttonOpenDemands.Click += new System.EventHandler(this.buttonOpenDemands_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(12, 119);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(35, 13);
            this.labelHello.TabIndex = 8;
            this.labelHello.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 562);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOpenDemands);
            this.Controls.Add(this.buttonOpenDeals);
            this.Controls.Add(this.buttonOpenSupplies);
            this.Controls.Add(this.buttonOpenRealestates);
            this.Controls.Add(this.buttonOpenAgents);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.Logo);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eSoft";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenAgents;
        private System.Windows.Forms.Button buttonOpenRealestates;
        private System.Windows.Forms.Button buttonOpenSupplies;
        private System.Windows.Forms.Button buttonOpenDeals;
        private System.Windows.Forms.Button buttonOpenDemands;
        private System.Windows.Forms.Label labelHello;
    }
}

