using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class AttendanceRepository
    {
        //private string connectionString = "your_connection_string_here";

        public void AddAttendance(Attendance attendance)
        {
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("INSERT INTO Attendance (StudentId, Date, IsPresent) VALUES (@StudentId, @Date, @IsPresent)", connection);
            //    command.Parameters.AddWithValue("@StudentId", attendance.StudentId);
            //    command.Parameters.AddWithValue("@Date", attendance.Date);
            //    command.Parameters.AddWithValue("@IsPresent", attendance.IsPresent);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //}
        }

        public List<Attendance> GetAllAttendance()
        {
            List<Attendance> attendances = new List<Attendance>();
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("SELECT * FROM Attendance", connection);
            //    connection.Open();
            //    using (var reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            attendances.Add(new Attendance
            //            {
            //                AttendanceId = (int)reader["AttendanceId"],
            //                StudentId = (int)reader["StudentId"],
            //                Date = (DateTime)reader["Date"],
            //                IsPresent = (bool)reader["IsPresent"]
            //            });
            //        }
            //    }
            //}
            return attendances;
        }
    }
}