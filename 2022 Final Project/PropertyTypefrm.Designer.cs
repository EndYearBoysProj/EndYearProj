namespace _2022_Final_Project
{
    partial class PropertyTypefrm
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
            this.btnAddType = new System.Windows.Forms.Button();
            this.dgvType = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbPropDescription = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddType
            // 
            this.btnAddType.BackColor = System.Drawing.Color.Yellow;
            this.btnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddType.Location = new System.Drawing.Point(279, 235);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(120, 30);
            this.btnAddType.TabIndex = 0;
            this.btnAddType.Text = "Add";
            this.btnAddType.UseVisualStyleBackColor = false;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // dgvType
            // 
            this.dgvType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvType.Location = new System.Drawing.Point(6, 289);
            this.dgvType.Name = "dgvType";
            this.dgvType.RowHeadersWidth = 51;
            this.dgvType.RowTemplate.Height = 24;
            this.dgvType.Size = new System.Drawing.Size(580, 142);
            this.dgvType.TabIndex = 1;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Yellow;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Location = new System.Drawing.Point(419, 235);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(120, 30);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(279, 67);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(307, 22);
            this.txtID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Property Type ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Property Description:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(143, 235);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 30);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbPropDescription
            // 
            this.cmbPropDescription.FormattingEnabled = true;
            this.cmbPropDescription.Items.AddRange(new object[] {
            "Townhouse",
            "Apartment",
            "House",
            "Residential Area"});
            this.cmbPropDescription.Location = new System.Drawing.Point(279, 142);
            this.cmbPropDescription.Name = "cmbPropDescription";
            this.cmbPropDescription.Size = new System.Drawing.Size(307, 24);
            this.cmbPropDescription.TabIndex = 8;
            // 
            // PropertyTypefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.cmbPropDescription);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.dgvType);
            this.Controls.Add(this.btnAddType);
            this.Name = "PropertyTypefrm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.PropertyTypefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.DataGridView dgvType;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbPropDescription;
    }
}