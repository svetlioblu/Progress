using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintADeck
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int card;
            bool numberOrNot = int.TryParse(input, out card);
            if (numberOrNot == false)
            {
              
                if (input == "J")
                {
                    for (int i = 2; i < 10; i++)
                    {

                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);




                    }
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                }else if(input == "Q")
                {
                    for (int i = 2; i < 10; i++)
                    {

                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);




                    }
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");

                }else if (input == "K")
                {
                    for (int i = 2; i <= 10; i++)
                    {

                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);




                    }
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                    Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");


                }else if (input=="A") {
                    for (int i = 2; i <=10; i++)
                    {

                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);




                    }
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                    Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                    Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");


                }

            }
            else
            {
                for (int i = 2; i <= card; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
            }
        }
    }
}
