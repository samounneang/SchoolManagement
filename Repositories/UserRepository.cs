using Microsoft.VisualBasic.ApplicationServices;
using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class UserRepository
    {
        //private string connectionString = "your_connection_string_here";

        public void AddUser(Users user)
        {
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("INSERT INTO User (Username, Password, Role) VALUES (@Username, @Password, @Role)", connection);
            //    command.Parameters.AddWithValue("@Username", user.Username);
            //    command.Parameters.AddWithValue("@Password", user.Password);
            //    command.Parameters.AddWithValue("@Role", user.Role);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //}
        }

        public List<Users> GetAllUsers()
        {
            List<Users> users = new List<Users>();
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("SELECT * FROM User", connection);
            //    connection.Open();
            //    using (var reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            users.Add(new Users
            //            {
            //                UserId = (int)reader["UserId"],
            //                Username = reader["Username"].ToString(),
            //                Password = reader["Password"].ToString(),
            //                Role = reader["Role"].ToString()
            //            });
            //        }
            //    }
            //}
            return users;
        }
    }
}
