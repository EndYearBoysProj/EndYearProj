using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_Final_Project
{
    public partial class AgentLoginfrm : Form
    {
        public AgentLoginfrm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            BussinessLogicLayer bll = new BussinessLogicLayer();

            DataTable dt = bll.AgentLogin(txtEmail.Text, txtPassword.Text);
            if (dt.Rows.Count > 0)
            {
                AgentHome home = new AgentHome();
                home.Show();
                this.Hide();
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Enter the correct credentials";
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmail, string.Empty);
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider2.SetError(txtPassword, "Enter password vales");
                return;
            }
            else
            {
                errorProvider2.SetError(txtPassword, string.Empty);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
