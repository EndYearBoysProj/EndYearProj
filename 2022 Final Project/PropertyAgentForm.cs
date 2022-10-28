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

using BLL;

namespace _2022_Final_Project
{
    public partial class PropertyAgentForm : Form
    {
        public PropertyAgentForm()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            PropertyAgent pa = new PropertyAgent();

            pa.PropertyID = int.Parse(cmbPropID.Text);
            pa.AgentID = int.Parse(cmbAgentID.Text);
            pa.Date = dtpDate.Text;



            int x = bll.InsertPropertyAgent(pa);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PropertyAgent page = new PropertyAgent();

            page.PropertyID = int.Parse(cmbPropID.Text);
            page.AgentID = int.Parse(cmbAgentID.Text);
            page.Date = dtpDate.Text;

            int x = bll.UpdatePropertyAgent(page);
            if (x > 0)
            {
                MessageBox.Show("You have updated your information");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvPropAgentForm.DataSource = bll.GetPropAgent();
        }

        private void dgvPropAgentForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPropAgentForm.SelectedRows.Count > 0)
            {
                txtPropertyAgentID.Text = dgvPropAgentForm.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString();
                cmbPropID.Text = dgvPropAgentForm.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                cmbAgentID.Text = dgvPropAgentForm.SelectedRows[0].Cells["AgentID"].Value.ToString();
                dtpDate.Text = dgvPropAgentForm.SelectedRows[0].Cells["Date"].Value.ToString();

            }
        }

        private void dgvPropAgentForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvPropAgentForm.SelectedRows.Count > 0)
            {
                txtPropertyAgentID.Text = dgvPropAgentForm.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString();
                cmbPropID.Text = dgvPropAgentForm.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                cmbAgentID.Text = dgvPropAgentForm.SelectedRows[0].Cells["AgentID"].Value.ToString();
                dtpDate.Text = dgvPropAgentForm.SelectedRows[0].Cells["Date"].Value.ToString();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AgentHome aa = new AgentHome();
            aa.Show();
            this.Hide();
        }
    }
}
