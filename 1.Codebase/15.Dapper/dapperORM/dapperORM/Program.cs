// See https://aka.ms/new-console-template for more information
using dapperORM;

Console.WriteLine("Welcome to Dapper");

Console.WriteLine();
Console.WriteLine();

//Dapper Introduction
DapperIntroduction dapperIntroduction = new DapperIntroduction();
dapperIntroduction.definition();

//Dapper Query
dapperQuery dapperquery = new dapperQuery();
dapperquery.dapperCreateInstance();