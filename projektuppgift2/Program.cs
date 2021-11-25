using System;
using System.IO;
using System.Threading;
namespace projektuppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Test = new string[6];
            int menu1 = 0;
            while (menu1 != 5)
            {              
                if (File.Exists("TestFile.txt"))
                {
                    Console.WriteLine($"1: Test File sys \n2: Manage text \n3: Search for song \n4: Reset \n5: stop");
                    menu1 = int.Parse(Console.ReadLine());
                    if (menu1 == 1)
                    {
                        string[] Filecontent = File.ReadAllLines("TestFile.txt");
                        foreach (string Line in Filecontent)
                        {
                            Console.WriteLine(Line);
                        }
                        Console.WriteLine();
                    }
                    else if (menu1 == 2)
                    {
                        Console.WriteLine($"Choose array position \n1-6");
                        int ArrayPosition = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Change text in position {ArrayPosition}");
                        Test[ArrayPosition - 1] = Console.ReadLine();
                        File.WriteAllLines("TestFile.txt", Test);
                    }
                    else if (menu1 == 3)
                    {
                        int count = 0;
                        Console.WriteLine("Type to search...");
                        string search = Console.ReadLine().ToLower();
                        string[] Filecontent = File.ReadAllLines("TestFile.txt");
                        foreach  (string song in Filecontent)
                        {
                            if (song.ToLower().Contains(search))
                            {
                                count++;
                                Console.WriteLine(song + $"Song nr {count}");
                            }
                            else
                            {
                                Console.WriteLine("Couldn't find any songs...");
                            }
                        }
                    }
                    else if (menu1 == 4)
                    {
                        {
                            Test[0] = "Hi1";
                            Test[1] = "Hi2";
                            Test[2] = "Hi3";
                            Test[3] = "Hi4";
                            Test[4] = "Hi5";
                            Test[5] = "Hi6";
                        }
                        File.WriteAllLines("TestFile.txt", Test);
                    }
                    else if (menu1 == 5)
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
                else
                {
                    {
                        Test[0] = "Hi1";
                        Test[1] = "Hi2";
                        Test[2] = "Hi3";
                        Test[3] = "Hi4";
                        Test[4] = "Hi5";
                        Test[5] = "Hi6";
                    }
                    File.WriteAllLines("TestFile.txt", Test);
                }
            }
        }
    }
}
