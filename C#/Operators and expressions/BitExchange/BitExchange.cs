using System;

namespace BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            ulong input = ulong.Parse(Console.ReadLine());
            ulong maskOne = (ulong)1 << 3;
            ulong maskTwo = (ulong)1 << 24;
            ulong maskThree = (ulong)1 << 4;
            ulong maskFour = (ulong)1 << 25;
            ulong maskFive = (ulong)1 << 5;
            ulong maskSix = (ulong)1 << 26;





            if ((input & 1 << 3) >> 3 != (input & 1 << 24) >> 24)
            {

                if ((input & 1 << 3) >> 3 == 1)
                {
                    input = input & ~(maskOne);
                }
                else
                {
                    input = input | maskOne;
                }
                if ((input & 1 << 24) >> 24 == 1)
                {
                    input = input & ~(maskTwo);
                }
                else
                {
                    input = input | maskTwo;
                }

            }
            if ((input & 1 << 4) >> 4 != (input & 1 << 25) >> 25)
            {
                if ((input & 1 << 4) >> 4 == 1)
                {
                    input = input & ~(maskThree);
                }
                else
                {
                    input = input | maskThree;
                }
                if ((input & 1 << 25) >> 25 == 1)
                {
                    input = input & ~(maskFour);
                }
                else
                {
                    input = input | maskFour;
                }
            }
            if ((input & 1 << 5) >> 5 != (input & 1 << 26) >> 26)
            {
                if ((input & 1 << 5) >> 5 == 1)
                {
                    input = input & ~(maskFive);
                }
                else
                {
                    input = input | maskFive;
                }
                if ((input & 1 << 26) >> 26 == 1)
                {
                    input = input & ~(maskSix);
                }
                else
                {
                    input = input | maskSix;
                }
            }

            Console.WriteLine(input);

        }
    }
}
