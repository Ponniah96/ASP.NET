//Object Oriented programming language
using OOPS;

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Procedural methods Vs OOPS");
Console.WriteLine("Procedural methods is used to perform some opertion on data");
Console.WriteLine("OOPS is used to create object which contains data and method");
Console.WriteLine("Advantages of OOPS");
Console.WriteLine("OOPS contains block of code which is readable, reusable, faster, clear structure");
Console.WriteLine("Classes & Objects relation");
Console.WriteLine("Classes are entity whereas objects contains instance of class");


//Classes and Objects
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Classes and Objects");
Roles roles = new Roles();
Console.WriteLine($"My Current Company {roles.AAIII}");
roles.ASE = "I-exceed";
Console.WriteLine($"Overwitr First Company Name: {roles.ASE}");
Console.WriteLine($"Roles Class DisplayCompanyName Method");
roles.DisplayCompanyName();


//Constructors
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Constructors");
Console.WriteLine("Constructors are the in-built methods of classes where we can assign field values");
Console.WriteLine("Properties of Constructor");
Console.WriteLine("1.Constructor name should be same as class name");
Console.WriteLine("2.We can assign field values by passing data as parameters");
Console.WriteLine("3.Constructor will be called when object is created");
Console.WriteLine($"Values which are passed to constructor:");
Console.WriteLine($"First Company Joining Year: {roles.ASEYear}");


//Access Modifiers
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Access Modifiers");
Console.WriteLine("Access modifiers are mainly used for visibility of class members (fields, methods)");
Console.WriteLine("Types of Access Modifiers");
Console.WriteLine("1.Pubic: Data can be accessible for all class");
Console.WriteLine("2.Private: Data can be accessed only within class");
Console.WriteLine("3.Protected: Data can be accessed only that class or its inherited class");
Console.WriteLine("4.Internal: Data can be accessed only with in assembly(namespcae)");


//C# Propereties

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("C# Encapslation");
Console.WriteLine("C# Encapsulation is mainly used to secure data by restricting their access");
Console.WriteLine("By achieving encapsulation we need to devleop class members with private access memebers");
Console.WriteLine("If you want to get set private field data we can use properties");
Console.WriteLine("C# Properties");
Console.WriteLine("C# Properties is mainly used to access private field class members");
Console.WriteLine("Types of C# Properties Methods");
Console.WriteLine("1.Get Method: It is mainly used to get private field data");
Console.WriteLine("2.Set Method: It is mainly used to set private filed data");
Console.WriteLine("Pass Private field for Roles class : 15000");
//roles.Display1stSalary();
roles.ASE1stSalary = "15000";
Console.WriteLine($"1st salary:{roles.ASE1stSalary}");


//Inheritance
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Inheritance");
Console.WriteLine("Inheritance is used to get parent class fileds and methods using : keword");
Console.WriteLine("Going to create new class /' Technology /' which is inherited from parent class roles ");
Clients clients = new Clients();
Console.WriteLine($"{clients.ASEClients} is the 1st client when I was joined {clients.ASE} in {clients.ASEYear}");


//Polymorphism
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Polymorphism");
Console.WriteLine("Polymorphism is used to extract method from parent class maily for reusability of code");
Console.WriteLine("Write Parent Class method \'Virtual\' keyword and child class method \'Override\' keyword");
ASEDisplaySalary salary = new ASEDisplaySalary();
SSEDisplaySalary salary1 = new SSEDisplaySalary();
AAIIIDisplaySalary salary2 = new AAIIIDisplaySalary();
roles.Display1stSalary();
salary.Display1stSalary();
salary1.Display1stSalary();
salary2.Display1stSalary();



//Abstraction

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Abstraction is used to hide and show sensitive information");
Console.WriteLine("Methods to achieve abstraction");
Console.WriteLine("1.Using abstract class");
Console.WriteLine("2.Using Interface");
Console.WriteLine();


//Abstract Class and Abstract Methods
Console.WriteLine("1.Abstract class method");
Console.WriteLine("If Class and Methods are called using Abstract keyword, we cannot access directly using objects");
Console.WriteLine("We can access abstract class and methods using derived class only");
Console.WriteLine("Example:");
Console.WriteLine("Create new abstract class called \'AbstractClass & AbstractMethod\' and define method in derived class \'DerivedClass\' using Inheritance, Polymorphism");
DerivedClass derivedClass = new DerivedClass();
Console.WriteLine("Output:");
derivedClass.AbstractMethod();
derivedClass.AbstractClassNormalMethod();
Console.WriteLine();


//Interface
Console.WriteLine("2.Interface");
Console.WriteLine("Interface is a completely abstract class");
Console.WriteLine("Advantages of Abstract Class");
Console.WriteLine("1.To achieve multiple inhertitance, we can use multiple interface");
Console.WriteLine("2.To hide/show only sensitive data");
Console.WriteLine("3.Default members of interfaces: abstract & public");
Console.WriteLine("4.Interface contains only properties & methods not fields and variables");
Console.WriteLine("5.Similar to abstract class we can assign methods, properties");
Console.WriteLine("6.Better to start with \'I\' at the start of the interface");
Console.WriteLine("7.No need to use overide keyword in implement class method");
ImplementClass implementClass = new ImplementClass();
implementClass.InterfaceMethod();


//Multiple Interface
ImplementMultipleClass implementMultipleClass = new ImplementMultipleClass();
implementMultipleClass.MultipleInterfaceMethod1();
implementMultipleClass.MultipleInterfaceMethod2();


//Extension Methods
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Extension Methods");
Console.WriteLine("Concept of Extesnion Method:");
Console.WriteLine("In General, we want to add new methods for old class, we use inhertiance concept");
Console.WriteLine("In some scenarios, sealed class or build-in class where we cannot find sourceCode or cannot able to use derived class, we will use extension methods");
Console.WriteLine();
Console.WriteLine("Important points of extension methods");
Console.WriteLine("Define \'static method, static class\' hile defining extension methods");
Console.WriteLine("Use this keyword along with OldClass name we need to use");
ExistingClassForExtensionMethod existingClassForExtensionMethod = new ExistingClassForExtensionMethod();
existingClassForExtensionMethod.Method1();
existingClassForExtensionMethod.Method2();


