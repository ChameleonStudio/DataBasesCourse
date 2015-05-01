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
    public partial class RealtyTypes : Form
    {
        public RealtyTypes()
        {
            InitializeComponent();
        }

        private void RealtyType_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult save = MessageBox.Show("Сохранить изменения в базе данных перед закрытием формы?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (save == DialogResult.Yes)
            {
                this.Validate();
                this.realtytypeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.realtoragencyDataSet);
            }
            else if (save == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void RealtyType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realtoragencyDataSet.realtytype' table. You can move, or remove it, as needed.
            this.realtytypeTableAdapter.Fill(this.realtoragencyDataSet.realtytype);

        }

        private void realtytypeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Utils.ShowDataErrorMessage(e);

        }
    }
}
