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

namespace _2022_Final_Project
{
    public partial class PropertyFrm : Form
    {
        public PropertyFrm()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();

        private void btnAdd_Click(object sender, EventArgs e)
        {

            PropertiesD pro = new PropertiesD();

            pro.Description = txtDescription.Text;
            pro.Price = double.Parse(txtPrice.Text);
            pro.Image = txtImage.Text;
            pro.PropertyTypeID = int.Parse(cmbPropertyTypeID.Text);
            pro.Status = cmbStatus.Text;
            pro.SuburbID = int.Parse(cmbSuburbsID.Text);

            int x = bll.InsertProperty(pro);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PropertiesD p = new PropertiesD();

            p.PropertyTypeID = int.Parse(cmbPropertyTypeID.Text);
            p.Price = double.Parse(txtPrice.Text);
            p.Status = cmbStatus.Text;
            p.PropertyID = int.Parse(txtPropertyID.Text);

            int x = bll.UpdateProperty(p);
            if (x > 0)
            {
                MessageBox.Show("You have updated your information");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PropertiesD de = new PropertiesD();

            de.PropertyID = int.Parse(txtPropertyID.Text);

            int x = bll.DeleteProperty(de);
            if (x > 0)
            {
                MessageBox.Show("Your information has been deleted");
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvProperty.DataSource = bll.DisplayProperty();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            hm.Show();
            this.Close();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PropertyFrm_Load(object sender, EventArgs e)
        {

        }

        private void dgvProperty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProperty.SelectedRows.Count > 0)
            {
                txtPropertyID.Text = dgvProperty.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                txtDescription.Text = dgvProperty.SelectedRows[0].Cells["Description"].Value.ToString();
                txtPrice.Text = dgvProperty.SelectedRows[0].Cells["Price"].Value.ToString();
                txtImage.Text = dgvProperty.SelectedRows[0].Cells["Image"].Value.ToString();
                cmbPropertyTypeID.Text = dgvProperty.SelectedRows[0].Cells["PropertyTypeID"].Value.ToString();
                cmbStatus.Text = dgvProperty.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbSuburbsID.Text = dgvProperty.SelectedRows[0].Cells["SuburbsID"].Value.ToString();
            }
        }
    }
}
