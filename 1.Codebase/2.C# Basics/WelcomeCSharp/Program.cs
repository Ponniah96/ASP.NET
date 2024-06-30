// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;
using WelcomeCSharp;

Console.WriteLine("Hello, World!");//1st Console
Console.WriteLine("Welcome to C#");//Welcome Console

/** Basic Details**/
Console.WriteLine("My Name is Ponniah Kothandaraman");
Console.Write("My Age is: ");
Console.Write(20 + 6);
Console.WriteLine();
Console.WriteLine();

//Varibales
int number = 1;
double floatingPointNumbers = 1.1;
char character  = 'a';
string name = "ponnioah";
bool isIndian = true;
Console.WriteLine("C# Variables");
Console.WriteLine("Int: {0}", number);
Console.WriteLine("Double: {0}", floatingPointNumbers);
Console.WriteLine("Char: {0}", character);
Console.WriteLine("String: {0}", name);
Console.WriteLine("Bool: {0}", isIndian);

//Constants
int changeNumber = 1;
changeNumber = 2;
const int unChangeNumber = 5;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Constants");
Console.WriteLine("ChangeValue: {0} ", changeNumber);
Console.WriteLine("UnchangeNumber: {0} ", unChangeNumber);

//DisplayVaribales
string name1 = "Ponniah";
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Name: {0}", name1);
Console.WriteLine("Name: " + name1);
string firstName = "Ponniah";
string lastName = "Kothandraman";
Console.WriteLine("Full Name: " + firstName +" " + lastName);

//Decalre Multip[le Varibales for Same Type
int num1 = 5, num2 = 6;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Using Comma we can initalize multiple variables: {0}",num1+num2);

//Identifiers
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Identifers are case-sesitive, start with lowercase");

//Data Types
int numbers = 1;
long nuumbers1 = 1245641524561;
float floatPointNumberss = 2.46432F;
double floatingPointNumber = 1.1;
char characters = 'a';
string names = "ponnioah";
bool isIndia = true;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("C# Data Types");
Console.WriteLine("Int: {0}", numbers);
Console.WriteLine("long: {0}", nuumbers1);
Console.WriteLine("Float: {0}", floatPointNumberss);    
Console.WriteLine("Double: {0}", floatingPointNumber);
Console.WriteLine("Char: {0}", characters);
Console.WriteLine("String: {0}", names);
Console.WriteLine("Bool: {0}", isIndia);

//Type Casting
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Type Casting is the method to convert data types from one to another");
Console.WriteLine("Types of Type Casting");
Console.WriteLine("1.Implicit type Casting: Convert Smaller type to largerr type , No type method cal lreuired");
Console.WriteLine("2.Explicit type casting: Convert Larger type to smaller type , Data type method reuiredd");
int integerNumber = 6786786;
long LongNumber = integerNumber;
Console.WriteLine("Int to long Implicit Conversion : "+ LongNumber);
double doublleDecimalNumber = 6.23576257;
float floatNuumber = (float)doublleDecimalNumber;
Console.WriteLine("Double to float Explicit conversion: " + floatNuumber);
Console.WriteLine("InBuuilt Conversion Methods");
Console.WriteLine("1.Convert.ToBoolean()");
Console.WriteLine("2.Convert.ToString()");
Console.WriteLine("3.Convert.ToDouble()");
Console.WriteLine("4.Convert.ToInt32(intt)");
Console.WriteLine("5.Convert.ToInt64(long)");

//read user Input
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Please Enter Your Name: ");
string userName=Console.ReadLine();
Console.WriteLine("Your Namne is " + userName);
Console.WriteLine("Please Enter Your Age: ");
string UserAge=Console.ReadLine();
Console.WriteLine("Your Age is " + Convert.ToInt32(UserAge));

//Operators
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Operators");
Console.WriteLine("Arithmetic Operators: + - * / % ");
Console.WriteLine("Assignment Operators: = += -= *= %= /=");
Console.WriteLine("Logical operators: && || !");
Console.WriteLine("Comaparsion operators : > < == >= <= !==");

//Math Operators
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Math operators");
int numSmall = 5, numBig = 10, numSqt = 64;
float numFloat = 8.945F;
Console.WriteLine("Max Number: "+Math.Max(numSmall, numBig));
Console.WriteLine("Min Nuumber: "+Math.Min(numSmall, numBig));
Console.WriteLine("Square Root: "+Math.Sqrt(numSqt));
Console.WriteLine("Round of: " + Math.Round(numFloat));

//Strings
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Strings");
string text = "Welcome to C# Strings";
Console.WriteLine("Display String using + Operator: "+text);
Console.WriteLine("Display String using parenthesis Operator: {0}", text);
Console.WriteLine("String Concatenation");
string firstName1 = "Ponniah ";
string lastName1 = "Kothandaraman";
Console.WriteLine("Concatenate String: " + firstName1 + lastName1);
Console.WriteLine("String Interpolation");
Console.WriteLine("Another option to concatenate string");
Console.WriteLine($"Concatenate string using string interpolation \'$\' sign: {firstName1}{lastName1}");
Console.WriteLine("Access Strings");
Console.WriteLine($"String Length of \'{text}\': {text.Length}");
Console.WriteLine($"Access First Char of \'{text}\': {text[0]}");
Console.WriteLine($"Indexof String \"{text}\" on \'C#\' text : \"{text.IndexOf("#")-1}\"");
Console.WriteLine($"Substring of \"{text}\" after \'C#\': \'{text.Substring(text.IndexOf("#") - 1)}\'");
Console.WriteLine("Special Characters");
Console.WriteLine("Single Quotes: \'\'");
Console.WriteLine("Double Quotes: \"\" ");
Console.WriteLine("Backslash: \\");
Console.WriteLine("New Line \n data will be added");
Console.WriteLine("Tav Space \t data will be moved");
Console.WriteLine("backspace \b data will be backspaced");

//Boolean
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Boolean Data Types");
Console.WriteLine("Boolean Data Types will only have 2 values either true or false");
Console.WriteLine("We can achieve this using logical and condtional operator");
Console.WriteLine("Using If operator we can comapre 2 values");
Console.WriteLine("Number1: ");
string Number1 = Console.ReadLine();
Console.WriteLine("Number2: ");
string Number2 = Console.ReadLine();
int value1 = Convert.ToInt32(Number1);
int value2 = Convert.ToInt32(Number2);
if (value1 >= value2)
{
    Console.WriteLine($"{value1} is greater than {value2}");
}
else
{
    Console.WriteLine($"{value2} is greater than {value1}");
}

//If Statement
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("If Statement executes only if condiotn is true");
Console.WriteLine("Else Statement executes only if condiotn is false");
Console.WriteLine("Number3: ");
string string3 = Console.ReadLine();
Console.WriteLine("Number4: ");
string string4 = Console.ReadLine();
int Number3 = Convert.ToInt32(string3), Number4 = Convert.ToInt32(string4);
if(Number3 == Number4)
{
    Console.WriteLine($"{Number3} is equal  to {Number4}"); 
}
else if(Number3 >= Number4)
{
    Console.WriteLine($"{Number3} is greater than {Number4}");
}
else
{
    Console.WriteLine($"{Number3} is less than {Number4}");
}
Console.WriteLine("ternary Operator");
string ternaryResult = (Number3 > Number4) ?"Number3 is greater than Number4":"Number3 is less than Number4";
Console.WriteLine($"Result: {ternaryResult}");

//Switch Statements
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Switch Statement");
Console.WriteLine("Switch Stement are used to executeblock of stements based on the constion is true");
Console.WriteLine("Enter Company Name: ");
String CompanyName=Console.ReadLine();
switch (CompanyName)
{
    case "Prodapt": Console.WriteLine("Prodapt solutions is my first company.\nI worked there for 3 years (2018-2021).\nI worked under windstream client for build eCommerce application, netwrok tracking applications.\n Technology: HTML, CSS, jQuery, React, Redux, kentico, ASP.Net");
        break;
    case "i-exceed":Console.WriteLine("I-excced is my 2nd Company. \n I worked there for 1 1\\2 years..\n I worked under TSb Client to build BBOnBoarding Customer applications, Profiler app etc. \n Technology: HTML, CSS, JS, jQuery, Appzillon, MYSQL, Jenkins");
        break;
    case "Devon":Console.WriteLine("Devon is my cuurent Company.\n I'm working here fromMay 2023 onwards. \n I worked under Royalhaskoning Ensis Preoject which was ther till JUULy end. \n Techhnology: React, Material UI, .Net, DevOps"); 
        break;
    default:
        Console.WriteLine("Devon is my cuurent Company.\n I'm working here fromMay 2023 onwards. \n I worked under Royalhaskoning Ensis Preoject which was ther till JUULy end. \n Techhnology: React, Material UI, .Net, DevOps");
        break;
}

//Looping Statements
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Loops");
Console.WriteLine("Loops are used to iterate function repeatedly until it mets condtion");
Console.WriteLine("While Loop: Execute Statement untilk condtion mets");
int i = 0, k=0, l=0, m=0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
Console.WriteLine("Do-while Loop: Execute statement for 1st time without checking condtion itself");
do
{
    Console.WriteLine(k);
    k++;
} while (k < 5);
Console.WriteLine("For Loop: Exceute statement if we have idea about starting, end limitt, condtion");
/*for(int j = 0; j < 5; j++)
{
    Console.WriteLine(j);
}*/
Console.WriteLine("For Each Loop: Execute statement only for arrays obljects");
string[] test = { "Welcome", "to", "Arrays" };
foreach(string s in test)
{
    Console.WriteLine(s);
}
Console.WriteLine("Break Statement: Used to terminate loop if consition was met");
while (l < 5)
{
    if (l == 3)
    {
        Console.WriteLine("Statement is going to break");
        break;
    }
    Console.WriteLine(l);
    l++;
}
Console.WriteLine("Continue Statement: Used to terminate specific condition if specific condition was met");
for (int o=0; o < 5;o++)
{
    if (o == 3)
    {
        //Console.WriteLine("COntinue Statement is going to execute");
        continue;
    }
    Console.WriteLine(o);
}


//Arrays
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Arrays");
Console.WriteLine("Arrays are used to store multiple values in a single variable");
Console.WriteLine("Syntax: string[] arrayName={}");
string[] array = { "array1", "array2", "array3" };
Console.Write($"Array Values are:");
foreach (string s in array)
{
    Console.Write(s);
    Console.Write('\t');
}
Console.WriteLine();
Console.WriteLine($"Array 1st element: {array[0]}");
Console.WriteLine($"Array Length: {array.Length}");
Array.Sort(array);
Console.WriteLine($"Sort Arrays: {array[0]}");
Console.WriteLine("Multi dimensional array");
Console.WriteLine("Syntax: string[,] arrayName={{},{}}");
string[,] multiDimensionalArray = { { "Array1 Element1", "Array1 Element2" }, { "Array2 Element1","Array2 Element2"} };
foreach (string s in multiDimensionalArray)
{
   Console.WriteLine(s);
}



//Methods
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("C# Methods");
static void NewMethod()
{
    Console.WriteLine("New method called successfully");
}
Console.WriteLine("Before Method Calls");
NewMethod();
Console.WriteLine("Method Parameters, arguments");
Console.WriteLine("Parameters: Parameters act as variables and it defines while creating method");
Console.WriteLine("Arguments: Arguments act as variables and it defines while calling method");
static void PassValues(string paramters="defaultValue")
{
    Console.WriteLine($"Parameters value: {paramters}");
}
PassValues("Value1");
PassValues();
Console.WriteLine("Return values");
static int Add(int value1=5, int value2=6)
{
    return value1 + value2;
}
int Result1 = Add(2, 3);
int Result2 = Add();
Console.WriteLine($"Result1: {Result1}");
Console.WriteLine($"Result2: {Result2}");
Console.WriteLine("Named Arguments");
static string DisplayFullName(string fName, string lName){
    return "Hello "+fName+" "+lName;
}
string result3 = DisplayFullName(fName:"Ponniah", lName:"Kothandaraman");
string result4 = DisplayFullName(fName:"Kothandaraman", lName:"Gomathinayagam");
string result5 = DisplayFullName(lName: "Arumuganarayanan",fName:"Gomathinayagam" );
Console.WriteLine($"Result3: {result3}");
Console.WriteLine($"Result4: {result4}");
Console.WriteLine($"Result5: {result5}");
Console.WriteLine("Mehod OverLoading");
static int AddData(int x, int y)
{
    return x + y;
}
/*static string AddData(string a)
{
    return a;
}*/
int result6= AddData(1, 2);
/*string result7 = AddData("Hello");*/


