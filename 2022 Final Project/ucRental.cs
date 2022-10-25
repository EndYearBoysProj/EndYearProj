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

namespace RealProject
{
    public partial class ucRental : UserControl
    {
        public ucRental()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll= new BussinessLogicLayer();
        
        private void btnAddRental_Click(object sender, EventArgs e)
        {
            RentalDetails ren = new RentalDetails();   

            ren.PropertyAgentD = int.Parse(txtPropertyAgentID.ToString());
            ren.TenantID = int.Parse(txtTenantID.ToString());
            ren.StartDate = dtpStartDate.Text;
            ren.EndDate = dtpEndDate.Text;
            

            int x = bll.InsertRental(ren);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }
        }

        private void btnDisplayRental_Click(object sender, EventArgs e)
        {
            dgvRental.DataSource = bll.DisplayRental();
        }

        private void btnUpdateRental_Click(object sender, EventArgs e)
        {
            RentalDetails ren = new RentalDetails();

            ren.StartDate = dtpStartDate.Text;
            ren.EndDate = dtpEndDate.Text;
           



            int x = bll.UpdateRental(ren);
            if (x > 0)
            {
                MessageBox.Show("Your information has been Updated");
            }
        }
    }
}
