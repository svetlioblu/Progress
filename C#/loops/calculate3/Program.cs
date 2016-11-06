using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace calculate3
{
    class Program
    {
        static void Main()
        //N! / (K!*(N - K)!)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());
            BigInteger substraction = N - K;
            BigInteger factorielN = 1;
            BigInteger factorielK = 1;
            BigInteger factoriel3 = 1;

            for (int i = 1; i <= N; i++)
            {
                factorielN *= i;



            }
            for (int i = 1; i <= K; i++)
            {
                factorielK *= i;
            }

            for (int i = 1; i <= substraction; i++)
            {
                factoriel3 *= i;
            }


            Console.WriteLine("{0}", (factorielN / (factorielK * factoriel3)));
           

        }
    }
}
