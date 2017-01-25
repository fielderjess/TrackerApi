using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Structure.Models
{
    public class Dispatch
    {
        public int callNum { get; set; }
        public int priority { get; set; }
        public String reqdBy { get; set; }
        public String stage { get; set; }
        public String driver { get; set; }
        public String truck { get; set; }
        public String zone { get; set; }
        public String location { get; set; }
        public String reason { get; set; }
        public DateTime time { get; set; }
        public String status { get; set; }
        public String destination { get; set; }
        public String[] remarks { get; set; }
    }
}
