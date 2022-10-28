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
    public partial class AgentReports : Form
    {
        public AgentReports()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();

        private void btnReports_Click(object sender, EventArgs e)
        {
            dgvAgentReports.DataSource = bll.GetAgent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgentForm frm = new AgentForm();
            frm.Show();
            this.Hide();
        }
    }
}
