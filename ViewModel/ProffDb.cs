using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ProffDb : BaseDb
    {
        protected override Base CreateModel(Base entity)
        {
            Proff p = entity as Proff;
            p.ProffName = reader["ProffName"].ToString();
            return base.CreateModel(entity);
        }
        public ProffList SelectAll()
        {
            command.CommandText = $"SELECT * FROM ProffTBL";
            ProffList pList = new ProffList(base.Select());
            return pList;
        }

        protected override Base NewEntity()
        {
            return new Proff();
        }
    }
}
