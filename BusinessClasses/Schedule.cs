using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***********************************************************
*   Josiah Martin
*   Lab #2
*   September 11, 2022
*   I did write this code myself...
***********************************************************/

namespace RegistrationSystem.BusinessClasses
{
    public class Schedule
    {
        // private _count property
        private int _count;

        // private _sections proptery to keep track of the number of sections in each schedule
        private List<Section> _sections;

        // public Count proptery to get the value of the private property
        public int Count { get { return _count; } }

        // no-arg constructor
        public Schedule()
        {
            _count = 0;
            _sections = new List<Section>();
        }

        // public add section function
        public void add(Section s)
        {
            _count++;
            _sections.Add(s);
        }

        // public drop section function
        public void drop(int index)
        {
            _count--;
            _sections.RemoveAt(index);
        }

        // override inherited ToString method from the Object class
        public override string ToString()
        {
            string scheduleStr = string.Empty;
            foreach (Section s in _sections)
            {
                scheduleStr += s.ToString() + "\n";
            }
            return "Schedule\nNumber of Sections : " + Count + "\nSections count : " + _sections.Count + "\n" + scheduleStr;
        }

        // Schedule's own display method
        public void Display()
        {
            foreach (Section section in _sections)
            {
                section.Display();
            }
        }
    }
}
