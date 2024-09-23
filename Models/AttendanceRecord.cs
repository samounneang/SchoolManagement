using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    internal class AttendanceRecord
    {
        public int AttendanceId { get; set; }
        public string StudentName { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string Status { get; set; }
    }
}
