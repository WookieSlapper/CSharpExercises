using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Contact
    {
        private DateTime dateOfBirth;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Name: {0}\r\n", this.fullName);
            stringBuilder.AppendFormat("Date of Birth: {0}\r\n", this.DateOfBirth);

            return stringBuilder.ToString();
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                this.dateOfBirth = value;
            }
        }

        public string firstName
        {
            get;
            set;
        }

        public string lastName
        {
            get;
            set;
        }

        public string fullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

          public Contact()
        {
        }

          public Contact(string firstName, string lastName)
              : this()
          {
              this.firstName = firstName;
              this.lastName = lastName;
          }

        public Contact(string firstName, string lastName, DateTime dateOfBirth): this()
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.DateOfBirth = dateOfBirth;
    }

        public bool VerifyEmailAddress(string emailAddress)
    {
        if (emailAddress == "joe@example.com")
        {
            return true;
        }
        else
        {
            return false;
        }
    }


        public void Search(float latitude, float longitude, int distance = 10, string culture = "en-US")
        {
            Console.WriteLine("latitude: {0}, longitude: {1}, distance: {2}, culture: {3}", latitude, longitude, distance, culture);
        }


    }
}
