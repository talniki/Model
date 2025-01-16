using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class QueueDb : BaseDb
    {
        static private QueueList list = new QueueList();

        public static CQueue SelectById(int id)
        {
            QueueDb db = new QueueDb();
            list = db.SelectAll();

            CQueue D = list.Find(item => item.Id == id);
            return D;
        }
        protected override Base CreateModel(Base entity)
        {
            CQueue Q = entity as CQueue;
            Q.QueueDate = (DateTime)(reader["QueueDate"]);
            Q.IDdoctor = DoctorDb.SelectById(int.Parse(reader["IDdoctor"].ToString()));
            Q.IDperson = PersonDb.SelectById(int.Parse(reader["IDPerson"].ToString()));
            Q.location = LocationDb.SelectById(int.Parse(reader["Location"].ToString()));
            return base.CreateModel(entity);
        }
        public QueueList SelectAll()
        {
            command.CommandText = $"SELECT * FROM QueueTBL";
            QueueList qList = new QueueList(base.Select());
            return qList;
        }

        protected override Base NewEntity()
        {
            return new CQueue();
        }

        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            CQueue c = entity as CQueue;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM QueueTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }

        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            CQueue c = entity as CQueue;
            if (c != null)
            {
                string sqlStr = $"Insert INTO QueueTBL (IDdoctor,IDPerson,QueueDate,Location)" +
                    "VALUES (@IDdoctor, @IDPerson, @QueueDate, @Location)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@IDdoctor", c.IDdoctor.Id));
                command.Parameters.Add(new OleDbParameter("@IDPerson", c.IDperson.Id));
                command.Parameters.Add(new OleDbParameter("@QueueDate", c.QueueDate));
                command.Parameters.Add(new OleDbParameter("@Location", c.location.Id));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }

        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            CQueue c = entity as CQueue;
            if (c != null)
            {
                string sqlstr = $"Update QueueTBL " +
                    $"SET IDdoctor=@IDdoctor, IDPerson=@IDPerson, QueueDate=@QueueDate, Location=@Location " +
                    $"WHERE id=@id ";
                command.CommandText = sqlstr;
                command.Parameters.Add(new OleDbParameter("@IDdoctor", c.IDdoctor.Id));
                command.Parameters.Add(new OleDbParameter("@IDPerson", c.IDperson.Id));
                command.Parameters.Add(new OleDbParameter("@QueueDate", c.QueueDate));
                command.Parameters.Add(new OleDbParameter("@Location", c.location.Id));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
