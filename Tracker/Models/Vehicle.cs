using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Structure.Models
{
    public class Vehicle
    {
        public int year { get; set; }
        public String make { get; set; }
        public String model { get; set; }
        public String style { get; set; }
        public String color { get; set; }
        public String vin { get; set; }
        public String licenseNum { get; set; }
        public String state { get; set; }
        public String odometer { get; set; }
        public Boolean keys { get; set; }
        public String location { get; set; }
        public String engineType { get; set; }
        public String tireSize { get; set; }
        public String goodUnitNum { get; set; }
        public String badUnitNum { get; set; }
        public Boolean loaded { get; set; }
        public Boolean trialer { get; set; }
        public Boolean dotHold { get; set; }
        public String trailerHeight { get; set; }
        public String trialerWeight { get; set; }
        public String trailerWidth { get; set; }
        public String trialerNum { get; set; }
    }   
}
