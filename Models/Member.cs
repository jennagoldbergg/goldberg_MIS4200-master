using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goldberg_MIS4200.Models
{
    public class Member
    {
        public int memberId { get; set; }
        public string memberDues { get; set; }
        public string memberRole { get; set; }
        public int studentId { get; set; }
        public int organizationId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Organization Organization { get; set; }
    }   
}