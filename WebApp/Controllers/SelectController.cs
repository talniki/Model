using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectController : ControllerBase
    {
        [HttpGet]
        [ActionName("CitySelector")]
        public CityList SelectAllCities()
        {
            CityDb db = new CityDb();
            CityList cities = db.SelectAll();
            return cities;
        }
        // Doctor Selector
        [HttpGet]
        [ActionName("DoctorSelector")]
        public DoctorList SelectAllDoctors()
        {
            DoctorDb db = new DoctorDb();
            DoctorList doctors = db.SelectAll();
            return doctors;
        }

        // Gender Selector
        [HttpGet]
        [ActionName("GenderSelector")]
        public GenderList SelectAllGenders()
        {
            GenderDb db = new GenderDb();
            GenderList genders = db.SelectAll();
            return genders;
        }

        // Location Selector
        [HttpGet]
        [ActionName("LocationSelector")]
        public LocationList SelectAllLocations()
        {
            LocationDb db = new LocationDb();
            LocationList locations = db.SelectAll();
            return locations;
        }

        // Parent Selector
        [HttpGet]
        [ActionName("ParentSelector")]
        public ParentList SelectAllParents()
        {
            ParentDb db = new ParentDb();
            ParentList parents = db.SelectAll();
            return parents;
        }

        // Patient Selector
        [HttpGet]
        [ActionName("PatientSelector")]
        public PatientList SelectAllPatients()
        {
            PatientDb db = new PatientDb();
            PatientList patients = db.SelectAll();
            return patients;
        }

        // Proff (Profession) Selector
        [HttpGet]
        [ActionName("ProffSelector")]
        public ProffList SelectAllProffs()
        {
            ProffDb db = new ProffDb();
            ProffList proffs = db.SelectAll();
            return proffs;
        }

        // Queue Selector
        [HttpGet]
        [ActionName("QueueSelector")]
        public QueueList SelectAllQueues()
        {
            QueueDb db = new QueueDb();
            QueueList queues = db.SelectAll();
            return queues;
        }

        // Person Selector
        [HttpGet]
        [ActionName("PersonSelector")]
        public PersonList SelectAllPersons()
        {
            PersonDb db = new PersonDb();
            PersonList persons = db.SelectAll();
            return persons;
        }
        // GET: api/<SelectController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<SelectController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<SelectController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<SelectController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<SelectController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
