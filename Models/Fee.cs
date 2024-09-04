using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    internal class Fee
    {
        public int FeeId { get; set; }
        public int StudentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DatePaid { get; set; }
    }
}
