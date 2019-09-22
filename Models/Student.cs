using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goldberg_MIS4200.Models
{
    public class Student
    {
        public int studentId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get
            {
                return lastName + "," + firstName;
            }        
        }
        public string studentMajor { get; set; }
        public ICollection<Member> Member { get; set; }
        public int schoolId { get; set; }
    }
}