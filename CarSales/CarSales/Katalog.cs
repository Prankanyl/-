using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSales
{
    public partial class Katalog : Form
    {
        public Form activeForm;

        public Katalog()
        {
            InitializeComponent();

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            activeForm = Form.ActiveForm;
            Menu menu = new Menu();
            HelpFunctions.show_form(activeForm, menu, "CarSales");
        }

        private void Katalog_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet1.avto". При необходимости она может быть перемещена или удалена.
            this.avtoTableAdapter.Fill(this.bDDataSet1.avto);
            //MessageBox.Show($"{this.bDDataSet1.avto}");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Katalog_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }
    }
}
