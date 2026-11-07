using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.Write("Choose a magic number ");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 1543235;
        int tries = 0;

        Console.WriteLine("You have to guess the magic number");

        while (guess != magicNumber)
        {
            string attempt = Console.ReadLine();
            guess = int.Parse(attempt);
            tries = tries + 1;
            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!!!");
                Console.WriteLine($"It took you {tries} attempts");
            }
            else
            {
                Console.Write("You didn't guess it. ");
                if (guess > magicNumber)
                {
                    Console.WriteLine("Try lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Try higher");
                }
                
            }
        }
    }
}