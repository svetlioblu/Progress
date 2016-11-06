using System;

namespace _3d_bit
{
    class Program
    {
        static void Main()
        {
            int thirdBit = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            //string bits = Convert.ToString(thirdBit, 2);
            //Console.WriteLine(bits);

            Console.WriteLine((thirdBit & mask) >> 3);
        }
    }
}
