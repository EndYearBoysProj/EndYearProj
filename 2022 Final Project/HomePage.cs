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
    }
}
