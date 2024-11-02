using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class QueueList:List<CQueue>
    {
        public QueueList() { }

        public QueueList(IEnumerable<CQueue> list) : base(list) { }

        public QueueList(IEnumerable<Base> list) : base(list.Cast<CQueue>().ToList()) { }
    }
}
