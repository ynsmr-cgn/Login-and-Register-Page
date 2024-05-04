using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage
{
    internal class loginClasses
    {
        // Properties for user information
        public int UserID {  get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string tel_number { get; set; }
        public string gender { get; set; }
        public string news { get; set; }

        // Connection string to the database
        static string login_dt = ConfigurationManager.ConnectionStrings["login_database"].ConnectionString;

        // Method to insert user data into the database
        public bool Insert(loginClasses c)
        {
            bool isSuccess = false;

            // Establish connection
            SqlConnection sqlConnection = new SqlConnection(login_dt);
            try
            {
                // SQL command to insert data
                string sql = "INSERT INTO login_table(name, lastname, username, mail, password, tel_number, gender, news) VALUES (@name, @lastname, @username, @mail, @password, @tel_number, @gender, @news)";

                // Create SQL command object
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);

                // Set parameters for SQL command
                cmd.Parameters.AddWithValue("@name", c.name);
                cmd.Parameters.AddWithValue("@lastname", c.lastname);
                cmd.Parameters.AddWithValue("@username", c.username);
                cmd.Parameters.AddWithValue("@mail", c.mail);
                cmd.Parameters.AddWithValue("@password", c.password);
                cmd.Parameters.AddWithValue("@tel_number", c.tel_number);
                cmd.Parameters.AddWithValue("@gender", c.gender);
                cmd.Parameters.AddWithValue("@news", c.news);

                // Open connection
                sqlConnection.Open();
                
                // Execute command
                int rows = cmd.ExecuteNonQuery();

                // Check if insertion was successful
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
            }
            finally
            {
                // Close connection
                sqlConnection.Close();
            }
            return isSuccess;
        }
    }
}
