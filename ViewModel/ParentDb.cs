using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ParentDb:BaseDb
    {
        static private ParentList list = new ParentList();

        public static Parent SelectById(int id)
        {
            ParentDb db = new ParentDb();
            list = db.SelectAll();

            Parent P = list.Find(item => item.Id == id);
            return P;
        }
        public ParentList SelectAll()
        {
            command.CommandText = $"SELECT * FROM ParentTBL";
            ParentList parentList = new ParentList(base.Select());
            return parentList;
        }

        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Parent c = entity as Parent;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM ParentTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }

        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Parent c = entity as Parent;
            if (c != null)
            {
                string sqlStr = $"Insert INTO ParentTBL (IdParent,IdChild) " +
                    "VALUES (@IdParent, @IdChild)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@IdParent", c.IdParent.Id));
                command.Parameters.Add(new OleDbParameter("@IdChild", c.IdChild.Id));
            }
        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Parent c = entity as Parent;
            if (c != null)
            {
                string sqlstr = $"Update ParentTBL " +
                    $"SET IDParent=@IDParent, IDChild=@IDChild " +
                    $"WHERE id=@id";
                command.CommandText = sqlstr;
                command.Parameters.Add(new OleDbParameter("@IDParent", c.IdParent.Id));
                command.Parameters.Add(new OleDbParameter("@IDChild", c.IdChild.Id));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }

        protected override Base CreateModel(Base entity)
        {
            Parent prnt = entity as Parent;
            prnt.IdParent = PatientDb.SelectById(int.Parse(reader["IDParent"].ToString()));
            prnt.IdChild = PersonDb.SelectById(int.Parse(reader["IDChild"].ToString()));
            return base.CreateModel(entity);
        }

        protected override Base NewEntity()
        {
            return new Parent();
        }
    }
}
