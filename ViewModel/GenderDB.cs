using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class GenderDb : BaseDb
    {
        static private GenderList genders = new GenderList();
        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Gender c = entity as Gender;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM GenderTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        public static Gender SelectById(int id)
        {
            GenderDb db = new GenderDb();
            genders = db.SelectAll();

            Gender g = genders.Find(item => item.Id == id);
            return g;
        }
        protected override Base CreateModel(Base entity)
        {
            Gender g = entity as Gender;
            g.GenderName = reader["GenderType"].ToString();
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

        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Gender c = entity as Gender;
            if (c != null)
            {
                string sqlStr = $"Insert into GenderTBL (GenderType) values (@GenderName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@GenderName", c.GenderName));
            }
        }

        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Gender c = entity as Gender;
            if (c != null)
            {
                string sqlstr = $"Update GenderTBL " +
                    $"SET GenderType=@GenderName " +
                    $"WHERE id=@id";
                command.CommandText = sqlstr;
                command.Parameters.Add(new OleDbParameter("@GenderName", c.GenderName));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
