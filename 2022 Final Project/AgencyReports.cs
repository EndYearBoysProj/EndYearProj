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
using ProjectForms;

namespace _2022_Final_Project
{
    public partial class AgencyReports : Form
    {
        public AgencyReports()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();

        private void btnReports_Click(object sender, EventArgs e)
        {
            dgvAgencyReports.DataSource = bll.GetAgencyReports();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgency fg = new frmAgency();
            fg.Show();
            this.Hide();
        }
    }
}
