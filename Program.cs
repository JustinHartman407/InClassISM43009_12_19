using System;

namespace InClassISM43009_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your age");
            int age = int.Parse(Console.ReadLine());
            

            try
            {
                if ((age == 25))
                {
                    Console.WriteLine("How many interations do you want to run Justin? ");
                    int number = int.Parse(Console.ReadLine());

                    int i = 0, limit = 4;
                    do
                    {
                        Console.WriteLine("you've entered:" + " " + number + "You've entered 4, this is the current integer of the value loop : "
                            + i);
                        i++;
                    }
                    while (i < limit);
                }

               
            }
            catch
            {
                Console.WriteLine("error");
            }
        }
    }
}
