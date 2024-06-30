using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    internal class Collections
    {
        public void definition()
        {
            Console.WriteLine("Prerequsite sof Collections");
            Console.WriteLine("1.Collections are used to group objects irrespective of data type, size (i.e: Employee Records holds multiple data like ID, name, role etc)");
            Console.WriteLine("2.Disadvantages of Arrays:");
            Console.WriteLine("2.1.Arrays are fixed-size");
            Console.WriteLine("2.2.Arrays store objects of same data type");
            Console.WriteLine("2.3.Arrays cannot able to add/update/delete rows in middle");
            Console.WriteLine("3.To overcome arrays difficulties we are using collections");

            Console.WriteLine();

            Console.WriteLine("Definition:");
            Console.WriteLine("Collections are the special class in C# which is used to store multiple objects with diiferent data types");

            Console.WriteLine();

            Console.WriteLine("Advantages");
            Console.WriteLine("1.Collections stores data with multiple data types");
            Console.WriteLine("2.Using Collections we can add, delete, edit data in middle");

            Console.WriteLine();

            Console.WriteLine("Categories:");
            Console.WriteLine("1.Indexed base collections - Array, List");
            Console.WriteLine("2.Key Value Pair - Hashable, Dictionary");
            Console.WriteLine("3.Priortized Collection - Stack, Queue");
            Console.WriteLine("3.Specialized collections - Combination of categories  - String collections, hybrid dictionaries");

            Console.WriteLine();

            Console.WriteLine("Types of Collections");
            Console.WriteLine("1.Non Generic Collection");
            Console.WriteLine("1.1.Using System.Collection");
            Console.WriteLine("1.2.Types - ArrayList, Stack, Queue, Dictionary, SortedList");
            Console.WriteLine("1.3.Loosely Typed");

            Console.WriteLine("2.Generic Collection");
            Console.WriteLine("2.1.Using System.Colllection.Generic");
            Console.WriteLine("2.2.Types - List<T>, Stack<T>, Queue<T>, Dictionary<Tkey, TValue>,LinkedList<T>");
            Console.WriteLine("2.3.Strongly Typed");

            Console.WriteLine("3.Concurrent Collection");
            Console.WriteLine("3.1.Using System.Collection.Concurrent");
            Console.WriteLine("3.2.Types - ConcurrentList<T>, ConcurrentbagStack<T>, ConcurrentQueue<T>, ConcurrentDictionary<TKey, TValue>");
            Console.WriteLine("3.3.Thread typed stong collection");
        }
    }
}
