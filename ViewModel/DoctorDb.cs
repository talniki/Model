using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class DoctorDb:PersonDb
    {
        static private DoctorList list = new DoctorList();

        public static Doctor SelectById(int id)
        {
            DoctorDb db = new DoctorDb();
            list = db.SelectAll();

            Doctor D = list.Find(item => item.Id == id);
            return D;
        }
        public DoctorList SelectAll()
        {
            command.CommandText = $"SELECT PersonTBL.id, PersonTBL.Fname, PersonTBL.Lname, PersonTBL.IDnum, PersonTBL.BirthDate, PersonTBL.Gender, DoctorTBL.specialization FROM (DoctorTBL INNER JOIN PersonTBL ON DoctorTBL.id = PersonTBL.id)";
            DoctorList docList = new DoctorList(base.Select());
            return docList;
        }

        protected override Base CreateModel(Base entity)
        {
            Doctor doct = entity as Doctor;
            doct.specialization = ProffDb.SelectById(int.Parse(reader["specialization"].ToString()));
            base.CreateModel(entity);
            return doct;
        }
        public override void Delete(Base entity)
        {
            Base reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
                deleted.Add(new ChangeEntity(base.CreateDeletedSQL, entity));
            }
        }
        public virtual void Insert(Base entity)
        {
            Base reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(base.CreateInsertSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertSQL, entity)); ;
            }
        }
        public virtual void Update(Base entity)
        {
            Base reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                updated.Add(new ChangeEntity(this.CreateUpdateSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdateSQL, entity));
            }
        }
        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Doctor c = entity as Doctor;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM DoctorTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Doctor c = entity as Doctor;
            if (c != null)
            {
                string sqlStr = $"Insert INTO DoctorTBL (id,specialization) " +
                    "VALUES (@id, @specialization)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
                command.Parameters.Add(new OleDbParameter("@specialization", c.specialization.Id));
            }
        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Doctor c = entity as Doctor;
            if (c != null)
            {
                string sqlstr = $"Update DoctorTBL " +
                    $"SET specialization=@specialization " +
                    $"WHERE id=@id";
                command.CommandText = sqlstr;
                command.Parameters.Add(new OleDbParameter("@specialization", c.specialization.Id));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
        protected override Base NewEntity()
        {
            return new Doctor();
        }
    }
}
