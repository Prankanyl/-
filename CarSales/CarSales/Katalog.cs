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
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Паша\\Desktop\\КПиЯП\\CourseWork-CarSales\\CarSales\\CarSales\\bin\\Debug\\BD.mdb";
        private OleDbConnection myConnection;
        public Katalog()
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

        private void Katalog_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Katalog_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM avto WHERE model = Audi";
            OleDbCommand comand = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = comand.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString() + " " + reader[4].ToString() + " " + reader[5].ToString() + " " + reader[6].ToString() + " " + reader[7].ToString() + " " + reader[8].ToString());
            }
            reader.Close();
        }
    }
}
