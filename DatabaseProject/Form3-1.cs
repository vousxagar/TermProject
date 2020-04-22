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
            String query = "SELECT CustomerName, CustomersID FROM customers WHERE CustomersID = '" + Useridcus.Text + "'";

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
                    this.customerID = rdr["CustomersID"].ToString();
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
            
            MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True");
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO customers(CustomersID,CustomerName,Gender,CustomerType,CustomerTelNo) VALUES (@id,@name,@gender,@type,@telno)";
            cmd.Parameters.AddWithValue("@id", Useridcus.Text);
            cmd.Parameters.AddWithValue("@name", passcus.Text);
            cmd.Parameters.AddWithValue("@gender", combogender1.Text);
            cmd.Parameters.AddWithValue("@type", combotype.Text);
            cmd.Parameters.AddWithValue("@telno", telme.Text);
            cmd.ExecuteNonQuery();
            
          
            MessageBox.Show("🌻🌻บันทึกสำเร็จ🌻🌻");

            Useridcus.Text = "";
            passcus.Text = "";
            combogender1.Text = "";
            combotype.Text = "";
            telme.Text = "";



            Form2_3 form2_3 = new Form2_3();
            form2_3.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
    

