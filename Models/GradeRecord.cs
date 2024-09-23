using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    internal class GradeRecord
    {
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public decimal Grade { get; set; }
        public string AcademicYear { get; set; }
    }
}
