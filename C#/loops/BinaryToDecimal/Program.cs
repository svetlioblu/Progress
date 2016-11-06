using System;


namespace BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            string binaryNumber = Console.ReadLine();
            int counter = binaryNumber.Length;
            long result = 0;


            Console.WriteLine();
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                long binaryToHex = 1;
                // Console.Write(binaryNumber.Substring(counter - 1, 1));

                if (binaryNumber.Substring(counter - 1, 1) == "1")
                {
                    if (i == 0)
                    {
                        binaryToHex = 1;
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        binaryToHex *= 2;
                    }
                    // Console.Write(binaryToHex + " ");
                    result += binaryToHex;
                }
                counter--;

            }
            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}
