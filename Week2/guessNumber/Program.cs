using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Number Guessing Game ===");
            Console.WriteLine();

            Console.Write("Enter minimum value (a): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter maximum value (b): ");
            int b = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            int answer = random.Next(a, b + 1);

            Console.WriteLine($"\nGuess a number between {a} and {b}");
            Console.WriteLine();

            int guess;

            while (true)
            {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < answer)
                {
                    Console.WriteLine("Higher.");
                }
                else if (guess > answer)
                {
                    Console.WriteLine("Lower.");
                }
                else
                {
                    Console.WriteLine($"\nCorrect.");
                    break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nGame Over.");
        }
    }
}
