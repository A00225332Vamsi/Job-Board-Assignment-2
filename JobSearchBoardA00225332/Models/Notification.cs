using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchBoardA00225332.Models
{
    public class Notification
    {
        public int ID { get; set; }
        public string DateSent { get; set; }
        public string User { get; set; }
        public string Type { get; set; }
    }
}
