using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class FeeRepository:BaseRepository
    {
        //private string connectionString = "your_connection_string_here";

        public void AddFee(Fee fee)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("INSERT INTO Fee (StudentId, Amount, DatePaid) VALUES (@StudentId, @Amount, @DatePaid)", connection);
                command.Parameters.AddWithValue("@StudentId", fee.StudentId);
                command.Parameters.AddWithValue("@Amount", fee.Amount);
                command.Parameters.AddWithValue("@DatePaid", fee.DatePaid);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Fee> GetAllFees()
        {
            List<Fee> fees = new List<Fee>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Fee", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fees.Add(new Fee
                        {
                            FeeId = (int)reader["FeeId"],
                            StudentId = (int)reader["StudentId"],
                            Amount = (decimal)reader["Amount"],
                            DatePaid = (DateTime)reader["DatePaid"]
                        });
                    }
                }
            }
            return fees;
        }
        public void UpdateFeeCharge(int feeId, decimal amount, DateTime dueDate, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE FeeCharges SET Amount = @Amount, DueDate = @DueDate, Status = @Status WHERE FeeId = @FeeId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@DueDate", dueDate);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@FeeId", feeId);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteFeeCharge(int feeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM FeeCharges WHERE FeeId = @FeeId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FeeId", feeId);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
