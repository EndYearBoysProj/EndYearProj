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
    public partial class frmCity : Form
    {
        public frmCity()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvCity.DataSource = bll.GetCity();
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.CityDescription = txtCity.Text;
            city.ProvinceID = int.Parse(cmbProvinceID.SelectedValue.ToString());

            int x = bll.InsertCity(city);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }
        }
    }
}
