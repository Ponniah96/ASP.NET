using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ADO.NET_SQL_Server_Basics
{
    internal class ADODotNet_SQL_Server_Basic_Query
    {
        public void SqlConnections()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("data source =DEV-LPT336\\SQLEXPRESS; database = ADO.NETBasicDB; integrated security = SSPI");
                connection.Open();
                Console.WriteLine("DB Conencted successfully");
            }
            catch(Exception e) { Console.WriteLine($"OOPS Something went wrong: {e}");}
            finally { connection?.Close(); Console.WriteLine("DB Closed successfully"); }
        }

        public void SqlCreateTable()
        {
            SqlConnection connection = null;
            try 
            {
                //Creating DB Connection
                connection = new SqlConnection("data source=DEV-LPT336\\SQLEXPRESS; database=ADO.NETBasicDB; integrated security = SSPI");

                //Create Table
                SqlCommand createTable = new SqlCommand("create table " +
                    "SqlServerBasicsTable(name varchar(100),age int not null, gender varchar(15)" +
                    ")", connection);
                
                //Connect DB
                connection.Open();

                //Execute Query
                createTable.ExecuteNonQuery();

                Console.WriteLine("Table Created");
            }
            catch(Exception e) { Console.WriteLine(e.ToString()); } 
            finally 
            {
                //Close connection
                connection?.Close();
            }
        }

        public void SqlInsertRecord()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("data source=DEV-LPT336\\SQLEXPRESS; database=ADO.NETBasicDB;integrated security=SSPI");

                //Insert Data into Table
                SqlCommand insertRecord = new SqlCommand("insert into SqlServerBasicsTable(name,age,gender) values('Ponniah',26,'Male')",connection);

                connection.Open();

                insertRecord.ExecuteNonQuery();
            }
            catch(Exception e) { Console.WriteLine($"Error Values: {e.ToString()}"); }
            finally
            {
                connection?.Close();
            }
        }

        public void SqlInsertMultipleRecords()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("data source=DEV-LPT336\\SQLEXPRESS; database=ADO.NETBasicDB;integrated security=SSPI");

                //Insert Data into Table
                SqlCommand insertRecord = new SqlCommand("insert into SqlServerBasicsTable(name,age,gender) values('Parvathy',25,'Female')", connection);
                SqlCommand insertRecord1 = new SqlCommand("insert into SqlServerBasicsTable(name,age,gender) values('Kothandaraman',57,'Male')", connection);
                SqlCommand insertRecord2 = new SqlCommand("insert into SqlServerBasicsTable(name,age,gender) values('Seethalakshmi',53,'Female')", connection);

                connection.Open();

                insertRecord.ExecuteNonQuery();
                insertRecord1.ExecuteNonQuery();
                insertRecord2.ExecuteNonQuery();
            }
            catch (Exception e) { Console.WriteLine($"Error Values: {e.ToString()}"); }
            finally
            {
                connection?.Close();
            }
        }

        public void SqlDeleteRecords()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("data source=DEV-LPT336\\SQLEXPRESS; database=ADO.NETBasicDB;integrated security=SSPI");

                //Dlete Data into Table
                SqlCommand deleteRecord = new SqlCommand("delete TOP(2) from SqlServerBasicsTable", connection);
               
                connection.Open();

                deleteRecord.ExecuteNonQuery();

                Console.WriteLine("Delete Records form tbale successfully");
            }
            catch (Exception e) { Console.WriteLine($"Error Values: {e.ToString()}"); }
            finally
            {
                connection?.Close();
            }
        }

        public void SqlReader()
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection("data source=DEV-LPT336\\SQLEXPRESS; database=ADO.NETBasicDB;integrated security=SSPI");
                //Get all the Records
                SqlCommand getAllRecords = new SqlCommand("Select * from SqlServerBasicsTable", connection);

                connection.Open();

                SqlDataReader sqlDataReader = getAllRecords.ExecuteReader();

                Console.WriteLine("Name\t\tAge\tGender");
                while (sqlDataReader.Read())
                {
                    Console.WriteLine(sqlDataReader["name"] + "\t" + sqlDataReader["age"] + "\t" + sqlDataReader["gender"]);
                }


            }
            catch(Exception e) { Console.WriteLine(e.ToString()); }
            finally
            {
                connection?.Close();
            }
        }

        public void SqlDataTable() 
        {
            SqlConnection connection = null;

            try
            {
                string connectionString = "data source=DEV-LPT336\\SQLEXPRESS; database=ADO.NETBasicDB;integrated security=SSPI";
                connection = new SqlConnection(connectionString);

                string selectQuery = "Select * from SqlServerBasicsTable";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, connection);

                connection.Open();

                //Using Data Table
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                Console.WriteLine();
                Console.WriteLine("Using Data Table");
                Console.WriteLine("Name\t\tAge\tGender");
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine(row["name"]+"\t"+ row["age"] + "\t"+row["gender"]);
                }


                //Using Data Set
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "ADO.NETBasicDB");

                Console.WriteLine();
                Console.WriteLine("Using Data Set");
                Console.WriteLine("Name\t\tAge\tGender");
                foreach (DataRow rows in dataSet.Tables["SqlServerBasicsTable"].Rows)
                {
                    Console.WriteLine(rows);
                }
            }
            catch(Exception e) { }
            finally
            {
                connection?.Close();
            }
        }

        public void SQLStoredProcedures()
        {
            Console.WriteLine("Inside Stored Procedure");
            SqlConnection connection = null;
            try
            {
                string connectionString = "data source=DEV-LPT336\\SQLEXPRESS;database=ADO.NETBasicDB;integrated security=SSPI";
                connection = new SqlConnection(connectionString);

                //Using Data Adapter Get All Data from DB
                string getAllData = "Select * From SqlServerBasicsTable";
                SqlDataAdapter sqlDataAdapter  = new SqlDataAdapter(getAllData,connection);

                //Open Connection
                connection.Open();

                //Create Data Table
                DataTable tableData = new DataTable();

                //Create Object Instance of SQL Data Adapter
                sqlDataAdapter.Fill(tableData);

                //Display All Table Data
                Console.WriteLine("Display All Data using DataTable Method");
                Console.WriteLine("Name\t\tAge\tGender");
                foreach (DataRow row in tableData.Rows)
                {
                    Console.WriteLine(row["name"] + "\t" + row["age"] + "\t" + row["gender"]);
                }

                Console.WriteLine();
                

                //Invoke Stored Procedure to get Name fields alone
                SqlCommand storeProcedureData = new SqlCommand()
                {
                    CommandText = "spGetName",
                    Connection = connection,
                    CommandType = CommandType.StoredProcedure,
                };

                //Read SQL Data
                SqlDataReader displayStoreProcedureData = storeProcedureData.ExecuteReader();

                //Print StoredProcedure data
                Console.WriteLine("Display Stored Procedure Data");
                Console.WriteLine("Name");
                while(displayStoreProcedureData.Read())
                {
                    Console.WriteLine(displayStoreProcedureData["name"]);
                }


            }
            catch (Exception e) { Console.WriteLine($"Exception: {e.ToString()}"); }
            finally { connection?.Close(); }
        }

    }
}
