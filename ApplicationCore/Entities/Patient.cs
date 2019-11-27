using System;
using System.Collections.Generic;
using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities
{
    public class Patient : Person,IAggregateRoot
    {

        public Patient(string id, string name, bool gender, DateTime birthday, Address address, string phone) : base(id, name, gender, birthday, address, phone)
        {
            
        }

        public Patient()
        {
        }

        private List<PayForm> _payForm = new List<PayForm>();
        IEnumerable<PayForm> payForms => _payForm.AsReadOnly();
         public ICollection<Enrollments> Enrollment{get; set;}

        // public Patient(string name, bool gender, DateTime birth, Address address)
        // {
        //     PatientName = name;
        //     Gender = gender;
        //     Birthday = birth;
        //     Address = address;
        // }

    }

}