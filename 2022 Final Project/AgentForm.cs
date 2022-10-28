using BLL;
using DAL;
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
        BussinessLogicLayer bll = new BussinessLogicLayer();

        private void btnBack_Click(object sender, EventArgs e)
        {
            AgentHome ag = new AgentHome();
            ag.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();

            a.Name = txtName.Text;
            a.Surname = txtSurname.Text;
            a.Email = txtEmail.Text;
            a.Password = txtPassword.Text;
            a.Phone = txtPhone.Text;
            a.Status = cmbStatus.Text;
            a.AgencyID = int.Parse(cmbAgencyID.Text);

            int x = bll.InsertAgent(a);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider1.SetError(txtName, string.Empty);
            }
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errorProvider2.SetError(txtSurname, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider2.SetError(txtSurname, string.Empty);
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider3.SetError(txtEmail, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider3.SetError(txtEmail, string.Empty);
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider4.SetError(txtPassword, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider4.SetError(txtPassword, string.Empty);
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errorProvider5.SetError(txtPhone, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider5.SetError(txtPhone, string.Empty);
            }
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                errorProvider6.SetError(cmbStatus, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider6.SetError(cmbStatus, string.Empty);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Agent agent = new Agent();


            agent.AgentID = int.Parse(txtAgentID.Text);


            int x = bll.DeleteAgent(agent);
            if (x > 0)
            {
                MessageBox.Show("Your information has been deleted !");
            }
        }

        private void AgentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Agent agen = new Agent();

          
            agen.Email = txtEmail.Text;
            agen.Phone = txtPhone.Text;
            agen.Status = cmbStatus.Text;
            

            int x = bll.UpdateAgent(agen);
            if (x > 0)
            {
                MessageBox.Show("Your information has been updated !");
            }
        }

        private void dgvAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAgentID.Text = dgvAgent.SelectedRows[0].Cells["AgentID"].Value.ToString();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAgent.DataSource = bll.GetAgent();
        }

        private void agentReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgentReports agr = new AgentReports();
            agr.Show();
            this.Hide();
        }
    }
}
