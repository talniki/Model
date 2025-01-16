using Model;
using System;
using System.Net.Http.Json;


namespace Service
{
    public class JsonResponse
    {
        public int Value { get; set; }
    }

    public class ApiService : IApiService
    {
        string uri;
        HttpClient client;

        public ApiService()
        {
            uri = "http://localhost:5231/api/";
            client = new HttpClient();
        }


        public ApiService(HttpClient client, string baseUri)
        {
            uri = "http://localhost:5231/api/";
            client = new HttpClient();
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.uri = baseUri ?? throw new ArgumentNullException(nameof(baseUri));
        }

        public async Task<int> DeleteACity(City city)
        {
            var c = uri + $"Delete/DeleteCity/  {city.Id}";
            return (await client.DeleteAsync(uri + $"Delete/DeleteCity/{city.Id}")).IsSuccessStatusCode ? 1 : 0; ;
        }

        public async Task<int> DeleteADoctor(Doctor doctor)
        {
            return (await client.DeleteAsync(uri + $"Delete/DeleteDoctor/{doctor.Id}")).IsSuccessStatusCode ? 1 : 0; ;
        }

        public async Task<int> DeleteAGender(Gender gender)
        {
            return (await client.DeleteAsync(uri + $"Delete/DeleteGender/{gender.Id}")).IsSuccessStatusCode ? 1 : 0; ;
        }

        public async Task<int> DeleteALocation(Location location)
        {
            return (await client.DeleteAsync(uri + $"Delete/DeleteLocation/{location.Id}")).IsSuccessStatusCode ? 1 : 0; ;
        }

        public async Task<int> DeleteAParent(Parent parent)
        {
            return (await client.DeleteAsync(uri + $"Delete/DeleteParent/{parent.Id}")).IsSuccessStatusCode ? 1 : 0; ;
        }

        public async Task<int> DeleteAPatient(Patient patient)
        {
            return (await client.DeleteAsync(uri + $"Delete/DeletePatient/{patient.Id}")).IsSuccessStatusCode ? 1 : 0; ;
        }

        public async Task<int> DeleteAPerson(Person person)
        {
            return (await client.DeleteAsync(uri + $"Delete/DeletePerson/{person.Id}")).IsSuccessStatusCode ? 1 : 0; ;
        }

        public async Task<int> DeleteAProff(Proff proff)
        {
            return (await client.DeleteAsync(uri + $"Delete/DeleteProff/{proff.Id}")).IsSuccessStatusCode ? 1 : 0; ;
        }

        public async Task<int> DeleteAQueue(CQueue q)
        {
            return (await client.DeleteAsync(uri + $"Delete/DeleteQueue/{q.Id}")).IsSuccessStatusCode ? 1 : 0; ;
        }

        public async Task<CityList> GetAllCities()
        {
            return await client.GetFromJsonAsync<CityList>(uri + "Select/CitySelector");
        }

        public async Task<DoctorList> GetAllDoctors()
        {
            return await client.GetFromJsonAsync<DoctorList>(uri + "Select/DoctorSelector");
        }

        public async Task<GenderList> GetAllGenders()
        {
            return await client.GetFromJsonAsync<GenderList>(uri + "Select/GenderSelector");
        }

        public async Task<LocationList> GetAllLocations()
        {
            return await client.GetFromJsonAsync<LocationList>(uri + "Select/LocationSelector");
        }

        public async Task<ParentList> GetAllParents()
        {
            return await client.GetFromJsonAsync<ParentList>(uri + "Select/ParentSelector");
        }

        public async Task<PatientList> GetAllPatients()
        {
            return await client.GetFromJsonAsync<PatientList>(uri + "Select/PatientSelector");
        }

        public async Task<PersonList> GetAllPersons()
        {
            return await client.GetFromJsonAsync<PersonList>(uri + "Select/PersonSelector");
        }

        public async Task<ProffList> GetAllProffs()
        {
            return await client.GetFromJsonAsync<ProffList>(uri + "Select/ProffSelector");
        }

        public async Task<QueueList> GetAllQueues()
        {
            return await client.GetFromJsonAsync<QueueList>(uri + "Select/QueueSelector");
        }
        //
        public Task<List<int>> GetTotalCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetTotalNameAsync()
        {
            throw new NotImplementedException();
        }
        //
        public async Task<int> InsertACity(City city)
        {
           return (await client.PostAsJsonAsync<City>(uri+ "Insert/InsertCity", city)).IsSuccessStatusCode? 1:0;
        }

        public async Task<int> InsertADoctor(Doctor doctor)
        {
            return (await client.PostAsJsonAsync<Doctor>(uri + "Insert/InsertDoctor", doctor)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAGender(Gender gender)
        {
            return (await client.PostAsJsonAsync<Gender>(uri + "Insert/InsertGender", gender)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertALocation(Location location)
        {
            return (await client.PostAsJsonAsync<Location>(uri + "Insert/InsertLocation", location)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAParent(Parent parent)
        {
            return (await client.PostAsJsonAsync<Parent>(uri + "Insert/InsertParent", parent)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAPatient(Patient patient)
        {
            return (await client.PostAsJsonAsync<Patient>(uri + "Insert/InsertPatient", patient)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAPerson(Person person)
        {
            return (await client.PostAsJsonAsync<Person>(uri + "Insert/InsertPerson", person)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAProff(Proff proff)
        {
            return (await client.PostAsJsonAsync<Proff>(uri + "Insert/InsertProff", proff)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAQueue(CQueue q)
        {
            return (await client.PostAsJsonAsync<CQueue>(uri + "Insert/InsertQueue", q)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateACity(City city)
        {
            return (await client.PutAsJsonAsync<City>(uri + "Update/UpdateCity", city)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateADoctor(Doctor doctor)
        {
            return (await client.PutAsJsonAsync<Doctor>(uri + "Update/UpdateDoctor", doctor)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAGender(Gender gender)
        {
            return (await client.PutAsJsonAsync<Gender>(uri + "Update/UpdateGender", gender)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateALocation(Location location)
        {
            return (await client.PutAsJsonAsync<Location>(uri + "Update/UpdateLocation", location)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAParent(Parent parent)
        {
            return (await client.PutAsJsonAsync<Parent>(uri + "Update/UpdateParent", parent)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAPatient(Patient patient)
        {
            return (await client.PutAsJsonAsync<Patient>(uri + "Update/UpdatePatient", patient)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAPerson(Person person)
        {
            return (await client.PutAsJsonAsync<Person>(uri + "Update/UpdatePerson", person)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAProff(Proff proff)
        {
            return (await client.PutAsJsonAsync<Proff>(uri + "Update/UpdateProff", proff)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAQueue(CQueue q)
        {
            return (await client.PutAsJsonAsync<CQueue>(uri + "Update/UpdateQueue", q)).IsSuccessStatusCode ? 1 : 0;
        }
    }
}
