using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    public  class CustomAttributes
    {
        public void AttributesDefinition()
        {
            Console.WriteLine("1.What is C# attribute");
            Console.WriteLine("C# attributes is a declarative tag which can applies to class, properties, methods");
            Console.WriteLine("C# attributes is a metadata which contains information about Code element");
            Console.WriteLine("Using \'System.Attribute\' we can create custom attributes");
            Console.WriteLine();
            Console.WriteLine("Predefined Attributes tags");
            Console.WriteLine("1.Serializable: Serialze data");
            Console.WriteLine("2.Obsolete: Throws error in Visual studio if Obselete condtion was not met");
            Console.WriteLine();
        }
    }

    [Serializable]
    class PredefinedAttribute:Attribute {
        public string? Name { get; set; }
        //public int Age = 26;
        public void SerializeData()
        {
            Console.WriteLine($"Serialize Attriibute Data, Name: {Name}");   
        }
    }

    //Custom Attributes
    [AttributeUsage(AttributeTargets.Class)]
    class CustomAttributeParent : Attribute { 
        public string? Name { get; set;}
        
        public CustomAttributeParent(string? name)
        {
            Name = name;
        }
    }

    [CustomAttributeParent("Ponniah Kothandaraman")]
    class CustomAttributeChild
    {
        public void DisplayParent() {
            Console.WriteLine("Display Custom Attributes"); 
        }
    }
}
