using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace goldberg_MIS4200.Models
{
    public class Student
    {
        public int studentId { get; set; }
        [Display (Name="First Name")]
        [Required(ErrorMessage ="Student first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display (Name ="Last Name")]
        [Required]
        [StringLength (20)]
        public string lastName { get; set; }
        [Display (Name ="Student's Major")]
        [Required]  
        public string studentMajor { get; set; }
        public string fullName { get
            {
                return lastName + ", " + firstName;
            }
                }
        public ICollection<Member> Member { get; set; }
        [Display (Name ="School ID Number")]
        [Required]
        public int schoolId { get; set; }
    }
}