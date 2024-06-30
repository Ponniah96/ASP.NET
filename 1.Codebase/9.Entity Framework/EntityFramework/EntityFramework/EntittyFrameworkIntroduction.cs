using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class EntittyFrameworkIntroduction
    {
        public void definition()
        {
            Console.WriteLine("Entity Framework");
            Console.WriteLine("Entity Framework is an open source Object relation mapper (ORM) which is used for .NET developers to working with database using .NET Objects");
            Console.WriteLine("It eliminates need for data access code which devlopers usually write");
            Console.WriteLine("Adavantages:");
            Console.WriteLine("1.EF generates necessary database commands for CRUD operations");
            Console.WriteLine("2.EF stores data in memory cache, so on top of it we can work for data");
            Console.WriteLine("3.EF can perform differnet types of operations on domain objects(basically classes representing database tables) using LINQ to entities");

        }
    }
}
