using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    internal class LambdaExpression
    {
        public void definition()
        {
            Console.WriteLine("Lambda Expression defines anonnymous function. (i.e:Similar to arrow function)");
            Console.WriteLine();

            //Syntax
            Console.WriteLine();
            Console.WriteLine("Syntax: (input paramters) => {expression or statements}");
            Console.WriteLine("=> Lambda operator");

            //Basic Example
            Console.WriteLine();
            Console.WriteLine("Find Square Root of 10");
            var square = (int x) => x * x;
            var result = square(10);
            Console.WriteLine($"Result: {result}"); 

            //Outer Variables, Captured variables, Closure
            Console.WriteLine();
            Console.WriteLine("Outer variables - lambda expression reference local variables, members, properties, methods");
            Console.WriteLine("Captured Variables - A variable referenced by lambda expression");
            Console.WriteLine("Closure - Lambda Expression contains capture variables");

            //Basic Example with outer variables
            Console.WriteLine();
            int num1 = 5;
            var multiply = (int x) => x * num1;
            var result1 = multiply(6);
            Console.WriteLine($"Result of 5*6: {result1}");

        }
    }
}
