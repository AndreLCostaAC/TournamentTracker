using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }
        public int Id { get; internal set; }

        public string FullName
        {
            get
            {
                return $"{Name} {LastName}";
            }
        }

        public PersonModel() { }

        public PersonModel(string name, string lastName, string emailAddress, string phoneNumber)
        {
            Name = name;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;

        }
    }

}
