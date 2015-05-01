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
    public partial class Realtors : Form
    {
        public Realtors()
        {
            InitializeComponent();
        }

        private void Realtors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realtoragencyDataSet.realtor' table. You can move, or remove it, as needed.
            this.realtorTableAdapter.Fill(this.realtoragencyDataSet.realtor);

        }

        private void Realtors_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult save = MessageBox.Show("Сохранить изменения в базе данных перед закрытием формы?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (save == DialogResult.Yes)
            {
                this.Validate();
                this.realtorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.realtoragencyDataSet);
            }
            else if (save == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void realtorDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Utils.ShowDataErrorMessage(e);
        }
    }
}
