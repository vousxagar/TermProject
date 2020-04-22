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

        ArrayList ProductsList = new ArrayList();

        void ProductButton_Click(object sender, EventArgs e)
        {
            Button ProductButton = sender as Button;

            DataAccess _DataAccess = new DataAccess();

            int ProductID = Convert.ToInt32(ProductButton.Tag);

            Details ProductDetails = _DataAccess.RetreiveProductDetails(ProductID);

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

                

            }
            else
            {
                ProductsGridView.Rows.Add(ProductID, ProductDetails.Name, ProductDetails.Price, 1, ProductDetails.Price * 1);
                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();


                foreach (DataGridViewRow Row in ProductsGridView.Rows)
                {
                    int ProductIDs = Convert.ToInt32(Row.Cells["ProductIDColumn"].Value);
                    string ProductName = Convert.ToString(Row.Cells["ProductNameColumn"].Value);
                    decimal ProductPrice = Convert.ToDecimal(Row.Cells["ProductPriceColumn"].Value);
                    int ProductQuantity = Convert.ToInt32(Row.Cells["ProductQuantityColumn"].Value);
                    decimal ProductTotal = Convert.ToDecimal(Row.Cells["TotalPriceColumn"].Value);

                    ProductsList.Add(new Details() { Name = ProductName, ID = ProductIDs, Price = ProductPrice, Quantity = ProductQuantity, Total = ProductTotal });
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
                MessageBox.Show("คุณต้องการที่จะลบหรือไม่!", " C A F É B A R", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ProductsGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int ProductID = Convert.ToInt32(ProductsGridView.Rows[e.RowIndex].Cells["id"].Value);
                    ProductsGridView.Rows.RemoveAt((e.RowIndex));
                }
                else
                {
                    ProductsGridView.Rows.RemoveAt((e.RowIndex));
                    MessageBox.Show("ลบสำเร็จ!", " C A F É B A R", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            reader.Close();
            Random random = new Random();
            int StaffID = random.Next(num);
            DataAccess dataAccess = new DataAccess();


            
            if (dataAccess.RecordASale(ProductsList, DateTime.Now, StaffID, CalculateTotalBill(ProductsGridView), customerid))
            {
                dataAccess.RecordSale_detail(ProductsList);
                MessageBox.Show("ขอบคุณที่ใช้บริการค่ะ", "Cafe Name!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("การซื้อสินค้าล้มเหลว ขออภัยในความไม่สะดวกค่ะ", "Cafe_name!", MessageBoxButtons.OK);
            }
        }

        private void ProductsFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

   



