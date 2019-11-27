using System.Collections.Generic;
namespace ApplicationCore.Entities
{
    
    public class Address: ValueObject
    {
        public string Num { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public Address() { }

        public Address(string num, string street, string district, string city, string state, string country)
        {
            Num = num;
            Street = street;
            District = district;
            City = city;
            State = state;
            Country = country;
        }
        protected override IEnumerable<object> GetAtomicValues()
        {
            // Using a yield return statement to return each element one at a time
            yield return Num;
            yield return Street;
            yield return District;
            yield return City;
            yield return State;
            yield return Country;
        }
        public string toString()
        {
            if (string.IsNullOrEmpty(this.State)) return string.Format("{0} {1}, {2}, {3}, {4}", this.Num, this.Street, this.District, this.City, this.Country);
            return string.Format("{0} {1}, {2}, {3} {4}, {5}", this.Num, this.Street, this.District, this.City, this.State, this.Country);
        }
        public void toValue(string address)
        {
            IList<string> list = StringExec.RegexSplit(address, "[\\,]?[\\s]+");
            this.Num = list[0];
            this.Street = list[1];
            this.District = list[2];
            this.City = list[3];
            if (list.Count == 5)
            {
                this.State = null;
                this.Country = list[4];
            }
            else
            {
                this.State = list[4];
                this.Country = list[5];
            }
        }
    }
}