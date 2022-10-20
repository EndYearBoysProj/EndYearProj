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
using DAL;

namespace ProjectForms
{
    public partial class frmSuburb : Form
    {
        public frmSuburb()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();

        private void frmSuburb_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Suburb suburb = new Suburb();

            suburb.Description = txtSuburb.Text;
            suburb.PostalCode = int.Parse(cmbPostalCode.SelectedValue.ToString());
            suburb.CityID = int.Parse(cmbCityID.SelectedValue.ToString());

            int x = bll.InsertSuburb(suburb);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvSuburb.DataSource = bll.GetSuburb();
        }
    }
}
