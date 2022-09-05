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
    // base class Person
    // could also be declared as an abstract class
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; } // Addresss property
        private Schedule _schedule; // private Schedule property

        // no-arg constructor
        public Person()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            Address = new Address();
            _schedule = new Schedule(); // instantiate a new Schedule object
        }

        // constructor with arguments
        public Person(string firstName, string lastName, string email, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            _schedule = new Schedule(); // instantiate a new Schedule object
        }

        // method to add a section to the person's schedule
        public void add(Section section)
        {
            _schedule.add(section);
        }

        // method to drop a section from the person's schedule
        // must be given an index
        public void drop(int index)
        {
            _schedule.drop(index);
        }

        // overriding the ToString() method inherited from the Object class
        override public string ToString()
        {


            return "First Name : " + FirstName + "\nLast Name : " + LastName + "\nEmail : " + Email + "\nAddress\n" + Address.ToString() + _schedule.ToString();
        }

        // Person's own display method to write the person object to the console window
        public void Display()
        {
            Console.WriteLine(ToString());
            System.Diagnostics.Debug.WriteLine(ToString());
        }
    }
}
