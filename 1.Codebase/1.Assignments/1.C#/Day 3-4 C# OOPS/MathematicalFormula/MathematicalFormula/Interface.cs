using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalFormula
{
    internal class Interface
    {  }

    //Interfaces
    interface IShapesFormula
    {
        void IDefault()
        {
            Console.WriteLine("Area of circle");
            Console.WriteLine("Area of triangle");
            Console.WriteLine("Area of rectangle");
            Console.WriteLine("Perimeter of circle");
            Console.WriteLine("Perimeter of triangle");
            Console.WriteLine("Perimeter of rectangle");
        }
        void IArea();

        void IPerimeter();

    }

    class ICircle : IShapesFormula
    {
        public int radius;
        public void IArea()
        {
            Console.Write("Enter Radius of Circle : ");
            string radiusValue = Console.ReadLine();
            radius = Convert.ToInt32(radiusValue);
            Console.WriteLine();
            Console.WriteLine("Area of Circle = π r^2 (where r - radius)");
            double areaOfCircle = Math.PI * radius * radius;
            Console.WriteLine();
            Console.WriteLine($"Resultant Area of Circle = {areaOfCircle}");
            Console.WriteLine();
            Console.WriteLine();
        }

        public void IPerimeter()
        {
            Console.WriteLine("Perimeter of Circle = 2 π r (where r - radius)");
            double perimeterOfCircle = 2 * Math.PI * radius;
            Console.WriteLine();
            Console.WriteLine($"Resultant Area of Circle = {perimeterOfCircle}");
            Console.WriteLine();
        }
    }

    class IRectangle : IShapesFormula
    {
        public int width;
        public int height;
        public void IArea()
        {
            Console.Write("Enter Width: ");
            string widthOfRectangle = Console.ReadLine();
            Console.Write("Enter length: ");
            string heightOfRectangle = Console.ReadLine();
            width = Convert.ToInt32(widthOfRectangle);
            height = Convert.ToInt32(heightOfRectangle);
            Console.WriteLine();
            Console.WriteLine("Area of rectangle = w*l (where w - width, l-length)");
            int areaOfRectangle = width * height;
            Console.WriteLine();
            Console.WriteLine($"Resultant Area of rectangle: {areaOfRectangle}");
            Console.WriteLine();
            Console.WriteLine();
        }

        public void IPerimeter()
        {
            int perimeterOfRectangle = 2 * (width + height);
            Console.WriteLine("Perimeter of rectangle = 2(l+w) (where w - width, l-length)");
            Console.WriteLine();
            Console.WriteLine($"Resultant perimeter of rectangle: {perimeterOfRectangle}");
        }
    }

    class ITriangle : IShapesFormula
    {
        int baseTriangle, heightTriangle, x, y, z;
        public void IArea()
        {
            Console.WriteLine();
            Console.Write("Enter base of triangle  :");
            string baseValue = Console.ReadLine();
            Console.Write("Enter height of triangle: ");
            string heightValue = Console.ReadLine();
            Console.WriteLine();
            baseTriangle = Convert.ToInt32(baseValue);
            heightTriangle = Convert.ToInt32(heightValue);
            double areaOfTriangle = 0.2 * baseTriangle * heightTriangle;
            Console.WriteLine();
            Console.WriteLine("Area of triangle = 1/2 * b * h (where b - base, h-height)");
            Console.WriteLine();
            Console.WriteLine($"Resultantt Area of Triangle : {areaOfTriangle}");
            Console.WriteLine();
        }

        public void IPerimeter()
        {
            Console.WriteLine();
            Console.Write("Enter Coordinates value x: ");
            string xValue = Console.ReadLine();
            x = Convert.ToInt32(xValue);
            Console.Write("Enter Coordinates value y: ");
            string yValue = Console.ReadLine();
            y = Convert.ToInt32(yValue);
            Console.Write("Enter Coordinates value z ");
            string zValue = Console.ReadLine();
            z = Convert.ToInt32(zValue);
            Console.WriteLine();
            Console.WriteLine("Perimeter of triangle = x + y + z (where x, y, z - coordinates)");
            int perimeterofTriangle = x + y + z;
            Console.WriteLine();
            Console.WriteLine($"Resultantt Primeter of Triangle : {perimeterofTriangle}");
            Console.WriteLine();
        }
    }

}
