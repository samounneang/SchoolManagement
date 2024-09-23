using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class SubjectRepository:BaseRepository
    {

        public void AddSubject(string subjectName, int classId, int teacherId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Subjects (SubjectName, ClassId, TeacherId) VALUES (@SubjectName, @ClassId, @TeacherId)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SubjectName", subjectName);
                cmd.Parameters.AddWithValue("@ClassId", classId);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);
                cmd.ExecuteNonQuery();
            }
        }
        public List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Subject", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            SubjectId = (int)reader["SubjectId"],
                            SubjectName = reader["SubjectName"].ToString(),
                            Credits = (int)reader["Credits"]
                        });
                    }
                }
            }
            return subjects;
        }
        public void UpdateSubject(int subjectId, string subjectName, int classId, int teacherId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Subjects SET SubjectName = @SubjectName, ClassId = @ClassId, TeacherId = @TeacherId WHERE SubjectId = @SubjectId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SubjectName", subjectName);
                cmd.Parameters.AddWithValue("@ClassId", classId);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);
                cmd.Parameters.AddWithValue("@SubjectId", subjectId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSubject(int subjectId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Subjects WHERE SubjectId = @SubjectId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SubjectId", subjectId);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
