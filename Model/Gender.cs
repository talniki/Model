﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Gender:Base
    {
        public string GenderName { get; set; }
        public override string ToString()
        {
            return GenderName;
        }
    }

}
