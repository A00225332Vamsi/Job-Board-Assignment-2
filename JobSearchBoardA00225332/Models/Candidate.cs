using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchBoardA00225332.Models
{
    public class Candidate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [StringLength(40000)]
        public string PhoneNumber { get; set; }
    }
}
