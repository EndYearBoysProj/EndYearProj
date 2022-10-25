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
    public partial class frmSuburb : Form
    {
        public frmSuburb()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll=new BussinessLogicLayer();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Suburb sub = new Suburb();


            sub.SuburbDescription = txtSuburbDesc.Text;
            sub.PostalCode = txtCode.Text;
            sub.CityID = int.Parse(cmbCityID.Text);

            int x = bll.InsertSuburb(sub);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvSuburb.DataSource = bll.GetSuburb();
        }
    }
}
