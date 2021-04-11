using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchBoardA00225332.Models
{
    public class JobPosting
    {
        public int ID { get; set; }
        public string Company { get; set; }

        [StringLength(40000)]
        public string Description { get; set; }
        public string Salary { get; set; }
    }
}
