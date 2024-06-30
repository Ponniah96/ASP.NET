using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerBasics
{
    internal class SQLServerClasses
    {
        public void definition()
        {
            //Select Statement
            Console.WriteLine("SQL Select Statement");
            Console.WriteLine("SQL Select Statement is used to select records of data from one or more tables and display it in a row");
            Console.WriteLine("SQL Select Statement will not staore any data. it will just fetch data");
            Console.WriteLine("Select statement is used to display all coluns or specfic columns");
            Console.WriteLine("Syntax:\nSelect * from TABLE_NAME;\nSelect COLUMN_NAME1, COLUMN_NAME2 from TABLE_NAME");

            Console.WriteLine();
            Console.WriteLine();

            //SQL Classes
            Console.WriteLine("SQL Classes");
            Console.WriteLine("SQL Classes is used to get additional information of table");
            Console.WriteLine();
            Console.WriteLine("Types of SQL Classes");
            Console.WriteLine("1.Where - Filtering Operations");
            Console.WriteLine("2.Top - Fetching Top records");
            Console.WriteLine("2.1.percent - Fetching Top percent of rows");
            Console.WriteLine("3.Order By - Sort Rows");
            Console.WriteLine("4.Group By - grouping rows");
            Console.WriteLine("5.having Class");

            Console.WriteLine();
            Console.WriteLine();

            //SQL Where Classes
            Console.WriteLine("Where Class");
            Console.WriteLine("SQL Where Class is used to filter rows from table");
            Console.WriteLine();
            Console.WriteLine("Methods to use Where class");
            Console.WriteLine("1.Where Classes used in select statement:");
            Console.WriteLine("1.1.Syntax: Select * from table_name where column_name='test'");
            Console.WriteLine("2.Where class used in update statement");
            Console.WriteLine("2.1.Syntax: Update * from table_name where column_name='test'");
            Console.WriteLine("3.Where class used in delete statement");
            Console.WriteLine("3.1.Syntax: Delete * from table_name where column_name='test'");
            Console.WriteLine();
            Console.WriteLine("Types of additional operators in Where class");
            Console.WriteLine("Using AND operator");
            Console.WriteLine("Using OR Operator");
            Console.WriteLine("Using both AND , OR operator");


            Console.WriteLine();
            Console.WriteLine();


            //SQL Order By Class
            Console.WriteLine("SQL Order By Class");
            Console.WriteLine("SQL Order By class is used to sort data in ascending or descecning order");
            Console.WriteLine("In Default SQL Order By Class is Ascending order");
            Console.WriteLine("Ascending Order: Select * FROM Table ORDER BY Name ASC");
            Console.WriteLine("Descending Order: Select * FROM Table ORDER BY Name DESC");
            Console.WriteLine();
            Console.WriteLine("Order using Relative Position");
            Console.WriteLine("Syntax: SELECT Name, Age From Table ORDER BY 1 ASC (where 1- Name)");
            Console.WriteLine();
            Console.WriteLine("Both ASC, DESC Keyword in single statement");
            Console.WriteLine("At that time, it will consider only 1st OrderBy class. If it's not matched in the sense, it will take next SQL class");
            Console.WriteLine();
            Console.WriteLine("Offset");
            Console.WriteLine("Offset is used to remove top rows");
            Console.WriteLine("Syntax: SELECt * FROM Table OFFSET 5 ROWS");
            Console.WriteLine();
            Console.WriteLine("Fetch");
            Console.WriteLine("Fecth is used to display next set of rows afgter offset rows");
            Console.WriteLine("Syntax: SELECT * FROM table OFFSET 5 rows FETCH next 5 rows");


            Console.WriteLine();
            Console.WriteLine();


            //SQL Top Class
            Console.WriteLine("SQL Top Class");
            Console.WriteLine("SQL Top class is used to retrieve daata from top records of the table");
            Console.WriteLine("Syntax: SELECT TOP (3) Name FROM table");
            Console.WriteLine();
            Console.WriteLine("Features of Top Clause");
            Console.WriteLine("1.Percent Class: Percent Class is used to get top percentage of records");
            Console.WriteLine("1.1.Syntax: SELECT TOP (30) PERCENT Name from Table");
            Console.WriteLine("2.With Ties: It is used to display records having (same values, but it drops because of Top values exceeded");
            Console.WriteLine("2.1.Syntax: SELECT TOP (3) WITH TIES Name from Table ");

            Console.WriteLine();
            Console.WriteLine();


            //SQL Group By Class
            Console.WriteLine("SQL Group By class");
            Console.WriteLine("SQL Group By Class is used to group data and perform aggregate function");
            Console.WriteLine();
            Console.WriteLine("SQL Group BY aggregare Functions:");
            Console.WriteLine("1.SUM");
            Console.WriteLine("2.COUNT");
            Console.WriteLine("3.MAX");
            Console.WriteLine("4.MIN");
            Console.WriteLine("5.Avg");
            Console.WriteLine();
            Console.WriteLine("Syntax:\nSELECT Name, COUNT(*) AS TotalRecords\nFROM table \nGROUP BY Name");

            Console.WriteLine();
            Console.WriteLine();


            //SQL Having Clause
            Console.WriteLine("SQL Having Clause");
            Console.WriteLine("SQL Having Clause is similar to Where clause. It is used to filtering rows followed by Group By Clause");
            Console.WriteLine();
            Console.WriteLine("Difference between Having and Group By Clause");
            Console.WriteLine("1.Having Clause: Exexute After GroupBy aggregate function completes. It will also have aggregare functions");
            Console.WriteLine("2.Where Clause: Execute before GriupBY aggregate function. It will not accept aggregate functions");
            Console.WriteLine();
            Console.WriteLine("Syntax:\nSELECT Name, Count(*) AS TotalEmployee \nFROM table \nGROUP BY Name \nHAVING Age>5");

            Console.WriteLine();
            Console.WriteLine();

            //SQL Stored Procedures
            Console.WriteLine("SQL Stored procedures");
            Console.WriteLine("SQL Stroed Procedures is a block of code which is used to perform some action similar to JavaScript functions");
            Console.WriteLine("Advantages");
            Console.WriteLine("1.Stored Procedures cache Syntax & Procedure method while executing first time itself and directly execute query to improve preformance by reduce load time");
            Console.WriteLine("2.We can also parameters in stored procedures");
            Console.WriteLine("Syntax");
            Console.WriteLine("CREATE PROCEURE spProceureName \nAS \nBEGIN \nSELECT * FROM TABLE \nEND");


        }
    }
}
