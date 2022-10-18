namespace _2022_Final_Project
{
    partial class HomePage
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
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnPropertyType = new System.Windows.Forms.Button();
            this.btnProvince = new System.Windows.Forms.Button();
            this.btnSuburb = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(223, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnProperty
            // 
            this.btnProperty.BackColor = System.Drawing.Color.Yellow;
            this.btnProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProperty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProperty.Location = new System.Drawing.Point(27, 45);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(175, 39);
            this.btnProperty.TabIndex = 0;
            this.btnProperty.Text = "Property";
            this.btnProperty.UseVisualStyleBackColor = false;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // btnPropertyType
            // 
            this.btnPropertyType.BackColor = System.Drawing.Color.Yellow;
            this.btnPropertyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPropertyType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropertyType.Location = new System.Drawing.Point(27, 121);
            this.btnPropertyType.Name = "btnPropertyType";
            this.btnPropertyType.Size = new System.Drawing.Size(175, 39);
            this.btnPropertyType.TabIndex = 1;
            this.btnPropertyType.Text = "Property Type";
            this.btnPropertyType.UseVisualStyleBackColor = false;
            this.btnPropertyType.Click += new System.EventHandler(this.btnPropertyType_Click);
            // 
            // btnProvince
            // 
            this.btnProvince.BackColor = System.Drawing.Color.Yellow;
            this.btnProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvince.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvince.Location = new System.Drawing.Point(27, 197);
            this.btnProvince.Name = "btnProvince";
            this.btnProvince.Size = new System.Drawing.Size(175, 39);
            this.btnProvince.TabIndex = 2;
            this.btnProvince.Text = "Province";
            this.btnProvince.UseVisualStyleBackColor = false;
            // 
            // btnSuburb
            // 
            this.btnSuburb.BackColor = System.Drawing.Color.Yellow;
            this.btnSuburb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuburb.Location = new System.Drawing.Point(27, 270);
            this.btnSuburb.Name = "btnSuburb";
            this.btnSuburb.Size = new System.Drawing.Size(175, 39);
            this.btnSuburb.TabIndex = 3;
            this.btnSuburb.Text = "Suburb";
            this.btnSuburb.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(27, 346);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(175, 39);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to Login";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(807, 415);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSuburb);
            this.Controls.Add(this.btnProperty);
            this.Controls.Add(this.btnProvince);
            this.Controls.Add(this.btnPropertyType);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Button btnPropertyType;
        private System.Windows.Forms.Button btnProvince;
        private System.Windows.Forms.Button btnSuburb;
        private System.Windows.Forms.Button btnBack;
    }
}