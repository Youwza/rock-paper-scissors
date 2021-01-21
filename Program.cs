using System;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {

            Play();

            // The game
            static void Play()
            {
                char input;
                PrintInfo();
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                while (input == 'r' || input == 'p' || input == 's' || input == 'R' || input == 'P' || input == 'S')
                {
                    int userDraw = UserChoice(input);
                    int opponentDraw = ComputerChoice();
                    if (userDraw == (opponentDraw + 1) || userDraw == (opponentDraw - 2))
                    {
                        Console.WriteLine("You won! \\( '-' )/");
                    }
                    else if (userDraw == (opponentDraw - 1) || userDraw == (opponentDraw + 2))
                    {
                        Console.WriteLine("You lost! ( ;-; )");
                    }
                    else
                    {
                        Console.WriteLine("It's a tie!");
                    }
                    Console.WriteLine("\nPlay again? Choose [r]ock, [p]aper or [s]cissors...\n");
                    input = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                //Console.WriteLine("You won " + wins + " out of " + (wins + loss + draw) + " times.");
                Console.WriteLine("Good bye!");
            }

            static int UserChoice(char input)
            {
                int userDraw;
                switch (input)
                {
                    case 'r':
                    case 'R':
                        Console.WriteLine("You drew ROCK!");
                        userDraw = 1;
                        break;
                    case 'p':
                    case 'P':
                        Console.WriteLine("You drew PAPER!");
                        userDraw = 2;
                        break;
                    default:
                        Console.WriteLine("You drew SCISSORS!");
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
                        Console.WriteLine("Your opponent drew ROCK!");
                        break;
                    case 2:
                        Console.WriteLine("Your opponent drew PAPER!");
                        break;
                    default: // case 0
                        Console.WriteLine("Your opponent drew SCISSORS!");
                        break;
                }
                return computerDraw;
            }

            // Funktion att skriva ut instruktionerna
            static void PrintInfo()
            {
                Console.WriteLine("\nPlay Rock, paper, scissors!");
                Console.WriteLine("\n\tROCK: Type R for rock...");
                Console.WriteLine("\tPAPER: type P for paper...");
                Console.WriteLine("\tSCISSORS: type S for scissors...\n");
            }
        }
    }
}
