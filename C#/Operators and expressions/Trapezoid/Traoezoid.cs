using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Traoezoid
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double areaOfTrapezoid = ((a + b) / 2) * h;
            Console.WriteLine("{0:0.0000000}", areaOfTrapezoid);


        }
    }
}
