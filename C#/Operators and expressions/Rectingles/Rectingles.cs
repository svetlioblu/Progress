using System;


namespace Rectingles
{
    class Rectingles
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double rectArea = width * height;
            double rectPerimeter = 2 * (width + height);
            Console.WriteLine("{0:0.00} {1:0.00}", rectArea, rectPerimeter);

        }
    }
}
