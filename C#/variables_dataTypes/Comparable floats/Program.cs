using System;
namespace Comparable_floats
{
    class Program
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double result;
            if (firstNumber > secondNumber)
            {

                result = firstNumber - secondNumber;
            }
            else
            {
                result = secondNumber - firstNumber;
            }

            if (result > eps || result == eps)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");

            }

        }
    }
}
