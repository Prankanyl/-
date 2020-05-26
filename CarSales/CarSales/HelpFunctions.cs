using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSales
{
    class HelpFunctions
    {
        public static void show_form(Form activeForm, Form form, string caption_form)
        {
            form.Text = caption_form;
            activeForm.Hide();
            form.ShowDialog();
            activeForm.Close();
        }
    }
}
