using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    public class CQueue:Base
    {
        public Doctor IDdoctor { get; set; }
        public Person IDperson { get; set; }
        public DateTime QueueDate { get; set; }
        public Location location { get; set; }

        public override string ToString()
        {
            return IDdoctor.Id + " , " + IDperson.Id + " , " + QueueDate + " , " + location.LocName + " , " + location.CityName + " , " + location.Street + " , " + location.BuildingNum + " , " + location.Parking;
        }
    }
}
