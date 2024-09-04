using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    internal class Result
    {
        public int ResultId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public decimal Score { get; set; }
    }
}
