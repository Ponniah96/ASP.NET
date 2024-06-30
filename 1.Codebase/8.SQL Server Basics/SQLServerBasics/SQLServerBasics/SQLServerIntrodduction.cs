using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerBasics
{
    internal class SQLServerIntrodduction
    {
        public void definition()
        {
            
            //SQL Server Basics
            Console.WriteLine("SQL:");
            Console.WriteLine("SQL is a Structured Query Language in which language act as a compiler to create, alter, drop tables, dB, Views, Stored procedures, functions etc"); ;
            Console.WriteLine("SQL is a commaon lanuage used for SQL Server, MySQL, Oracle etc");
            Console.WriteLine("SQL is a case-insensitive and end with semicolums");
            Console.WriteLine("Difference between SQL Server and SSMS");
            Console.WriteLine("SQL Server is a Database");
            Console.WriteLine("SSMS is a tool to conncet SQL Server Database"); 
            Console.WriteLine("SQL Server is a RDBMS developed by Microsoft");
            Console.WriteLine("Transact SQL is an extension of SQL  used for SQL Server");


            Console.WriteLine();
            Console.WriteLine();

            //SQL Sub languages
            Console.WriteLine("SQL Sub Languages");
            Console.WriteLine("1.Data Definiton Language");
            Console.WriteLine("1.1.Definition");
            Console.WriteLine("DDL is used to create,alter,drop structure of table, views, SP");
            Console.WriteLine("DDL is used to change structure of table not data of table");
            Console.WriteLine("1.2.Commands of DDL");
            Console.WriteLine("1.2.1.Create - Create command is used to create table,DB, views, SP");
            Console.WriteLine("1.2.2.Alter  - Alter Command is used to change Table, column names, data types, add or delete new columns ");
            Console.WriteLine("1.2.3.SP_RENAME - SP_Rename is used to rename table as well as column names");
            Console.WriteLine("1.2.4.Truncate  - Truncate is used to remve data from table. It won't use where statemanet");
            Console.WriteLine("1.2.5.Drop - Drop is used to drop table from DB");
            Console.WriteLine();
            Console.WriteLine("2.Data Manipulation Language");
            Console.WriteLine("2.1.Definition");
            Console.WriteLine("Data Manipulatin Language is used to manipulate data from Table,DB");
            Console.WriteLine("2.2.Commands");
            Console.WriteLine("2.2.1.Delete");
            Console.WriteLine("2.2.2.Remove");
            Console.WriteLine();
            Console.WriteLine("3.Data Query Language");
            Console.WriteLine("3.1.Commands");
            Console.WriteLine("3.1.1.Select");
            Console.WriteLine();
            Console.WriteLine("4.Transaction Control Language");
            Console.WriteLine("4.1.Commands");
            Console.WriteLine("4.1.1.Commit");
            Console.WriteLine("4.1.2.Rollback");
            Console.WriteLine();
            Console.WriteLine("5.Data Control Language");
            Console.WriteLine("5.1.Commands");
            Console.WriteLine("5.1.Revoke");
            Console.WriteLine("5.1.2.Grant");


            //SQL Queries to Create, Rename, Delete table
            Console.WriteLine("SQL Server Query to Create, rename, delete database");
            Console.WriteLine("Create database TestDB;\nAlter database TESTDB Modify Name=TestDB;\nDrop database TestDB;");

            Console.WriteLine();
            Console.WriteLine();



            //SQLServer Data Types
            Console.WriteLine("SQL Server Data Types");
            Console.WriteLine("1.Integer");
            Console.WriteLine("2.Decimal");
            Console.WriteLine("2.1.Precision (0-36)");
            Console.WriteLine("2.1.1.Precise (Before & After decimal points 3.21)");
            Console.WriteLine("2.1.2.Scale (After decimal point .21)");
            Console.WriteLine("2.2.Numeric points");
            Console.WriteLine("3.Character");
            Console.WriteLine("3.1.Unicode");
            Console.WriteLine("3.1.1.Nchar()");
            Console.WriteLine("3.1.1.Nvarchar() - dynamically adjust size preferable");
            Console.WriteLine("3.1.1.Ntext()");
            Console.WriteLine("3.2.Non Unicode");
            Console.WriteLine("3.2.1.char()");
            Console.WriteLine("3.2.1.varchar() - dynamically adjust size preferable");
            Console.WriteLine("3.2.1.text()");
            Console.WriteLine("4.Cuurent to text");
            Console.WriteLine("5.Binary - Video, audio, Image upto 2GB");
            Console.WriteLine("6.Special characters - Timestamp");
            Console.WriteLine("7.Date time: YYYY-MM-DD hh:mm:ss:ms");


            Console.WriteLine();
            Console.WriteLine();

            //SQL Server Constraints
            Console.WriteLine("Data inetgrity");
            Console.WriteLine("To maintain Data accuracy, stability,consistency in DB is called Data integrrity");
            Console.WriteLine();
            Console.WriteLine("SQL Server Constraints");
            Console.WriteLine("To maintain data integerity, SQL server uses constraints");
            Console.WriteLine();
            Console.WriteLine("Types f SQL Server Constraints");
            Console.WriteLine("1.NOT NULL Constarints");
            Console.WriteLine("1.1.Syntax: column_name int NOTNULL");
            Console.WriteLine("2.Default Constarints");
            Console.WriteLine("2.1.Syntax: column_name int DEFAULT 10");
            Console.WriteLine("3.UNIQUE Constraints");
            Console.WriteLine("3.1.Syntax: column_name int UNIQUE");
            Console.WriteLine("4.CHECK Constraints");
            Console.WriteLine("4.1.Syntax: column_name int CHECK(column_name>10)");
            Console.WriteLine("5.PRIMARY Key Constraints");
            Console.WriteLine("5.1.Definition:");
            Console.WriteLine("5.1.1. Primary Key is used to create column with UNIQUE + NOT NULL Constarints");
            Console.WriteLine("5.1.2.Primary Key are used to create unique value of table");
            Console.WriteLine("5.2.Syntax: COLUMNNAME int PRIMARY_KEY");
            Console.WriteLine("5.3.Difference between Primary Key and UNique");
            Console.WriteLine("5.3.1.Primary Key accpts Unique+Not Null Values alone, whereas Unique allow null");
            Console.WriteLine("5.3.2.Primary Key contains Unique clustered collections , Unique contains non-clustered collections");
            Console.WriteLine("5.4.Composite Priary Key Syntax: PRIMARY KEY (COLUMN_NAME1, COLUMN_NAME2)");
            Console.WriteLine("6.FOREIGN Key Constarints");
            Console.WriteLine("6.1.Definition");
            Console.WriteLine("6.1.1.Foreign Key Constarints are used to link between 2 tables with the help of common columns");
            Console.WriteLine("6.1.2.Common Column might not be same name but must be same data type");
            Console.WriteLine("6.1.3.Common column referenced from master table is either Primary key or Unique Key or Null values");
            Console.WriteLine("6.2.Methods to create froign key");
            Console.WriteLine("6.2.1.Create Column Level Foreign Key:");
            Console.WriteLine("6.2.1.1.Syntax:  COLUMNNAME Int CONSTRAINT constaint_name REFERENCE MASTER_TABLE");
            Console.WriteLine("6.2.2.Create Table Level Foreign Key:");
            Console.WriteLine("6.2.2.1.Syntax: CONSTRAINT contraint_name INT(COLUMN NAME) FOREIGN KEY REFERENCE MASTER_TABLE");
            Console.WriteLine();
            Console.WriteLine("Custom Constraint");
            Console.WriteLine("Custom Constraints are the constraint name we can derive it on our own");
            Console.WriteLine("Methods towrite Custom Constaints");
            Console.WriteLine("1.Define Custom Constraints at Column Level");
            Console.WriteLine("1.1.Syntax: column_name int CONSTRAINTS constraint_name UNIQUE");
            Console.WriteLine("2.Define Custom Constraints at Table Level");
            Console.WriteLine("2.1.Syntax: column_name int \n CONSTRAINT constaint_name UNIQUE(column_name)");
            Console.WriteLine("3.Composite Constraints");
            Console.WriteLine("3.1.Syntax: CONSTRAINT constraint_name UNIQUE(columna_name1, column_name2)");

            Console.WriteLine();
            Console.WriteLine();


            //Identity Column
            Console.WriteLine("Identity Column");
            Console.WriteLine("Identity Column is used as auto increment value for column. We cannot manually add identity columnvaues"); ;
            Console.WriteLine("Syntax: COLUMN_NAME int identity(1,2); where 1-seed, 2-increment value");
            Console.WriteLine("Manually add Identity Column:"); ;
            Console.WriteLine("Set Manually ON identity Column: SET IDENTITY_INSERT TABLE_NAME ON");
            Console.WriteLine("Set Manually OFF identity Column: SET IDENTITY_INSERT TABLE_NAME OFF");


            Console.WriteLine();
            Console.WriteLine();

            //Sequence Object
            Console.WriteLine("Sequence Object");
            Console.WriteLine("Sequence Object is an object created used to update values automatically");
            Console.WriteLine("Features of Sequence Objects");
            Console.WriteLine("1.Start Value");
            Console.WriteLine("2.End Value");
            Console.WriteLine("3.Increment");
            Console.WriteLine("4.Min Value");
            Console.WriteLine("5.Max value");
            Console.WriteLine("6.Cycle");
            Console.WriteLine("7.Cache");
            Console.WriteLine("Syntax");
            Console.WriteLine("Create Sequence [dbo].[sequenceObj]\nAS INT \nSTART with 1 \nINCREMENT 1");
            Console.WriteLine();
            Console.WriteLine("CREATE Table Table_Name\n(ID int PrimaryKey,\nName varchar(50))");
            Console.WriteLine();
            Console.WriteLine("Insert into Table_Name values\n(NEXT VALUE for [dbo].[sequenceObj] ID, 'Ponniah)");

            Console.WriteLine();
            Console.WriteLine();



        }
    }
}
