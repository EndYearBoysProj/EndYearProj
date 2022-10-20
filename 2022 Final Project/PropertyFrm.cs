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
        BussinessLogicLayer bll=new BussinessLogicLayer();

        private void btnAdd_Click(object sender, EventArgs e)
        {

            PropertiesD prop=new PropertiesD();   

            prop.Description = txtDescription.Text;
            prop.Price = double.Parse(txtPrice.Text);
            prop.image = txtImage.Text;
            prop.PropertyTypeID = int.Parse(txtPropertyTypeID.Text);
            prop.Status= cmbStatus.Text;
            prop.SuburbID = int.Parse(cmbSuburbsID.Text);

            int x = bll.InsertProperty(prop);
            if(x>0)
            {
                MessageBox.Show("Your information has been added !");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PropertiesD p=new PropertiesD();

            p.PropertyTypeID = int.Parse(txtPropertyTypeID.Text);
            p.Price = double.Parse(txtPrice.Text);
            p.Status = cmbStatus.Text;
            p.PropertyID = int.Parse(txtPropertyID.Text);

            int x = bll.UpdateProperty(p);
                if(x>0)
            {
                MessageBox.Show("You have updated your information");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PropertiesD d = new PropertiesD();

            d.PropertyID= int.Parse(txtPropertyID.Text);

            int x = bll.DeleteProperty(d);
            if (x>0)
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


        private void dgvProperty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
