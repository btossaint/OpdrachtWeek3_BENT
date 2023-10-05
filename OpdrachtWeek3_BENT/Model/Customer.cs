using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtWeek3_BENT.Model
{
    public class Customer
    {
        private string companyname;
        private string contactPerson;
        private string phoneNumber;
        private string street;
        private int number;
        private string zipcode;
        private string city;
        private string country;

        public Customer(string _companyname, string _contactPerson, string _phoneNumber)
        {
            companyname     = _companyname;
            contactPerson   = _contactPerson;
            phoneNumber     = _phoneNumber;                    
        }

        public string ContactPerson { get => contactPerson; }
        public string Companyname { get => companyname; }

        public void ChangePhoneNumber(string _phoneNumber)
        {
            phoneNumber     = _phoneNumber;
        }

        public void SetAddress(string _street, int _number, string _zipcode, string _city, string _country)
        {
            street  = _street;
            number  = _number;
            zipcode = _zipcode;
            city    = _city;
            country = _country;
        }
    }
}
