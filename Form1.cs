/***********************************************************
*   Josiah Martin
*   Lab #2
*   August 17, 2022
*   I did write this code myself...
***********************************************************/

using RegistrationSystem.BusinessClasses;

namespace RegistrationSystem
{
    public partial class TestClassForm : Form
    {
        public TestClassForm()
        {
            InitializeComponent();
        }

        // method called when the form button is clicked
        private void testAddrBtn_Click(object sender, EventArgs e)
        {
            Address addr = new Address("901 Ct", "Roswell", "GA", 40112);

            addr.display();
        }

        // method called when the 'Test Course' button is clicked
        private void testCourseBtn_Click(object sender, EventArgs e)
        {
            /*Course course = new Course("CIST 1001", "C# II", "Learn how to create applications using C# .NET framework.", 4);*/
            /*Course course = new Course();*/
            /*course.SelectDB("CIST 1001");*/
            Course course = new Course("CIST 1313", "Intro to Python", "xxxxxxx", 4);
            course.CourseName = "this is a test";
            course.Description = "Some text";
            course.DeleteDB();
            course.display();
        }

        // method called when the user clicks on 'Test Section' button
        private void testSectionBtn_Click(object sender, EventArgs e)
        {
            Section section = new Section(20314, "1001", "Mondays 1:00PM - 2:00PM", "F1115", 1002);
            /*Section section = new Section();*/
            /*section.SelectDB(30105);*/
            section.CourseID = "2002";
            section.RoomNo = "F2221";
            section.DeleteDB();
            section.Display();
        }

        // method called when the user clicks 'Test Person' button
        private void personBtn_Click(object sender, EventArgs e)
        {
            Person p = new Person("Tony", "Stanza", "tstanza@yahoo.com", new Address("707 Red Ct", "Atlanta", "Ga", 20341));
            Section[] sections = new Section[3];

            sections[0] = new Section(20314, "1001", "Mondays 1:00PM - 2:00PM", "F1115", 1002);
            sections[1] = new Section(30123, "1002", "Tuesdays 5:00PM - 6:00PM", "B2222", 1003);
            sections[2] = new Section(45634, "1003", "Thursdays 12:00PM - 1:00PM", "M33333", 1004);

            p.add(sections[0]);
            p.add(sections[1]);
            p.add(sections[2]);
            p.Display();
        }

        // method called when the user clicks 'Test Instructor' button
        private void instructorBtn_Click(object sender, EventArgs e)
        {
            Instructor i = new Instructor("David", "Bowing", "d.bowing@outlook.com", new Address("909 Blue Ct", "Atlanta", "Ga", 40302), 1001, "F2001");
            /*Section[] sections = new Section[3];

            sections[0] = new Section(20314, "1001", "Mondays 1:00PM - 2:00PM", "F1115", 1002);
            sections[1] = new Section(30123, "1002", "Tuesdays 5:00PM - 6:00PM", "B2222", 1003);
            sections[2] = new Section(45634, "1003", "Thursdays 12:00PM - 1:00PM", "M33333", 1004);

            i.add(sections[0]);
            i.add(sections[1]);
            i.add(sections[2]);*/
            /*Instructor instructor = new Instructor();
            instructor.SelectDB(2);*/
            i.FirstName = "Joe";
            i.LastName = "Nate";
            i.Address.State = "KY";
            i.DeleteDB();
            i.Display();
        }

        // method called when the user clicks 'Test Student' button
        private void studentBtn_Click(object sender, EventArgs e)
        {
            Student s = new Student("Alfred", "Wayne", "a.wayne@outlook.com", new Address("808 Yellow Ct", "Atlanta", "Ga", 50323), 3001, 3.96);
            /*Section[] sections = new Section[10];

            sections[0] = new Section(20314, "1001", "Mondays 1:00PM - 2:00PM", "F1115", 1002);
            sections[1] = new Section(30123, "1002", "Tuesdays 5:00PM - 6:00PM", "B2222", 1003);
            sections[2] = new Section(45634, "1003", "Thursdays 12:00PM - 1:00PM", "M33333", 1004);

            s.add(sections[0]);
            s.add(sections[1]);
            s.add(sections[2]);*/
            /*Student s = new Student();
            s.SelectDB(4);*/
            s.FirstName = "Joe";
            s.LastName = "Nate";
            s.Gpa = 4.0;
            s.DeleteDB();
            s.Display();
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();

            Section[] sections = new Section[10];

            sections[0] = new Section(20314, "1001", "Mondays 1:00PM - 2:00PM", "F1115", 1002);
            sections[1] = new Section(30123, "1002", "Tuesdays 5:00PM - 6:00PM", "B2222", 1003);
            sections[2] = new Section(45634, "1003", "Thursdays 12:00PM - 1:00PM", "M33333", 1004);

            schedule.add(sections[0]);
            schedule.add(sections[1]);
            schedule.add(sections[2]);


            /*schedule.Display();*/

            schedule.drop(1);

            schedule.Display();

            System.Diagnostics.Debug.WriteLine(schedule.ToString());
        }
    }
}