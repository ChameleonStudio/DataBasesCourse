using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealtorAgency
{
    public partial class Realties : Form
    {
        public Realties()
        {
            InitializeComponent();
        }

        private void Realties_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realtoragencyDataSet.realtytype' table. You can move, or remove it, as needed.
            this.realtytypeTableAdapter.Fill(this.realtoragencyDataSet.realtytype);
            // TODO: This line of code loads data into the 'realtoragencyDataSet.region' table. You can move, or remove it, as needed.
            this.regionTableAdapter.Fill(this.realtoragencyDataSet.region);
            // TODO: This line of code loads data into the 'realtoragencyDataSet.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.realtoragencyDataSet.client);
            // TODO: This line of code loads data into the 'realtoragencyDataSet.realty' table. You can move, or remove it, as needed.
            this.realtyTableAdapter.Fill(this.realtoragencyDataSet.realty);
        }

        private void Realties_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult save = MessageBox.Show("Сохранить изменения в базе данных перед закрытием формы?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (save == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    this.realtyBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.realtoragencyDataSet);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            else if (save == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void realtyDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Utils.ShowDataErrorMessage(e);
        }
              
     }
}
