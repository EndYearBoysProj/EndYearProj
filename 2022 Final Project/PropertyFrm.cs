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
            
            Properties prop = new Properties();

            prop.Description = txtDescription.Text;
            prop.Price = double.Parse(txtPrice.Text);
            prop.Image = txtImage.Text;
            prop.PropertyTypeID = int.Parse(txtPropertyTypeID.Text);
            prop.Status= txtStatus.Text;
            prop.SuburbsID = int.Parse(txtSuburbsID.Text);

            int x = bll.InsertProperty(prop);
            if(x>0)
            {
                MessageBox.Show("Your information has been added !");
            }
        }
    }
}
