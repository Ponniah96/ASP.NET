// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.IO;

Console.WriteLine("Enum, Files");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Enum");
Console.WriteLine("Enum is special type of class which contains group of constants"); 
Console.WriteLine("Use \'Enum\' Keyword  we can define enumerations");
Console.WriteLine("We can access enum like accessing class usong objects");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Files");
Console.WriteLine("C# Files are used to read/write/delete files contents"); 
Console.WriteLine("To access file methods we have to use syntax \'file.someMethod()\' ");
Console.WriteLine("important methods of files");
Console.WriteLine("1.Create()");
Console.WriteLine("2.WriteAllText()");
Console.WriteLine("3.ReadAlltext()");
Console.WriteLine("4.Replace()");
Console.WriteLine("5.Copy()");
Console.WriteLine("6.AppendText()");

Console.WriteLine();
Console.WriteLine("Create new File");
File.Create("newFile.txt");
Console.WriteLine("File created");
Console.WriteLine();
Console.WriteLine("Write text File");
//File.WriteAllText("newFile1.txt", "hello world");
Console.WriteLine(); 
Console.WriteLine("Read Text File");
string readText = File.ReadAllText("newFile1.txt");
Console.WriteLine($"File Data: {readText}");




