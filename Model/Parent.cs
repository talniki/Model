using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Parent:Base
    {
        public Patient IdParent { get; set; }
        public Person IdChild { get; set; }

        public override string ToString()
        {
            return IdParent.Id + " , " + IdChild.Id ;
        }
    }
}
