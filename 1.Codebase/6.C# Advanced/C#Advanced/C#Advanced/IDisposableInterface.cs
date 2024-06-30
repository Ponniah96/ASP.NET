using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    internal class IDisposableInterface
    {
        public void defintion() {
            Console.WriteLine("IDisposable interface is used to relaese or make free of used/unrequired resources");
            Console.WriteLine("Instead of calling IDisposable interface keyword follow below steps");
            Console.WriteLine("1.In ref struuct, don't use IDisposable interface");
            Console.WriteLine("2.Inside ref struct, use public void dispose() ");
            Console.WriteLine("3. In Main method use \'using\' kwyword to create instance of ref struct");
        }

    }

    ref struct IDisposableMethod
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IDisposableMethod(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void DisplayFullName() { 
            Console.WriteLine($"Display FullName using IDisposable Method: {FirstName} {LastName}");
        }

        public void Dispose()
        {
            //Console.WriteLine("IDisposable Object Dispose of");
        }
    }
}
