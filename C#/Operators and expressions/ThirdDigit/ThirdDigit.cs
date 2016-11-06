using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int thirdDigit = (input / 100) % 10;

            Console.WriteLine(thirdDigit == 7 ? "true" : "false " + thirdDigit);
        }
    }
}
