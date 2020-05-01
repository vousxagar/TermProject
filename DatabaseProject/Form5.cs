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

namespace DatabaseProject
{
    public partial class Form5 : Form
    {

        string ConnectionString = "server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database = final; allowuservariables=True";
        public string ReturnUserName(int CustomerID)
        {
            MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True");
            {
                MySqlCommand command = new MySqlCommand("SELECT CustomerName FROM customers where CustomersID = '" + CustomerID + "';", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                string UserName = string.Empty;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserName = reader.GetString(0);
                    }
                }
                reader.Close();

                return UserName;
            }
        }
        public Form5(int CustomerID)
        {
            InitializeComponent();

            customerid = CustomerID;

            Username = ReturnUserName(CustomerID);
        }

        public int customerid = 1;
        public string Username = string.Empty;

        public int RowIndex = 1;

        public ArrayList RetreiveAllCategoriesFromDatabase()
        {
            ArrayList CategoriesList = new ArrayList();

            using (MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True"))
            {
                MySqlCommand command = new MySqlCommand("SELECT ProductID, ProductName, ProductDetail FROM products;", connection);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int CategoryID = reader.GetInt32(0);
                        string CategoryName = reader.GetString(1);
                        byte[] CategoryPicture = (byte[])reader[2];

                        CategoriesList.Add(new Details() { ID = CategoryID, Name = CategoryName, Picture = CategoryPicture });
                    }
                }
                reader.Close();

                return CategoriesList;
            }
        }

        


        private void Form5_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            ArrayList AllCategories = _DataAccess.RetreiveAllCategoriesFromDatabase();

            foreach (Details Category in AllCategories)
            {
                Button btn = new Button();
                btn.Text = Category.Name;
                btn.Size = new System.Drawing.Size(100, 100);
                btn.ForeColor = Color.White;

                MemoryStream ms = new MemoryStream(Category.Picture);
                btn.Image = Image.FromStream(ms);
                btn.Image = new Bitmap(btn.Image, btn.Size);

          
                btn.Tag = Category.ID;
                ProductsFlowPanel.Controls.Add(btn);
                btn.Click += ProductButton_Click;



            }
        }

        int ProductID1 = 0;
        decimal ProductPrice1 = 0;
        int ProductQuantity1;
        string Name1 = string.Empty;

        int ProductID2 = 0;
        decimal ProductPrice2 = 0;
        int ProductQuantity2;
        string Name2 = string.Empty;

        /*int ProductID3 = 0;
        decimal ProductPrice3 = 0;
        int ProductQuantity3;
        string Name3 = string.Empty;

        int ProductID4 = 0;
        decimal ProductPrice4 = 0;
        int ProductQuantity4;
        string Name4 = string.Empty;*/


        void ProductButton_Click(object sender, EventArgs e)
        {
            Button ProductButton = sender as Button;

            DataAccess _DataAccess = new DataAccess();

            int ProductID = Convert.ToInt32(ProductButton.Tag);

            Details ProductDetails = _DataAccess.RetreiveProductDetails(ProductID);

            if (ProductID1 == 0)
            {
                ProductID1 = ProductID;
            }

            if (CheckProductAlreadyAdded(ProductID))
            {

                // MessageBox.Show("Product Alraedy Exists in Datagrid view at Index : " + RowIndex);
                int Quantity = Convert.ToInt32(ProductsGridView.Rows[RowIndex].Cells["ProductQuantityColumn"].Value);
                decimal Price = Convert.ToInt32(ProductsGridView.Rows[RowIndex].Cells["ProductPriceColumn"].Value);


                Quantity++;

                /////////////<Do thisssss...... Important.. Have decimal part in the total price>
                double TotalPrice = Convert.ToDouble(Quantity * Price);

                ProductsGridView.Rows[RowIndex].Cells["ProductQuantityColumn"].Value = Quantity;
                ProductsGridView.Rows[RowIndex].Cells["TotalPriceColumn"].Value = TotalPrice;
                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();


            }
            else
            {
                ProductsGridView.Rows.Add(ProductID, ProductDetails.Name, ProductDetails.Price, 1, ProductDetails.Price * 1);
                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();

            }

            if(ProductID1 == ProductID)
            {
                foreach (DataGridViewRow Row in ProductsGridView.Rows)
                {
                    ProductPrice1 = Convert.ToDecimal(Row.Cells["ProductPriceColumn"].Value);
                    ProductQuantity1 = Convert.ToInt32(Row.Cells["ProductQuantityColumn"].Value);
                }
            }
            else
            {
                foreach (DataGridViewRow Row in ProductsGridView.Rows)
                {
                    ProductID2 = Convert.ToInt32(Row.Cells["ProductIDColumn"].Value);
                    ProductPrice2 = Convert.ToDecimal(Row.Cells["ProductPriceColumn"].Value);
                    ProductQuantity2 = Convert.ToInt32(Row.Cells["ProductQuantityColumn"].Value);
                }
            }
           

        }


        public bool CheckProductAlreadyAdded(int ProductID)
        {
            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                if (Convert.ToInt32(Row.Cells["ProductIDColumn"].Value) == ProductID)
                {
                    RowIndex = Row.Index;
                    return true;
                }
            }
            return false;
        }

        public decimal CalculateTotalBill(DataGridView ProductsGridView)
        {
            decimal TotalBill = 0;

            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                decimal ProductTotal = Convert.ToDecimal(Row.Cells["TotalPriceColumn"].Value);

                TotalBill = TotalBill + ProductTotal;

            }

            return TotalBill;
        }

        private void ProductsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ProductsGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    if (MessageBox.Show("คุณต้องการลบรายการนี้ หรือไม่?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        decimal DeletedProductTotal = Convert.ToDecimal(ProductsGridView.Rows[e.RowIndex].Cells["TotalPriceColumn"].Value);

                        decimal CurrentTotalBill = Convert.ToDecimal(TotalBillBox.Text);

                        CurrentTotalBill = CurrentTotalBill - DeletedProductTotal;

                        ProductsGridView.Rows.RemoveAt(e.RowIndex);
                        TotalBillBox.Text = CurrentTotalBill.ToString();
                    }
                }
            }
        }

        private void buy_button_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database=final; allowuservariables=True");
            MySqlCommand command = new MySqlCommand("SELECT StaffID FROM staffs", connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            int num = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    num += 1;
                }
                num++;
            }
            reader.Close();
            Random random = new Random();
            int StaffID = random.Next(1,num);
            DataAccess dataAccess = new DataAccess();

            
            if (dataAccess.RecordASale(DateTime.Now, StaffID, CalculateTotalBill(ProductsGridView), customerid))
             {
                RecordSale_detail1(ProductID1, ProductPrice1, ProductQuantity1);
                ProductID1 = 0;
                ProductPrice1 = 0;
                ProductQuantity1 = 0;
                RecordSale_detail2(ProductID2, ProductPrice2, ProductQuantity2);
                ProductID2 = 0;
                ProductPrice2 = 0;
                ProductQuantity2 = 0;
                /*RecordSale_detail3(ProductID3, ProductPrice3, ProductQuantity3);
                ProductID3 = 0;
                ProductPrice3 = 0;
                ProductQuantity3 = 0;
                RecordSale_detail4(ProductID4, ProductPrice4, ProductQuantity4);
                ProductID4 = 0;
                ProductPrice4 = 0;
                ProductQuantity4 = 0;*/
                MessageBox.Show("ขอบคุณที่ใช้บริการค่ะ", " C A F É B A R", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TotalBillBox.Text = string.Empty;
                ProductsGridView.Rows.Clear();
            }
             else
             {
                MessageBox.Show("การซื้อสินค้าล้มเหลว ขออภัยในความไม่สะดวกค่ะ", " C A F É B A R", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        private void ProductsFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool RecordSale_detail1(int ProductID1, decimal ProductPrice1, int ProductQuantity1)
        {

            DataAccess dataAccess = new DataAccess();
            int SaleID = dataAccess.ReturnSaleID();
            if (ProductID1 != 0)
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Open();
                /*Start a local transaction*/
                MySqlTransaction sqlTran = connection.BeginTransaction();
                /*Enlist a command in the current transaction*/
                MySqlCommand command = connection.CreateCommand();
                command.Transaction = sqlTran;
                command.Parameters.AddWithValue("@ProductID1", ProductID1);
                command.Parameters.AddWithValue("@ProductPrice1", ProductPrice1);
                command.Parameters.AddWithValue("@ProductQuantity1", ProductQuantity1);
                command.Parameters.AddWithValue("@SaleID", SaleID);
                command.CommandText = "Insert into sale_details (SaleID,ProductID, Price, Quantity) values (@SaleID, @ProductID1, @ProductPrice1, @ProductQuantity1)";
                command.ExecuteNonQuery();
                sqlTran.Commit();
                connection.Close();
                // MessageBox.Show("Add datail 1");

            }
            return true;
        }
        private bool RecordSale_detail2(int ProductID2, decimal ProductPrice2, int ProductQuantity2)
        {
            DataAccess dataAccess = new DataAccess();
            int SaleID = dataAccess.ReturnSaleID();
            if (ProductID2 != 0)
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Open();
                MySqlTransaction sqlTran1 = connection.BeginTransaction();
                /*Enlist a command in the current transaction*/
                MySqlCommand command1 = connection.CreateCommand();
                command1.Transaction = sqlTran1;

                command1.Parameters.AddWithValue("@ProductID2", ProductID2);
                command1.Parameters.AddWithValue("@ProductPrice2", ProductPrice2);
                command1.Parameters.AddWithValue("@ProductQuantity2", ProductQuantity2);
                command1.Parameters.AddWithValue("@SaleID", SaleID);
                command1.CommandText = "Insert into sale_details (SaleID,ProductID, Price, Quantity) values (@SaleID, @ProductID2, @ProductPrice2, @ProductQuantity2)";
                command1.ExecuteNonQuery();
                sqlTran1.Commit();
                connection.Close();
                //MessageBox.Show("Add detail 2");
            }
            return true;
        }

        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Visible = true;
        }
        
    }
}
   



