using Model;
using Service;
using ViewModel;
//#region
//CityDb city = new CityDb();
//CityList citylist = city.SelectAll();
//foreach (City c in citylist)
//{
//    Console.WriteLine("city name: " + c.CityName + "    city id: " + c.Id);
//}
//#endregion
//#region
//GenderDb gender = new GenderDb();
//GenderList genderlist = gender.SelectAll();
//foreach (Gender gen in genderlist)
//{
//    Console.WriteLine(gen.GenderName + gen.Id);
//}
//#endregion
//#region
//ProffDb proffdb = new ProffDb();
//ProffList Profflist = proffdb.SelectAll();
//foreach (Proff proff in Profflist)

//{
//    Console.WriteLine("prof id: " + proff.Id + "   prof gender: " + proff.ProffName);
//}
//#endregion
//#region
//DoctorDb doctor = new DoctorDb();
//DoctorList doctorlist = doctor.SelectAll();
//foreach (Doctor doc in doctorlist)
//{
//    Console.WriteLine(doc.ToString() + " , " + "docID: "+doc.Id);

//}
//#endregion
//#region
//PersonDb person = new PersonDb();
//PersonList personlist = person.SelectAll();
//foreach (Person per in personlist)
//{
//    Console.WriteLine(per.ToString() + "," + per.Id);
//}
//#endregion
//#region
//LocationDb location = new LocationDb();
//LocationList locationlist = location.SelectAll();
//foreach (Location loc in locationlist)
//{
//    Console.WriteLine(loc.ToString() + "," + loc.Id);
//}
//#endregion
//#region
//ParentDb parent = new ParentDb();
//ParentList parentlist = parent.SelectAll();
//foreach (Parent prnt in parentlist)
//{
//    Console.WriteLine(prnt.ToString() + "," + prnt.Id);
//}
//#endregion
//#region
//PatientDb patient = new PatientDb();
//PatientList patientlist = patient.SelectAll();
//foreach (Patient pat in patientlist)
//{
//    Console.WriteLine(pat.ToString() + "," + "ID: "+pat.Id);
//}
//#endregion
//#region
//QueueDb cqueue = new QueueDb();
//QueueList queuelist = cqueue.SelectAll();
//foreach (CQueue q in queuelist)
//{
//    Console.WriteLine(q.ToString() + "," + q.Id);
//}
//#endregion
//#region
//LocationDb LDB = new LocationDb();
//LocationList locations = LDB.SelectAll();
//    foreach (Location c in locations)
//Console.WriteLine(c.LocName);
//Location LLast = locations.Last();
//cDB.Delete(cLast);
//cDB.SaveChanges();
//Console.WriteLine("delete :");
//locations = cDB.SelectAll();
//foreach (Location c in locations)
//    Console.WriteLine(c.LocName);
//#endregion
//#region
//CityDb xDB = new CityDb();
//CityList cities = xDB.SelectAll();
//foreach (City c in cities)
//    Console.WriteLine(c.CityName);
//City cLast = cities[9];
//cDB.Delete(cLast);
//cDB.SaveChanges();
//Console.WriteLine("delete :");
//cities = cDB.SelectAll();
//foreach (City c in cities)
//    Console.WriteLine(c.CityName);
//#endregion
//#region
//GenderDb cDB = new GenderDb();
//GenderList gender = cDB.SelectAll();
//foreach (Gender x in gender)
//    Console.WriteLine(x.GenderName);
//Gender gLast = gender.Last();
//cDB.Delete(cLast);
//cDB.SaveChanges();
//Console.WriteLine("delete :");
//gender = cDB.SelectAll();
//foreach (Gender x in gender)
//    Console.WriteLine(x.GenderName);
//#endregion
//#region
//DoctorDb dDB = new DoctorDb();
//DoctorList doctor = dDB.SelectAll();
//foreach (Doctor c in doctor)
//    Console.WriteLine(c.specialization);
//Doctor dLast = doctor[2];
//cDB.Delete(cLast);
//cDB.SaveChanges();
//Console.WriteLine("delete :");
//doctor = cDB.SelectAll();
//foreach (Doctor c in doctor)
//    Console.WriteLine(c.specialization);
//#endregion
//#region
//ParentDb pDB = new ParentDb();
//ParentList parent = pDB.SelectAll();
//foreach (Parent c in parent)
//    Console.WriteLine("id parent: " +c.IdParent + "id child: "+ c.IdChild);
//Parent pLast = parent.Last();
//cDB.Delete(cLast);
//cDB.SaveChanges();
//Console.WriteLine("delete :");
//parent = cDB.SelectAll();
//foreach (Parent c in parent)
//    Console.WriteLine("id parent: " + c.IdParent + "id child: " + c.IdChild);
//#endregion
//================================================================================
////#region
//PatientDb aDB = new PatientDb();
//PatientList patient = aDB.SelectAll();
//foreach (Patient c in patient)
//    Console.WriteLine(c.Password);
//Patient aLast = patient[2];
//cDB.Delete(cLast);
//cDB.SaveChanges();
//Console.WriteLine("delete :");
//patient = aDB.SelectAll();
//foreach (Patient c in patient)
//    Console.WriteLine(c.Password);
//#endregion
//#region
//PersonDb sDB = new PersonDb();
//PersonList person = sDB.SelectAll();
//foreach (Person s in patient)
//    Console.WriteLine(s.Fname);
//Person sLast = person[2];
//cDB.Delete(cLast);
//cDB.SaveChanges();
//Console.WriteLine("delete :");
//patient = sDB.SelectAll();
//foreach (Patient s in patient)
//    Console.WriteLine(s.Fname);
//#endregion
//#region
//ProffDb cpDB = new ProffDb();
//ProffList proff = cpDB.SelectAll();
//foreach (Proff c in proff)
//    Console.WriteLine(c.ProffName);
//Proff ppLast = proff[0];
//cDB.Delete(cLast);
//cDB.SaveChanges();
//Console.WriteLine("delete :");
//proff = cDB.SelectAll();
//foreach (Proff c in proff)
//    Console.WriteLine(c.ProffName);
//#endregion
//#region
//QueueDb cDB = new QueueDb();
//QueueList q = cDB.SelectAll();
//foreach (CQueue c in q)
//    Console.WriteLine(c.QueueDate);
//CQueue cLast = q.Last();
//cDB.Delete(cLast);
//cDB.SaveChanges();
//Console.WriteLine("delete :");
//q = cDB.SelectAll();
//foreach (CQueue c in q)
//    Console.WriteLine(c.QueueDate);
//#endregion
//====================================================================
//#region
//PersonDb pdb = new PersonDb();
//Person u1 = new Person()
//{
//    Fname = "ivgi",
//    Lname = "gay",
//    IDnum = "564738294",
//    BirthDate = new DateTime(2001, 3, 7),
//    Gender = cLast
//};
//pdb.Insert(u1);
//pdb.SaveChanges();
//PersonList plist = pdb.SelectAll();
//foreach (Person u in plist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//CityDb user = new CityDb();
//City c = new City()
//{
//    CityName = "קריית שמונה",
//};
//user.Insert(c);
//user.SaveChanges();
//CityList users = user.SelectAll();
//foreach (City u in users)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//GenderDb gen = new GenderDb();
//Gender c = new Gender()
//{
//    GenderName = "None",
//};
//gen.Insert(c);
//gen.SaveChanges();
//GenderList gens = gen.SelectAll();
//foreach (Gender u in gens)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//ProffDb gen = new ProffDb();
//Proff c = new Proff()
//{
//    ProffName = "Allergist",
//};
//gen.Insert(c);
//gen.SaveChanges();
//ProffList gens = gen.SelectAll();
//foreach (Proff u in gens)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//LocationDb gen = new LocationDb();
//Location c = new Location()
//{
//    LocName = "macabi dent",
//    CityName= cLast,
//    Street="התאנה",
//    BuildingNum=19,
//    Parking=true,
//};
//gen.Insert(c);
//gen.SaveChanges();
//LocationList gens = gen.SelectAll();
//foreach (Location u in gens)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//DoctorDb gen = new DoctorDb();
//Doctor c = new Doctor()
//{
//    specialization = cLast,
//    BirthDate = new DateTime(),
//    Fname = "gal",
//    Lname = "tik",
//    IDnum = "333777666",
//    Gender = gLast
//};
//gen.Insert(c);
//gen.SaveChanges();
//DoctorList gens = gen.SelectAll();
//foreach (Doctor u in gens)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//ParentDb gen = new ParentDb();
//Parent c = new Parent()
//{
//    IdChild = sLast,
//    IdParent = aLast,
//};
//gen.Insert(c);
//gen.SaveChanges();
//ParentList gens = gen.SelectAll();
//foreach (Parent u in gens)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//QueueDb gen = new QueueDb();
//CQueue c = new CQueue()
//{
//    location = LLast,
//    QueueDate = new DateTime(2025, 7, 1),
//    IDdoctor = dLast,
//    IDperson = sLast,
//};
//gen.Insert(c);
//gen.SaveChanges();
//QueueList gens = gen.SelectAll();
//foreach (CQueue u in gens)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//PatientDb gen = new PatientDb();
//Patient c = new Patient()
//{
//    Password = "eee",
//    Mail = "eee@gmail.com",
//    PhoneNum = "0544869755",
//    city = cLast,
//    Fname = "mishel",
//    Lname = "nik",
//    IDnum = "204968295",
//    BirthDate = new DateTime(2000, 8, 2),
//    Gender = gLast,

//};
//gen.Insert(c);
//gen.SaveChanges();
//PatientList gens = gen.SelectAll();
//foreach (Patient u in gens)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//=====================================================================
//#region
//PersonDb pdb = new PersonDb();
//PersonList plist = pdb.SelectAll();
//foreach (Person u in plist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//Person u1 = plist[3];
//u1.IDnum = "232232232";
//pdb.Update(u1);
//pdb.SaveChanges();
//Console.WriteLine(" after : ");
//PersonList polist = pdb.SelectAll();
//foreach (Person u in polist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//ProffDb pdb = new ProffDb();
//ProffList plist = pdb.SelectAll();
//foreach (Proff u in plist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//Proff u1 = plist[5];
//u1.ProffName = "Neurology";
//pdb.Update(u1);
//pdb.SaveChanges();
//Console.WriteLine(" after : ");
//ProffList polist = pdb.SelectAll();
//foreach (Proff u in polist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//GenderDb pdb = new GenderDb();
//GenderList plist = pdb.SelectAll();
//foreach (Gender u in plist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//Gender u1 = plist[2];
//u1.GenderName = "attack hellicopter";
//pdb.Update(u1);
//pdb.SaveChanges();
//Console.WriteLine(" after : ");
//GenderList polist = pdb.SelectAll();
//foreach (Gender u in polist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//CityDb pdb = new CityDb();
//CityList plist = pdb.SelectAll();
//foreach (City u in plist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//City u1 = plist[3];
//u1.CityName = "מטולה";
//pdb.Update(u1);
//pdb.SaveChanges();
//Console.WriteLine(" after : ");
//CityList polist = pdb.SelectAll();
//foreach (City u in polist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//LocationDb pdb = new LocationDb();
//LocationList plist = pdb.SelectAll();
//foreach (Location u in plist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//Location u1 = plist[5];
//u1.BuildingNum = 8;
//pdb.Update(u1);
//pdb.SaveChanges();
//Console.WriteLine(" after : ");
//LocationList polist = pdb.SelectAll();
//foreach (Location u in polist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//QueueDb pdb = new QueueDb();
//QueueList plist = pdb.SelectAll();
//foreach (CQueue u in plist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//CQueue u1 = plist[1];
//u1.QueueDate = new DateTime(2025,2,10);
//pdb.Update(u1);
//pdb.SaveChanges();
//Console.WriteLine(" after : ");
//QueueList polist = pdb.SelectAll();
//foreach (CQueue u in polist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//ParentDb pdb = new ParentDb();
//ParentList plist = pdb.SelectAll();
//foreach (Parent u in plist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//Parent u1 = plist[2];
//u1.IdChild.Id = 12;
//pdb.Update(u1);
//pdb.SaveChanges();
//Console.WriteLine(" after : ");
//ParentList polist = pdb.SelectAll();
//foreach (Parent u in polist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//DoctorDb pdb = new DoctorDb();
//DoctorList plist = pdb.SelectAll();
//foreach (Doctor u in plist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//Doctor u1 = plist[2];
//u1.specialization = ppLast;
//pdb.Update(u1);
//pdb.SaveChanges();
//Console.WriteLine(" after : ");
//DoctorList polist = pdb.SelectAll();
//foreach (Doctor u in polist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//#region
//PatientDb pdb = new PatientDb();
//PatientList plist = pdb.SelectAll();
//foreach (Patient u in plist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//Patient u1 = plist[0];
//u1.Password = "rywueywiu";
//pdb.Update(u1);
//pdb.SaveChanges();
//Console.WriteLine(" after : ");
//PatientList polist = pdb.SelectAll();
//foreach (Patient u in polist)
//{
//    Console.WriteLine(u.Id + ": " + u.ToString());
//}
//#endregion
//static async Task Main(string[] args)
//{
//    ApiService apiservice = new();
//    CityList cities = await apiservice.GetAllCities();
//    Console.WriteLine(cities.Count);
//    int id = cities.Last().Id;
//    await apiservice.DeleteACity(id);
//    Console.WriteLine(cities.Count);

//    City c1 = new City() { CityName = "בית אל" };
//    await apiservice.InsertACity(c1);
//    City myCity = cities.First();
//    myCity.CityName = "נתניה";
//    await apiservice.UpdateACity(myCity);
//}