using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class ClassRepository:BaseRepository
    {

        public void AddClass(Class cls)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("INSERT INTO Class (ClassName) VALUES (@ClassName)", connection);
                command.Parameters.AddWithValue("@ClassName", cls.ClassName);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void UpdateClass(int classId, string className, string classRoom, int teacherId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Classes SET ClassName = @ClassName, ClassRoom = @ClassRoom, TeacherId = @TeacherId WHERE ClassId = @ClassId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClassName", className);
                cmd.Parameters.AddWithValue("@ClassRoom", classRoom);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);
                cmd.Parameters.AddWithValue("@ClassId", classId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Class> GetAllClasses()
        {
            List<Class> classes = new List<Class>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Class", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        classes.Add(new Class
                        {
                            ClassId = (int)reader["ClassId"],
                            ClassName = reader["ClassName"].ToString()
                        });
                    }
                }
            }
            return classes;
        }
    }
}
