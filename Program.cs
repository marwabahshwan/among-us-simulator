using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___Among_Us_game
{
    internal class Program
    {
        static Random rand = new Random();
        static int RandomNumber(int playersNumber)
        {

            int num = rand.Next(1, playersNumber);
            return num;
        }

        static void BeginningInterface()
        {
            Console.WriteLine("\n         --- AMONG US --- \n");


            Console.WriteLine(@"          .-----------.  ");
            Console.WriteLine(@"         /             \ ");
            Console.WriteLine(@"        /               \ ");
            Console.Write(@"       /    ");


            Console.Write(" -------");

            Console.WriteLine(@"     \");
            Console.Write(@"       |   ");

            Console.Write(" |       |");

            Console.WriteLine(@"    |");
            Console.WriteLine(@"    .--|    '-------'    |");
            Console.WriteLine(@"    |  |                 |");
            Console.WriteLine(@"    |  |                 |");
            Console.WriteLine(@"    '--|                 |");
            Console.WriteLine(@"       |      .---.      |");
            Console.WriteLine(@"       |     |     |     |");
            Console.WriteLine(@"       |_____|     |_____|");
            Console.WriteLine(@"        '---'       '---'");

            Console.WriteLine("\n      [ Identity Verified ]\n");


            Console.Write("Enter the number of players (between 5-10): ");
        }

        static int PlayersNumbers()
        {
            int playersNumber = int.Parse(Console.ReadLine());
            while (playersNumber < 5 || playersNumber > 10)
            {
                if (playersNumber < 5)
                {
                    Console.Write("Players must be 5 at least: ");
                    playersNumber = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Players must be 10 or less: ");
                    playersNumber = int.Parse(Console.ReadLine());
                }
            }

            return playersNumber;
        }

        static void PlayersNames(string[] Players, int playersNumber)
        {
            Console.Write("Enter your name: ");
            Players[0] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\nEnter the players' names: ");
            Console.WriteLine("Player 1: " + Players[0]);
            for (int i = 1; i < playersNumber; i++)
            {
                Console.Write("Player " + (i + 1) + ": ");
                Players[i] = Console.ReadLine();
            }

            Console.WriteLine(@"      .          .           .      *     .          ");
            Console.WriteLine(@"  *         .          .         .            .      ");
            Console.WriteLine(@"       .          *        .           .             ");
            Console.WriteLine(@"  .         ____          .      .           *       ");
            Console.WriteLine(@"       .   /    \    .          .         .          ");
            Console.WriteLine(@"  *       |  ()  |       .           .        .      ");
            Console.WriteLine(@"      .    \____/             .           .          ");
            Console.WriteLine(@"  .            .          *          .               ");
            Console.WriteLine(@"      *             .           .            *       ");
            Console.WriteLine();
        }

        static void Level1(string[] Players, int playersNumber, string victim)
        {
            Console.WriteLine("Welcome " + Players[0] + ". You are the leader here with " + (playersNumber - 1) + " other crewmates.\nSomething is weird.. Check the rooms.\n");


            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("              ###  LEVEL 1  ###");
            Console.WriteLine("-----------------------------------------------");

            while (true)
            {
                Console.WriteLine("This is the Power Room.\nCheck: [1] Cables, [2] Floor, [3] Next level");
                int Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    Console.WriteLine("Someone cut the cables!\n");
                    Console.WriteLine("-----------------------------------------------\n");
                    continue;
                }
                else if (Choice == 2)
                {
                    Console.WriteLine("You found an ID card for " + victim + "\n");
                    Console.WriteLine("-----------------------------------------------\n");
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    Console.Clear();

                    break;
                }
            }
        }

        static void Level2(string[] Players, int imposterIndex, int victimIndex, int innocentIndex, string Imposter)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("              ###  LEVEL 2  ###");
            Console.WriteLine("-----------------------------------------------");

            while (true)
            {
                Console.WriteLine("You entered the Security Room.\nCheck: [1] Camera, [2] Deleted File, [3] Next Level");
                int Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    for (int i = 1; i < Players.Length; i++)
                    {
                        if (i != victimIndex && i != imposterIndex)
                        {
                            innocentIndex = i;
                            Console.WriteLine(Players[innocentIndex] + " is doing his task\n");
                            Console.WriteLine("-----------------------------------------------\n");
                            break;
                        }
                    }

                    continue;
                }
                else if (Choice == 2)
                {
                    Console.WriteLine("What does " + Imposter + " do?\n");
                    Console.WriteLine("-----------------------------------------------\n");
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    Console.Clear();

                    break;
                }
            }
        }

        static void Level3(string[] Players, string victim, int victimIndex, int imposterIndex, int innocentIndex, int innocentIndex2)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("              ###  LEVEL 3  ###");
            Console.WriteLine("-----------------------------------------------");

            while (true)
            {
                Console.WriteLine("You went to the Storing Room to see what happened.\nCheck: [1] There is something on the floor, [2] Phone?, [3] Next Level");
                int Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    Console.WriteLine("That's " + victim + "'s body!\n");
                    Console.WriteLine("-----------------------------------------------\n");
                    continue;
                }
                else if (Choice == 2)
                {
                    Console.WriteLine("That's " + victim + "'s phone. There's a message\n\n");

                    for (int i = 1; i < Players.Length; i++)
                    {
                        if (i != victimIndex && i != imposterIndex && i != innocentIndex)
                        {
                            innocentIndex2 = i;
                            break;
                        }
                    }

                    Console.WriteLine("____________________________________________________________________");
                    Console.WriteLine("|    *" + Players[innocentIndex2] + "*                                                        |");
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("|                                                                   |");
                    Console.WriteLine("|[" + victim + "]: I finished my task. What about you?                       |");
                    Console.WriteLine("|[" + Players[innocentIndex2] + "]: Yea, almost                                               |");
                    Console.WriteLine("|[" + victim + "]: Hey, where are you? I'm in the storing room               |");
                    Console.WriteLine("|                       New message                                 |");
                    Console.WriteLine("|[" + Players[innocentIndex2] + "]: Sorry I have another task to do                           |");
                    Console.WriteLine("--------------------------------------------------------------------\n");

                    Console.WriteLine("-----------------------------------------------\n");
                    continue;
                }
                else
                {
                    Console.WriteLine();
                    Console.Clear();

                    break;
                }
            }
        }

        static void Vote(string[] Players, int victimIndex, string Imposter, int playersNumber)
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*                           VOTE                          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("          It's time to vote for the imposter..\n");


            for (int i = 1; i < Players.Length; i++)
            {
                if (i != victimIndex)
                {
                    Console.Write("   [" + Players[i] + "] ");
                }
            }
            Console.WriteLine();

            Console.Write("                    ");
            string choice = Console.ReadLine();
            bool x = false;
            do
            {
                if (choice == Imposter)
                {
                    Console.WriteLine("\n\n          " + Imposter + " Was the imposter. You win!");
                    Console.WriteLine("\n**************************VICTORY*******************************");
                    Console.WriteLine("****************************************************************");
                    x = true;
                }
                else
                {
                    for (int i = 1; i < playersNumber; i++)
                    {
                        if (choice == Players[i])
                        {
                            Console.WriteLine("\n\n          " + choice + " Was not the imposter. " + Imposter + " wins");
                            Console.WriteLine("\n**********************GAME IS OVER*************************");
                            Console.WriteLine("***********************************************************");
                            x = true;
                            x = true;
                        }
                    }
                    if (x == false)
                    {
                        Console.Write("\nYou must vote for one of the players: ");
                        choice = Console.ReadLine();
                    }
                }
            } while (x == false);
        }
        static void Main(string[] args)
        {
            BeginningInterface();
            int playersNumber = PlayersNumbers();
            string[] Players = new string[playersNumber];

            PlayersNames(Players, playersNumber);

            int imposterIndex = RandomNumber(playersNumber);
            string Imposter = Players[imposterIndex];
            int victimIndex;
            int innocentIndex = 0;
            int innocentIndex2 = 0;

            do
            {
                victimIndex = RandomNumber(playersNumber);

            } while (victimIndex == imposterIndex);

            string victim = Players[victimIndex];

            //Console.WriteLine("Victim: " + victim);
            //Console.WriteLine("Imposter: " + Imposter);

            Level1(Players, playersNumber, victim);

            Level2(Players, imposterIndex, victimIndex, innocentIndex, Imposter);

            Level3(Players, victim, victimIndex, imposterIndex, innocentIndex, innocentIndex2);

            Vote(Players, victimIndex, Imposter, playersNumber);

        }
    }
}

