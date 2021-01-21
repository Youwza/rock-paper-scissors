using System;

namespace rock_paper_scissors
{
    class Program
    {

        // Stats
        public static int wins = 0;
        public static int loss = 0;
        public static int draw = 0;
        public static int rounds = 0;

        static void Main(string[] args)
        {

            Play();

            // The game
            static void Play()
            {
                char input;
                PrintInfo();
                PrintRound();
                input = Console.ReadKey().KeyChar;

                while (input == 'r' || input == 'p' || input == 's' || input == 'R' || input == 'P' || input == 'S')
                {
                    Console.WriteLine();
                    int userDraw = UserChoice(input);
                    int opponentDraw = ComputerChoice();
                    if (userDraw == (opponentDraw + 1) || userDraw == (opponentDraw - 2))
                    {
                        Console.WriteLine("\n\tYou won! \\( '-' )/");
                        wins++;
                    }
                    else if (userDraw == (opponentDraw - 1) || userDraw == (opponentDraw + 2))
                    {
                        Console.WriteLine("\n\tYou lost! ( ;-; )");
                        loss++;
                    }
                    else
                    {
                        Console.WriteLine("\n\tIt's a tie!");
                        draw++;
                    }
                    Console.WriteLine("\nPlay again? Choose [r]ock, [p]aper or [s]cissors...\n");
                    PrintRound();
                    input = Console.ReadKey().KeyChar;
                }
                Console.WriteLine("\tYou won " + wins + " out of " + (wins + loss + draw) + " games.");
                Console.WriteLine("\tYou lost " + loss + " and tied " + draw + " games.");

                if (wins > loss)
                {
                    Console.WriteLine("\tWell done!");
                }
                else
                {
                    Console.WriteLine("\tBetter luck next time!");
                }

                Console.WriteLine("\n\tGood bye!");
            }

            static int UserChoice(char input)
            {
                int userDraw;
                switch (input)
                {
                    case 'r':
                    case 'R':
                        Console.WriteLine("\tYou drew ROCK!");
                        userDraw = 1;
                        break;
                    case 'p':
                    case 'P':
                        Console.WriteLine("\tYou drew PAPER!");
                        userDraw = 2;
                        break;
                    default:
                        Console.WriteLine("\tYou drew SCISSORS!");
                        userDraw = 3;
                        break;
                }
                return userDraw;
            }

            // 
            static int ComputerChoice()
            {
                Random value = new Random();
                int computerDraw = value.Next(0, 3);
                switch (computerDraw)
                {
                    case 1:
                        Console.WriteLine("\tYour opponent drew ROCK!");
                        break;
                    case 2:
                        Console.WriteLine("\tYour opponent drew PAPER!");
                        break;
                    default: // case 0
                        Console.WriteLine("\tYour opponent drew SCISSORS!");
                        break;
                }
                return computerDraw;
            }

            static void PrintRound()
            {
                rounds++;
                Console.Write("Round " + rounds + ": ");
            }

            // Funktion att skriva ut instruktionerna
            static void PrintInfo()
            {
                Console.WriteLine("\nPlay Rock, paper, scissors!");
                Console.WriteLine("\n\t> ROCK: Type R for rock...");
                Console.WriteLine("\t> PAPER: type P for paper...");
                Console.WriteLine("\t> SCISSORS: type S for scissors...\n");
            }
        }
    }
}
