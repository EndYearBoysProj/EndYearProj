namespace _2022_Final_Project
{
    partial class PropertyFrm
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
            this.dgvProperty = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.txtPropertyTypeID = new System.Windows.Forms.TextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbSuburbsID = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProperty
            // 
            this.dgvProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperty.Location = new System.Drawing.Point(12, 288);
            this.dgvProperty.Name = "dgvProperty";
            this.dgvProperty.RowHeadersWidth = 51;
            this.dgvProperty.RowTemplate.Height = 24;
            this.dgvProperty.Size = new System.Drawing.Size(776, 150);
            this.dgvProperty.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Property ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(51, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Suburbs ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(51, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(51, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Property Type ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(51, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Image:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(51, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(51, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Description:";
            // 
            // txtPropertyID
            // 
            this.txtPropertyID.Enabled = false;
            this.txtPropertyID.Location = new System.Drawing.Point(438, 31);
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.ReadOnly = true;
            this.txtPropertyID.Size = new System.Drawing.Size(350, 22);
            this.txtPropertyID.TabIndex = 8;
            // 
            // txtPropertyTypeID
            // 
            this.txtPropertyTypeID.Location = new System.Drawing.Point(438, 147);
            this.txtPropertyTypeID.Name = "txtPropertyTypeID";
            this.txtPropertyTypeID.Size = new System.Drawing.Size(350, 22);
            this.txtPropertyTypeID.TabIndex = 12;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(438, 119);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(350, 22);
            this.txtImage.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(438, 91);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(350, 22);
            this.txtPrice.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(438, 63);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(350, 22);
            this.txtDescription.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Yellow;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(393, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(492, 241);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Yellow;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(591, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Yellow;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Location = new System.Drawing.Point(690, 241);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(90, 23);
            this.btnDisplay.TabIndex = 19;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(288, 241);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbSuburbsID
            // 
            this.cmbSuburbsID.FormattingEnabled = true;
            this.cmbSuburbsID.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.cmbSuburbsID.Location = new System.Drawing.Point(438, 204);
            this.cmbSuburbsID.Name = "cmbSuburbsID";
            this.cmbSuburbsID.Size = new System.Drawing.Size(350, 24);
            this.cmbSuburbsID.TabIndex = 21;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.cmbStatus.Location = new System.Drawing.Point(438, 175);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(350, 24);
            this.cmbStatus.TabIndex = 22;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // PropertyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbSuburbsID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtPropertyTypeID);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProperty);
            this.Name = "PropertyFrm";
            this.Text = "PropertyFrm";
            this.Load += new System.EventHandler(this.PropertyFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProperty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.TextBox txtPropertyTypeID;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbSuburbsID;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}