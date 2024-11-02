using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LocationList:List<Location>
    {
        public LocationList() { }

        public LocationList(IEnumerable<Location> list) : base(list) { }

        public LocationList(IEnumerable<Base> list) : base(list.Cast<Location>().ToList()) { }
    }
}
