using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CQueue:Base
    {
        public string IDdoctor { get; set; }
        public string IDperson { get; set; }
        public DateTime QueueDate { get; set; }
        public string Location { get; set; }
    }
}
