using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to 'Guess my number game!'");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int i = 1;

        while (i == 1)
        {
            Console.Write("Guess my number! ");
            string guessString = Console.ReadLine();
            int guess = int.Parse(guessString);

            if (guess > number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess < number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                i = 0;
            }
        }
    }
}