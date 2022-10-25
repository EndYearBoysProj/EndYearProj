namespace RealProject
{
    partial class ucRental
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddRental = new System.Windows.Forms.Button();
            this.btnUpdateRental = new System.Windows.Forms.Button();
            this.btnDisplayRental = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRental = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtTenantID = new System.Windows.Forms.TextBox();
            this.txtPropertyAgentID = new System.Windows.Forms.TextBox();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddRental
            // 
            this.btnAddRental.Location = new System.Drawing.Point(196, 290);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(150, 40);
            this.btnAddRental.TabIndex = 0;
            this.btnAddRental.Text = "Add";
            this.btnAddRental.UseVisualStyleBackColor = true;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // btnUpdateRental
            // 
            this.btnUpdateRental.Location = new System.Drawing.Point(352, 290);
            this.btnUpdateRental.Name = "btnUpdateRental";
            this.btnUpdateRental.Size = new System.Drawing.Size(150, 40);
            this.btnUpdateRental.TabIndex = 1;
            this.btnUpdateRental.Text = "Update";
            this.btnUpdateRental.UseVisualStyleBackColor = true;
            this.btnUpdateRental.Click += new System.EventHandler(this.btnUpdateRental_Click);
            // 
            // btnDisplayRental
            // 
            this.btnDisplayRental.Location = new System.Drawing.Point(508, 290);
            this.btnDisplayRental.Name = "btnDisplayRental";
            this.btnDisplayRental.Size = new System.Drawing.Size(150, 40);
            this.btnDisplayRental.TabIndex = 2;
            this.btnDisplayRental.Text = "Display";
            this.btnDisplayRental.UseVisualStyleBackColor = true;
            this.btnDisplayRental.Click += new System.EventHandler(this.btnDisplayRental_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rental ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Property Agent ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tenant ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "End Date:";
            // 
            // dgvRental
            // 
            this.dgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRental.Location = new System.Drawing.Point(6, 353);
            this.dgvRental.Name = "dgvRental";
            this.dgvRental.RowHeadersWidth = 51;
            this.dgvRental.RowTemplate.Height = 24;
            this.dgvRental.Size = new System.Drawing.Size(652, 155);
            this.dgvRental.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.txtTenantID);
            this.groupBox1.Controls.Add(this.txtPropertyAgentID);
            this.groupBox1.Controls.Add(this.txtRentalID);
            this.groupBox1.Controls.Add(this.dgvRental);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAddRental);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnDisplayRental);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnUpdateRental);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 525);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rental Information:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(196, 236);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 13;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(196, 191);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 12;
            // 
            // txtTenantID
            // 
            this.txtTenantID.Location = new System.Drawing.Point(196, 142);
            this.txtTenantID.Name = "txtTenantID";
            this.txtTenantID.Size = new System.Drawing.Size(449, 22);
            this.txtTenantID.TabIndex = 11;
            // 
            // txtPropertyAgentID
            // 
            this.txtPropertyAgentID.Location = new System.Drawing.Point(196, 94);
            this.txtPropertyAgentID.Name = "txtPropertyAgentID";
            this.txtPropertyAgentID.Size = new System.Drawing.Size(449, 22);
            this.txtPropertyAgentID.TabIndex = 10;
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(196, 42);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(452, 22);
            this.txtRentalID.TabIndex = 9;
            // 
            // ucRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucRental";
            this.Size = new System.Drawing.Size(678, 553);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRental;
        private System.Windows.Forms.Button btnUpdateRental;
        private System.Windows.Forms.Button btnDisplayRental;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRental;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtTenantID;
        private System.Windows.Forms.TextBox txtPropertyAgentID;
        private System.Windows.Forms.TextBox txtRentalID;
    }
}
