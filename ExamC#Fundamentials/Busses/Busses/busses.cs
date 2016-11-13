using System;

namespace Busses
{
    //            Given the sequence of the speeds of the buses, 
    //            print on the console the number of groups that are formed.
    //              buses cannot outrun buses in front of them
    //              If bus A is moving faster and reaches a bus B that is moving slower,
    //              then A must lower its speed to match that of B
    //              buses with equal speeds does not form a group
    //              Their form different groups

    class busses
    {
        static void Main()
        {
            int busses = int.Parse(Console.ReadLine());
            int groupspeed = int.MaxValue;
            int groupCount = 0;
      
            for (int i = 0; i < busses; i++)
            {
                int speed = int.Parse(Console.ReadLine());
                if (speed <= groupspeed) {
                    groupspeed = speed;
                    groupCount++;
                }
              
                    
                }
            Console.WriteLine(groupCount);
        }
        

        }
    }


