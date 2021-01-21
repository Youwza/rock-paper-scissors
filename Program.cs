using System;

namespace rock_paper_scissors
{
    class Program
    {

        static void Main(string[] args)
        {
            Play();
        }

        // The game
        static void Play()
        {
            char input;
            PrintInfo();
            InitRound();
            input = Console.ReadKey().KeyChar;

            while (input == 'r' || input == 'p' || input == 's' || input == 'R' || input == 'P' || input == 'S')
            {
                Console.WriteLine();
                int userDraw = UserChoice(input);
                int opponentDraw = ComputerChoice();
                if (userDraw == opponentDraw)
                {
                    Console.WriteLine("\n\tIt's a tie!");
                    draw++;
                }
                else if (userDraw == (opponentDraw + 1) || userDraw == (opponentDraw - 2))
                {
                    Console.WriteLine("\n\tYou won! \\( '-' )/");
                    wins++;
                }
                else
                {
                    Console.WriteLine("\n\tYou lost! ( ;-; )");
                    loss++;
                }
                Console.WriteLine("\nPlay again? Choose [r]ock, [p]aper or [s]cissors...\n");
                InitRound();
                input = Console.ReadKey().KeyChar;
            }
            Console.WriteLine("\n\n\tYou won " + wins + " out of " + (wins + loss + draw) + " games.");
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

        // Stats
        public static int wins = 0;
        public static int loss = 0;
        public static int draw = 0;
        public static int rounds = 0;

        // Draws
        public static string[] Choice = { "rock", "paper", "scissors" };

        // Opponent's turn
        static int ComputerChoice()
        {
            Random value = new Random();
            int computerDraw = value.Next(0, 3);
            switch (computerDraw)
            {
                case 0:
                    break;
                case 1:
                    break;
                default: // case 2
                    break;
            }
            Console.WriteLine("\tYour opponent drew " + Choice[computerDraw].ToUpper() + "!");
            return computerDraw;
        }

        // User's turn
        static int UserChoice(char input)
        {
            int userDraw;
            switch (input)
            {
                case 'r':
                case 'R':
                    userDraw = 0;
                    break;
                case 'p':
                case 'P':
                    userDraw = 1;
                    break;
                default:
                    userDraw = 2;
                    break;
            }
            Console.WriteLine("\tYou drew " + Choice[userDraw].ToUpper() + "!");
            return userDraw;
        }

        // Init round
        static void InitRound()
        {
            rounds++;
            Console.Write("Round " + rounds + ": ");
        }

        // Print instructions
        static void PrintInfo()
        {
            Console.WriteLine("\nPlay Rock, paper, scissors!");
            Console.WriteLine("\n\t> ROCK: Type R for rock...");
            Console.WriteLine("\t> PAPER: type P for paper...");
            Console.WriteLine("\t> SCISSORS: type S for scissors...\n");
        }

    }
}
