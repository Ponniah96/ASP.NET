using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    internal class Generics
    {
        public void definition()
        {
            Console.WriteLine("Generics is used to create method/class/properties without specified data types. Data types can be specified ate the time of compilation");
            Console.WriteLine();
            Console.WriteLine("Importance of Generics");
            Console.WriteLine("1.Methods to create method \'isEqual()\' and it should work for all data types:");
            Console.WriteLine("1.1.Create object data type - It throws error like boxing, unboxing and typecasting");
            Console.WriteLine("1.2.Method Overloading - It will work but we need to create multiple lines of code");
            Console.WriteLine("2.To overcome this issue we declare method calss as generic methos");
            Console.WriteLine();
            Console.WriteLine("Syntax of Generics");
            Console.WriteLine("class ClassName<T> (where T mentions data types)");
            Console.WriteLine();
            Console.WriteLine("Advantages of C# Generics");
            Console.WriteLine("1.Reusability of code");
            Console.WriteLine("2.Generics are safe type");
            Console.WriteLine("3.Better Performace - Overcome boxing, unboxing, typecasting issue");
        }
    }

    //Generics Class
    class GenericClass<T>
    {
        public T GenericValue { get; set; }
        public GenericClass(T value) {
            GenericValue = value;
        }

        public T GenericMethod(T values)
        {
            Console.WriteLine();
            Console.WriteLine($"C# Generics Class: Type-{typeof(T).ToString()}");
            Console.WriteLine($"Constructor Value: {GenericValue}");
            Console.WriteLine($"Method Value: {values}");
            return GenericValue;
        }
    }

    //Generics Methods
    class GenericMethodClass
    {
        public void GenericMethodClassMethod<T>(T Value)
        {
            Console.WriteLine();
            Console.WriteLine($"C# Generics methods: Type-{typeof(T).ToString()}");
            Console.WriteLine($"Method value: {Value}");
        }
    }
}
