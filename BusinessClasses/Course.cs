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
    public class Course
    {
        // all public getters and setters
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int CreditHours { get; set; }

        // no-arg constructor
        public Course()
        {
            CourseID = 0;
            CourseName = "";
            Description = "";
            CreditHours = 0;
        }

        // constructor with arguments
        public Course(int courseID, string courseName, string description, int creditHours)
        {
            CourseID = courseID;
            CourseName = courseName;
            Description = description;
            CreditHours = creditHours;
        }


        override public string ToString()
        {
            return "Course ID : " + CourseID + " Course Name : " + CourseName + " Description : " + Description + " Credit Hours : " + CreditHours;
        }

        public void display()
        {
            System.Diagnostics.Debug.WriteLine(ToString());
            Console.WriteLine(ToString());
        }
    }
}
