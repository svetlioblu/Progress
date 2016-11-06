using System;

namespace FibonaciSequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long temp;
            long firstNumber = 0;
            long secondNumber = 1;

            Console.Write(firstNumber);
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(", {0}", secondNumber);
                temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber += temp;
            }
        }
    }
}
