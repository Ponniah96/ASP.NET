using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADODotNetSQLServerBasics
{
    internal class ADODotNETSqlServerConnection
    {
        public void definition()
        {
            Console.WriteLine("Welcome to ADO.Net SQL Server Connection");

            Console.WriteLine();
            Console.WriteLine();

            //Instantiate SQL Connection
            SqlConnection sqlConnection = null;
            try
            {
                //Connect SQL Server
                string connectionString = "data source=DEV-LPT336\\SQLEXPRESS; database=ADO.NET;integrated security=SSPI";
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Connection Established");
                Console.WriteLine();

                //Create Table
                string createTable = "Create Table Employee17(ID int not null, Name varchar(100), Age int, Gender varchar(20), Department varchar(25), Experience int)";
                SqlCommand createTableCommand = new SqlCommand(createTable, sqlConnection);
                createTableCommand.ExecuteNonQuery();
                Console.WriteLine("Table Created");
                Console.WriteLine();

                //Insert Records in Table
                string insertSingleRecordString = "insert into Employee17(Id,Name,Age,Gender,Department,Experience) values(2851,'Ponniah', 26, 'Female', 'Development', 5)";
                SqlCommand insertSingleRecord = new SqlCommand(insertSingleRecordString, sqlConnection);
                insertSingleRecord.ExecuteNonQuery();
                Console.WriteLine("Single Record Inserted");
                Console.WriteLine();

                //Insert Multiple Records
                string insertRecordOneString = "insert into Employee17(Id,Name,Age,Gender,Department,Experience) values(2851,'Ponniah', 26, 'Female', 'Development', 5)";
                string insertRecordTwoString = "insert into Employee17(Id,Name,Age,Gender,Department,Experience) values(4030, 'Kothandaraman', 57, 'Male', 'Admin', 30)";
                string insertRecordThreeString = "insert into Employee17(Id,Name,Age,Gender,Department,Experience) values(1023, 'Trisha', 24, 'Female', 'HR', 4)";
                string insertRecordFourString = "insert into Employee17(Id,Name,Age,Gender,Department,Experience) values(1994, 'Ajith', 25, 'Male', 'Finance', 5)";
                string insertRecordFiveString = "insert into Employee17(Id,Name,Age,Gender,Department,Experience) values(2010, 'Vijay', 35, 'Male', 'Travel', 15)";
                string insertRecordSixString = "insert into Employee17(Id,Name,Age,Gender,Department,Experience) values(7612, 'Dhanush', 26, 'Female', 'Development', 5)";
                string insertRecordSevenString = "insert into Employee17(Id,Name,Age,Gender,Department,Experience) values(1276, 'Nayanthara', 57, 'Female', 'Admin', 30)";
                string insertRecordEightString = "insert into Employee17(Id,Name,Age,Gender,Department,Experience) values(7912,'Prasanth', 24, 'Male', 'HR', 4)";
                string insertRecordNineString = "insert into Employee17(Id,Name,Age,Gender,Department,Experience) values(4562,'Dinesh', 25, 'Male', 'Finance', 5)";
                string insertRecordTenString = "insert into Employee17(Id,Name,Age,Gender,Department,Experience) values(7652,'Ganesh', 35, 'Male', 'Travel', 15)";
                SqlCommand insertRecordOne = new SqlCommand(insertRecordOneString, sqlConnection);
                SqlCommand insertRecordTwo = new SqlCommand(insertRecordTwoString, sqlConnection);
                SqlCommand insertRecordThree = new SqlCommand(insertRecordThreeString, sqlConnection);
                SqlCommand insertRecordFour = new SqlCommand(insertRecordFourString, sqlConnection);
                SqlCommand insertRecordFive = new SqlCommand(insertRecordFiveString, sqlConnection);
                SqlCommand insertRecordSix = new SqlCommand(insertRecordSixString, sqlConnection);
                SqlCommand insertRecordSeven = new SqlCommand(insertRecordSevenString, sqlConnection);
                SqlCommand insertRecordEight = new SqlCommand(insertRecordEightString, sqlConnection);
                SqlCommand insertRecordNine = new SqlCommand(insertRecordNineString, sqlConnection);
                SqlCommand insertRecordTen = new SqlCommand(insertRecordTenString, sqlConnection);
                insertRecordOne.ExecuteNonQuery();
                insertRecordTwo.ExecuteNonQuery();
                insertRecordThree.ExecuteNonQuery();
                insertRecordFour.ExecuteNonQuery();
                insertRecordFive.ExecuteNonQuery();
                insertRecordSix.ExecuteNonQuery();
                insertRecordSeven.ExecuteNonQuery();
                insertRecordEight.ExecuteNonQuery();
                insertRecordNine.ExecuteNonQuery();
                insertRecordTen.ExecuteNonQuery();
                Console.WriteLine("Multiple Record Inserted");
                Console.WriteLine();

                //Update Values
                string updateValuesString = "Update Employee17 Set Gender='Female' where ID=4030";
                SqlCommand updateValues = new SqlCommand(updateValuesString, sqlConnection);
                updateValues.ExecuteNonQuery();
                Console.WriteLine("Table Values Updated");
                Console.WriteLine() ;

                //Delete Tables
                string deleteValuesString = "Delete TOP(1) From Employee17";
                SqlCommand deleteValues = new SqlCommand(deleteValuesString, sqlConnection);
                deleteValues.ExecuteNonQuery();
                Console.WriteLine("Table Values Deleted");
                Console.WriteLine();


                //Display All Records using SQL Data Reader
                string selectAllValuesString = "Select * From Employee17";
                SqlCommand selectAllValues = new SqlCommand(selectAllValuesString, sqlConnection);
                SqlDataReader reader = selectAllValues.ExecuteReader();               
                Console.WriteLine("Display table values using Data Reader");
                while (reader.Read())
                {
                    Console.WriteLine(reader["ID"] + "\t" + reader["Name"] + "\t" + reader["Age"] + "\t" + reader["Gender"] + "\t" + reader["Department"] + "\t" + reader["Experience"]);
                }
                Console.WriteLine();
                reader.Close();

                //Display All Records using SQL Data Reader
                string selectAllValuesStrings = "Select * From Employee17";
                SqlDataAdapter adapter = new SqlDataAdapter(selectAllValuesStrings, sqlConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
               
                Console.WriteLine("Display table values using Data Adapter");
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine(row["ID"] + "\t" + row["Name"] + "\t" + row["Age"] + "\t" + row["Gender"] + "\t" + row["Department"] + "\t" + row["Experience"]);
                }
                Console.WriteLine();


                //Display Stored Procedure
                SqlCommand storedProcedureData = new SqlCommand()
                {
                    CommandText = "spGroupByDepartment",
                    CommandType = CommandType.StoredProcedure,
                    Connection = sqlConnection
                };
                SqlDataReader storedResultSet = storedProcedureData.ExecuteReader();
                Console.WriteLine("Display Stored Result Values");
                Console.WriteLine("Department  TotalEmployee");
                while (storedResultSet.Read())
                {
                    Console.WriteLine(storedResultSet["department"] + "\t" + storedResultSet["TotalEmployee"]);
                }

            }
            catch (Exception ex) { Console.WriteLine($"Exception Details: {ex.ToString()}"); }
            finally { sqlConnection?.Close(); }
        }
    }
}
