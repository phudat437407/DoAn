using System;

namespace ApplicationCore.Entities
{
    public class Person
    {
        public Person() {}
        public Person(string id,string name, bool gender,DateTime birthdate,Address address,string phone )
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.BirthDate = birthdate;
            this.Phone = phone;
            this.Address = address;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public Account Account { get; set; }
    }
}