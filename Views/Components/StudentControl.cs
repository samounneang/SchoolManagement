using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Views.Components
{
    public partial class StudentControl : UserControl
    {
        public StudentControl()
        {
            InitializeComponent();
            LoadDataGrid();
        }
        private BindingSource bindingSource;


        List<Student> students = new List<Student>();
        private void LoadDataGrid()
        {
            students = [
                new Student { No = 1, StudentID = "001", Name = "Long chong", Gender = "Male", Contact = "09865434" },
                new Student { No = 2, StudentID = "002", Name = "Lok Lak", Gender = "Male", Contact = "07890877" },
                new Student { No = 3, StudentID = "003", Name = "Banh kanh", Gender = "Male", Contact = "05468493" },
                new Student { No = 4, StudentID = "004", Name = "Albert Joch", Gender = "Male", Contact = "01258493" }
                ];
          
        }

        private void tabStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabStudent.SelectedTab == tabDisplay)
            //    LoadDataGrid();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {

            Student student = new Student();//{ StudentID = txtFirstName.Text, Name = txtLastName.Text, Gender = cboGender.Text, Contact = txtAddress.Text, No = 1 };
            students.Add(student);

            bindingSource = new BindingSource();
            bindingSource.DataSource = students;

            // Bind BindingSource to DataGridView
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            // Assume textboxes to enter search criteria
            //int? studentId = int.TryParse(txtSearchStudentId.Text, out int id) ? id : (int?)null;
            string studentId = "txtSearchStudentId.Text";
            string studentName = "txtSearchStudentId.Text";
            //string grade = gradeTextBox.Text;

            SearchStudents(studentId, studentName);
        }

        public void SearchStudents(string? studentId = null, string studentName = null)
        {
            // Lambda expression with multiple conditions
            var filteredStudents = students.Where(s =>
                (s.StudentID == studentId)// &&
                //(string.IsNullOrEmpty(studentName) || s.Name.Contains(studentName, StringComparison.OrdinalIgnoreCase))
                //string.IsNullOrEmpty(grade) // || s.Grade.Equals(grade, StringComparison.OrdinalIgnoreCase))
            ).ToList();

            if (filteredStudents.Any())
            {
                // If found, display filtered students
                bindingSource.DataSource = filteredStudents;

            }

            else
            {
                // If not found, show message or clear the DataGridView
                MessageBox.Show("No students found matching the search criteria.");
                //bindingSource.DataSource = new List<Student>(); // Clear DataGridView
            }

        }
    }

    public class Student
    {
        public int  No { get; set; }
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        
    }
}
