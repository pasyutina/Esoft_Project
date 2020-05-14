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
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenDeals = new System.Windows.Forms.Button();
            this.buttonOpenDemands = new System.Windows.Forms.Button();
            this.buttonOpenSupplies = new System.Windows.Forms.Button();
            this.buttonOpenRealEstates = new System.Windows.Forms.Button();
            this.buttonOpenAgents = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenClients.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenClients.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenClients.Location = new System.Drawing.Point(12, 121);
            this.buttonOpenClients.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenClients.TabIndex = 1;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenDeals
            // 
            this.buttonOpenDeals.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenDeals.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenDeals.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenDeals.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDeals.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDeals.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenDeals.Location = new System.Drawing.Point(12, 501);
            this.buttonOpenDeals.Name = "buttonOpenDeals";
            this.buttonOpenDeals.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDeals.TabIndex = 2;
            this.buttonOpenDeals.Text = "Сделки";
            this.buttonOpenDeals.UseVisualStyleBackColor = false;
            // 
            // buttonOpenDemands
            // 
            this.buttonOpenDemands.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenDemands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDemands.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDemands.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenDemands.Location = new System.Drawing.Point(12, 359);
            this.buttonOpenDemands.Name = "buttonOpenDemands";
            this.buttonOpenDemands.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDemands.TabIndex = 3;
            this.buttonOpenDemands.Text = "Предложения";
            this.buttonOpenDemands.UseVisualStyleBackColor = false;
            // 
            // buttonOpenSupplies
            // 
            this.buttonOpenSupplies.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSupplies.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenSupplies.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenSupplies.Location = new System.Drawing.Point(12, 430);
            this.buttonOpenSupplies.Name = "buttonOpenSupplies";
            this.buttonOpenSupplies.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenSupplies.TabIndex = 4;
            this.buttonOpenSupplies.Text = "Потребности";
            this.buttonOpenSupplies.UseVisualStyleBackColor = false;
            // 
            // buttonOpenRealEstates
            // 
            this.buttonOpenRealEstates.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenRealEstates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenRealEstates.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenRealEstates.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenRealEstates.Location = new System.Drawing.Point(12, 253);
            this.buttonOpenRealEstates.Name = "buttonOpenRealEstates";
            this.buttonOpenRealEstates.Size = new System.Drawing.Size(265, 86);
            this.buttonOpenRealEstates.TabIndex = 5;
            this.buttonOpenRealEstates.Text = "Объекты недвижимости";
            this.buttonOpenRealEstates.UseVisualStyleBackColor = false;
            // 
            // buttonOpenAgents
            // 
            this.buttonOpenAgents.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenAgents.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenAgents.ForeColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenAgents.Location = new System.Drawing.Point(12, 187);
            this.buttonOpenAgents.Name = "buttonOpenAgents";
            this.buttonOpenAgents.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenAgents.TabIndex = 6;
            this.buttonOpenAgents.Text = "Риелторы";
            this.buttonOpenAgents.UseVisualStyleBackColor = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(-7, -1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(294, 104);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 561);
            this.Controls.Add(this.buttonOpenAgents);
            this.Controls.Add(this.buttonOpenRealEstates);
            this.Controls.Add(this.buttonOpenSupplies);
            this.Controls.Add(this.buttonOpenDemands);
            this.Controls.Add(this.buttonOpenDeals);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esoft";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenDeals;
        private System.Windows.Forms.Button buttonOpenDemands;
        private System.Windows.Forms.Button buttonOpenSupplies;
        private System.Windows.Forms.Button buttonOpenRealEstates;
        private System.Windows.Forms.Button buttonOpenAgents;
    }
}

