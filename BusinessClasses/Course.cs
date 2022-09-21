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
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int CreditHours { get; set; }

        // no-arg constructor
        public Course()
        {
            CourseID = "";
            CourseName = "";
            Description = "";
            CreditHours = 0;
        }

        // constructor with arguments
        public Course(string courseID, string courseName, string description, int creditHours)
        {
            CourseID = courseID;
            CourseName = courseName;
            Description = description;
            CreditHours = creditHours;
        }

        //++++++++++++++++  DATABASE Data Elements +++++++++++++++++
        private System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
        private System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
        private System.Data.OleDb.OleDbConnection OleDbConnection2;
        private string cmd;

        private void DBSetup()
        {
            // +++++++++++++++++++++++++++  DBSetup function +++++++++++++++++++++++++++++++
            OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            OleDbConnection2 = new System.Data.OleDb.OleDbConnection();

            //OleDbDataAdapter1
            OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand2;
            OleDbDataAdapter2.InsertCommand = OleDbInsertCommand2;
            OleDbDataAdapter2.SelectCommand = OleDbSelectCommand2;
            OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand2;

            OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" +
            "ocking Mode=1;Data Source=C:\\Users\\josia\\OneDrive\\Desktop\\RegistrationSystem\\RegistrationSystem\\DB\\RegistrationMDB.mdb;J" +
            "et OLEDB:Engine Type=5;Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:System datab" +
            "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
            "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
            "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
            "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";
        }  //end DBSetup()

        // selectDB method
        public void SelectDB(string courseId)
        {
            CourseID = courseId;
            DBSetup();
            cmd = "SELECT * FROM Courses WHERE CourseID = '" + courseId + "';";
            OleDbDataAdapter2.SelectCommand.CommandText = cmd;
            OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            System.Diagnostics.Debug.WriteLine(cmd);
            try
            {
                OleDbConnection2.Open();
                System.Data.OleDb.OleDbDataReader dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                // read data
                dr.Read();
                CourseName = (string)dr.GetValue(1);
                Description = (string)dr.GetValue(2);
                CreditHours = dr.GetInt32(3);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
            finally
            {
                OleDbConnection2.Close();
            }
        }

        // UpdateDB method
        public void UpdateDB()
        {
            DBSetup();
            cmd = "UPDATE Courses SET CourseName = '" + CourseName + "', Description = '" + Description + "', CreditHours = " + CreditHours + " WHERE CourseID = '" + CourseID + "';";
            OleDbDataAdapter2.UpdateCommand.CommandText = cmd;
            OleDbDataAdapter2.UpdateCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            System.Diagnostics.Debug.WriteLine(cmd);
            try
            {
                // update the database
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                Console.WriteLine((n == 1) ? "Data Updated" : "Error: did not update data properly");
                System.Diagnostics.Debug.WriteLine((n == 1) ? "Data Updated" : "Error: did not update data properly");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
            finally
            {
                OleDbConnection2.Close();
            }
        }

        // DeleteDB method
        public void DeleteDB()
        {
            DBSetup();
            cmd = "DELETE FROM Courses WHERE CourseID = '" + CourseID + "';";
            OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
            OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            System.Diagnostics.Debug.WriteLine(cmd);
            try
            {
                // delete from the database
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();
                Console.WriteLine((n == 1) ? "Data Deleted" : "Error: did not delete data properly");
                System.Diagnostics.Debug.WriteLine((n == 1) ? "Data Deleted" : "Error: did not delete data properly");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
            finally
            {
                OleDbConnection2.Close();
            }
        }

        // InsertDB method
        public void InsertDB()
        {
            DBSetup();
            cmd = "INSERT INTO Courses VALUES('" + CourseID + "', '" + CourseName + "', '" + Description + "', " + CreditHours + ");";
            OleDbDataAdapter2.InsertCommand.CommandText = cmd;
            OleDbDataAdapter2.InsertCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            System.Diagnostics.Debug.WriteLine(cmd);
            try
            {
                // insert into database
                OleDbConnection2.Open();
                int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                Console.WriteLine((n == 1) ? "Data Inserted" : "Error: did not insert data properly");
                System.Diagnostics.Debug.WriteLine((n == 1) ? "Data Inserted" : "Error: did not insert data properly");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
            finally
            {
                OleDbConnection2.Close();
            }
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
