using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeleteController : ControllerBase
    {
        [HttpDelete("{id}")]
        [ActionName("DeleteCity")]
        public int DeleteACity(int id)
        {
            City c = CityDb.SelectById(id);
            CityDb db = new CityDb();
            db.Delete(c);
            int x = db.SaveChanges();
            return x;
        }
        [HttpDelete("{id}")]
        [ActionName("DeleteDoctor")]
        public int DeleteADoctor(int id)
        {
            Doctor d = DoctorDb.SelectById(id);
            DoctorDb db = new DoctorDb();
            db.Delete(d);
            int x = db.SaveChanges();
            return x;
        }

        // Delete a Gender
        [HttpDelete("{id}")]
        [ActionName("DeleteGender")]
        public int DeleteAGender(int id)
        {
            Gender g = GenderDb.SelectById(id);
            GenderDb db = new GenderDb();
            db.Delete(g);
            int x = db.SaveChanges();
            return x;
        }

        // Delete a Location
        [HttpDelete("{id}")]
        [ActionName("DeleteLocation")]
        public int DeleteALocation(int id)
        {
            Location l = LocationDb.SelectById(id);
            LocationDb db = new LocationDb();
            db.Delete(l);
            int x = db.SaveChanges();
            return x;
        }

        // Delete a Parent
        [HttpDelete("{id}")]
        [ActionName("DeleteParent")]
        public int DeleteAParent(int id)
        {
            Parent p = ParentDb.SelectById(id);
            ParentDb db = new ParentDb();
            db.Delete(p);
            int x = db.SaveChanges();
            return x;
        }

        // Delete a Patient
        [HttpDelete("{id}")]
        [ActionName("DeletePatient")]
        public int DeleteAPatient(int id)
        {
            Patient p = PatientDb.SelectById(id);
            PatientDb db = new PatientDb();
            db.Delete(p);
            int x = db.SaveChanges();
            return x;
        }

        // Delete a Proff
        [HttpDelete("{id}")]
        [ActionName("DeleteProff")]
        public int DeleteAProff(int id)
        {
            Proff p = ProffDb.SelectById(id);
            ProffDb db = new ProffDb();
            db.Delete(p);
            int x = db.SaveChanges();
            return x;
        }

        // Delete a Queue
        [HttpDelete("{id}")]
        [ActionName("DeleteQueue")]
        public int DeleteAQueue(int id)
        {
            CQueue q = QueueDb.SelectById(id);
            QueueDb db = new QueueDb();
            db.Delete(q);
            int x = db.SaveChanges();
            return x;
        }

        // Delete a Person
        [HttpDelete("{id}")]
        [ActionName("DeletePerson")]
        public int DeleteAPerson(int id)
        {
            Person p = PersonDb.SelectById(id);
            PersonDb db = new PersonDb();
            db.Delete(p);
            int x = db.SaveChanges();
            return x;
        }
        // GET: api/<DeleteController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<DeleteController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<DeleteController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<DeleteController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<DeleteController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
