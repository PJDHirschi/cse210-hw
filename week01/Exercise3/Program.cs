using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Guess My Number ===");


        while (true)
        {

            Random rng = new Random();
            int magic = rng.Next(1, 101);

            int attempts = 0;
            int guess = 0;


            while (guess != magic)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a whole number (e.g., 42).");
                    continue;
                }

                attempts++;

                if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Guesses taken: {attempts}");
                }
            }


            Console.Write("Play again? (yes/no) ");
            string again = (Console.ReadLine() ?? "").Trim().ToLower();

            if (again != "yes" && again != "y")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }

            Console.WriteLine();
        }
    }
}
