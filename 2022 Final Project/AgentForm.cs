using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_Final_Project
{
    public partial class AgentForm : Form
    {
        public AgentForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AgentHome ag = new AgentHome();
            ag.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
