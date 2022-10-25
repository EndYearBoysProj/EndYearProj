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
    public partial class TenantFrm : Form
    {
        public TenantFrm()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TenantD te = new TenantD();

            te.Name = txtTenantName.Text;
            te.Surname = txtTenantSurname.Text;
            te.Email = txtTenantEmail.Text;
            te.Password = txtTenantPassword.Text;
            te.Phone = txtTenantNo.Text;
            te.Status = cmbTenantStatus.SelectedIndex;

            int x = bll.InsertDetails(te);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TenantD t = new TenantD();

            t.TenantID = int.Parse(txtID.Text);
            t.Email = txtTenantEmail.Text;
            t.Phone = txtTenantNo.Text;
            t.Status = cmbTenantStatus.SelectedIndex;



            int x = bll.UpdateTenant(t);
            if (x > 0)
            {
                MessageBox.Show("Your information has been Updated");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TenantD tenant = new TenantD();

            tenant.TenantID = int.Parse(txtID.Text);

            int x = bll.DeleteTenant(tenant);

            if (x > 0)
            {
                MessageBox.Show("Your information has been Deleted");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvTenant.DataSource = bll.DisplayDetails();
        }
    }
}
