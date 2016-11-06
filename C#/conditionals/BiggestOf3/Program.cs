using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOf3
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double biggestNumber = a;
            if (b > a && b > c)
            {
                biggestNumber = b;
            }
            else if (c > a && c > b)
            {
                biggestNumber = c;
            }
            Console.WriteLine(biggestNumber);
        }
    }
}
