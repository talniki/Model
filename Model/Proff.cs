﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Proff:Base
    {
        public string ProffName { get; set; }

        public override string ToString()
        {
            return ProffName;
        }
    }
}
