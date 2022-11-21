using System;

namespace Models
{
    public abstract class User
    {
        public static int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { 
            get
            {
                return GetName();
            }
        }
        public int PhoneNumber { get; set; }
        public Address Address { get; set; }
        public DateTime DOB { get; set; }

        public User(string firstName, string lastName, int phoneNumber, Address address, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Address = address;
            DOB = dateOfBirth;
        }
        
        private string GetName()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public int GetAge()
        {
            int age = DateTime.Now.Year - this.DOB.Year;
            return age;
        }
    }
}
