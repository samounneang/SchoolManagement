using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class ClassRepository
    {
        //private string connectionString = "your_connection_string_here";

        public void AddClass(Class cls)
        {
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("INSERT INTO Class (ClassName) VALUES (@ClassName)", connection);
            //    command.Parameters.AddWithValue("@ClassName", cls.ClassName);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //}
        }

        public List<Class> GetAllClasses()
        {
            List<Class> classes = new List<Class>();
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("SELECT * FROM Class", connection);
            //    connection.Open();
            //    using (var reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            classes.Add(new Class
            //            {
            //                ClassId = (int)reader["ClassId"],
            //                ClassName = reader["ClassName"].ToString()
            //            });
            //        }
            //    }
            //}
            return classes;
        }
    }
}
