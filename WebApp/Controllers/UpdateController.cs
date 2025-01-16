using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UpdateController : ControllerBase
    {
        [HttpPut]
        [ActionName("UpdateCity")]
        public int UpdateACity([FromBody] City c)
        {
            CityDb cDB = new CityDb();
            cDB.Update(c);
            int x = cDB.SaveChanges();
            return x;
        }
        // Update a Doctor
        [HttpPut]
        [ActionName("UpdateDoctor")]
        public int UpdateADoctor([FromBody] Doctor doctor)
        {
            DoctorDb dDB = new DoctorDb();
            dDB.Update(doctor);
            int x = dDB.SaveChanges();
            return x;
        }

        // Update a Gender
        [HttpPut]
        [ActionName("UpdateGender")]
        public int UpdateAGender([FromBody] Gender gender)
        {
            GenderDb gDB = new GenderDb();
            gDB.Update(gender);
            int x = gDB.SaveChanges();
            return x;
        }

        // Update a Location
        [HttpPut]
        [ActionName("UpdateLocation")]
        public int UpdateALocation([FromBody] Location location)
        {
            LocationDb lDB = new LocationDb();
            lDB.Update(location);
            int x = lDB.SaveChanges();
            return x;
        }

        // Update a Parent
        [HttpPut]
        [ActionName("UpdateParent")]
        public int UpdateAParent([FromBody] Parent parent)
        {
            ParentDb pDB = new ParentDb();
            pDB.Update(parent);
            int x = pDB.SaveChanges();
            return x;
        }

        // Update a Patient
        [HttpPut]
        [ActionName("UpdatePatient")]
        public int UpdateAPatient([FromBody] Patient patient)
        {
            PatientDb pDB = new PatientDb();
            pDB.Update(patient);
            int x = pDB.SaveChanges();
            return x;
        }

        // Update a Proff (Profession)
        [HttpPut]
        [ActionName("UpdateProff")]
        public int UpdateAProff([FromBody] Proff proff)
        {
            ProffDb pDB = new ProffDb();
            pDB.Update(proff);
            int x = pDB.SaveChanges();
            return x;
        }

        // Update a Queue
        [HttpPut]
        [ActionName("UpdateQueue")]
        public int UpdateAQueue([FromBody] CQueue queue)
        {
            QueueDb qDB = new QueueDb();
            qDB.Update(queue);
            int x = qDB.SaveChanges();
            return x;
        }

        // Update a Person
        [HttpPut]
        [ActionName("UpdatePerson")]
        public int UpdateAPerson([FromBody] Person person)
        {
            PersonDb pDB = new PersonDb();
            pDB.Update(person);
            int x = pDB.SaveChanges();
            return x;
        }
        // GET: api/<UpdateController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<UpdateController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<UpdateController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<UpdateController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UpdateController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
