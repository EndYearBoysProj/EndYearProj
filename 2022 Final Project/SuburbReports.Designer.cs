namespace _2022_Final_Project
{
    partial class SuburbReports
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
            this.dgvSubReports = new System.Windows.Forms.DataGridView();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnBacl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubReports
            // 
            this.dgvSubReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubReports.Location = new System.Drawing.Point(12, 12);
            this.dgvSubReports.Name = "dgvSubReports";
            this.dgvSubReports.RowHeadersWidth = 51;
            this.dgvSubReports.RowTemplate.Height = 24;
            this.dgvSubReports.Size = new System.Drawing.Size(776, 333);
            this.dgvSubReports.TabIndex = 0;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Yellow;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Location = new System.Drawing.Point(24, 390);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(166, 27);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Get Suburb Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBacl
            // 
            this.btnBacl.BackColor = System.Drawing.Color.Yellow;
            this.btnBacl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBacl.Location = new System.Drawing.Point(240, 390);
            this.btnBacl.Name = "btnBacl";
            this.btnBacl.Size = new System.Drawing.Size(166, 27);
            this.btnBacl.TabIndex = 2;
            this.btnBacl.Text = "Back";
            this.btnBacl.UseVisualStyleBackColor = false;
            this.btnBacl.Click += new System.EventHandler(this.btnBacl_Click);
            // 
            // SuburbReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBacl);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.dgvSubReports);
            this.Name = "SuburbReports";
            this.Text = "SuburbReports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubReports;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnBacl;
    }
}