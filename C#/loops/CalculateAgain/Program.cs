using System;

using System.Numerics;

namespace CalculateAgain
{
    class Program
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            BigInteger secondFactoriel = 1;
            int counter = 1;
            BigInteger sum = 0;


            for (int i = 1; i <= n; i++)
            {
                if (counter > k)
                {
                    secondFactoriel *= i;
                }
                if (counter <= n)
                {
                    factoriel *= counter;
                    counter++;
                    secondFactoriel *= i;
                }
            }

            sum = secondFactoriel / factoriel;

            Console.WriteLine(sum);
        }
    }
}
