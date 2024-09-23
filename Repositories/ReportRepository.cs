using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class ReportRepository
    {
        public List<AttendanceRecord> GetAttendanceReport(int studentId, DateTime startDate, DateTime endDate)
        {
            List<AttendanceRecord> report = new List<AttendanceRecord>();

            using (SqlConnection conn = new SqlConnection("connectionString"))
            {
                conn.Open();

                string reportQuery = @"
            SELECT s.StudentName, a.AttendanceDate, a.Status
            FROM Attendance a
            JOIN Students s ON a.StudentId = s.StudentId
            WHERE a.AttendanceDate BETWEEN @StartDate AND @EndDate
            AND s.StudentId = @StudentId";

                SqlCommand cmd = new SqlCommand(reportQuery, conn);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        report.Add(new AttendanceRecord
                        {
                            StudentName = reader.GetString(0),
                            AttendanceDate = reader.GetDateTime(1),
                            Status = reader.GetString(2)
                        });
                    }
                }
            }

            return report;
        }
        public List<GradeRecord> GetGradeReport(int studentId, string academicYear)
        {
            List<GradeRecord> report = new List<GradeRecord>();

            using (SqlConnection conn = new SqlConnection("connectionString"))
            {
                conn.Open();

                string reportQuery = @"
            SELECT s.StudentName, sub.SubjectName, g.Grade, g.AcademicYear
            FROM Grades g
            JOIN Students s ON g.StudentId = s.StudentId
            JOIN Subjects sub ON g.SubjectId = sub.SubjectId
            WHERE g.StudentId = @StudentId
            AND g.AcademicYear = @AcademicYear";

                SqlCommand cmd = new SqlCommand(reportQuery, conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@AcademicYear", academicYear);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        report.Add(new GradeRecord
                        {
                            StudentName = reader.GetString(0),
                            SubjectName = reader.GetString(1),
                            Grade = reader.GetDecimal(2),
                            AcademicYear = reader.GetString(3)
                        });
                    }
                }
            }

            return report;
        }

    }
}
