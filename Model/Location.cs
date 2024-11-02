using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Location:Base
    {
        public string LocName { get; set; }
        public City CityName { get; set; }
        public string Street { get; set; }
        public int BuildingNum { get; set; }
        public string Parking { get; set; }
    }
}
