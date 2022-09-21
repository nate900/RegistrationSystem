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
        public void SelectDB(int id)
        {
            Id = id;
            DBSetup();
            cmd = "SELECT * FROM Students WHERE ID = " + id + ";";
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
                FirstName = (string)dr.GetValue(1);
                LastName = (string)dr.GetValue(2);
                Address.Street = (string)dr.GetValue(3);
                Address.City = (string)dr.GetValue(4);
                Address.State = (string)dr.GetValue(5);
                Address.Zip = dr.GetInt32(6);
                Email = (string)dr.GetValue(7);
                Gpa = dr.GetFloat(8);
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
            cmd = "UPDATE Students SET FirstName = '" + FirstName + "', LastName = '" + LastName + "', Street = '" + Address.Street + "', City = '" + Address.City + "', State = '" + Address.State + "', Zip = " + Address.Zip + ", EMail = '" + Email + "', GPA = " + Gpa + " WHERE ID = " + Id + ";"; 
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
            cmd = "DELETE FROM Students WHERE ID = " + Id + ";";
            OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
            OleDbDataAdapter2.DeleteCommand.Connection = OleDbConnection2;
            Console.WriteLine(cmd);
            System.Diagnostics.Debug.WriteLine(cmd);
            try
            {
                // delete from database
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
            cmd = "INSERT INTO Students VALUES(" + Id + ", '" + FirstName + "', '" + LastName + "', '" + Address.Street + "', '" + Address.City + "', '" + Address.State + "', '" + Address.Zip + "', '" + Email + "', " + Gpa + ");";
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

        // overriding the ToString() method inherited from the Object class
        override public string ToString() { return "ID : " + Id + "\nGPA : " + Gpa.ToString("F") + "\n" + base.ToString(); }

        // Student's own display method
        public void Display() { Console.WriteLine(ToString()); System.Diagnostics.Debug.WriteLine(ToString()); }
    }
}
