using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Parent:Base
    {
        public int Id { get; set; }
        public Patient IdParent { get; set; }
        public Person IdChild { get; set; }
    }
}
