using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int a = (input / 1000) % 10;
            int b = (input / 100) % 10;
            int h = (input / 10) % 10;
            int d = input % 10;
            Console.WriteLine(a);
            //SUM
            int inputCopy = input;
            
            int sum = input.ToString().Sum(c => c - '0');
            Console.WriteLine(sum);

            //REVERSE
            string thirdDigit = Convert.ToString(input);

            Console.WriteLine("{0}{1}{2}{3}",thirdDigit[3],thirdDigit[2],thirdDigit[1],thirdDigit[0]);

            //Last digit in first position
            int lastDigit = (input % 10);
            int takeLastFirstDigits = (input - (input % 10)) / 10;
            Console.WriteLine("{0}{1}", lastDigit, takeLastFirstDigits);

            // Change second and third place
            int secondDigit = (input / 100) % 10;
            
            Console.WriteLine("{0}{1}{2}{3}", thirdDigit[0], thirdDigit[2], thirdDigit[1], thirdDigit[3]);












        }
    }
}
