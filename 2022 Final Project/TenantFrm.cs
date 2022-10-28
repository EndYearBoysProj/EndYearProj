using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }
            if (string.IsNullOrEmpty(txtTenantName.Text))
            {
                errorProvider1.SetError(txtTenantName, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTenantName, string.Empty);
            }
            if (string.IsNullOrEmpty(txtTenantSurname.Text))
            {
                errorProvider2.SetError(txtTenantSurname, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider2.SetError(txtTenantSurname, string.Empty);
            }
            if (string.IsNullOrEmpty(txtTenantEmail.Text))
            {
                errorProvider3.SetError(txtTenantEmail, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider3.SetError(txtTenantEmail, string.Empty);
            }
            if (string.IsNullOrEmpty(txtTenantPassword.Text))
            {
                errorProvider4.SetError(txtTenantPassword, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider4.SetError(txtTenantPassword, string.Empty);
            }
            if (string.IsNullOrEmpty(txtTenantNo.Text))
            {
                errorProvider5.SetError(txtTenantNo, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider5.SetError(txtTenantNo, string.Empty);
            }
            if (string.IsNullOrEmpty(cmbTenantStatus.Text))
            {
                errorProvider6.SetError(cmbTenantStatus, "Enter recognised values");
                return;
            }
            else
            {
                errorProvider6.SetError(cmbTenantStatus, string.Empty);
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            TenantD tde = new TenantD();
            tde.TenantID = int.Parse(txtID.Text);

            int x = bll.DeleteTenant(tde);

            if (x > 0)
            {
                MessageBox.Show("Your information has been Deleted");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvTenant.DataSource = bll.DisplayDetails();
        }

        private void dgvTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvTenant.SelectedRows[0].Cells["TenantID"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RentalFrm rf = new RentalFrm();
            rf.Show();
            this.Hide();
        }
    }
}
