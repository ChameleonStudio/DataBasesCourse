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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.realtoragencyDataSet.client);
        }

        private void Clients_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult save = MessageBox.Show("Сохранить изменения в базе данных перед закрытием формы?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (save == DialogResult.Yes)
            {
                this.Validate();
                this.clientBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.realtoragencyDataSet);
            }
            else if(save == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void clientDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Не все обязательные поля заполнены!!!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //e.Exception.Message;
            e.Cancel = true;
        }
    }
}
