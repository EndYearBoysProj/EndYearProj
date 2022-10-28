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

namespace _2022_Final_Project
{
    public partial class PropertyReportcs : Form
    {
        public PropertyReportcs()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void btnReports_Click(object sender, EventArgs e)
        {
            dgvPReports.DataSource = bll.GetPropReports();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PropertyFrm prf = new PropertyFrm();
            prf.Show();
            this.Hide();
        }
    }
}
