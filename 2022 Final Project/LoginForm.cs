using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace _2022_Final_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
         
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            BussinessLogicLayer bll = new BussinessLogicLayer();

            DataTable dt = bll.Login(txtEmail.Text, txtPassword.Text);
            if(dt.Rows.Count > 0)
            {
                HomePage home=new HomePage();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password !");
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
