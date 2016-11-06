using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine()), s = 1, pow = 1, fact = 1;

            for (int i = 1; i <= n; i++)
            {
                pow *= x;
                fact *= i;
                s += fact / pow;
            }

            Console.WriteLine("{0:0.00000}", s);
        }
    }
}
