using System;

namespace PagesInDigits
{
    //    A book has N pages, numbered from 1 to N(1, 2, 3, ... N - 1, N).
    //The total number of digits in the page numbers is D.
    //How many pages does the book have?
    //In other words: Write a program to find the number N.
    class NumberOfPages
    {
        static void Main()
        {
            int digits = int.Parse(Console.ReadLine());
            int pages = 0;
            for (int i = 1; digits != 0; i++)
            {
                pages++;
                digits -= i.ToString().Length;
            }
            Console.WriteLine(pages);
        }
    }
}
