﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CityList:List<City>
    {
        public CityList() { }

        public CityList(IEnumerable<City> list) : base(list) { }

        public CityList(IEnumerable<Base> list) : base(list.Cast<City>().ToList()) { }
    }
}
