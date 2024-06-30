using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_SQL_Server_Basics
{
    internal class ADOBasics
    {
        public void definiton()
        {
            Console.WriteLine("ADO Stands for ACtiveX Data Objects");
            Console.WriteLine("ADO.NET is a microsoft data access technology which is used to communicate data from Data Sources to .NET Application");
            Console.WriteLine("ADO.NET uses predefined class to connect, retrieve, CRUD operation with data sources");
            Console.WriteLine();

            //Data Sources
            Console.WriteLine("Data Sources:");
            Console.WriteLine("SQL Server");
            Console.WriteLine("Oracle");
            Console.WriteLine("MySQL");
            Console.WriteLine("XML");
            Console.WriteLine();

            //Components of ADO.NET
            Console.WriteLine("Components of ADO.NET");
            Console.WriteLine("1.ADO.NET Providers");
            Console.WriteLine("1.1.Connection : Used to connect DB - SQLConnection");
            Console.WriteLine("1.2.Command : Used to write queries - SQLCommand");
            Console.WriteLine("1.3.DataReader: Used to read DB - SQLDataReader");
            Console.WriteLine("1.4.DataStreamer: Used to conncet bridge between DB & Code - SQLDataStreamer");
            Console.WriteLine("2.ADO.NET DataSet");
            Console.WriteLine("2.1.DataSet : Create own memory Cache from DB anf perform own operations");
            Console.WriteLine("2.2.DataTable|: Create own ttable from DataSet tto do queries on top of them");
            Console.WriteLine("2.3.DataView: Used to ddo srt, ffilter query from Datasset");
            Console.WriteLine("2.4.ConnectionSttring: ");
            Console.WriteLine() ;

            //Advantages
            Console.WriteLine("Advantages of ADO.NEtT");
            Console.WriteLine("1.Flexibility");
            Console.WriteLine("2.Disconnected from DB- Use thier own DataSet");
            Console.WriteLine("3.Control over DatBase, DBConnection Management");
            Console.WriteLine("4.legacy applications usedd");
            Console.WriteLine();

            //Disadvantagess
            Console.WriteLine("Disadvantages of ADO.NET");
            Console.WriteLine("1.Lower level of abstyractions"); ;
            Console.WriteLine("2.Difficult for maintenance"); ;
            Console.WriteLine("3.Difficult to learning"); ;
            Console.WriteLine("4.Maintenance OverHeading");
            Console.WriteLine("5.Not suitable for rapid devel;opment");
            Console.WriteLine("6.Updation required to met current standards");
            Console.WriteLine();

            //Alternate option
            Console.WriteLine("Alternate option for ADO.NET"); ;
            Console.WriteLine("Considereing high level abstraction and efficient performance kindly use below optionss");
            Console.WriteLine("1.Entity framwork");
            Console.WriteLine("2.ORM (Dapper ORM)");
        }
    }
}
