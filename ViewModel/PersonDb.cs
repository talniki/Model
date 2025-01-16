using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PersonDb :BaseDb
    {
        static private PersonList list = new PersonList();

        public static Person SelectById(int id)
        {
            PersonDb db = new PersonDb();
            list = db.SelectAll();

            Person p = list.Find(item => item.Id == id);
            return p;
        }
        public PersonList SelectAll()
        {
            command.CommandText = $"SELECT * FROM PersonTBL";
            PersonList personList = new PersonList(base.Select());
            return personList;
        }

        protected override void CreateDeletedSQL(Base entity, OleDbCommand cmd)
        {
            Person c= entity as Person;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM PersonTBL where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }

        protected override void CreateInsertSQL(Base entity, OleDbCommand cmd)
        {
            Person c = entity as Person;
            if (c != null)
            {
                string sqlStr = $"Insert INTO PersonTBL (Fname,Lname,IDnum,BirthDate,Gender)" +
                    "VALUES (@Fname, @Lname, @IDnum, @BirthDate, @Gender)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@Fname", c.Fname));
                command.Parameters.Add(new OleDbParameter("@Lname", c.Lname));
                command.Parameters.Add(new OleDbParameter("@IDnum", c.IDnum));
                command.Parameters.Add(new OleDbParameter("@BirthDate", c.BirthDate));
                command.Parameters.Add(new OleDbParameter("@Gender", c.Gender.Id));
            }
        }
        protected override void CreateUpdateSQL(Base entity, OleDbCommand cmd)
        {
            Person c = entity as Person;
            if (c != null)
            {
                string sqlstr = $"Update PersonTBL " +
                    $"SET Fname=@Fname, Lname=@Lname, IDnum=@IDnum, BirthDate=@BirthDate, Gender=@Gender " +
                    $"WHERE id=@id";
                command.CommandText = sqlstr;
                command.Parameters.Add(new OleDbParameter("@Fname", c.Fname));
                command.Parameters.Add(new OleDbParameter("@Lname", c.Lname));
                command.Parameters.Add(new OleDbParameter("@IDnum", c.IDnum));
                command.Parameters.Add(new OleDbParameter("@BirthDate", c.BirthDate));
                command.Parameters.Add(new OleDbParameter("@Gender", c.Gender.Id));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
        protected override Base CreateModel(Base entity)
        {
            Person prs = entity as Person;
            prs.Fname = reader["Fname"].ToString();
            prs.Lname = reader["Lname"].ToString();
            prs.IDnum = reader["IDnum"].ToString();
            prs.BirthDate = (DateTime)(reader["BirthDate"]);
            prs.Gender = GenderDb.SelectById(int.Parse(reader["Gender"].ToString()));
            base.CreateModel(entity);
            return prs;
        }

        protected override Base NewEntity()
        {
            return new Person();
        }
    }
}
