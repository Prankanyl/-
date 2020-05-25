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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Katalog katalog = new Katalog();
            show_form(katalog);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            registr.Text = "Регистрация";
            show_form(registr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            registr.Text = "Вход";
            show_form(registr);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void show_form(Form form)
        {
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
