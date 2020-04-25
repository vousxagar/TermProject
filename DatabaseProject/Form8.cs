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
            DataAccess _DataAccess = new DataAccess();

            DateTimecomboBox.Items.Add("=====วันที่=====");

            foreach (Details DateTime in _DataAccess.ReturnDateTime())
            {
                DateTimecomboBox.Items.Add(DateTime.SaleTime);
            }

            DateTimecomboBox.SelectedIndex = 0;
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

            //dataGridView1.DataSource = data;

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

           // dataGridView1.DataSource = data;
        }




        private void DateTimecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalesGridView.Rows.Clear();

            if (DateTimecomboBox.SelectedIndex == 0)
            {
                DataAccess _DataAccess = new DataAccess();

                foreach (Details SaleDetails in _DataAccess.RetreiveAllSales())
                {
                    SalesGridView.Rows.Add(SaleDetails.SaleID, SaleDetails.SaleTime, SaleDetails.Name, SaleDetails.Total, "View Products");
                }
            }
            else if (DateTimecomboBox.SelectedIndex > 0)
            {
                DateTime dateTime = Convert.ToDateTime(DateTimecomboBox.SelectedItem);

                DataAccess _DataAccess = new DataAccess();

                int SaleID = _DataAccess.ReturnSaleID(dateTime);

                foreach (Details SaleDetails in _DataAccess.RetreiveAllSaleDetail(SaleID))
                {
                    SalesGridView.Rows.Add(SaleDetails.SaleID, SaleDetails.SaleTime, SaleDetails.Name, SaleDetails.Total, "View Products");
                }
            }
        }

        private void SalesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (SalesGridView.Columns[e.ColumnIndex].Name == "ProductsColumn")
                {
                    int SaleID = Convert.ToInt32(SalesGridView.Rows[e.RowIndex].Cells["SaleIDColumn"].Value);

                    SaleDetail _ViewSaleItems = new SaleDetail(SaleID);

                    _ViewSaleItems.ShowDialog();
                }
            }
            
        }
    }
}
