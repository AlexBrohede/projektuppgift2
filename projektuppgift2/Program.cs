using System;
using System.IO;
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
                    string[] Test = new string[6];
                    {
                        Test[0] = "Hi1";
                        Test[1] = "Hi2";
                        Test[2] = "Hi3";
                        Test[3] = "Hi4";
                        Test[4] = "Hi5";
                        Test[5] = "Hi6";
                    }
                    File.WriteAllLines("TestFile.txt", Test);
                    string[] Filecontent = File.ReadAllLines("TestFile.txt");
                    foreach (string Line in Filecontent)
                    {
                        Console.WriteLine(Line);
                    }
                    Console.WriteLine();
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
