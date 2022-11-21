using System;

namespace Models
{
    public class Representative : User 
    {
        public string Company { get; set; }
        public string[] Licenses { get; set; }

        public Representative(string firstName, string lastName, int phoneNumber, Address address, DateTime dateOfBirth, string company, string[] licenses)
            : base(firstName, lastName, phoneNumber, address, dateOfBirth)
        {
            this.Company = company;
            this.Licenses = licenses;
        }
    }
}
