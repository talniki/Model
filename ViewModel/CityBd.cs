using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CityBd :BaseDb
    {
        protected override Base CreateModel(Base entity)
        {
            City c = entity as City;
            c.CityName = reader["CityName"].ToString();
            return base.CreateModel(entity);
        }
        public CityList SelectAll()
        {
            command.CommandText = $"SELECT * FROM CityTBL";
            CityList cList = new CityList(base.Select());
            return cList;
        }

        protected override Base NewEntity()
        {
            return new City();
        }
    }
}
