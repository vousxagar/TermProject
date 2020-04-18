using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace DatabaseProject
{
    public partial class Form6 : Form
    {
        private string conn = "server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True";
        private string productname;
        private string productID;
        private string price;

        int i;
        public Form6()
        {
            InitializeComponent();
        }
        private void getTheName(String username)
        {

            MySqlConnection connection = new MySqlConnection(conn);
            connection.ConnectionString = conn;
            String query = "SELECT ProductID, ProductName, Price FROM products WHERE ProductID = '" + txt_add_id.Text + "'";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    this.productname = rdr["ProductName"].ToString();
                    this.productID = rdr["ProductID"].ToString();
                    this.price = rdr["Price"].ToString();


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
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_select_addpic_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = " ";
            openFileDialog1.Title = "Insert an Image";
            openFileDialog1.FileName = " ";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("operatin cancelled");
            }
            else
            {
                pic_add.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True");
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
            MemoryStream ms = new MemoryStream();
            pic_add.Image.Save(ms, pic_add.Image.RawFormat);
            byte[] pic_addImage = ms.GetBuffer();
            ms.Close();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO products(ProductID, ProductName, Price, ProductDetail)  VALUES(@id,@name,@price,@pic)";
            cmd.Parameters.AddWithValue("@id", txt_add_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_add_name.Text);
            cmd.Parameters.AddWithValue("@price", textBox2.Text );
            cmd.Parameters.AddWithValue("@pic", pic_addImage);
            cmd.ExecuteNonQuery();
      
            MessageBox.Show("บันทึกสำเร็จ!", " C A F É B A R", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_add_id.Text = "";
            txt_add_name.Text = "";
            textBox2.Text = "";
            pic_add.Image = null;

            showdatagrid();

        }
        private void showdatagrid()
        {
            string sql = "SELECT * FROM products";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=02032543;database=final");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open(); //เปิดการเชื่อมต่อ
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();

            
        }
        
        
        private string staffname;
        private string StaffName
        {
            get { return staffname; }
            set { staffname = value; }
        }
        private string staffID;
        private string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
        public Form6(string StaffName, string StaffID)
        {
            InitializeComponent();
            this.StaffName = StaffName;
            this.StaffID = StaffID;
        }

        private void btn_save_edit_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True");
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
            MemoryStream ms = new MemoryStream();
            pic_edit.Image.Save(ms, pic_edit.Image.RawFormat);
            byte[] pic_editImage = ms.GetBuffer();
            ms.Close();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE products SET  ProductName = " + txt_edit_name.Text +"', Price = '" + textBox1.Text + "', ProductDetail = '" + pic_editImage + " )";
           
            cmd.ExecuteNonQuery();

            MessageBox.Show("บันทึกสำเร็จ!", " C A F É B A R", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_add_id.Text = "";
            txt_add_name.Text = "";
            textBox2.Text = "";
            pic_add.Image = null;

            showdatagrid();
        }
    }
}
