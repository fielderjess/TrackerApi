using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Structure.Models
{
    public class PoliceCall
    {
        public int callNum { get; set; }
        public String rqedBy { get; set; }
        public String location { get; set; }
        public String make { get; set; }
        public String color { get; set; }
        public List<String> remarks { get; set; }
        public String towType { get; set; }
        public String reason { get; set; }
        public String operatorNum { get; set; }
        public String unitNum { get; set; }
        public String incidentNum { get; set; }
    }
}
