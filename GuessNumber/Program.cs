using System;

namespace FindTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new Random();
                int toFind = rnd.Next(1, 21);
                int attempt = 0;
                bool ContGame = true;

                Console.WriteLine("Find the number from 1 to 20:");

                while (ContGame)
                {
                    int UserGuess;
                    bool validInput = int.TryParse(Console.ReadLine(), out UserGuess);

                    if (!validInput || UserGuess < 1 || UserGuess > 20)
                    {
                        Console.WriteLine("Invalid input. Enter a number between 1 and 20.");
                        continue;
                    }

                    if (UserGuess > toFind)
                    {
                        attempt++;
                        Console.WriteLine($"Lower. Attempts: {attempt}");
                    }
                    else if (UserGuess < toFind)
                    {
                        attempt++;
                        Console.WriteLine($"Higher. Attempts: {attempt}");
                    }
                    else
                    {
                        Console.WriteLine("You won!");
                        Console.WriteLine($"Attempts: {attempt}");
                        ContGame = false;
                        Exit();
                    }

                    if (attempt == 5)
                    {
                        Console.WriteLine("You lost.");
                        Console.WriteLine($"The correct number was: {toFind}");
                        ContGame = false;
                        Exit();
                    }
                }
            }
        }

        static void Exit()
        {
            Console.WriteLine("Press Spacebar to play again.");
            Console.WriteLine("Press Tab to exit.");
            bool input = true;

            while (input)
            {
                var next = Console.ReadKey(true);
                if (next.Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    input = false;
                    return;
                }
                else if (next.Key == ConsoleKey.Tab)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }
    }
}