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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();
        
        

        private void btnAddType_Click(object sender, EventArgs e)
        {
            PropertyType type = new PropertyType();

            type.PropertyTypeDescription = txtDescription.Text;

            int x = bll.InsertPropertyType(type);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            PropertyType type = new PropertyType();
            dgvType.DataSource = bll.DisplayPropertyType();

        }
    
    }
}
