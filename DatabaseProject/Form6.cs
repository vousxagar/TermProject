using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class pic_add : Form
    {
        private string conn = "server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True";
        private string productname;
        private string productID;
        private string price;

        private int ID_C;
        private string Name_C;
        private string Price_C;
        byte[] Pic_C;

        int i;
        public pic_add()
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
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }
        private void btn_addnew_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True");
            MySqlCommand cmd = connection.CreateCommand();
            connection.Open();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] pic_addImage = ms.GetBuffer();
            ms.Close();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO products(ProductID, ProductName, Price, ProductDetail)  VALUES(@id,@name,@price,@pic)";
            cmd.Parameters.AddWithValue("@id", txt_add_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_add_name.Text);
            cmd.Parameters.AddWithValue("@price", textBox2.Text);
            cmd.Parameters.AddWithValue("@pic", pic_addImage);
            cmd.ExecuteNonQuery();
            MessageBox.Show("บันทึกสำเร็จ!", " C A F É B A R", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_add_id.Text = "";
            txt_add_name.Text = "";
            textBox2.Text = "";
            pictureBox1.Image = null;
            showdatagrid();

        }

        public ArrayList RetreiveAllProducts()
        {
            ArrayList ProductsList = new ArrayList();

            MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo = True; database = final; allowuservariables = True");

            MySqlCommand command = new MySqlCommand("SELECT ProductDetail, ProductID, ProductName, Price FROM products;", connection);
            connection.Open();

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    byte[] ProductPicture = (byte[])reader[0];
                    int ProductID = reader.GetInt32(1);
                    string ProductName = reader.GetString(2);
                    decimal ProductPrice = reader.GetDecimal(3);


                    ProductsList.Add(new Details() { Name = ProductName, Price = ProductPrice, Picture = ProductPicture, ID = ProductID });
                }
            }
            reader.Close();

            return ProductsList;

        }

        private void showdatagrid()
        {
            foreach (Details ProductDetail in RetreiveAllProducts())
            {
                dataGridView2.Rows.Add(ProductDetail.Picture, ProductDetail.ID, ProductDetail.Name, ProductDetail.Price);
            }
            if (dataGridView2.SelectedRows.Count >= 0)
            {
                string ID_C = dataGridView2.SelectedRows[0].Cells[1].Value + String.Empty;
                string Name_C = dataGridView2.SelectedRows[0].Cells[2].Value + String.Empty;
                string Price_C = dataGridView2.SelectedRows[0].Cells[3].Value + String.Empty;

                txt_edit_id.Text = ID_C;
                txt_edit_name.Text = Name_C;
                textBox1.Text = Price_C;
            }
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

        public string SetTextbox { get; internal set; }

        string StaffPassword;
        public pic_add(string StaffName, string StaffID)
        {
            InitializeComponent();
            this.StaffName = StaffName;
            this.StaffID = StaffID;
            string sql = "SELECT StaffPassword FROM staffs";
            MySqlConnection connection = new MySqlConnection(conn);
            connection.ConnectionString = conn;
            String query = "SELECT StaffPassword FROM staffs WHERE StaffID = '" + StaffID + "'";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", StaffID);
                cmd.ExecuteScalar();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    this.StaffPassword = rdr["StaffPassword"].ToString();


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
            cmd.CommandText = "UPDATE products SET ProductName = @name, Price = @price, ProductDetail = @pic where products.ProductID = @id";
            cmd.Parameters.AddWithValue("@id", txt_edit_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_edit_name.Text);
            cmd.Parameters.AddWithValue("@price", textBox1.Text);
            cmd.Parameters.AddWithValue("@pic", pic_editImage);
            cmd.ExecuteNonQuery();
            MessageBox.Show("แก้ไขสำเร็จ!", " C A F É B A R", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_edit_id.Text = "";
            txt_edit_name.Text = "";
            textBox1.Text = "";
            pic_edit.Image = null;
            showdatagrid();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            foreach (Details ProductDetail in RetreiveAllProducts())
            {
                dataGridView2.Rows.Add(ProductDetail.Picture, ProductDetail.ID, ProductDetail.Name, ProductDetail.Price);
            }

            if (dataGridView2.SelectedRows.Count >= 0)
            {
                string ID_C = dataGridView2.SelectedRows[0].Cells[1].Value + String.Empty;
                string Name_C = dataGridView2.SelectedRows[0].Cells[2].Value + String.Empty;
                string Price_C = dataGridView2.SelectedRows[0].Cells[3].Value + String.Empty;

                txt_edit_id.Text = ID_C;
                txt_edit_name.Text = Name_C;
                textBox1.Text = Price_C;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_select_edit_Click(object sender, EventArgs e)
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
                pic_edit.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        public bool DeleteProduct(int ProductID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True"))
                {
                    MySqlCommand command = new MySqlCommand("Delete from products where ProductID = '" + ProductID + "'", connection);
                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                if (dataGridView2.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("คุณต้องการที่จะลบหรือไม่!", " C A F É B A R", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int ProductID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["id"].Value);


                        if (DeleteProduct(ProductID))
                        {
                            dataGridView2.Rows.RemoveAt(e.RowIndex);
                        }
                        else if (!DeleteProduct(ProductID))
                        {
                            MessageBox.Show("ลบสำเร็จ!", " C A F É B A R", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            if (dataGridView2.SelectedRows.Count >= 0)
            {
                string ID_C = dataGridView2.SelectedRows[0].Cells[1].Value + String.Empty;
                string Name_C = dataGridView2.SelectedRows[0].Cells[2].Value + String.Empty;
                string Price_C = dataGridView2.SelectedRows[0].Cells[3].Value + String.Empty;

                txt_edit_id.Text = ID_C;
                txt_edit_name.Text = Name_C;
                textBox1.Text = Price_C;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 form4 = new Form4();
            form4.Visible = true;
        }

        private void pic_add_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pic_add_Click_1(object sender, EventArgs e)
        {

        }
    }
}

