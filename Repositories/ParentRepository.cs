using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class ParentRepository:BaseRepository
    {
        public void AddParent(string parentName, string phoneNumber, string address, int studentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Parents (ParentName, PhoneNumber, Address, StudentId) VALUES (@ParentName, @PhoneNumber, @Address, @StudentId)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ParentName", parentName);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Parents> GetAllParents()
        {
            List<Parents> parents = new List<Parents>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Parent", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        parents.Add(new Parents
                        {
                            ParentId = (int)reader["ParentId"],
                            Name = reader["Name"].ToString(),
                            ContactNumber = reader["ContactNumber"].ToString()
                        });
                    }
                }
            }
            return parents;
        }
        public void UpdateParent(int parentId, string parentName, string phoneNumber, string address)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Parents SET ParentName = @ParentName, PhoneNumber = @PhoneNumber, Address = @Address WHERE ParentId = @ParentId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ParentName", parentName);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@ParentId", parentId);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteParent(int parentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Parents WHERE ParentId = @ParentId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ParentId", parentId);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
