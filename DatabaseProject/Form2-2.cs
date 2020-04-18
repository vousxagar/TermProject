using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Form2_2 : Form

    {
        private string conn ="server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True";
        private string staffname;
        private string staffID;
     
        int i;
        
        public Form2_2()
        {
            InitializeComponent();
        }

        private void getTheName(String username)
        {
           
            MySqlConnection connection = new MySqlConnection(conn);
            connection.ConnectionString = conn;
            String query = "SELECT StaffName, StaffID FROM staffs WHERE StaffID = '" + UserID.Text + "'";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    this.staffname = rdr["StaffName"].ToString();
                    this.staffID = rdr["StaffID"].ToString();


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
        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True");
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staffs where StaffID ='" + UserID.Text + "' and StaffPassword ='" + Password.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("you have entered invalid ID or Password");
            }

            else
            {
                this.getTheName(UserID.Text);
                this.Hide();
                string StaffName = this.staffname.Trim();
                string StaffID = this.staffID.Trim();


                Form4 form4 = new Form4(StaffName, StaffID);
                form4.Show();
            }

            connection.Close();
            

        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("แล้วพบกันใหม่โอกาศหน้าที่ร้าน C A F É B A R ", "C A F É B A R", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2_4 form2_4 = new Form2_4();
            form2_4.Visible = true;
        }

      
    }
}
