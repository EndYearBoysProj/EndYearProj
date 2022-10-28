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
    public partial class AgentHome : Form
    {
        public AgentHome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PropertyTypefrm ptf = new PropertyTypefrm();
            ptf.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RentalFrm rf = new RentalFrm();
            rf.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PropertyAgentForm paf = new PropertyAgentForm();
            paf.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnAgentD_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PropertyFrm paf = new PropertyFrm();
            paf.Show();
            this.Hide();
        }
    }
}
