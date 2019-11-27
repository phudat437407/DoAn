using System.Linq;
using System;
using ApplicationCore.Entities;

namespace Infrastructure.Persistence
{
    public class DataSeed
    {
        public static void Initialize(RegisterContext context)
        {
           
            context.Database.EnsureCreated();
            
           
            // DB has seeded
            if (context.Enrollments.Any()) return;
            if (context.Patients.Any()) return;
            var patients = new Patient[]
            {
                new Patient
                {
                   Id="A001", 
                   Name="Nguyen Ha",
                   Gender = true,
                   BirthDate = System.DateTime.Parse("1989-12-6"),
                   Address = new Address("198","Đường số 12","Phường 1","Quận 1", "TPHCM","Việt Nam"),
                   Phone = "0337859647"
               
                   },
                new Patient
                {
                   Id = "B004", 
                   Name="Van Duc",
                   Gender = false,
                   BirthDate = System.DateTime.Parse("1996-8-9"),
                   Address = new Address("19","Nguyễn Thượng Hiền","Phường 1","Quận 1", "TPHCM","Việt Nam"),
                   Phone = "09794567895"
                
                   },
                new Patient
                {
                   Id = "T008", 
                   Name="Văn Trung",
                   Gender = false,
                   BirthDate = System.DateTime.Parse("1996-8-10"),
                   Address = new Address("19","Nguyễn Thượng Hiền","Phường 1","Quận 1", "TPHCM","Việt Nam"),
                   Phone = "09794567878"
               
                   },
                new Patient
                {
                   Id = "T745", 
                   Name="Nguyễn Thị Hoa",
                   Gender = true,
                   BirthDate = System.DateTime.Parse("1996-10-9"),
                   Address = new Address("19","Nguyễn Thượng Hiền","Phường 1","Quận 1", "TPHCM","Việt Nam"),
                   Phone = "03694567895"
               
                   }
            };
            foreach (Patient p in patients)
            {
                context.Patients.Add(p); // cung ten voi DbSet<Patient> Patient trong RegisterContext
            }
            context.SaveChanges();
            var doctors = new Doctor[]
            {
                new Doctor("S001","Nguyen A", false, new DateTime(1999, 12, 5),new Address("271", "An Duong Vuong", "9", "5", "Ho Chi Minh", "Viet Nam"), "0334578965"),
                new Doctor("H008","Nguyen B", false, new DateTime(1988, 5, 1),new Address("273", "An Duong Vuong", "9", "5", "Ho Chi Minh", "Viet Nam"), "0975658745")
            };

            foreach (Doctor d in doctors)
            {
                context.Doctors.Add(d); // cung ten voi DbSet<Patient> Patient trong RegisterContext
            }
            context.SaveChanges();

           
            var enrollments = new Enrollments[]
            {
                // new Enrollment {

                //     StudentID = students.Single(s => s.LastName == "Alexander").ID,

                //     CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,

                //     Grade = Grade.A

                // },
                new Enrollments {
                   
                        PatientId = patients.Single(p => p.Name == "Nguyen Ha").Id,
                        DoctorId = doctors.Single(d => d.Name == "Nguyen A").Id,
                        enrollmentDate = new EnrollmentDate{
                            Date = System.DateTime.Parse("14"),
                            Month = System.DateTime.Parse("2"),
                            Year = System.DateTime.Parse("2020"),
                            Time = System.DateTime.Parse("14:00:00")
                        }
                },

                 new Enrollments {
                   
                        PatientId = patients.Single(p => p.Name == "Van Duc").Id,
                        DoctorId = doctors.Single(d => d.Name == "Nguyen B").Id,
                        enrollmentDate = new EnrollmentDate{
                            Date = System.DateTime.Parse("11"),
                            Month = System.DateTime.Parse("1"),
                            Year = System.DateTime.Parse("2020"),
                            Time = System.DateTime.Parse("11:30:00")
                        }
                }
                    
            };

            foreach (Enrollments e in enrollments)
            {
                var enrollmentInData = context.Enrollments.Where(
                    s =>
                            s.patient.Id == e.PatientId &&

                            s.doctor.Id == e.DoctorId).SingleOrDefault();

                if (enrollmentInData == null)
                {
                    context.Enrollments.Add(e);
                }
                context.Enrollments.Add(e); // cung ten voi DbSet<Patient> Patient trong RegisterContext
            }
            context.SaveChanges();

            
        }
    }
}