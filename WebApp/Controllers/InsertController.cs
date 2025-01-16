using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InsertController : ControllerBase
    {
        [HttpPost]
        [ActionName("InsertCity")]
        public int InsertACity([FromBody] City city)
        {
            CityDb cDB = new CityDb();
            cDB.Insert(city);
            int x = cDB.SaveChanges();
            return x;
        }
        // Insert a Doctor
        [HttpPost]
        [ActionName("InsertDoctor")]
        public int InsertADoctor([FromBody] Doctor doctor)
        {
            DoctorDb dDB = new DoctorDb();
            dDB.Insert(doctor);
            int x = dDB.SaveChanges();
            return x;
        }

        // Insert a Gender
        [HttpPost]
        [ActionName("InsertGender")]
        public int InsertAGender([FromBody] Gender gender)
        {
            GenderDb gDB = new GenderDb();
            gDB.Insert(gender);
            int x = gDB.SaveChanges();
            return x;
        }

        // Insert a Location
        [HttpPost]
        [ActionName("InsertLocation")]
        public int InsertALocation([FromBody] Location location)
        {
            LocationDb lDB = new LocationDb();
            lDB.Insert(location);
            int x = lDB.SaveChanges();
            return x;
        }

        // Insert a Parent
        [HttpPost]
        [ActionName("InsertParent")]
        public int InsertAParent([FromBody] Parent parent)
        {
            ParentDb pDB = new ParentDb();
            pDB.Insert(parent);
            int x = pDB.SaveChanges();
            return x;
        }

        // Insert a Patient
        [HttpPost]
        [ActionName("InsertPatient")]
        public int InsertAPatient([FromBody] Patient patient)
        {
            PatientDb pDB = new PatientDb();
            pDB.Insert(patient);
            int x = pDB.SaveChanges();
            return x;
        }

        // Insert a Proff (Profession)
        [HttpPost]
        [ActionName("InsertProff")]
        public int InsertAProff([FromBody] Proff proff)
        {
            ProffDb pDB = new ProffDb();
            pDB.Insert(proff);
            int x = pDB.SaveChanges();
            return x;
        }

        // Insert a Queue
        [HttpPost]
        [ActionName("InsertQueue")]
        public int InsertAQueue([FromBody] CQueue queue)
        {
            QueueDb qDB = new QueueDb();
            qDB.Insert(queue);
            int x = qDB.SaveChanges();
            return x;
        }

        // Insert a Person
        [HttpPost]
        [ActionName("InsertPerson")]
        public int InsertAPerson([FromBody] Person person)
        {
            PersonDb pDB = new PersonDb();
            pDB.Insert(person);
            int x = pDB.SaveChanges();
            return x;
        }
        // GET: api/<InsertController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<InsertController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<InsertController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<InsertController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<InsertController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
