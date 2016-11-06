using System;

namespace Nth_BIT
{
    class Program
    {
        static void Main()
        {
            long P = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            //string temp = Convert.ToString(P, 2);
            //Console.WriteLine(temp);
            long mask = 1 << N;
            Console.WriteLine((P & mask) >> N);


        }
    }
}
