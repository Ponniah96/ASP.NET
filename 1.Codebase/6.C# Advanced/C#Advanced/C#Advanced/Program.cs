using C_Advanced;

Console.WriteLine("Welcome to C# Advanced Concepts");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Topics will cover in this C# Advanced Project");
Console.WriteLine("1.Custom Atributes");
Console.WriteLine("2.IDisposable Pattern using Keyword");
Console.WriteLine("3.Generics in C#");
Console.WriteLine("4.Collections in C#  - List");
Console.WriteLine("5.Collections in C# - Dictionary");
Console.WriteLine("6.Collections in C# - IEnumerable");
Console.WriteLine("7.Task Parallel Library");
Console.WriteLine("8.Async and Await methods");
Console.WriteLine("9.Delegates and Events");
Console.WriteLine("10.Lambda expressions (Expression class)");
Console.WriteLine("11.Func, Action, Predictable delegates");
Console.WriteLine("12.LINQ basics (Where, Join, Select, Group)");

Console.WriteLine();
Console.WriteLine();


//Custom Attributes
Console.WriteLine("1.Custom Atributes");
CustomAttributes customAttributes = new CustomAttributes();
customAttributes.AttributesDefinition();

PredefinedAttribute predefinedAttribute = new PredefinedAttribute();
predefinedAttribute.Name = "Ponniah Kothandaraman";
predefinedAttribute.SerializeData();

var attributes = Attribute.GetCustomAttributes(typeof(CustomAttributeChild));
var getCustomAttributeData = attributes.OfType<CustomAttributeParent>().Single();
Console.WriteLine($"Custom Attribute Data, Name: {getCustomAttributeData.Name}");

Console.WriteLine();
Console.WriteLine();


//IDisposable Pattern
Console.WriteLine("2.IDisposbale Method");
IDisposableInterface disposableInterface = new IDisposableInterface();
disposableInterface.defintion();
using var IDisposeMethodValue = new IDisposableMethod("Ponniah", "Kothandaraman");
IDisposeMethodValue.DisplayFullName();

Console.WriteLine();
Console.WriteLine();


//Generics 
Console.WriteLine("3.Generics in C#");
Generics generics = new Generics();
generics.definition();
GenericClass<string> genericStringValues = new GenericClass<string>("Welcome to generics");
genericStringValues.GenericMethod("Ponniah Kothandaraman");
GenericClass<int> genericIntValues = new GenericClass<int>(26);
genericIntValues.GenericMethod(26);
GenericMethodClass genericMethodClass = new GenericMethodClass();
genericMethodClass.GenericMethodClassMethod<int>(20);


Console.WriteLine();
Console.WriteLine();

//Collections
Console.WriteLine("Collections in C#");
Collections collections = new Collections();
collections.definition();

Console.WriteLine();
Console.WriteLine();

//Collections List
Console.WriteLine("4.Collection List in C#");
CollectionList collectionList = new CollectionList();
collectionList.definition();

Console.WriteLine();
Console.WriteLine();

//Collections Dictionary
Console.WriteLine("5.Collections Dictionary in C#");
CollectionDictionary collectionDictionary = new CollectionDictionary();
collectionDictionary.defintion();

Console.WriteLine();
Console.WriteLine();

//Collections IEnumerable
Console.WriteLine("6.Collections Ienumerable in C#");
Console.WriteLine("Points to remembered");
Console.WriteLine("IEnumerable is an interface allows you to read only access to collectioon. IT contins GetEnumerable method");
Console.WriteLine("IEnumerable is a base class for all non generic collection classes");
Console.WriteLine("Default Methods of IEnumerable: AsParallel(), OfType<>");
Console.WriteLine("Collections uses IEnumberable for iterations");
Console.WriteLine("We can create cutom IEnumerable Interface. It will inherit all LIUNQ Functionality");


Console.WriteLine();
Console.WriteLine();

//Delegates
Console.WriteLine("Delegates");
Delegates delegates = new Delegates();
delegates.definition();


Console.WriteLine();
Console.WriteLine();

//Lambda Expression
Console.WriteLine("Lambda Expression");
LambdaExpression lambda = new LambdaExpression();
lambda.definition();


Console.WriteLine();
Console.WriteLine();

//Events
Console.WriteLine("Events");
Events events = new Events();
events.defintion();


Console.WriteLine();
Console.WriteLine();

//Func, Action, Predicate Delegates
Console.WriteLine("Generic Delegates");
GenericDelegates genericDelegates = new GenericDelegates(); 
genericDelegates.definition();


Console.WriteLine();
Console.WriteLine();


//LINQ 
Console.WriteLine("Linq");
Console.WriteLine("Linq is a query languagee which is mainly used to query data from external resources");

Console.WriteLine();

Console.WriteLine("Architechture of Linq");
Console.WriteLine("Application --> Linq Query --> Linq Providers --> Data source");
Console.WriteLine("Data Source:");
Console.WriteLine("Memory Objects, SQL, oracle, Entity Framewoek, XML, Other sources"); 


Console.WriteLine();

Console.WriteLine("Types of LINQ Query Methods");
Console.WriteLine("1.Query");
Console.WriteLine("2.Method");
Console.WriteLine("3.Mixed");

Console.WriteLine("Prerequisites to write Query");
Console.WriteLine("1.Data Source");
Console.WriteLine("2.Query");
Console.WriteLine("3.Execution");

Console.WriteLine();

Console.WriteLine("Basic Syntax");
Console.WriteLine("List<T> list_name = new List<T>().Where(n%2==0)");

//Select Query
int[] numbers = new int[] { 1, 2, 3, 4, 5 };
var square = numbers.Select(x => x*x);
Console.WriteLine("Squre of numjbers");
foreach (int number in square)
{
    Console.WriteLine($"{number}, {Thread.CurrentThread.ManagedThreadId} ");
}
Console.WriteLine();

//Where Query to filter greate than 2
var greaterthan2 = numbers.Where(x => x>2);
Console.WriteLine("Find numbers greater than 2");
foreach (int number in greaterthan2)
{
    Console.Write(number);
}

//GroupBy Query to filter even Numbers
/*List<int> employeeData = new;
Console.WriteLine("Filter Even Numbers");
foreach (int number in groupBy)
{
    Console.Write(number);
}*/



Console.WriteLine();
Console.WriteLine();

//Async and await methods
Console.WriteLine("Asyncronous programming");
Console.WriteLine("Asyncronous programming helps program to execute faster than before. IOt helps multi-threading process");
Console.WriteLine("Basic Syntax");
Console.WriteLine("Method: public static await void method_name()");
Console.WriteLine("Expression: await Task.Delay(TimeSpan.FromSeconds(10)");


//task Parallel Processing
Console.WriteLine("Task Parallel Library");
Console.WriteLine("For large amount of data application, it is suggested to use Task Parallel Processing");
Console.WriteLine("As Name suggests, if we want to retrieve large amount of data use TPL methods");
Console.WriteLine("Methods of TPL:");
Console.WriteLine("1.Parallel.For()");
Parallel.For(1, 10, numbers => { Console.WriteLine($"{numbers}, {Thread.CurrentThread.ManagedThreadId}");}); 
Console.WriteLine("2.Parallel.ForEach()");