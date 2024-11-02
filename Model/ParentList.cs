using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ParentList:List<Parent>
    {
        public ParentList() { }

        public ParentList(IEnumerable<Parent> list) : base(list) { }

        public ParentList(IEnumerable<Base> list) : base(list.Cast<Parent>().ToList()) { }
    }
}
