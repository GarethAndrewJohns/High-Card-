using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Card_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] CardsName = new string[] {"One of Hearts",    "One of Diamonds",   "One of Spades",   "One of Clubs",
                                               "Two of Hearts",    "Two of Diamonds",   "Two of Spades",   "Two of Clubs",
                                               "Three of Hearts",  "Three of Diamonds", "Three of Spades", "Three of Clubs",
                                               "Four of Hearts",   "Four of Diamonds",  "Four of Spades",  "Four of Clubs",
                                               "Five of Hearts",   "Five of Diamonds",  "Five of Spades",  "Five of Clubs",
                                               "Six of Hearts",    "Six of Diamonds",   "Six of Spades",   "Six of Clubs",
                                               "Seven of Hearts",  "Seven of Diamonds", "Seven of Spades", "Seven of Clubs",
                                               "Eight of Hearts",  "Eight of Diamonds", "Eight of Spades", "Eight of Clubs",
                                               "Nine of Hearts",   "Nine of Diamonds",  "Nine of Spades",  "Nine of Clubs",
                                               "Ten of Hearts",    "Ten of Diamonds",   "Ten of Spades",   "Ten of Clubs",
                                               "Jack of Hearts",   "Jack of Diamonds",  "Jack of Spades",  "Jack of Clubs",
                                               "Queen of Hearts",  "Queen of Diamonds", "Queen of Spades", "Queen of Clubs",
                                               "King of Hearts",   "King of Diamonds",  "King of Spades",  "King of Clubs",
                                               "Ace of Hearts",    "Ace of Diamonds",   "Ace of Spades",   "Ace of Clubs"};

            int[] CardsValues = new int[] {1,  1,  1,  1,
                                           2,  2,  2,  2,
                                           3,  3,  3,  3,
                                           4,  4,  4,  4,
                                           5,  5,  5,  5,
                                           6,  6,  6,  6,
                                           7,  7,  7,  7,
                                           8,  8,  8,  8,
                                           9,  9,  9,  9,
                                           10, 10, 10, 10,
                                           11, 11, 11, 11,
                                           12, 12, 12, 12,
                                           13, 13, 13, 13,
                                           14, 14, 14, 14};
            int RandomIndex, i, j;

            Random rnd = new Random();

            //Game Intro
            Console.WriteLine("Welcome to the thrilling and competitive game that is High Card!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Please enter in the number of players that wish to participate:");
            j = Convert.ToInt32(Console.ReadLine());

            //Creates the player arrays
            string[] PlayerNames = new string[j];
            string[] PlayerCards = new string[j];
            int[] PlayerValues = new int[j];

            //Cycles through players giving each of them a name
            i = 0;
            while (i<j)
            {
                i = i + 1;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Enter in the name of Player " + i);
                PlayerNames[i-1] = Console.ReadLine();
            }

            //Game now counts down
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Prepare yourselves! The game is about to begin!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Game starting in ... 3");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Game starting in ... 2");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Game starting in ... 1");
            System.Threading.Thread.Sleep(1000);

            //Card selection process
            i = 0;
            while (i<j)
            {
                i = i + 1;
                RandomIndex = rnd.Next(0, 52);
                PlayerCards[i - 1] = CardsName[RandomIndex];
                PlayerValues[i - 1] = CardsValues[RandomIndex];
                Console.WriteLine(PlayerNames[i - 1] + " has drawn the " + PlayerCards[i - 1] + "!");
                System.Threading.Thread.Sleep(1500);
            }

            //Highest value is found
            int maxValue = PlayerValues.Max();
            int maxIndex = PlayerValues.ToList().IndexOf(maxValue);

            //Winner is declared
            Console.WriteLine("The winner is " + PlayerNames[maxIndex] + "! Congratulations!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
