using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CityDb :BaseDb
    {
        static private CityList list = new CityList();
        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            City c = entity as City;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM CityTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
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

        public static City SelectById(int id)
        {
            CityDb db = new CityDb();
            list = db.SelectAll();

            City C = list.Find(item => item.Id == id);
            return C;
        }
        protected override Base NewEntity()
        {
            return new City();
        }

        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            City c = entity as City;
            if (c != null)
            {
                string sqlStr = $"insert into CityTBL (CityName) values (@CityName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@CityName", c.CityName));
            }
        }

        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            City c = entity as City;
            if (c != null)
            {
                string sqlstr = $"Update CityTBL " +
                    $"SET CityName=@CityName " +
                    $"WHERE id=@id";
                command.CommandText = sqlstr;
                command.Parameters.Add(new OleDbParameter("@CityName", c.CityName));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
