using System;
using ApplicationCore.Interfaces;
using System.Collections.Generic;
//using ApplicationCore.Entities.DoctorAggregate;
namespace ApplicationCore.Entities
{
    public class Doctor : Person, IAggregateRoot
    {
        public Doctor()
        {
        }

        public Doctor(string id, string name, bool gender, DateTime birthday,Address address, string phone) : base(id, name, gender, birthday, address, phone)
        {
        }
    }
}