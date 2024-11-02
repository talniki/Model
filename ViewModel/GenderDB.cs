using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class GenderDB : BaseDb
    {
        protected override Base CreateModel(Base entity)
        {
            Gender g = entity as Gender;
            g.GenderName = reader["GenderName"].ToString();
            return base.CreateModel(entity);
        }
        public GenderList SelectAll()
        {
            command.CommandText = $"SELECT * FROM GenderTBL";
            GenderList gList = new GenderList(base.Select());
            return gList;
        }

        protected override Base NewEntity()
        {
            return new Gender();
        }
    }
}
