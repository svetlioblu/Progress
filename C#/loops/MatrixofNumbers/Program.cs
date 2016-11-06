using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixofNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i < n + 1; i++)
            {
                Console.Write("{0} ", i);
                for (int j = i + 1; j < n + i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
