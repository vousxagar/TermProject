using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    class DataAccess
    {

            string ConnectionString;

            public DataAccess()
            {
                ConnectionString = "server = localhost; user id = root; password = 02032543; persistsecurityinfo=True; database = final; allowuservariables=True";
            }


            public ArrayList RetreiveAllCategoriesFromDatabase()
            {
                ArrayList CategoriesList = new ArrayList();

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
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

            public bool AddNewProductToDatabase(string ProductName, decimal ProductPrice, int ProductCategoryID, string ProductDescription, byte[] ProductPicture)
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    /*Start a local transaction*/
                    MySqlTransaction sqlTran = connection.BeginTransaction();

                    /*Enlist a command in the current transaction*/
                    MySqlCommand command = connection.CreateCommand();
                    command.Transaction = sqlTran;

                    try
                    {
                        // Execute separate commands.
                        command.Parameters.AddWithValue("@ProductName", ProductName);
                        command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                        command.Parameters.AddWithValue("@ProductCategoryID", ProductCategoryID);
                        command.Parameters.AddWithValue("@ProductDescription", ProductDescription);
                        command.Parameters.AddWithValue("@ProductImage", ProductPicture);

                        command.CommandText =
                           "Insert into products (ProductName, ProductPrice, ProductCategoryID, ProductDescription, ProductImage) values (@ProductName, @ProductPrice, @ProductCategoryID, @ProductDescription, @ProductImage)";
                        command.ExecuteNonQuery();

                        // Commit the transaction.
                        sqlTran.Commit();

                        connection.Close();

                        return true;
                    }
                    catch (Exception ee)
                    {
                        connection.Close();
                        return false;
                    }
                }
            }

            public ArrayList RetreiveAllProducts()
            {
                ArrayList ProductsList = new ArrayList();

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT ProductID, ProductName, ProductPrice, ProductCategoryID, ProductDescription, ProductImage FROM products;", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int ProductID = reader.GetInt32(0);
                            string ProductName = reader.GetString(1);
                            decimal ProductPrice = reader.GetDecimal(2);
                            int ProductCategoryID = reader.GetInt32(3);
                            string ProductCategoryName = ReturnCategoryName(ProductCategoryID);
                            string ProductDescription = reader.GetString(4);
                            byte[] ProductPicture = (byte[])reader[5];

                            ProductsList.Add(new Details() { Name = ProductName, Price = ProductPrice, Category = ProductCategoryName, Description = ProductDescription, Picture = ProductPicture, ID = ProductID });
                        }
                    }
                    reader.Close();

                    return ProductsList;
                }
            }

            public ArrayList RetreiveProductsFromDatabase()
            {
                ArrayList ProductsList = new ArrayList();

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT ProductID, ProductName, Price, ProductDetail FROM products ;", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int ProductID = reader.GetInt32(0);
                            string ProductName = reader.GetString(1);
                            decimal ProductPrice = reader.GetDecimal(2);
                            byte[] ProductPicture = (byte[])reader[3];

                            ProductsList.Add(new Details() { ID = ProductID, Name = ProductName, Price = ProductPrice, Picture = ProductPicture });
                        }
                    }
                    reader.Close();

                    return ProductsList;
                }
            }

        public ArrayList RetreiveAllSaleDetail(int SaleID)
        {
            ArrayList SaleDetail = new ArrayList();
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT SaleDateTime, StaffID, GrandTotal FROM sales where SaleID = '" + SaleID + "';", connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DateTime SaleTime = reader.GetDateTime(0);
                        int SalesmanID = reader.GetInt32(1);
                        string SalesmanName = ReturnUserName(SalesmanID);
                        decimal TotalBill = reader.GetDecimal(2);

                        SaleDetail.Add(new Details() { SaleID = SaleID, SaleTime = SaleTime, Name = SalesmanName, Total = TotalBill });
                    }
                }
                reader.Close();
                return SaleDetail;
            }
        }


        public int ReturnSaleID(DateTime dateTime)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT SaleID FROM sales where SaleDateTime = @DateTime;", connection);
                connection.Open();
                command.Parameters.Add("@DateTime", MySqlDbType.DateTime).Value = dateTime;
                MySqlDataReader reader = command.ExecuteReader();
                int SaleID = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SaleID = reader.GetInt32(0);
                    }
                }
                reader.Close();
                return SaleID;
            }
        }
        public ArrayList ReturnDateTime()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                MySqlCommand command = new MySqlCommand("SELECT SaleDateTime FROM sales", connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                ArrayList DateTime = new ArrayList();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DateTime dateTime = reader.GetDateTime(0);
                        DateTime.Add(new Details() { SaleTime = dateTime });
                    }
                }
                reader.Close();

                return DateTime;
            }
        }
            public int ReturnCategoryID(string CategoryName)
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT CategoryID FROM categories where CategoryName = '" + CategoryName + "';", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    int CategoryID = 0;

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CategoryID = reader.GetInt32(0);
                        }
                    }
                    reader.Close();

                    return CategoryID;
                }
            }

            public string ReturnCategoryName(int CategoryID)
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT CategoryName FROM categories where CategoryID = '" + CategoryID + "';", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    string CategoryName = string.Empty;

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CategoryName = reader.GetString(0);
                        }
                    }
                    reader.Close();

                    return CategoryName;
                }
            }

            public Details RetreiveProductDetails(int ProductID)
            {
                Details ProductDetails = new Details();

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT ProductName, Price, ProductDetail FROM products where ProductID = '" + ProductID + "';", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ProductDetails.Name = reader.GetString(0);
                            ProductDetails.Price = reader.GetDecimal(1);
                            ProductDetails.Picture = (byte[])reader[2];
                        }
                    }
                    reader.Close();

                    return ProductDetails;
                }
            }



        
        public bool RecordASale(DateTime SaleTime, int StaffID, decimal TotalBill, int CustomerID)
            {
                

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    /*Start a local transaction*/
                    MySqlTransaction sqlTran = connection.BeginTransaction();

                    /*Enlist a command in the current transaction*/
                    MySqlCommand command = connection.CreateCommand();
                    command.Transaction = sqlTran;

                   try
                   {

                            //// Execute separate commands.
                            command.Parameters.AddWithValue("@SaleDateTime", SaleTime);
                            command.Parameters.AddWithValue("@CustomerID", CustomerID);
                            command.Parameters.AddWithValue("@StaffID", StaffID);
                            command.Parameters.AddWithValue("@GrandTotal", TotalBill);
                            command.CommandText = "Insert into sales (SaleDateTime, CustomerID, StaffID,GrandTotal ) values (@SaleDateTime, @CustomerID, @StaffID, @GrandTotal)";
                            command.ExecuteNonQuery();

                    sqlTran.Commit();
                    connection.Close();

                }


                    catch (Exception ee)
                    {
                        connection.Close();
                        return false;
                    }




                return true;
            }
            }

            public int ReturnSaleID()
            {
                int SaleID = 0;
                try
                {

                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                    {
                        MySqlCommand command = new MySqlCommand("SELECT SaleID FROM Sales;", connection);
                        connection.Open();

                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                SaleID = reader.GetInt32(0);
                            }
                        }
                        reader.Close();

                        return SaleID;
                    }
                }
                catch (Exception)
                {
                    return SaleID;
                }
            }

            public bool DeleteProduct(int ProductID)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
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

            public bool UpdateProduct(int ProductID, string ProductName, decimal ProductPrice, int ProductCategoryID, string ProductDescription, byte[] ProductPicture)
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    /*Start a local transaction*/
                    MySqlTransaction sqlTran = connection.BeginTransaction();

                    /*Enlist a command in the current transaction*/
                    MySqlCommand command = connection.CreateCommand();
                    command.Transaction = sqlTran;

                    try
                    {
                        // Execute separate commands.
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@ProductName", ProductName);
                        command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                        command.Parameters.AddWithValue("@ProductCategoryID", ProductCategoryID);
                        command.Parameters.AddWithValue("@ProductDescription", ProductDescription);
                        command.Parameters.AddWithValue("@ProductImage", ProductPicture);

                        command.CommandText =
                           "Update products set ProductName = @ProductName, ProductPrice = @ProductPrice, ProductCategoryID = @ProductCategoryID, ProductDescription = @ProductDescription, ProductImage=@ProductImage where ProductID = @ProductID";
                        command.ExecuteNonQuery();

                        // Commit the transaction.
                        sqlTran.Commit();

                        connection.Close();

                        return true;
                    }
                    catch (Exception ee)
                    {
                        connection.Close();
                        return false;
                    }
                }
            }

            public ArrayList RetreiveAllSales()
            {
                ArrayList SalesList = new ArrayList();

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT SaleID, SaleDateTime, StaffID, GrandTotal FROM sales;", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int SaleID = reader.GetInt32(0);
                            DateTime SaleTime = reader.GetDateTime(1);
                            int SalesmanID = reader.GetInt32(2);
                            string SalesmanName = ReturnUserName(SalesmanID);
                            decimal TotalBill = reader.GetDecimal(3);

                            SalesList.Add(new Details() { SaleID = SaleID, SaleTime = SaleTime, Name = SalesmanName, Total = TotalBill });
                        }
                    }
                    reader.Close();

                    return SalesList;
                }
            }

            public string ReturnUserName(int StaffID)
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT StaffName FROM staffs where StaffID = '" + StaffID + "';", connection);
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

            public string ReturnProductName(string ProductID)
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT ProductName FROM products where ProductID = '" + ProductID + "';", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    string ProductName = string.Empty;

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ProductName = reader.GetString(0);
                        }
                    }
                    reader.Close();

                    return ProductName;
                }
            }

            public int ReturnUserID(string StaffCode)
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT StaffID FROM staffs where StaffID = '" + StaffCode + "';", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    int StaffID = 0;

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            StaffID = reader.GetInt32(0);
                        }
                    }
                    reader.Close();

                    return StaffID;
                }
            }

            public bool ConfirmUser(string StaffCode, string StaffPassword)
            {
                string PasswordFromDatabase = string.Empty;

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT StaffPassword FROM staffs where StaffCode = '" + StaffCode + "';", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            PasswordFromDatabase = reader.GetString(0);
                        }
                    }
                    reader.Close();
                }

                if (StaffPassword == PasswordFromDatabase)
                {
                    return true;
                }
                else return false;
            }


            public ArrayList RetreiveSaleItems(int SaleID)
            {
                ArrayList ProductsList = new ArrayList();

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand command = new MySqlCommand("SELECT ProductID, Price, Quantity FROM sale_details where SaleID = '" + SaleID + "';", connection);
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string ProductID = reader.GetString(0);
                            decimal ProductPrice = reader.GetDecimal(1);
                            int ProductQuantity = reader.GetInt32(2);


                            string ProductName = this.ReturnProductName(ProductID);

                            ProductsList.Add(new Details() { Name = ProductName, Price = ProductPrice, Quantity = ProductQuantity});
                        }
                    }
                    reader.Close();

                    return ProductsList;
                }
            }
        
    }
}
