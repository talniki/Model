﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class City:Base
    {
        public string CityName { get; set; }

        public override string ToString()
        {
            return CityName;
        }
    }
}
