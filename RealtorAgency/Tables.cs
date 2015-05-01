using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealtorAgency
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clients clientForm = new Clients();
            clientForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Realtors realtorForm = new Realtors();
            realtorForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Deals dealForm = new Deals();
            dealForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Realties realtyForm = new Realties();
            realtyForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Orders orderForm = new Orders();
            orderForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Regions regionForm = new Regions();
            regionForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RealtyTypes realtyTypeForm = new RealtyTypes();
            realtyTypeForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OrderTypes orderTypeForm = new OrderTypes();
            orderTypeForm.ShowDialog();
        }


    }
}
