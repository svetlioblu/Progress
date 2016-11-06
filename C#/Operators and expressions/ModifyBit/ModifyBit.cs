using System;


namespace ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            ulong N = ulong.Parse(Console.ReadLine());//number
            int P = int.Parse(Console.ReadLine());// place
            int V = int.Parse(Console.ReadLine());//bit

            ulong mask =(ulong) 1 << P;
            if (V == 0)
            {
                ulong resultZero = N & ~(mask);
                Console.WriteLine(resultZero);

            }
            else
            {
                ulong resultOne =(ulong) N | mask;
                Console.WriteLine(resultOne);
            }


        }
    }
}

