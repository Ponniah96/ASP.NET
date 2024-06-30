using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    internal class CollectionDictionary
    {
        public void defintion()
        {
            Console.WriteLine("Definition");
            Console.WriteLine("Dictionary is a generic collection class that contains data of Key, value pairs");
            Console.WriteLine();

            //Prerequisites
            Console.WriteLine("Prerequistes of dictionary");
            Console.WriteLine("1.Key values should not be null and it should be unique");
            Console.WriteLine("2.Both key and value should contain similar data type while we initalizing dictionary");
            Console.WriteLine();

            //Methods
            Console.WriteLine("Methods of Initialize Dictionary");
            Console.WriteLine("1.Dictionary() - class empty  - capacity default - equlaity comparer deafult");
            Console.WriteLine("2.Dictionary(IDictionary<T key, T Value> dictionary()) - class specified elements -  capacity default - equlaity comparer deafult");
            Console.WriteLine("3.Dictionary(IEnumerable<T key, T Value> dictionary()) - class specified elements -  capacity default - equlaity comparer deafult");
            Console.WriteLine("4.Dictionary(IEqualityComparer<T key?> dictionary()) - class empty -  capacity default - equlaity comparer contains specified elements");
            Console.WriteLine("5.Dictionary(int capacity) - class empty  - capacity specified - equlaity comparer deafult");
            Console.WriteLine("6.Dictionary(IEnumerable<T key, T Value>, IEqualityComparer<T key?>) - class specified elements - capacity default - equlaity comparer contains specified elements");
            Console.WriteLine("7.Dictionary(IEqualityComparer<T key?>, int capacity) - class empty - capacity specified - equlaity comparer contains specified elements");
            Console.WriteLine("8.Dictionary(SerializedInfo, SerializedData)- Dictionary contains serialized data");
            Console.WriteLine();

            //Initialization
            Console.WriteLine("Initialzing Dictionary");
            Console.WriteLine("Syntax: Dictionary<T Key, T value> dictionary_name = new Dictionary(){}");
            Dictionary<int, string> countries = new Dictionary<int, string>();
            Console.WriteLine();

            //Assigning values
            Console.WriteLine("Methods to assign Values in Dictionary:");
            //Using Add Method
            Console.WriteLine("1.Using Add Method");
            countries.Add(1, "India");
            countries.Add(2, "Pakistan");
            //Using Initialization method
            Console.WriteLine("2.Using Initialization Constructor");
            Dictionary<int, string> newCountries = new Dictionary<int, string>()
            {
                {3,"United Kingdom" },
                {4, "United States"}
            };
            //Using Indexer Method
            countries[5] = "Russia";
            Console.WriteLine();

            //Accessing Values
            Console.WriteLine("Methods to access dictionary Values");
            //Using Keys
            Console.WriteLine("1.Using keys");
            Console.WriteLine($"Array Elements at Index 0:{countries[1]}");
            Console.WriteLine($"Array Elements at Index 1:{countries[2]}");
            //Using For Loop
            Console.WriteLine("2.Using For Loop");
            for (int i = 0; i < countries.Count; i++)
            {
                int keys = countries.Keys.ElementAt(i);
                string value = countries[keys];
                Console.WriteLine($"Keys:{keys}, Value:{value}");
            }
            //using forEach Loop
            Console.WriteLine("3.Using ForEach Loop");
            foreach(KeyValuePair<int, string> pair in countries) { 
                Console.WriteLine($"Keys: {pair.Key}, Value: {pair.Value}");
            }
            //Using Parallel ForAll()
            Console.WriteLine("4.Using AsParallel ForAll()") ;
            countries.AsParallel().ForAll(x => Console.WriteLine($"Keys:{x.Key}, Value: {x.Value}"));
            Console.WriteLine();

            //Update Element using Indexer
            Console.WriteLine("Update Element using Indexer") ;
            countries[5] = "Russia Updated";
            Console.WriteLine($"UPdated Value: {countries[5]}");
            Console.WriteLine() ;

            //Remove Elements
            //Using Remove(T Key)
            Console.WriteLine("1.Using Remove()");
            Console.WriteLine("Before Removing Element");
            foreach (KeyValuePair<int, string> pair in countries)
            {
                Console.WriteLine(pair.Value);
            }
            Console.WriteLine("Removing Russia");
            countries.Remove(5);
            Console.WriteLine("After Removing Element");
            foreach (KeyValuePair<int, string> pair in countries)
            {
                Console.WriteLine(pair.Value);
            }
            //Using Clear Method
            Console.WriteLine("Using Clear()");
            Console.WriteLine($"Before Removing Element:{newCountries.Count}");
            newCountries.Clear();
            Console.WriteLine($"After Removing Element:{newCountries.Count}");


            //Complex Data Structure
            Employee employee1 = new Employee()
            {
                Id = 2851,
                Name = "Ponniah",
            };
            Employee employee2 = new Employee()
            {
                Id = 4030,
                Name = "Kothandaraman",
            };
            Dictionary<int, Employee> employee = new Dictionary<int, Employee>()
            {
                {1, employee1},
                {2, employee2}
            };
            //Print Complex Data
            Console.WriteLine("print Employee data");
            foreach (KeyValuePair<int, Employee> data in employee)
            {
                Console.WriteLine($"Keys:{data.Key}, Employee ID:{data.Value.Id}, Employee Name: {data.Value.Name}");
            }
            Console.WriteLine();

            //Array to Dictionary
            Console.WriteLine("Convet Array to Dictioanry: ArrayName.ToDictionary()");
            Console.WriteLine();


            //Trygetvalue
            Console.WriteLine("TryGetValue");
            Console.WriteLine("Syntax: dictionary_name.trygetValue(Key, out variable)");
        }

    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
