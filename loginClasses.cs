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
        public int UserID {  get; set; }
        public string name { get; set; }
        public string lastname { get; set; }

        public string username { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string tel_number { get; set; }
        public string gender { get; set; }
        public string news { get; set; }

        static string login_dt = ConfigurationManager.ConnectionStrings["login_database"].ConnectionString;

        public bool Insert(loginClasses c)
        {
            bool isSuccess = false;

            SqlConnection sqlConnection = new SqlConnection(login_dt);
            try
            {
                string sql = "INSERT INTO login_table(name, lastname, username, mail, password, tel_number, gender, news) VALUES (@name, @lastname, @username, @mail, @password, @tel_number, @gender, @news)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnection);

                cmd.Parameters.AddWithValue("@name", c.name);
                cmd.Parameters.AddWithValue("@lastname", c.lastname);
                cmd.Parameters.AddWithValue("@username", c.username);
                cmd.Parameters.AddWithValue("@mail", c.mail);
                cmd.Parameters.AddWithValue("@password", c.password);
                cmd.Parameters.AddWithValue("@tel_number", c.tel_number);
                cmd.Parameters.AddWithValue("@gender", c.gender);
                cmd.Parameters.AddWithValue("@news", c.news);

                sqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();

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

            }
            finally
            {
                sqlConnection.Close();
            }
            return isSuccess;
        }
    }
}
