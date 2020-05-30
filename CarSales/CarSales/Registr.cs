using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CarSales
{
    public partial class Registr : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD.mdb";
        private OleDbConnection myConnection;
        public Form activeForm;
        public Registr()
        { 
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
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

        private void Registr_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
 