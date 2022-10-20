
namespace _2022_Final_Project
{
    partial class frmCity
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProvinceID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suburbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justPropertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCity = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.cmbProvinceID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.btnAddCity);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City";
            // 
            // cmbProvinceID
            // 
            this.cmbProvinceID.FormattingEnabled = true;
            this.cmbProvinceID.Location = new System.Drawing.Point(178, 84);
            this.cmbProvinceID.Name = "cmbProvinceID";
            this.cmbProvinceID.Size = new System.Drawing.Size(260, 28);
            this.cmbProvinceID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(45, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Province ID:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Yellow;
            this.btnDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDisplay.Location = new System.Drawing.Point(460, 78);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(113, 28);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.Color.Yellow;
            this.btnAddCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddCity.Location = new System.Drawing.Point(460, 34);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(113, 28);
            this.btnAddCity.TabIndex = 2;
            this.btnAddCity.Text = "Add";
            this.btnAddCity.UseVisualStyleBackColor = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(178, 36);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(260, 26);
            this.txtCity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter City:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.homePageToolStripMenuItem.Text = "Home Page";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertyTypeToolStripMenuItem,
            this.propertyToolStripMenuItem,
            this.cityToolStripMenuItem,
            this.suburbToolStripMenuItem,
            this.agencyToolStripMenuItem,
            this.agentToolStripMenuItem,
            this.tenantToolStripMenuItem,
            this.rentalToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // propertyTypeToolStripMenuItem
            // 
            this.propertyTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertyTypeToolStripMenuItem1,
            this.propertyToolStripMenuItem1,
            this.propertyAgentToolStripMenuItem});
            this.propertyTypeToolStripMenuItem.Name = "propertyTypeToolStripMenuItem";
            this.propertyTypeToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.propertyTypeToolStripMenuItem.Text = "Property";
            // 
            // propertyTypeToolStripMenuItem1
            // 
            this.propertyTypeToolStripMenuItem1.Name = "propertyTypeToolStripMenuItem1";
            this.propertyTypeToolStripMenuItem1.Size = new System.Drawing.Size(189, 24);
            this.propertyTypeToolStripMenuItem1.Text = "Property Type";
            // 
            // propertyToolStripMenuItem1
            // 
            this.propertyToolStripMenuItem1.Name = "propertyToolStripMenuItem1";
            this.propertyToolStripMenuItem1.Size = new System.Drawing.Size(189, 24);
            this.propertyToolStripMenuItem1.Text = "Property";
            // 
            // propertyAgentToolStripMenuItem
            // 
            this.propertyAgentToolStripMenuItem.Name = "propertyAgentToolStripMenuItem";
            this.propertyAgentToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.propertyAgentToolStripMenuItem.Text = "Property Agent";
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.propertyToolStripMenuItem.Text = "Province";
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.cityToolStripMenuItem.Text = "City";
            // 
            // suburbToolStripMenuItem
            // 
            this.suburbToolStripMenuItem.Name = "suburbToolStripMenuItem";
            this.suburbToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.suburbToolStripMenuItem.Text = "Suburb";
            // 
            // agencyToolStripMenuItem
            // 
            this.agencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawsonToolStripMenuItem,
            this.remaxToolStripMenuItem,
            this.justPropertyToolStripMenuItem});
            this.agencyToolStripMenuItem.Name = "agencyToolStripMenuItem";
            this.agencyToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.agencyToolStripMenuItem.Text = "Agency";
            // 
            // rawsonToolStripMenuItem
            // 
            this.rawsonToolStripMenuItem.Name = "rawsonToolStripMenuItem";
            this.rawsonToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.rawsonToolStripMenuItem.Text = "Rawson";
            // 
            // remaxToolStripMenuItem
            // 
            this.remaxToolStripMenuItem.Name = "remaxToolStripMenuItem";
            this.remaxToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.remaxToolStripMenuItem.Text = "Remax";
            // 
            // justPropertyToolStripMenuItem
            // 
            this.justPropertyToolStripMenuItem.Name = "justPropertyToolStripMenuItem";
            this.justPropertyToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.justPropertyToolStripMenuItem.Text = "Just Property";
            // 
            // agentToolStripMenuItem
            // 
            this.agentToolStripMenuItem.Name = "agentToolStripMenuItem";
            this.agentToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.agentToolStripMenuItem.Text = "Agent";
            // 
            // tenantToolStripMenuItem
            // 
            this.tenantToolStripMenuItem.Name = "tenantToolStripMenuItem";
            this.tenantToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.tenantToolStripMenuItem.Text = "Tenant";
            // 
            // rentalToolStripMenuItem
            // 
            this.rentalToolStripMenuItem.Name = "rentalToolStripMenuItem";
            this.rentalToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.rentalToolStripMenuItem.Text = "Rental";
            // 
            // dgvCity
            // 
            this.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCity.Location = new System.Drawing.Point(15, 33);
            this.dgvCity.Name = "dgvCity";
            this.dgvCity.Size = new System.Drawing.Size(639, 216);
            this.dgvCity.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Yellow;
            this.groupBox2.Controls.Add(this.dgvCity);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 270);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "City Details";
            // 
            // frmCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(742, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCity";
            this.Text = "frmCity";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProvinceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem propertyAgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suburbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justPropertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvCity;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}