using System;
using System.Linq;


namespace CardSign
{
    class CardSign
    {
        static void Main()
        {
            string card = Console.ReadLine();
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            
            if (cards.Contains(card))
            {
                Console.WriteLine("yes " + card);
            }else
            {
                Console.WriteLine("no " + card);
            }


        }
    }
}
