namespace _2022_Final_Project
{
    partial class RentalFrm
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
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.dgvRental = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddRental = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisplayRental = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateRental = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPropAgentID = new System.Windows.Forms.ComboBox();
            this.cmbTenantID = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(212, 214);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 27;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(212, 169);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 26;
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(212, 26);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(452, 22);
            this.txtRentalID.TabIndex = 23;
            // 
            // dgvRental
            // 
            this.dgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRental.Location = new System.Drawing.Point(12, 292);
            this.dgvRental.Name = "dgvRental";
            this.dgvRental.RowHeadersWidth = 51;
            this.dgvRental.RowTemplate.Height = 24;
            this.dgvRental.Size = new System.Drawing.Size(652, 155);
            this.dgvRental.TabIndex = 22;
            this.dgvRental.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRental_CellClick);
            this.dgvRental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRental_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(30, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "End Date:";
            // 
            // btnAddRental
            // 
            this.btnAddRental.BackColor = System.Drawing.Color.Yellow;
            this.btnAddRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRental.Location = new System.Drawing.Point(175, 246);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(150, 40);
            this.btnAddRental.TabIndex = 14;
            this.btnAddRental.Text = "Add";
            this.btnAddRental.UseVisualStyleBackColor = false;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Start Date:";
            // 
            // btnDisplayRental
            // 
            this.btnDisplayRental.BackColor = System.Drawing.Color.Yellow;
            this.btnDisplayRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayRental.Location = new System.Drawing.Point(487, 246);
            this.btnDisplayRental.Name = "btnDisplayRental";
            this.btnDisplayRental.Size = new System.Drawing.Size(150, 40);
            this.btnDisplayRental.TabIndex = 16;
            this.btnDisplayRental.Text = "Display";
            this.btnDisplayRental.UseVisualStyleBackColor = false;
            this.btnDisplayRental.Click += new System.EventHandler(this.btnDisplayRental_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tenant ID:";
            // 
            // btnUpdateRental
            // 
            this.btnUpdateRental.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRental.Location = new System.Drawing.Point(331, 246);
            this.btnUpdateRental.Name = "btnUpdateRental";
            this.btnUpdateRental.Size = new System.Drawing.Size(150, 40);
            this.btnUpdateRental.TabIndex = 15;
            this.btnUpdateRental.Text = "Update";
            this.btnUpdateRental.UseVisualStyleBackColor = false;
            this.btnUpdateRental.Click += new System.EventHandler(this.btnUpdateRental_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Property Agent ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rental ID:";
            // 
            // cmbPropAgentID
            // 
            this.cmbPropAgentID.FormattingEnabled = true;
            this.cmbPropAgentID.Items.AddRange(new object[] {
            "2",
            "4",
            "5",
            "6"});
            this.cmbPropAgentID.Location = new System.Drawing.Point(212, 77);
            this.cmbPropAgentID.Name = "cmbPropAgentID";
            this.cmbPropAgentID.Size = new System.Drawing.Size(449, 24);
            this.cmbPropAgentID.TabIndex = 28;
            // 
            // cmbTenantID
            // 
            this.cmbTenantID.FormattingEnabled = true;
            this.cmbTenantID.Items.AddRange(new object[] {
            "1016",
            "1017",
            "1018"});
            this.cmbTenantID.Location = new System.Drawing.Point(212, 125);
            this.cmbTenantID.Name = "cmbTenantID";
            this.cmbTenantID.Size = new System.Drawing.Size(449, 24);
            this.cmbTenantID.TabIndex = 29;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 246);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 40);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RentalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbTenantID);
            this.Controls.Add(this.cmbPropAgentID);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.dgvRental);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddRental);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDisplayRental);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdateRental);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RentalFrm";
            this.Text = "RentalFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.DataGridView dgvRental;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddRental;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDisplayRental;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateRental;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPropAgentID;
        private System.Windows.Forms.ComboBox cmbTenantID;
        private System.Windows.Forms.Button btnBack;
    }
}