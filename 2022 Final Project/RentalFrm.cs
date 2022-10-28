using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace _2022_Final_Project
{
    public partial class RentalFrm : Form
    {
        public RentalFrm()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            RentalD rn = new RentalD();

            rn.PropertyAgentD = int.Parse(cmbPropAgentID.Text);
            rn.TenantID = int.Parse(cmbTenantID.Text);
            rn.StartDate = dtpStartDate.Text;
            rn.EndDate = dtpEndDate.Text;


            int x = bll.InsertRental(rn);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }
        }

        private void btnUpdateRental_Click(object sender, EventArgs e)
        {
            RentalD re = new RentalD();

            re.StartDate = dtpStartDate.Text;
            re.EndDate = dtpEndDate.Text;




            int x = bll.UpdateRental(re);
            if (x > 0)
            {
                MessageBox.Show("Your information has been Updated");
            }
        }

        private void btnDisplayRental_Click(object sender, EventArgs e)
        {
            dgvRental.DataSource = bll.DisplayRental();
        }

        private void dgvRental_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRental.SelectedRows.Count > 0)
            {
                txtRentalID.Text = dgvRental.SelectedRows[0].Cells["RentalID"].Value.ToString();
               

            }
        }

        private void dgvRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AgentHome ago = new AgentHome();
            ago.Show();
            this.Hide();
        }

        private void rentalReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalReport rep = new RentalReport();
            rep.Show();
            this.Hide();
        }
    }
}
