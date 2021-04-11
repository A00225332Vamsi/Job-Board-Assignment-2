using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchBoardA00225332.Models
{
    public class Resume
    {
        public int ID { get; set; }
        public string candidate { get; set; }
        [StringLength(40000)]
        public string Experience { get; set; }
        [StringLength(4000)]
        public string skills { get; set; }
    }
}
