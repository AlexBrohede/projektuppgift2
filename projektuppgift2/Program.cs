using System;
using System.Threading;
namespace projektuppgift2
{
    class Program
    {
        static void Main(string[] args)
        {      
            int menu1 = 0;
            while (menu1 != 4)
            {
                Console.WriteLine($"menu1 \n4: stop");
                menu1 = int.Parse(Console.ReadLine());
                if (menu1 == 1)
                {

                }
                else if (menu1 == 2)
                {

                }
                else if (menu1 == 3)
                {

                }
                else if (menu1 == 4)
                {
                    Console.WriteLine($"Stopping the simulation");
                    Thread.Sleep(1500);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("That was not an option \nPress any key to pick again");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
