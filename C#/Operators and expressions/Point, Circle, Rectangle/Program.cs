using System;


namespace Point__Circle__Rectangle
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double radious = 1.5 * 1.5;

            //Calculating point is it in a given  circle K({1, 1}, 1.5)
            bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= radious;
            //Calculating point is it in a given rectangle R(top=1, left=-1, width=6, height=2)

            bool isInRectangle = x >= -1 && x <= 5 && y >= -1 && y <= 1;
            string resultCircle = isInCircle == true ? "inside circle" : "outside circle";
            string resultrectangle = isInRectangle == true ? "inside rectangle" : "outside rectangle";
            Console.WriteLine("{0} {1}", resultCircle, resultrectangle);




        }
    }
}
