using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestThanFive
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            double biggestNumber = a;
            if (b > a && b > c && b > d && b > e)
            {
                biggestNumber = b;
            }
            else if (c > a && c > b && c > d && c > e)
            {
                biggestNumber = c;
            }
            else if (d > a && d > b && d > c && d > e)
            {
                biggestNumber = d;
            }
            else if (e > a && e > b && e > c && e > d)
            {
                biggestNumber = e;
            }
            Console.WriteLine(biggestNumber);
        }
    }
}
