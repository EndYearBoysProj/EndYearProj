namespace _2022_Final_Project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnAgent = new System.Windows.Forms.Button();
            this.btnTenant = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(229, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Property Central";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(309, 130);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(180, 50);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnAgent
            // 
            this.btnAgent.Location = new System.Drawing.Point(309, 211);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(180, 50);
            this.btnAgent.TabIndex = 2;
            this.btnAgent.Text = "Agent";
            this.btnAgent.UseVisualStyleBackColor = true;
            // 
            // btnTenant
            // 
            this.btnTenant.Location = new System.Drawing.Point(309, 294);
            this.btnTenant.Name = "btnTenant";
            this.btnTenant.Size = new System.Drawing.Size(180, 50);
            this.btnTenant.TabIndex = 3;
            this.btnTenant.Text = "Tenant";
            this.btnTenant.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-2, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTenant);
            this.Controls.Add(this.btnAgent);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Button btnTenant;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

