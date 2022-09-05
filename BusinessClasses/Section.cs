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
    public class Section
    {
        public string CRN { get; set; }
        public int CourseID { get; set; }
        public string TimeDay { get; set; }
        public string RoomNo { get; set; }
        public int InstructorID { get; set; }

        // no-arg constructor
        public Section()
        {
            CRN = "";
            CourseID = 0;
            TimeDay = "";
            RoomNo = "";
            InstructorID = 0;
        }

        // constructor with arguments
        public Section(string crn, int courseId, string timeDay, string roomNo, int instructorId)
        {
            CRN = crn;
            CourseID = courseId;
            TimeDay = timeDay;
            RoomNo = roomNo;
            InstructorID = instructorId;
        }

        override public string ToString() { return "CRN : " + CRN + " Course ID : " + CourseID + " Time Day : " + TimeDay + " Room No : " + RoomNo + " Instructor ID : " + InstructorID; }

        public void Display()
        {
            Console.WriteLine(ToString());
            System.Diagnostics.Debug.WriteLine(ToString());
        }

    }
}
