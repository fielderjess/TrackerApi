using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Structure.Models
{
    public class Call
    {
        public int callNum { get; set; }
        public String rqedBy { get; set; }
        public int priority { get; set; }
        public String phone { get; set; }
        public String ext { get; set; }
        public String caller { get; set; }
        public String ownerPhone { get; set; }
        public String ownerExt { get; set; }
        public String owner { get; set; }
        public Billing bill { get; set; }
        public Tow tow { get; set; }
        public List<String> comments { get; set; }
        public List<Vehicle> vehicles { get; set; }
        public List<String> remarks { get; set; }
    }
}
