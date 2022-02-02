using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Modules
{
    public class Address
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string PostalCode { get; set; }
        
        public Address(string country, string state, string city, string streetname, int streetnumber, string postalcode)
        {
            this.Country = country;
            this.State = state;
            this.City = city;
            this.StreetName = streetname;
            this.StreetNumber = streetnumber;
            this.PostalCode = postalcode;
        }
        public Address(string country, string state, string city, string streetname, int streetnumber)
        {
            this.Country = country;
            this.State = state;
            this.City = city;
            this.StreetName = streetname;
            this.StreetNumber = streetnumber;
            
        }
        public Address(string postalcode)
        {
            
            this.PostalCode = postalcode;
        }
    }
}
