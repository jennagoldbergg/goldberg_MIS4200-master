using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace goldberg_MIS4200.Models
{
    public class Organization
    {
        public int organizationId { get; set; }
        public string orgName { get; set; }
        public string orgMajorAssociated { get; set; }
    }
}