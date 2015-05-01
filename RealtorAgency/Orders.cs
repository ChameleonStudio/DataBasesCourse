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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realtoragencyDataSet.ordertype' table. You can move, or remove it, as needed.
            this.ordertypeTableAdapter.Fill(this.realtoragencyDataSet.ordertype);
            // TODO: This line of code loads data into the 'realtoragencyDataSet.realty' table. You can move, or remove it, as needed.
            this.realtyTableAdapter.Fill(this.realtoragencyDataSet.realty);
            // TODO: This line of code loads data into the 'realtoragencyDataSet.realtor' table. You can move, or remove it, as needed.
            this.realtorTableAdapter.Fill(this.realtoragencyDataSet.realtor);
            // TODO: This line of code loads data into the 'realtoragencyDataSet.order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.realtoragencyDataSet.order);

        }

        private void Orders_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult save = MessageBox.Show("Сохранить изменения в базе данных перед закрытием формы?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (save == DialogResult.Yes)
            {
                this.Validate();
                this.orderBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.realtoragencyDataSet);
            }
            else if (save == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void orderDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Utils.ShowDataErrorMessage(e);
        }
    }
}
