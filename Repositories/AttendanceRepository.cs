using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class AttendanceRepository:BaseRepository
    {
        //private string connectionString = "your_connection_string_here";

        public static void AddAttendance(Attendance attendance)
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
        public static void RecordAttendance(int studentId, DateTime date, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string insertAttendanceQuery = "INSERT INTO Attendance (StudentId, AttendanceDate, Status) VALUES (@StudentId, @AttendanceDate, @Status)";
                SqlCommand cmd = new SqlCommand(insertAttendanceQuery, conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@AttendanceDate", date);
                cmd.Parameters.AddWithValue("@Status", status);

                cmd.ExecuteNonQuery();
            }
        }
        public static void UpdateAttendance(int attendanceId, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string updateAttendanceQuery = "UPDATE Attendance SET Status = @Status WHERE AttendanceId = @AttendanceId";
                SqlCommand cmd = new SqlCommand(updateAttendanceQuery, conn);
                cmd.Parameters.AddWithValue("@AttendanceId", attendanceId);
                cmd.Parameters.AddWithValue("@Status", status);

                cmd.ExecuteNonQuery();
            }
        }
                
        public static List<AttendanceRecord> GetAttendanceByStudent(int studentId)
        {
            List<AttendanceRecord> attendanceRecords = new List<AttendanceRecord>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string attendanceQuery = "SELECT AttendanceId, AttendanceDate, Status FROM Attendance WHERE StudentId = @StudentId";
                SqlCommand cmd = new SqlCommand(attendanceQuery, conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        attendanceRecords.Add(new AttendanceRecord
                        {
                            AttendanceId = reader.GetInt32(0),
                            AttendanceDate = reader.GetDateTime(1),
                            Status = reader.GetString(2)
                        });
                    }
                }
            }

            return attendanceRecords;
        }
                
        public static List<Attendance> GetAllAttendance()
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