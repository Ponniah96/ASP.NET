using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    internal class CollectionList
    {
        public void definition()
        {
            Console.WriteLine("List<T> is generic list collection class using System.Collections.Generic namespace");
            Console.WriteLine();

            //Simple Type

            //Initialize List
            Console.WriteLine("Initialize List Collection");
            Console.WriteLine("Syntax: List<T> listName = new List<T>()");
            List<string> Countries = new List<string>();
            Console.WriteLine();


            //Add Elements to List
            Console.WriteLine("Adding Elements List Collection - It will add elements at end of list");
            Console.WriteLine("Methods to add elements in List");
            Console.WriteLine("1.Using Add() Method");
            Console.WriteLine("2.Using AddRange() Method");
            Console.WriteLine("3.Add Elements directly at end of initalization");
            //Add Elements while initialize list
            List<string> newCountries = new List<string>()
            {
                "United Kingdom",
                "Russia"
            };
            //Add Method
            Countries.Add("India");
            Countries.Add("United States");
            //AddRange Method
            Countries.AddRange(newCountries);


            //Accessing List Elements
            Console.WriteLine("Accesing List Elements");
            Console.WriteLine("methods to access list elements");
            Console.WriteLine("1.Using Index position");
            //Access using index position
            string CountryName = Countries[0];
            Console.WriteLine($"Index 0 : {CountryName}");
            //Access using for loop
            Console.WriteLine("2.Usind for loop");
            for (var i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine(Countries[i]);
            }
            //Access using forEach Loop
            Console.WriteLine("3.Using forEach loop");
            foreach (var country in Countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine() ;


            //Insert elements
            Console.WriteLine("Insert List Elements");
            Console.WriteLine("Methods to insert list elements");
            //Using Insert()
            Console.WriteLine("1.Using Insert()");
            Countries.Insert(1, "Pakistan");
            Console.WriteLine("After Insert Pakistan into countries");
            foreach (var country in Countries)
            {
                Console.WriteLine(country);
            }
            //Using InsertRange()
            Console.WriteLine("2.User InserTange()");
            Countries.InsertRange(2, newCountries);
            foreach (var country in Countries)
            {
                Console.WriteLine(country);
            }

            //Remove List Elements
            Console.WriteLine("Remove List Elements");
            Console.WriteLine("Methods to Remove List Elements");
            //Using Remove()
            Console.WriteLine("1.Using Remove()");
            Countries.Remove("United States");
            Console.WriteLine("After Removing United States");
            foreach (var country in Countries)
            {
                Console.WriteLine(country);
            }
            //Using RemoveAll()
            Console.WriteLine("1.Using RemoveAll()");
            Countries.RemoveAll(x=>x=="United Kingdom");
            Console.WriteLine("After Removing All United kingdom");
            foreach (var country in Countries)
            {
                Console.WriteLine(country);
            }
            //Using RemoveAt()
            Console.WriteLine("1.Using RemoveAt()");
            Countries.RemoveAt(3);
            Console.WriteLine("After Removing 3 index");
            foreach (var country in Countries)
            {
                Console.WriteLine(country);
            }
            //Using RemoveRange()
            Console.WriteLine("1.Using Removerange()");
            Countries.RemoveRange(2,1);
            Console.WriteLine("After Removing Range 2, 1");
            foreach (var country in Countries)
            {
                Console.WriteLine(country);
            }
            //Using Clear()
            Console.WriteLine("1.Using Clear()");
            newCountries.Clear();
            Console.WriteLine("After Clear method");
            Console.WriteLine();

            //Find List Elements
            Console.WriteLine("Find Elements in List");
            Console.WriteLine("Methods to find elements");
            Console.WriteLine("1.Find()");
            Console.WriteLine("2.FindAll()");
            Console.WriteLine("3.FindLast()");
            Console.WriteLine("4.FindIndex()");
            Console.WriteLine("5.FindLastIndex()");
            Console.WriteLine("6.Contains()");
            Console.WriteLine("7.Exists()");
            Console.WriteLine($"Using Contains method to find India: {Countries.Contains("India")}");
            Console.WriteLine();

            //Complex Type
            Employee employee = new Employee(){
                Id=1,
                Name= "Ponniah"
            };
            Employee employee2 = new Employee()
            {
                Id = 2,
                Name = "Kothandaraman"
            };
            List<Employee> list = new List<Employee>();
            list.Add(employee);
            list.Add(employee2);
            Console.WriteLine("Complex type");
            Console.WriteLine("Display Employee Data");
            foreach(Employee emp in list)
            {
                Console.WriteLine($"Employee ID: {emp.Id} , Employee Name: {emp.Name}");
            }
            Console.WriteLine();

            //Important Methods in Generic List Class
            Console.WriteLine("Important methods of generic list class");
            Console.WriteLine("1.TrueForAll()");
            Console.WriteLine("2.AsReadOnly()");
            Console.WriteLine("2.1.Syntax: System.Collections.ObjectModel.ReadOnlyCollection<Employee> readOnlyEmployees = listEmployees.AsReadOnly()");
            Console.WriteLine("3.TrimExcess() - Find Capacity of element");
            Console.WriteLine("3.1.Find capacity of list using listElement.Capcatiy");
            Console.WriteLine("3.2.Syntax: listElement.TrimExcess()");
        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
