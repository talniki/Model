using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patient:Base
    {
        public string Password { get; set; }
        public string Mail { get; set; }
        public string mail { get; set; }
        public string PhoneNum { get; set; }
        public City city { get; set; }
    }
}
