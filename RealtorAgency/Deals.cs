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
    public partial class Deals : Form
    {
        public Deals()
        {
            InitializeComponent();
        }

        private void Deals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realtoragencyDataSet.region' table. You can move, or remove it, as needed.
            this.regionTableAdapter.Fill(this.realtoragencyDataSet.region);
            // TODO: This line of code loads data into the 'realtoragencyDataSet.order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.realtoragencyDataSet.order);
            // TODO: This line of code loads data into the 'realtoragencyDataSet.order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.realtoragencyDataSet.order);
            // TODO: This line of code loads data into the 'realtoragencyDataSet.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.realtoragencyDataSet.client);
            // TODO: This line of code loads data into the 'realtoragencyDataSet.deal' table. You can move, or remove it, as needed.
            this.dealTableAdapter.Fill(this.realtoragencyDataSet.deal);

        }

        private void Deals_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult save = MessageBox.Show("Сохранить изменения в базе данных перед закрытием формы?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (save == DialogResult.Yes)
            {
                this.Validate();
                this.dealBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.realtoragencyDataSet);
            }
            else if (save == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dealDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Utils.ShowDataErrorMessage(e);
        }
    }
}
