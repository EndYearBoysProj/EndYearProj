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

       
    }
}
