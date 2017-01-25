using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Structure.Models
{
    public class Tow
    {
        public String location { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String zipcode { get; set; }
        public String landmark { get; set; }
        public String destination { get; set; }
        public String destCity { get; set; }
        public String destState { get; set; }
        public String destZipcode { get; set; }
        public String destLandmark { get; set; }
        public String impound { get; set; }
        public String lot { get; set; }
        public String reason { get; set; }
        public String towType { get; set; }
        public String  eta { get; set; }
        public String truckType { get; set; }
        public String locationZone { get; set; }
        public String destinationZone { get; set; }
        public DateTime scheduledDate { get; set; }
        public DateTime Time { get; set; }
        public String status { get; set; }

    }
}
