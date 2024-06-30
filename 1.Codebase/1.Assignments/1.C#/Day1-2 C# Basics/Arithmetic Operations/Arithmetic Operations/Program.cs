// See https://aka.ms/new-console-template for more information
Console.WriteLine("C# Assignment Day 1-2 C# Basics");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Build Simple Calculator");
Console.WriteLine();
Console.WriteLine("Performance doing using calculator");
Console.WriteLine("1.Addition");
Console.WriteLine("2.Subtraction");
Console.WriteLine("3.Multiplication");
Console.WriteLine("4.Division");


//User Inputs
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Enter User Inputs");
Console.WriteLine();
Console.Write("Input1: ");
string data1 = Console.ReadLine();
Console.Write("Input2: ");
string data2 = Console.ReadLine();
int num1, num2;
try
{
    num1 = Convert.ToInt32(data1);
    num2 = Convert.ToInt32(data2);

    //Selecting Arithmetic Operations
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Choose Arithmetic Operations");
    Console.WriteLine();
    Console.WriteLine("Type 1 - Add, 2 - Sub, 3 - Multiplication, 4 - Division");
    Console.WriteLine();
    Console.Write("Type 1 or 2 or 3 or 4: ");
    string operationValue = Console.ReadLine();
    switch (operationValue)
    {
        case "1": Addition(num1, num2); break;
        case "2": Subtraction(num1, num2); break;
        case "3": Multiplication(num1, num2); break;
        case "4": Division(num1, num2); break;
        default: Console.WriteLine("Please Enter Valid Input : 1 or 2 or 3 or 4");break;
    }


    //Defining Arithmetic Operations
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    static void Addition(int num1, int num2)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("You choose addition operation");
        Console.WriteLine();
        Console.WriteLine($"Addtion Result of {num1} and {num2} : {num1 + num2}");
    }

    static void Subtraction(int num1, int num2)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("You choose subtraction operation");
        Console.WriteLine();
        Console.WriteLine($"Subtraction Result of {num1} and {num2} : {num1 - num2}");
    }

    static void Multiplication(int num1, int num2)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("You choose multiplication operation");
        Console.WriteLine();
        Console.WriteLine($"Multiplication Result of {num1} and {num2} : {num1 * num2}");
    }

    static void Division(int num1, int num2)
    {
        try
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You choose division operation");
            Console.WriteLine();
            Console.WriteLine($"Division Result of {num1} and {num2} : {num1 / num2}");
        }
        catch(Exception e) {
            Console.WriteLine($"Error Message: {e.Message}");
        }
    }
}
catch(Exception e) {
    Console.WriteLine();
    Console.WriteLine($"Error Message: {e.Message}");
}

//Calling Function
/*Addition(num1, num2);
Subtraction(num1, num2);
Multiplication(num1, num2);
Division(num1, num2);*/