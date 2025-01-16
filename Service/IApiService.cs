using Model;
using ViewModel;

namespace Service
{
    public interface IApiService
    {
        public Task<CityList> GetAllCities();
        public Task<int> DeleteACity(City city);
        public Task<int> InsertACity(City city);
        public Task<int> UpdateACity(City city);
        // Doctor
        public Task<DoctorList> GetAllDoctors();
        public Task<int> DeleteADoctor(Doctor doctor);
        public Task<int> InsertADoctor(Doctor doctor);
        public Task<int> UpdateADoctor(Doctor doctor);

        // Gender
        public Task<GenderList> GetAllGenders();
        public Task<int> DeleteAGender(Gender gender);
        public Task<int> InsertAGender(Gender gender);
        public Task<int> UpdateAGender(Gender gender);

        // Location
        public Task<LocationList> GetAllLocations();
        public Task<int> DeleteALocation(Location location);
        public Task<int> InsertALocation(Location location);
        public Task<int> UpdateALocation(Location location);

        // Parent
        public Task<ParentList> GetAllParents();
        public Task<int> DeleteAParent(Parent parent);
        public Task<int> InsertAParent(Parent parent);
        public Task<int> UpdateAParent(Parent parent);

        // Patient
        public Task<PatientList> GetAllPatients();
        public Task<int> DeleteAPatient(Patient patient);
        public Task<int> InsertAPatient(Patient patient);
        public Task<int> UpdateAPatient(Patient patient);

        // Proff (Profession)
        public Task<ProffList> GetAllProffs();
        public Task<int> DeleteAProff(Proff proff);
        public Task<int> InsertAProff(Proff proff);
        public Task<int> UpdateAProff(Proff proff);

        // Queue
        public Task<QueueList> GetAllQueues();
        public Task<int> DeleteAQueue(CQueue queue);
        public Task<int> InsertAQueue(CQueue queue);
        public Task<int> UpdateAQueue(CQueue queue);

        // Person
        public Task<PersonList> GetAllPersons();
        public Task<int> DeleteAPerson(Person person);
        public Task<int> InsertAPerson(Person person);
        public Task<int> UpdateAPerson(Person person);
    }
}
