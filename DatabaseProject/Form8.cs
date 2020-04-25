using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Form8 : Form
    {
        public object TextBoxValueToSearch { get; private set; }

        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 form7 = new Form7();
            form7.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            searchData("");
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True");
            MySqlCommand cmd = new MySqlCommand("SELECT SaleDateTime, CustomerID, StaffID, GrandTotal FROM sales;", connection);
            connection.Open();

            DataTable data = new DataTable();

            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(data);

            dataGridView1.DataSource = data;

        }

        private void textBoxValueToSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            string valueTOSearch = TextBoxValueToSearch.ToString();
            searchData(valueTOSearch);
        }

        private void searchData(string valueTOSearch)
        {
            MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True");
            MySqlCommand cmd = new MySqlCommand("SELECT SaleDateTime, CustomerID, StaffID, GrandTotal FROM sales;", connection);
            connection.Open();

            DataTable data = new DataTable();

            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(data);

            dataGridView1.DataSource = data;
        }
    }
}
