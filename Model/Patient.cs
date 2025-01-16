using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    public class Patient:Person
    {
        public string Password { get; set; }
        public string Mail { get; set; }
        public string PhoneNum { get; set; }
        public City city { get; set; }

        public override string ToString()
        {
            return "Fname: "+ this.Fname  +" , "+ "pass: " +Password + " , " + "mail: " + Mail + " , " +"phonenum:  " + PhoneNum + " , " +"city: "+ city.CityName;
        }
    }
}
