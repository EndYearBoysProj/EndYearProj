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
    public partial class SuburbReports : Form
    {
        public SuburbReports()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();

        private void button1_Click(object sender, EventArgs e)
        {
            dgvSubReports.DataSource = bll.GetSuburb();
        }

        private void btnBacl_Click(object sender, EventArgs e)
        {
            frmSuburb fs = new frmSuburb();
            fs.Show();
            this.Hide();
        }
    }
}
