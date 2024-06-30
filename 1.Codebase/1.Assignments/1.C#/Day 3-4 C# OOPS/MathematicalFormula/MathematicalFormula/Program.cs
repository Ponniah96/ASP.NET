// See https://aka.ms/new-console-template for more information
using MathematicalFormula;

Console.WriteLine("C# OOPS");


//Mathematical Formula

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Calculate Mathematical Shapes Formula");

try
{

    InheritanceAndPolymorphism shapesFormula = new InheritanceAndPolymorphism();
    Circle circle = new Circle();
    Rectangle rectangle = new Rectangle();
    Triangle triangle = new Triangle();

    shapesFormula = circle;

    AbstractCircle circle2 = new AbstractCircle();
    AbstractRectangle rectangle2 = new AbstractRectangle();
    AbstractRectangle triangle2 = new AbstractRectangle();

    ICircle circle3 = new ICircle();
    IRectangle rectangle3 = new IRectangle();
    ITriangle triangle3 = new ITriangle();

    Console.WriteLine();
    Console.WriteLine("Press 1 - Abstract Class");
    Console.WriteLine("Press 2 - Inheritance & Polymorphism");
    Console.WriteLine("Press 3 - Interface");
    Console.Write("Enter 1 or 2 or 3 to display Required Method: ");
    string requiredMethodValue = Console.ReadLine();
    int requiredMethod = Convert.ToInt32(requiredMethodValue);
    Console.WriteLine();


    if (requiredMethod == 1)
    {
        Console.WriteLine();
        Console.WriteLine("Abstract Class");
        circle2.Default();
        Console.WriteLine();
        Console.WriteLine("Press 1 - Circle(Area & perimeter)");
        Console.WriteLine("Press 2 - Rectangle(Area & perimeter)");
        Console.WriteLine("Press 3 - Triangle(Area & perimeter)");
        Console.WriteLine();
        Console.Write("Enter 1 or 2 or 3 to get required formula: ");
        string AbstractValue = Console.ReadLine();
        int requiredAbstractFormulakey = Convert.ToInt32(AbstractValue);
        Console.WriteLine();
        switch (requiredAbstractFormulakey)
        {
            case 1: circle2.AbstractArea(); circle2.AbstractPerimeter(); break;
            case 2: rectangle2.AbstractArea(); rectangle2.AbstractPerimeter(); break;
            case 3: triangle2.AbstractArea(); triangle2.AbstractPerimeter(); break;
            default: Console.WriteLine("Please Enter 1 or 2 or 3 "); break;
        }
    }

    else if (requiredMethod == 2)
    {
        Console.WriteLine();
        Console.WriteLine("Inheritance & Polymorphism");
        shapesFormula.Area();
        shapesFormula.Perimeter();
        Console.WriteLine();
        Console.WriteLine("Press 1 - Circle(Area & perimeter)");
        Console.WriteLine("Press 2 - Rectangle(Area & perimeter)");
        Console.WriteLine("Press 3- Triangle(Area & perimeter)");
        Console.WriteLine();
        Console.Write("Enter 1 or 2 or 3 to get required formula: ");
        string value = Console.ReadLine();
        int requiredFormulakey = Convert.ToInt32(value);
        Console.WriteLine();
        switch (requiredFormulakey)
        {
            case 1: circle.Area(); circle.Perimeter(); break;
            case 2: rectangle.Area(); rectangle.Perimeter(); break;
            case 3: triangle.Area(); triangle.Perimeter(); break;
            default: Console.WriteLine("Please Enter 1 or 2 or 3 "); break;
        }
    }


    else if (requiredMethod == 3)
    {
        Console.WriteLine();
        Console.WriteLine("Inheritance");
        //circle3.IDefault();
        Console.WriteLine("Area of circle");
        Console.WriteLine("Area of triangle");
        Console.WriteLine("Area of rectangle");
        Console.WriteLine("Perimeter of circle");
        Console.WriteLine("Perimeter of triangle");
        Console.WriteLine("Perimeter of rectangle");
        Console.WriteLine();
        Console.WriteLine("Press 1 - Circle(Area & perimeter)");
        Console.WriteLine("Press 2 - Rectangle(Area & perimeter)");
        Console.WriteLine("Press 3 - Triangle(Area & perimeter)");
        Console.WriteLine();
        Console.Write("Enter 1 or 2 or 3 to get required formula: ");
        string AbstractValue = Console.ReadLine();
        int requiredAbstractFormulakey = Convert.ToInt32(AbstractValue);
        Console.WriteLine();
        switch (requiredAbstractFormulakey)
        {
            case 1: circle3.IArea(); circle3.IPerimeter(); break;
            case 2: rectangle3.IArea(); rectangle3.IPerimeter(); break;
            case 3: triangle3.IArea(); triangle3.IPerimeter(); break;
            default: Console.WriteLine("Please Enter 1 or 2 or 3 "); break;
        }
    }

    else
    {
        Console.WriteLine("Please Enter 1 or 2 or 3");
    }
}

catch(Exception e)
{
    Console.WriteLine($"Error Message: {e.Message}");
}