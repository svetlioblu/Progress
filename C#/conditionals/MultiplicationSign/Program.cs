using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double multiplication = a * b * c;
            if (multiplication < 0)
            {
                Console.WriteLine("-");
            }else if (multiplication > 0)
            {
                Console.WriteLine("+");
            }else if (multiplication == 0)
            {
                Console.WriteLine("0");
            }
           

        }
    }
}
