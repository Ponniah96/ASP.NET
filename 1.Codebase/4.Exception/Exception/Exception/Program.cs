// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("C# Exception");
Console.WriteLine("C# Exception will occur when user program wrongly, user enters wrong input types, Database Exceptions, and so on");
Console.WriteLine("At the time of exception, C# breaks compiler and throws error");
Console.WriteLine("To overcome compiler broken issue, C# come up with Exception Handling methods");


//Exception Handling Key Paramters
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Key paramters of C# Exception");
Console.WriteLine("1.try     Statement: Wraps all the possible error codes inside try statement");
Console.WriteLine("2.Catch   Statement: Define exception message in this block.");
Console.WriteLine("3.Finally Statement: Execute piece of code if try block code is either broke or not");

//Common Exceptions
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("C# Exception Types");
Console.WriteLine("1.Arithmetic Exception");
Console.WriteLine("2.FileNotFoundException");
Console.WriteLine("3.IndexOutofRangeException");
Console.WriteLine("4.TimeOutException");

//without catch-finally block
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Only Try block");
try
{
    int a = 5, b = 0;
    Console.WriteLine("inside try Block");
    Console.WriteLine($"Division Operation of {a} and {b} values are: {a / b}");
}
catch { }


//without finally block
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Try Catch block");
try
{
    int a = 5, b = 0;
    Console.WriteLine("inside try catch Block");
    Console.WriteLine($"Division Operation of {a} and {b} values are: {a / b}");
}
catch (Exception e)
{
    Console.WriteLine($"Exception Message: {e.Message}");
}


//All block
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Try Catch Finally block");
try
{
    int a = 5, b = 0;
    Console.WriteLine("inside try catch finally block");
    Console.WriteLine($"Division Operation of {a} and {b} values are: {a / b}");
}
catch (Exception e)
{
    Console.WriteLine($"Exception Message: {e.Message}");
}
finally 
{
    Console.WriteLine("Finally Block Executed");
}


//Custom Exception block
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Try Catch Finally block");
try
{
    int a = 5, b = 2;
    Console.WriteLine("inside try catch finally block");
    Console.WriteLine($"Division Operation of {a} and {b} values are: {a / b}");
    throw new ArithmeticException("Decimal Values will not be appeared");
}
catch { }


//User Enter value
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("User Input Exception");
Console.WriteLine("Enter Name: "); 
try {
    string userName = Console.ReadLine();
    Console.WriteLine("User Name: "+ userName);
    string userAge = Console.ReadLine();
    int age =Convert.ToInt32(userAge);
    Console.WriteLine("user Age: "+ age);
}
catch(Exception e) {
    Console.WriteLine($"Exception Messgae: {e.Message}");
}