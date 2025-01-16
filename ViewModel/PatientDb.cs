using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PatientDb:PersonDb
    {
        static private PatientList list = new PatientList();

        public static Patient SelectById(int id)
        {
            PatientDb db = new PatientDb();
            list = db.SelectAll();

            Patient p = list.Find(item => item.Id == id);
            return p;
        }
        public PatientList SelectAll()
        {
            command.CommandText = $"SELECT PersonTBL.id, PersonTBL.Fname, PersonTBL.Lname, PersonTBL.IDnum, PersonTBL.BirthDate, PersonTBL.Gender, PatientTBL.[Password], PatientTBL.Mail, PatientTBL.PhoneNum, PatientTBL.City FROM (PatientTBL INNER JOIN PersonTBL ON PatientTBL.id = PersonTBL.id)";
            PatientList patientList = new PatientList(base.Select());
            return patientList;
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
            Patient c = entity as Patient;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM PatientTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override Base CreateModel(Base entity)
        {
            Patient prs = entity as Patient;
            prs.Password = reader["Password"].ToString();
            prs.Mail = reader["Mail"].ToString();
            prs.PhoneNum = reader["PhoneNum"].ToString();
            prs.city = CityDb.SelectById(int.Parse(reader["City"].ToString()));
            return base.CreateModel(entity);
        }
        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Patient c = entity as Patient;
            if (c != null)
            {
                string sqlStr = $"Insert INTO PatientTBL (id, [Password],Mail,PhoneNum, City) " +
                    "VALUES (@id, @Password, @Mail, @PhoneNum, @City)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
                command.Parameters.Add(new OleDbParameter("@Password", c.Password));
                command.Parameters.Add(new OleDbParameter("@Mail", c.Mail));
                command.Parameters.Add(new OleDbParameter("@PhoneNum", c.PhoneNum));
                command.Parameters.Add(new OleDbParameter("@City", c.city.Id));
            }
        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Patient c = entity as Patient;
            if (c != null)
            {
                string sqlstr = $"Update PatientTBL " +
                    $"SET [Password]=@Password, Mail=@Mail, PhoneNum=@PhoneNum, City=@City " +
                    $"WHERE id=@id ";
                command.CommandText = sqlstr;
                command.Parameters.Add(new OleDbParameter("@Password", c.Password));
                command.Parameters.Add(new OleDbParameter("@Mail", c.Mail));
                command.Parameters.Add(new OleDbParameter("@PhoneNum", c.PhoneNum));
                command.Parameters.Add(new OleDbParameter("@City", c.city.Id));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
        protected override Base NewEntity()
        {
            return new Patient();
        }
    }
}
