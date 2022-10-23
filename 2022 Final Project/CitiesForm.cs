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
    public partial class CitiesForm : Form
    {
        public CitiesForm()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            City ct = new City();

            ct.CityDescription = txtDescription.Text;
            ct.ProvinceID = int.Parse(cmbProvinceID.Text);

            int x = bll.InsertCity(ct);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            dgvCity.DataSource = bll.GetCity();
        }
    }
}
