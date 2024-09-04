using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class ParentRepository
    {
        //private string connectionString = "your_connection_string_here";

        public void AddParent(Parents parent)
        {
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("INSERT INTO Parent (Name, ContactNumber) VALUES (@Name, @ContactNumber)", connection);
            //    command.Parameters.AddWithValue("@Name", parent.Name);
            //    command.Parameters.AddWithValue("@ContactNumber", parent.ContactNumber);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //}
        }

        public List<Parents> GetAllParents()
        {
            List<Parents> parents = new List<Parents>();
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("SELECT * FROM Parent", connection);
            //    connection.Open();
            //    using (var reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            parents.Add(new Parents
            //            {
            //                ParentId = (int)reader["ParentId"],
            //                Name = reader["Name"].ToString(),
            //                ContactNumber = reader["ContactNumber"].ToString()
            //            });
            //        }
            //    }
            //}
            return parents;
        }
    }
}
