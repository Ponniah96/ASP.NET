using Dapper;
using dapperORM.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dapperORM
{
    internal class dapperQuery
    {
        public void dapperCreateInstance()
        {
            SqlConnection connection = null;
            string connectionString = "data source=DEV-LPT336\\SQLEXPRESS; database=ADO.NETBasicDB;integrated security=SSPI";
            connection = new SqlConnection(connectionString);
            connection.Open();

            //Get All Records
            IEnumerable<SQLServerData> data = connection.Query<SQLServerData>("select * from SqlServerBasicsTable");
            foreach (SQLServerData dataItem in data)
            {
                Console.WriteLine(dataItem.name.ToString());
            }

            //Get Selected records
            IEnumerable<SQLServerData> selectedData = connection.Query<SQLServerData>("select * from SqlServerBasicsTable where age=@age", new{age=26} );
            foreach (SQLServerData dataItem in selectedData)
            {
                Console.WriteLine($"Selected Data Name: {dataItem.name.ToString()}");
            }

            //Get Selected Records in Proper method
            var queryText = "Select * from SqlServerBasicsTable where age=@age";
            var param = new { age = 25 };
            IEnumerable<SQLServerData> selectedDataStandardFormat = connection.Query<SQLServerData>(queryText, param);
            foreach (SQLServerData dataItem in selectedDataStandardFormat)
            {
                Console.WriteLine($"Selected Data Name: {dataItem.name.ToString()}");
            }

            //Get Multiple Selected record
            var queryMultipleText = "Select * from SqlServerBasicsTable where age in @age";
            var multipleParams = new { age =  new List<int> { 25, 26 } };
            IEnumerable<SQLServerData> selectedMultipleDataStandardFormat = connection.Query<SQLServerData>(queryMultipleText, multipleParams);
            foreach (SQLServerData dataItem in selectedMultipleDataStandardFormat)
            {
                Console.WriteLine($"Selected Data Multiple Names: {dataItem.name.ToString()}");
            }

            //Update Value
            var updateQueryRecord = "Update SqlServerBasicsTable set name = @name, age = @age, gender = @gender where age = @getAge";
            var updateParamsValue = new { name = "Ponniah", age = 27,gender ="Male",getAge=26 };
            var updateQueryRecords = connection.Execute(updateQueryRecord, updateParamsValue);
            Console.WriteLine($"Update Status of Query: {updateQueryRecords}");

            //Insert New Record
            var insertQueryRecord = "Insert into SqlServerBasicsTable values (@name,@age,@gender)";
            var insertParamsValue = new { name = "Gomathi", age = 30, gender = "Female" };
            var insertNewRecord = connection.Execute(insertQueryRecord, insertParamsValue);
            Console.WriteLine($"Insert New Record: {insertNewRecord}");

            //Delete Record
            var deleteQueryRecord = "Delete from SqlServerBasicsTable where age=@age";
            var deleteParamsValue = new { age = 30 };
            var deleteRecord = connection.Execute(deleteQueryRecord, deleteParamsValue);
            Console.WriteLine($"Delete Record in table, {deleteRecord}");
        }
    }
}
