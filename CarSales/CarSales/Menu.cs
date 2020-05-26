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
        public Form activeForm;
        public Menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Katalog katalog = new Katalog();
            activeForm = Form.ActiveForm;
            HelpFunctions.show_form(activeForm, katalog, "Каталог");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            registr.label4.Visible = true;
            registr.textBox4.Visible = true;
            registr.label5.Visible = true;
            registr.textBox5.Visible = true;
            registr.label6.Text = "Регистрация";
            registr.button1.Text = "Регистрация";
            activeForm = Form.ActiveForm;
            HelpFunctions.show_form(activeForm, registr, "Регистрация");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            registr.label4.Visible = false;
            registr.textBox4.Visible = false;
            registr.label5.Visible = false;
            registr.textBox5.Visible = false;
            registr.label6.Text = "Вход";
            registr.button1.Text = "Вход";
            activeForm = Form.ActiveForm;
            HelpFunctions.show_form(activeForm, registr, "Вход");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
