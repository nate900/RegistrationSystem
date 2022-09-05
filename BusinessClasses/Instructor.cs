using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**********************************************************************************************
*   Josiah Martin
*   Lab #3
*   August 29, 2022
*   I did write this code myself...
 *********************************************************************************************/
namespace RegistrationSystem.BusinessClasses
{
    // Instructor inherits from Person
    public class Instructor : Person
    {
        public int Id { get; set; }
        public string Office { get; set; }

        // no-arg constructor
        public Instructor()
        {
            // set the type attribute to identify the object
            Id = 0;
            Office = "";
        }

        // constructor with arguments
        public Instructor(string firstName, string lastName, string email, Address address, int id, string office)
            : base(firstName, lastName, email, address)
        {
            Id = id;
            Office = office;
        }

        // overriding the ToString() method inherited from the Object class
        override public string ToString() { return "ID : " + Id + "\nOffice : " + Office + "\n" + base.ToString(); }

        // Instructor's own display method
        public void Display() { Console.WriteLine(ToString()); System.Diagnostics.Debug.WriteLine(ToString()); }
    }
}
