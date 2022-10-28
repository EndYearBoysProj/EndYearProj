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
using _2022_Final_Project;

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
            agency.SuburbID = int.Parse(cmbSuburbID.Text);

            int x = bll.InsertAgency(agency);

            if (x > 0)
            {
                MessageBox.Show(x + "Agency Added.");
            }
            if (string.IsNullOrEmpty(txtAgencyName.Text))
            {
                errorProvider1.SetError(txtAgencyName, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider1.SetError(txtAgencyName, string.Empty);
            }
            if (string.IsNullOrEmpty(cmbSuburbID.Text))
            {
                errorProvider2.SetError(cmbSuburbID, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider2.SetError(cmbSuburbID, string.Empty);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvAgency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAgencyID.Text = dgvAgency.SelectedRows[0].Cells["AgencyID"].Value.ToString();
        }

        private void agencyReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgencyReports ar = new AgencyReports();
            ar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }
    }
}
