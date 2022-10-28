using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace _2022_Final_Project
{
    public partial class Province : Form
    {
        public Province()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ProvinceD pr = new ProvinceD();

            pr.Description = cmbDescription.Text;
           

            int x = bll.InsertProvince(pr);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            dgvProvince.DataSource = bll.GetProvince();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            hm.Show();
            this.Hide();
        }
    }
}
