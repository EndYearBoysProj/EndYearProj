namespace _2022_Final_Project
{
    partial class Province
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
            this.dgvProvince = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProvinceID = new System.Windows.Forms.TextBox();
            this.cmbDescription = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvince)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProvince
            // 
            this.dgvProvince.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvince.Location = new System.Drawing.Point(12, 288);
            this.dgvProvince.Name = "dgvProvince";
            this.dgvProvince.RowHeadersWidth = 51;
            this.dgvProvince.RowTemplate.Height = 24;
            this.dgvProvince.Size = new System.Drawing.Size(571, 150);
            this.dgvProvince.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Yellow;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(358, 225);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 30);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Yellow;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Location = new System.Drawing.Point(232, 225);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(100, 30);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.BackColor = System.Drawing.Color.Yellow;
            this.BtnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisplay.Location = new System.Drawing.Point(483, 225);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(100, 30);
            this.BtnDisplay.TabIndex = 3;
            this.BtnDisplay.Text = "Display";
            this.BtnDisplay.UseVisualStyleBackColor = false;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Province ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(60, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description:";
            // 
            // txtProvinceID
            // 
            this.txtProvinceID.Location = new System.Drawing.Point(232, 82);
            this.txtProvinceID.Name = "txtProvinceID";
            this.txtProvinceID.ReadOnly = true;
            this.txtProvinceID.Size = new System.Drawing.Size(351, 22);
            this.txtProvinceID.TabIndex = 6;
            // 
            // cmbDescription
            // 
            this.cmbDescription.FormattingEnabled = true;
            this.cmbDescription.Items.AddRange(new object[] {
            "Eastern Cape",
            "Western Cape",
            "Kwa-Zulu-Natal",
            "Free State",
            "Northern Cape",
            "Gauteng",
            "Limpopo",
            "Mpumalanga",
            "North West"});
            this.cmbDescription.Location = new System.Drawing.Point(232, 136);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.Size = new System.Drawing.Size(351, 24);
            this.cmbDescription.TabIndex = 7;
            // 
            // Province
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.cmbDescription);
            this.Controls.Add(this.txtProvinceID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDisplay);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dgvProvince);
            this.Name = "Province";
            this.Text = "Province";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvince)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProvince;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProvinceID;
        private System.Windows.Forms.ComboBox cmbDescription;
    }
}