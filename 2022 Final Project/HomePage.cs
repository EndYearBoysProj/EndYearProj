using ProjectForms;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnPropertyType_Click(object sender, EventArgs e)
        {
            PropertyTypefrm form2 = new PropertyTypefrm();
            form2.Show();
            this.Close();
           
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            PropertyFrm frm = new PropertyFrm();
            frm.Show();
            this.Hide();
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            Province pr = new Province();
            pr.Show();
            this.Hide();
        }

        private void btnSuburb_Click(object sender, EventArgs e)
        {
            frmSuburb frm = new frmSuburb();
            frm.Show();
            this.Hide();
        }

        private void btnAgency_Click(object sender, EventArgs e)
        {
            frmAgency frm = new frmAgency();
            frm.Show();
            this.Hide();
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            AgentForm frm = new AgentForm();
            frm.Show();
            this.Hide();
        }
    }
}
