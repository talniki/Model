using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DoctorList:List<Doctor>
    {
        public DoctorList() { }

        public DoctorList(IEnumerable<Doctor> list) : base(list) { }

        public DoctorList(IEnumerable<Base> list) : base(list.Cast<Doctor>().ToList()) { }
    }
}
