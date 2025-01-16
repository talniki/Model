using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Doctor:Person
    {
        public Proff specialization { get; set; }
        public override string ToString()
        {
            return "proff: " + specialization.ProffName+", Fname:"+this.Fname;
        }
    }
}
