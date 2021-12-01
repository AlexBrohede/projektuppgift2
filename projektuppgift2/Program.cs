using System;
using System.IO;
using System.Threading;
namespace projektuppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            int SongCount;
            
            int menu1 = 0;
            while (menu1 != 5)
            {
                if (File.Exists("CountFile.txt"))
                {
                    SongCount = int .Parse(File.ReadAllText("CountFile.txt"));
                    string[] Test = new string[SongCount];
                    if (File.Exists("TestFile.txt"))
                    {
                        Console.WriteLine($"1: View toplist \n2: Change list \n3: Search for a song \n4: Reset list \n5: stop");
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
                            Console.WriteLine($"Choose placement \n1-{SongCount}");
                            int ArrayPosition = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Type to change {ArrayPosition}");
                            Test[ArrayPosition - 1] = Console.ReadLine();
                            File.WriteAllLines("TestFile.txt", Test);
                        }
                        else if (menu1 == 3)
                        {
                            bool find = false;
                            int count = 0;
                            Console.WriteLine("Type to search...");
                            string search = Console.ReadLine().ToLower();
                            string[] Filecontent = File.ReadAllLines("TestFile.txt");
                            foreach (string song in Filecontent)
                            {
                                if (song.ToLower().Contains(search))
                                {
                                    Console.WriteLine(song + $", Song nr {count + 1}");
                                    find = true;
                                }
                                count++;
                            }
                            if (find == false)
                            {
                                Console.WriteLine("Couldn't find any songs...");
                            }

                        }
                        else if (menu1 == 4)
                        {
                            {
                                SongCount = 6;
                            }
                            File.WriteAllText("CountFile.txt", SongCount.ToString());
                            for (int i = 0; i < SongCount; i++)
                            {
                                Test[i] = "Empty";
                            }
                            File.WriteAllLines("TestFile.txt", Test);
                            
                        }
                        else if (menu1 == 5)
                        {
                            Console.WriteLine($"Stopping the simulation");
                            Thread.Sleep(1500);
                        }
                        else if (menu1 == 6)
                        {
                            //Test or De bug command
                            Console.WriteLine(SongCount + "\nNew Count");
                            SongCount = int.Parse(Console.ReadLine());
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
                        for (int i = 0; i < SongCount; i++)
                        {
                            Test[i] = "Empty";
                        }
                        File.WriteAllLines("TestFile.txt", Test);
                    }
                }
                else
                {
                    SongCount = 6;     
                }
                File.WriteAllText("CountFile.txt", SongCount.ToString());

            }
        }
    }
}
