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
    public partial class frmAgent : Form
    {
        public frmAgent()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();

            agent.AgentID = int.Parse(txtAgentID.Text);
            agent.Name = txtAgentName.Text;
            agent.Surname = txtSurname.Text;
            agent.Email = txtEmail.Text;
            agent.Password = txtPassword.Text;
            agent.Phone = int.Parse(txtPhone.Text);
            agent.Status = cmbStatus.SelectedValue.ToString();
            agent.AgencyID = int.Parse(cmbAgencyID.SelectedValue.ToString());

            int x = bll.InsertAgent(agent);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();

            agent.Email = txtEmail.Text;
            agent.Phone = int.Parse(txtPhone.Text);
            agent.Status = cmbStatus.SelectedValue.ToString();

            int g = bll.UpdateAgent(agent);
            if (g > 0)
            {
                MessageBox.Show("Your information has been updated !");
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAgent.DataSource = bll.GetAgent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
