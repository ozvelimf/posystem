using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MainClass
{
    public static class Function
    {
        private static string connectionString = @"Data Source=MFO;Initial Catalog=posystem;Integrated Security=True";
        public static string sessionUsername;
        public static int sessionUserID;

        // USER AND LOGIN
        public static DataTable LoadUserData(string searchTerm)
        {
            string qry = @"Select id, username as Username, email as Email from users where username like @searchTerm order by id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable GetUserData(int id)
        {
            string qry = @"Select id, username as Username, email as Email from users where id = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public static bool SaveUserData(int id, string username, string email, string password = null)
        {
            string qry;
            bool isUpdate = id > 0;

            if (isUpdate)
            {
                qry = @"Update users set username = @username, email = @Email" + (password != null ? ", password = @password" : "") + " where id = @id";
            }
            else
            {
                qry = @"Insert into users (username, email, password) values (@username, @Email, @password)";
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@Email", email);

                    if (password != null)
                    {
                        cmd.Parameters.AddWithValue("@password", password);
                    }

                    if (isUpdate)
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                    }

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public static bool ValidateUserData(int id, string username, string email, string password, string repassword)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            bool isNewUser = id == 0;

            if (isNewUser)
            {
                
                if (string.IsNullOrWhiteSpace(password) || password != repassword)
                {
                    return false;
                }
            }
            else
            {
                
                if (!string.IsNullOrEmpty(password) || !string.IsNullOrEmpty(repassword))
                {
                    if (password != repassword || string.IsNullOrWhiteSpace(password))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool DeleteUserData(int id)
        {
            string deleteCartQry = "Delete from cart where user_id = @id";
            string deleteUserQry = "Delete from users where id = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmdCart = new SqlCommand(deleteCartQry, con, transaction))
                        {
                            cmdCart.Parameters.AddWithValue("@id", id);
                            cmdCart.ExecuteNonQuery();
                        }

                        using (SqlCommand cmdUser = new SqlCommand(deleteUserQry, con, transaction))
                        {
                            cmdUser.Parameters.AddWithValue("@id", id);
                            int rowsAffected = cmdUser.ExecuteNonQuery();
                            transaction.Commit();
                            return rowsAffected > 0;
                        }
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static bool ValidateLogin(string username, string password)
        {
            string qry = @"Select count(*) from users where username = @username and password = @password";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    con.Open();
                    int userCount = (int)cmd.ExecuteScalar();
                    return userCount > 0;
                }
            }
        }

        public static int getUserID(string username)
        {
            string qry = "Select id from users where username = @username";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int userId))
                    {
                        return userId;
                    }
                    else
                    {
                        // Kullanıcı bulunamazsa -1 döndürülebilir veya uygun başka bir değeri seçebilirsiniz
                        return -1;
                    }
                }
            }
        }

        public static string getUsername(int userID)
        {
            string qry = "Select username from users where id = @userID";
            string username = string.Empty;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            username = reader["username"].ToString();
                        }
                    }
                }
            }

            return username;
        }

        // PRODUCTS

        public static DataTable LoadProductsData(string searchTerm)
        {
            string qry = @"Select id, name as Name, price as Price from products where name like @searchTerm order by id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public static bool SaveProductData(int id, string name, decimal price)
        {
            string qry;
            bool isUpdate = id > 0;

            if (isUpdate)
            {
                qry = @"Update products set name = @name, price = @price where id = @id";
            }
            else
            {
                qry = @"Insert into products (name, price) values (@name, @price)";
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);

                    if (isUpdate)
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                    }

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public static bool DeleteProductData(int id)
        {
            string qry = "Delete from products where id = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public static DataTable GetProductData(int id)
        {
            string qry = @"Select id, name as Name, price as Price from products where id = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        // CART
        public static bool SaveCartData(int user_id, int product_id)
        {
            string qry = @"Insert into cart (user_id, product_id) values (@user_id, @product_id)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@product_id", product_id);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public static DataTable GetUserCart(int userId)
        {
            string qry = @"Select id, user_id, product_id from cart where user_id = @userId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public static bool DeleteCartItem(int cartId)
        {
            string qry = "Delete from cart where id = @cartId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@cartId", cartId);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        // CART PAYMENT and ORDERS
        public static bool SaveOrderData(int user_id, List<int> product_id, decimal price)
        {
            string qry = @"INSERT INTO orders (user_id, products_id, price) VALUES (@user_id, @products_id, @price)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    string productIds = string.Join(",", product_id);

                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@products_id", productIds);
                    cmd.Parameters.AddWithValue("@price", price);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public static void ClearCart(int user_id)
        {
            string qry = @"DELETE FROM cart WHERE user_id = @user_id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@user_id", user_id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable LoadOrdersData(string searchTerm)
        {
            string qry = @"Select id, user_id, price from orders where user_id like @searchTerm order by id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
