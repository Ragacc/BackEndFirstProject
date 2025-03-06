using System;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[]
            {
                "boomfire", "boom", "xl", "celsius", "reign",
                "rockstar", "monster", "bang", "nos", "redbull"
            };
            Random rand = new Random();
            string wordToGuess = words[rand.Next(words.Length)];

            char[] wordProgress = new string('_', wordToGuess.Length).ToCharArray();

            int attempts = 10;

            Console.WriteLine("Welcome to HangMan! Try to guess the hidden word.");
            Console.WriteLine("The word to guess has " + wordToGuess.Length + " letters.");

            while (attempts > 0)
            {
                Console.WriteLine("Current progress: " + new string(wordProgress));
                Console.WriteLine($"You have {attempts} attempts left.");

                Console.Write("Enter a letter: ");
                char guess = Char.ToLower(Console.ReadLine()[0]);

                bool correctGuess = false;

                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess && wordProgress[i] == '_')
                    {
                        wordProgress[i] = guess;
                        correctGuess = true;
                    }
                }

                if (!correctGuess)
                {
                    attempts--;
                    Console.WriteLine("Wrong guess! Try again.");
                }

                if (new string(wordProgress) == wordToGuess)
                {
                    Console.WriteLine("Congratulations! You've guessed the word: " + wordToGuess);
                    break;
                }

                if (attempts == 0)
                {
                    Console.WriteLine("Game over! You've run out of attempts.");
                    Console.WriteLine("The correct word was: " + wordToGuess);
                }
            }
        }
    }
}
