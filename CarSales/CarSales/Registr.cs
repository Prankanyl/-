using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSales
{
    public partial class Registr : Form
    {
        public Form activeForm;
        public Registr()
        { 
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            activeForm = Form.ActiveForm;
            Menu menu = new Menu();
            HelpFunctions.show_form(activeForm, menu, "CarSales");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 