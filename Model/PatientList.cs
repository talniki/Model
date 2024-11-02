using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PatientList:List<Patient>
    {
        public PatientList() { }

        public PatientList(IEnumerable<Patient> list) : base(list) { }

        public PatientList(IEnumerable<Base> list) : base(list.Cast<Patient>().ToList()) { }
    }
}
