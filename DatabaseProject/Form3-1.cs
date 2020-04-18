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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2_3 form2_3 = new Form2_3();
            form2_3.Visible = true;
        }
        private string conn = "server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True";
        private string customername;
        private string customerID;
        private string customerTelNo;

        int i;
        private void getTheName(String username)
        {

            MySqlConnection connection = new MySqlConnection(conn);
            connection.ConnectionString = conn;
            String query = "SELECT CustomerName, CustomerID FROM customers WHERE CustomerID = '" + Useridcus.Text + "'";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    this.customername = rdr["CustomerName"].ToString();
                    this.customerID = rdr["CustomerID"].ToString();
                    this.customerTelNo = rdr["CustomerTelNo"].ToString();



                }
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("แล้วพบกันใหม่โอกาศหน้าที่ร้าน C A F É B A R ", "C A F É B A R", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True");
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customers where CustomerID ='" + Useridcus.Text + "' and CustomerName ='" + passcus.Text + "' and CustomerTelNo ='" + telme.Text + "'  ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("you have entered invalid ID and Name or TelNo ");
            }

            else
            {
                this.getTheName(Useridcus.Text);
                this.Hide();
                string CustomerName = this.customername.Trim();
                string CustomerID = this.customerID.Trim();

                


                Form4_1 form4_1 = new Form4_1(customername, customerID);
                form4_1.Show();
            }

            connection.Close();


        }
    }
}
    

