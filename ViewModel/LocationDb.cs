using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class LocationDb:BaseDb
    {
        static private LocationList list = new LocationList();

        public static Location SelectById(int id)
        {
            LocationDb db = new LocationDb();
            list = db.SelectAll();

            Location l = list.Find(item => item.Id == id);
            return l;
        }
        public LocationList SelectAll()
        {
            command.CommandText = $"SELECT * FROM LocationTBL";
            LocationList locationList = new LocationList(base.Select());
            return locationList;
        }
        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Location c = entity as Location;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM LocationTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }

        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Location c = entity as Location;
            if (c != null)
            {
                string sqlStr = $"Insert INTO LocationTBL (LocName,CityName,Street,BuildingNum,Parking)" +
                    " VALUES (@LocName, @CityName, @Street, @BuildingNum, @Parking) ";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@LocName", c.LocName));
                command.Parameters.Add(new OleDbParameter("@CityName", c.CityName.Id));
                command.Parameters.Add(new OleDbParameter("@Street", c.Street));
                command.Parameters.Add(new OleDbParameter("@BuildingNum", c.BuildingNum));
                command.Parameters.Add(new OleDbParameter("@Parking", c.Parking));
            }
        }

        protected override Base CreateModel(Base entity)
        {
            Location loc = entity as Location;
            loc.LocName = reader["LocName"].ToString();
            loc.Street = reader["Street"].ToString();
            loc.BuildingNum = int.Parse(reader["BuildingNum"].ToString());
            loc.CityName = CityDb.SelectById(int.Parse(reader["CityName"].ToString()));
            loc.Parking = bool.Parse(reader["Parking"].ToString());
            base.CreateModel(entity);
            return loc;
        }

        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Location c = entity as Location;
            if (c != null)
            {
                string sqlstr = $"Update LocationTBL " +
                    $"SET LocName=@LocName, CityName=@CityName, Street=@Street, BuildingNum=@BuildingNum, Parking=@Parking " +
                    $"WHERE id=@id";
                command.CommandText = sqlstr;
                command.Parameters.Add(new OleDbParameter("@LocName", c.LocName));
                command.Parameters.Add(new OleDbParameter("@CityName", c.CityName.Id));
                command.Parameters.Add(new OleDbParameter("@Street", c.Street));
                command.Parameters.Add(new OleDbParameter("@BuildingNum", c.BuildingNum));
                command.Parameters.Add(new OleDbParameter("@Parking", c.Parking));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }

        protected override Base NewEntity()
        {
            return new Location();
        }
    }
}
