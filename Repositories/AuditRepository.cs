using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class AuditRepository:BaseRepository
    {
        //string connectionstring = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ToString();
        public void AddAuditLog(string action, string username, DateTime timestamp, string details)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO AuditLog (Action, Username, Timestamp, Details) VALUES (@Action, @Username, @Timestamp, @Details)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Action", action);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Timestamp", timestamp);
                cmd.Parameters.AddWithValue("@Details", details);
                cmd.ExecuteNonQuery();
            }
        }
    }
}