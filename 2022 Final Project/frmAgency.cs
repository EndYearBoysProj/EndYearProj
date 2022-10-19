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

namespace ProjectForms
{
    public partial class frmAgency : Form
    {
        public frmAgency()
        {
            InitializeComponent();
        }
        DataAccessLayer dal = new DataAccessLayer();
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agency agency = new Agency();

            agency.AgencyName = txtAgencyName.Text;

            int x = bll.InsertAgency(agency);

            if (x > 0)
            {
                MessageBox.Show(x + "Agency Added.");
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAgency.DataSource = bll.GetAgency();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Agency agency = new Agency();
            agency.AgencyID = int.Parse(txtAgencyID.Text);

            int d = bll.DeleteAgency(agency);

            if (d > 0)
            {
                MessageBox.Show(d + "Agency Deleted.");
            }
        }
    }
}
