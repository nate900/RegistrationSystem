using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***********************************************************
*   Josiah Martin
*   Lab #2
*   August 17, 2022
*   I did write this code myself...
***********************************************************/

namespace RegistrationSystem.BusinessClasses
{
    public class Address
    {
        // all getter and setters or properties of the Address class
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        // constructor with no arguments
        public Address()
        {
            Street = "";
            City = "";
            State = "";
            Zip = 0;
        }

        // constructor with arguments
        public Address(string street, string city, string state, int zip)
        {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }

        override public string ToString()
        {
            return "Street : " + Street + ", City : " + City + ", State : " + State + ", Zip code : " + Zip + "\n";
        }

        public void display()
        {
            // Sometimes the output window will not show output using Console.WriteLine() when using a form app
            // I included both lines of console window output just in case something was not working
            System.Diagnostics.Debug.WriteLine(ToString());
            Console.Write(ToString());
        }
    }
}
