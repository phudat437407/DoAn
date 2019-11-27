using AutoMapper;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;
namespace ApplicationCore
{
    // public class AutoMapperConfiguration
    // {
    //     public static void Configure()
    //     {

    //     }
    // }
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Account, AccountDTO>();
            CreateMap<AccountDTO, Account>();

            CreateMap<Person, PersonDTO>();
            CreateMap<PersonDTO, Person>();

            CreateMap<Patient, PatientDTO>();
            CreateMap<PatientDTO, Patient>();

            CreateMap<Doctor, DoctorDTO>();
            CreateMap<DoctorDTO, Doctor>();


            CreateMap<Address, AddressDTO>();
            CreateMap<AddressDTO, Address>();



            
        }
    }
}