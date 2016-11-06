using System;


namespace Circkle
{
    class Program
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            // find area
            double area = (Math.PI) * (Math.Pow(radius, 2));
            //find perimeter
            double perimeter = (2*Math.PI) * radius;
            Console.WriteLine("{1:0.00} {0:0.00}",area,perimeter);
        }
    }
}
