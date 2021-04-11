using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchBoardA00225332.Models
{
    public class SavedSearch
    {
        public int ID { get; set; }
        public string User { get; set; }
        [StringLength(40000)]
        public string SearchTerms { get; set; }
    }
}
