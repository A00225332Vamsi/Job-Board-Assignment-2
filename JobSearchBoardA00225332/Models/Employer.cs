using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchBoardA00225332.Models
{
    public class Employer
    {
        public int ID { get; set; }
        [StringLength(40000)]
        public string CompanyName { get; set; }
        [StringLength(40000)]
        public string YearEstablished { get; set; }
        [StringLength(40000)]
        public string Biography { get; set; }
    }
}
