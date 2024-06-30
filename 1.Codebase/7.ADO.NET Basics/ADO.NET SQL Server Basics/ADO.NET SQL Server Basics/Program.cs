// See https://aka.ms/new-console-template for more information
using ADO.NET_SQL_Server_Basics;

Console.WriteLine("ADO.NET and SQL Server Basics");

Console.WriteLine();
Console.WriteLine();

//ADO Introduction
Console.WriteLine("ADO Introduction");

ADOBasics aDOBasics = new ADOBasics();
aDOBasics.definiton();

Console.WriteLine();
Console.WriteLine();

//ADO.NET SQL Server Connection
Console.WriteLine("ADO.Net SQL Server Connection");
ADODotNet_SQL_Server_Basic_Query aDODotNet_SQL_Server_Basic_Query = new ADODotNet_SQL_Server_Basic_Query();
//Connect SQL Server
//aDODotNet_SQL_Server_Basic_Query.SqlConnections();
//Create Table in SQL Server DB
//aDODotNet_SQL_Server_Basic_Query.SqlCreateTable();
//Insert Record in SQL Server DB
//aDODotNet_SQL_Server_Basic_Query.SqlInsertRecord();
//Insert multiple records
//aDODotNet_SQL_Server_Basic_Query.SqlInsertMultipleRecords();
//Delete Record
//aDODotNet_SQL_Server_Basic_Query.SqlDeleteRecords();
//Display Record
//aDODotNet_SQL_Server_Basic_Query.SqlReader();
//SQL Data Adapter using Data Table
//aDODotNet_SQL_Server_Basic_Query.SqlDataTable();
//SQL Stored Procedure
aDODotNet_SQL_Server_Basic_Query.SQLStoredProcedures();