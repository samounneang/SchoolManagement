﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Grade { get; set; }
        public string ParentContact { get; set; }
    }
}
