using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace goldberg_MIS4200.Models
{
    public class Organization
    {
        public int organizationId { get; set; }
        [Display (Name ="Name of Organization")]
        [Required]
        [StringLength(40)]
        public string orgName { get; set; }
        [Display (Name = "Major Associated with the Organization")]
        [Required]
        public string orgMajorAssociated { get; set; }
    }
}