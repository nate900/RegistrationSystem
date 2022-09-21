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
        public int CRN { get; set; }
        public string CourseID { get; set; }
        public string TimeDay { get; set; }
        public string RoomNo { get; set; }
        public int InstructorID { get; set; }

        // no-arg constructor
        public Section()
        {
            CRN = 0;
            CourseID = "";
            TimeDay = "";
            RoomNo = "";
            InstructorID = 0;
        }

        // constructor with arguments
        public Section(int crn, string courseId, string timeDay, string roomNo, int instructorId)
        {
            CRN = crn;
            CourseID = courseId;
            TimeDay = timeDay;
            RoomNo = roomNo;
            InstructorID = instructorId;
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
        public void SelectDB(int crn)
        {
            CRN = crn;
            DBSetup();
            cmd = "SELECT * FROM Sections WHERE CRN = " + crn + ";";
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
                CourseID = (string)dr.GetValue(1);
                TimeDay = (string)dr.GetValue(2);
                RoomNo = (string)dr.GetValue(3);
                InstructorID = dr.GetInt32(4);
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

        // UpdateDB method
        public void UpdateDB()
        {
            DBSetup();
            cmd = "UPDATE Sections SET CourseID = '" + CourseID + "', TimeDays = '" + TimeDay + "', RoomNo = '" + RoomNo + "', Instructor = " + InstructorID + " WHERE CRN = " + CRN + ";";
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

        // DeleteDB method
        public void DeleteDB()
        {
            DBSetup();
            cmd = "DELETE FROM Sections WHERE CRN = " + CRN + ";";
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

        // InsertDB method
        public void InsertDB()
        {
            DBSetup();
            cmd = "INSERT INTO Sections VALUES(" + CRN + ", '" + CourseID + "', '" + TimeDay + "', '" + RoomNo + "', " + InstructorID + ");";
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

        override public string ToString() { return "CRN : " + CRN + " Course ID : " + CourseID + " Time Day : " + TimeDay + " Room No : " + RoomNo + " Instructor ID : " + InstructorID; }

        public void Display()
        {
            Console.WriteLine(ToString());
            System.Diagnostics.Debug.WriteLine(ToString());
        }

    }
}
