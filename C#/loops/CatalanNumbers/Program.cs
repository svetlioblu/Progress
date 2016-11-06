using System;
using System.Numerics;

namespace CatalanNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger nFact = 1;
            BigInteger sum = 0;
            BigInteger nPlus1Fact = 1;
            BigInteger twoNFact = 1;
            BigInteger sum1 = 0;
            BigInteger result = 0;


            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
            }
            for (int i = 1; i <= 2 * n; i++)
            {
                twoNFact *= i;
            }
            for (int i = 1; i <= (n + 1); i++)
            {
                nPlus1Fact *= i;
            }

            sum = twoNFact;
            sum1 = nPlus1Fact * nFact;
            result = sum / sum1;

            Console.WriteLine(result);

        }
    }
}
