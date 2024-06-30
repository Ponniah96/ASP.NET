using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    delegate void DelegateMethodd(string name);
    internal class Delegates
    {
        public void definition()
        {
            Console.WriteLine("Delaegates is a type that hold refernce of method which continas both arguments and return type");
            Console.WriteLine("It use as a callback for passing method as argument to anoither method");
            Console.WriteLine();
            Console.WriteLine("Prerequisites");
            Console.WriteLine("1.Use Delegate Keyword create delegate variable");
            Console.WriteLine("2.Make sure both type of method and arguments should match");

            //Assign delegate
            Console.WriteLine("Assign Delegates");
            DelegateMethodd getName = DisplayName;
            getName("Ponniah Kothandaraman");

            //Add Delegates Methods
            Console.WriteLine("Add Delegate Method: Using \'+=\'");
            getName += RemainingConcepts;
            getName("Events, Lamba Expression");

            //Remove Delegates Methods
            Console.WriteLine("Remove Delegate Method: Using \'-=\'");
            getName -= RemainingConcepts;
            getName("After Removing delagates");
            Console.WriteLine();

            //Anonymous Methods
            Console.WriteLine("Anonymous Methods");
            Console.WriteLine("Anonymous methods in delegates we can use delegate instance directly without calling seperate method");
            //Declaration
            DelegateMethodd getAnonymousValue = delegate (string name) { Console.WriteLine($"Display Data using method: {name}"); };
            getAnonymousValue("Anonymous");

        }

        public static void DisplayName(string name)
        {
            Console.WriteLine($"Welcome to Delegate:{name}");
        }

        public static void RemainingConcepts(string name)
        {
            Console.WriteLine($"Remnaining Concepts:{name}");
        }
    }
}
