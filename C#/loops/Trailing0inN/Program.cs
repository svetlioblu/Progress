using System;
using System.Numerics;

namespace Trailing0inN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fact = 1;
            int counter = 1;
            int zeroCounter = 0;
            int zeroHelper = 0;
            //find the factoriel
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            //print factoriel
            // Console.WriteLine(fact);
            //put factoriel in a array
            string num = fact.ToString();
            int index = fact.ToString().Length;
            int[] intArray = new int[index];

            for (int i = 0; i < index; i++)
            {
                intArray[i] = int.Parse(num.Substring(index - counter, 1));
                counter++;
                if (zeroHelper == 2)
                {
                    Console.WriteLine(zeroCounter);
                    Environment.Exit(0);
                }
                if (intArray[i] == 0)
                {
                    zeroCounter++;
                    zeroHelper = 0;
                }
                zeroHelper++;

            }
            Console.WriteLine(zeroCounter);
        }
    }
}
