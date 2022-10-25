﻿using System;
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
    public partial class RentalFrm : Form
    {
        public RentalFrm()
        {
            InitializeComponent();
        }
        BussinessLogicLayer bll = new BussinessLogicLayer();

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            RentalD rn = new RentalD();

            rn.PropertyAgentD = int.Parse(txtPropertyAgentID.Text);
            rn.TenantID = int.Parse(txtTenantID.Text);
            rn.StartDate = dtpStartDate.Text;
            rn.EndDate = dtpEndDate.Text;


            int x = bll.InsertRental(rn);
            if (x > 0)
            {
                MessageBox.Show("Your information has been added !");
            }
        }

        private void btnUpdateRental_Click(object sender, EventArgs e)
        {
            RentalD re = new RentalD();

            re.StartDate = dtpStartDate.Text;
            re.EndDate = dtpEndDate.Text;




            int x = bll.UpdateRental(re);
            if (x > 0)
            {
                MessageBox.Show("Your information has been Updated");
            }
        }

        private void btnDisplayRental_Click(object sender, EventArgs e)
        {
            dgvRental.DataSource = bll.DisplayRental();
        }
    }
}