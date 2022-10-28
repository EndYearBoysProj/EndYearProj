namespace _2022_Final_Project
{
    partial class AgencyReports
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
            this.btnReports = new System.Windows.Forms.Button();
            this.dgvAgencyReports = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgencyReports)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Yellow;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Location = new System.Drawing.Point(12, 395);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(166, 27);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Get Agency Report";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // dgvAgencyReports
            // 
            this.dgvAgencyReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgencyReports.Location = new System.Drawing.Point(12, 12);
            this.dgvAgencyReports.Name = "dgvAgencyReports";
            this.dgvAgencyReports.RowHeadersWidth = 51;
            this.dgvAgencyReports.RowTemplate.Height = 24;
            this.dgvAgencyReports.Size = new System.Drawing.Size(776, 203);
            this.dgvAgencyReports.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(205, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgencyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.dgvAgencyReports);
            this.Name = "AgencyReports";
            this.Text = "AgencyReports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgencyReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.DataGridView dgvAgencyReports;
        private System.Windows.Forms.Button button1;
    }
}