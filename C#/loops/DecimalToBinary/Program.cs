using System;


namespace DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            string convertToBinary = "";
            string result = "";

            while (decimalNumber >= 1)
            {
                convertToBinary += decimalNumber % 2;
                decimalNumber /= 2;
            }


            int counter = convertToBinary.Length;

            for (int i = 0; i < convertToBinary.Length; i++)
            {
                result += convertToBinary.Substring(counter - 1, 1);
                counter--;
            }

            Console.WriteLine(result);
        }
    }
}
