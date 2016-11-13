using System;

namespace BobbyAvocadoto
{
    class BobbyAvocadoto
    {
        //Bobi's head is represented by an integer N. All C combs that he can buy are 
        //    also represented as integers. Bobi can use a comb only if his head and the comb 
        //    don't have any overlapping set(1) bits
        //    (the 1s in N represent hairs and 0s represent bald spots and the 1s in a comb represent 
        //    the comb's teeth). The best comb for Bobi is the comb with most teeth(bits set to 1) that he can 
        //    use. Write a program that finds the best comb 
        //    for Bobi by given N and combs, and prints it on the console.
        static void Main()
        {
            int head = int.Parse(Console.ReadLine());
            int numberOfCombs= int.Parse(Console.ReadLine());
            int bestCount = 0;
            int bestComb = 0;
            for (int i = 0; i < numberOfCombs; i++)
            {
               int comb = int.Parse(Console.ReadLine());
                // check if comb is valid. Don't have any overlapping set(1) bits
                if ((head & comb) == 0)
                {
                    int currentCount = 0;
                    //count number of combs teeth
                    for (int j = 0; j < 32; j++)
                    {
                        currentCount += (int)((comb >> j) & 1);
                       
                    }
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestComb = comb;
                        
                    }


                }
            }
            Console.WriteLine(bestComb);
        }
    }
}
