using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealtorAgency
{
    static class Utils
    {
        public static void ShowDataErrorMessage(DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Не все обязательные поля заполнены!!!" + 
                            "\n" + e.Exception.Message,
                             "ОШИБКА",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            e.Cancel = true;
        }

     }
}
