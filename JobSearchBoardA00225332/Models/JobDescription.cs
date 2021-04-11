using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchBoardA00225332.Models
{
    public class Jobdescription
    {
        public int ID { get; set; }

        public string JobName { get; set; }

        public string Salary { get; set; }

        [StringLength(4000)]
        public string JobSpecifications { get; set; }

        public string jobRequirement { get; set; }

        public string ProjectDuration { get; set; }
    }
}
