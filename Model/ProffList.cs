using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProffList:List<Proff>
    {
        public ProffList() { }

        public ProffList(IEnumerable<Proff> list) : base(list) { }

        public ProffList(IEnumerable<Base> list) : base(list.Cast<Proff>().ToList()) { }
    }
}
