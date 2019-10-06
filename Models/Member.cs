using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace goldberg_MIS4200.Models
{
    public class Member
    {
        public int memberId { get; set; }
        [Display (Name ="Member's Dues")]
        [DataType(DataType.Currency)]
        public string memberDues { get; set; }
        [Display (Name ="Member's Role")]
        [Required]
        [StringLength(40)]
        public string memberRole { get; set; }
        [Display (Name ="Student's Name")]
        [Required]
        public int studentId { get; set; }
        [Display (Name ="Organization")]
        [Required]
        public int organizationId { get; set; }  
        public virtual Student Student { get; set; }
        public virtual Organization Organization { get; set; }
    }   
}