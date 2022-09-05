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
    // Studnet inherits from Person
    public class Student : Person
    {
        public int Id { get; set; }
        public double Gpa { get; set; }

        // no-arg constructor
        public Student()
        {
            // set the type attribute to identify the object
            Id = 0;
            Gpa = 0.0;
        }

        // constructor with arguments
        public Student(string firstName, string lastName, string email, Address address, int id, double gpa)
            : base(firstName, lastName, email, address)
        {
            Id = id;
            Gpa = gpa;
        }

        // overriding the ToString() method inherited from the Object class
        override public string ToString() { return "ID : " + Id + "\nGPA : " + Gpa + "\n" + base.ToString(); }

        // Student's own display method
        public void Display() { Console.WriteLine(ToString()); System.Diagnostics.Debug.WriteLine(ToString()); }
    }
}
