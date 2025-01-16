using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ProffDb : BaseDb
    {
        static private ProffList list = new ProffList();

        public static Proff SelectById(int id)
        {
            ProffDb db = new ProffDb();
            list = db.SelectAll();

            Proff D = list.Find(item => item.Id == id);
            return D;
        }
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

        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Proff c = entity as Proff;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM ProffTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }

        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Proff c = entity as Proff;
            if (c != null)
            {
                string sqlStr = $"insert into ProffTBL (ProffName) values (@ProffName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@ProffName", c.ProffName));
            }
        }

        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Proff c = entity as Proff;
            if (c != null)
            {
                string sqlstr = $"Update ProffTBL " +
                    $"SET ProffName=@ProffName " +
                    $"WHERE id=@id ";
                command.CommandText = sqlstr;
                command.Parameters.Add(new OleDbParameter("@ProffName", c.ProffName));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
