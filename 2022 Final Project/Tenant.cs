using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace RealProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TenantDetails ten = new TenantDetails();

            ten.Name = txtTenantName.Text;
            ten.Surname = txtTenantSurname.Text;
            ten.Email = txtTenantEmail.Text;
            ten.Password = txtTenantPassword.Text;
            ten.Phone = txtTenantNo.Text;
            ten.Status = cmbTenantStatus.SelectedIndex;

            int x = bll.InsertDetails(ten);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvTenant.DataSource = bll.DisplayDetails();
        }

        private void dgvTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTenant.SelectedRows.Count > 0)
            {
                txtID.Text = dgvTenant.SelectedRows[0].Cells["TenantID"].Value.ToString();
                txtTenantName.Text = dgvTenant.SelectedRows[0].Cells["Name"].Value.ToString();
                txtTenantSurname.Text = dgvTenant.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtTenantEmail.Text = dgvTenant.SelectedRows[0].Cells["Email"].Value.ToString();
                txtTenantPassword.Text = dgvTenant.SelectedRows[0].Cells["Password"].Value.ToString();
                txtTenantNo.Text = dgvTenant.SelectedRows[0].Cells["Phone"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TenantDetails ten = new TenantDetails();

            ten.TenantID= int.Parse(txtID.Text);
            ten.Email = txtTenantEmail.Text;
            ten.Phone = txtTenantNo.Text;
            ten.Status = cmbTenantStatus.SelectedIndex;

            

            int x = bll.UpdateTenant(ten);
            if (x > 0)
            {
                MessageBox.Show("Your information has been Updated");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TenantDetails ten = new TenantDetails();

            ten.TenantID = int.Parse(txtID.Text);

            int x = bll.DeleteTenant(ten);

            if (x > 0)
            {
                MessageBox.Show("Your information has been Deleted");
            }
        }

        private void dgvTenant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTenant.SelectedRows.Count > 0)
            {
                txtID.Text = dgvTenant.SelectedRows[0].Cells["TenantID"].Value.ToString();
                txtTenantName.Text = dgvTenant.SelectedRows[0].Cells["Name"].Value.ToString();
                txtTenantSurname.Text = dgvTenant.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtTenantEmail.Text = dgvTenant.SelectedRows[0].Cells["Email"].Value.ToString();
                txtTenantPassword.Text = dgvTenant.SelectedRows[0].Cells["Password"].Value.ToString();
                txtTenantNo.Text = dgvTenant.SelectedRows[0].Cells["Phone"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
    }
}

