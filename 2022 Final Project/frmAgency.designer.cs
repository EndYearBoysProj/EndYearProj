﻿
namespace ProjectForms
{
    partial class frmAgency
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
            this.dgvAgency = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAgencyID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAgencyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgency)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.dgvAgency);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(7, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agency Details";
            // 
            // dgvAgency
            // 
            this.dgvAgency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgency.Location = new System.Drawing.Point(15, 37);
            this.dgvAgency.Name = "dgvAgency";
            this.dgvAgency.Size = new System.Drawing.Size(604, 204);
            this.dgvAgency.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gold;
            this.groupBox2.Controls.Add(this.txtAgencyID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtAgencyName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 142);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agency";
            // 
            // txtAgencyID
            // 
            this.txtAgencyID.Location = new System.Drawing.Point(172, 44);
            this.txtAgencyID.Name = "txtAgencyID";
            this.txtAgencyID.Size = new System.Drawing.Size(247, 26);
            this.txtAgencyID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agency ID :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(496, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDisplay.Location = new System.Drawing.Point(497, 63);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(117, 30);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(496, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAgencyName
            // 
            this.txtAgencyName.Location = new System.Drawing.Point(172, 85);
            this.txtAgencyName.Name = "txtAgencyName";
            this.txtAgencyName.Size = new System.Drawing.Size(247, 26);
            this.txtAgencyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Agency :";
            // 
            // frmAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(658, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAgency";
            this.Text = "frmAgency";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgency)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAgency;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAgencyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtAgencyID;
        private System.Windows.Forms.Label label2;
    }
}