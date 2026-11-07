using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "no letter";

        Console.Write("What are your grades? ");
        
        string input = Console.ReadLine();
        int grades = int.Parse(input);

        if (grades >= 90 && grades < 101)
        {
            letter = "A";
            Console.WriteLine(letter);
        }
        else if (grades >= 80)
        {
            letter = "B";
            Console.WriteLine(letter);
        }
        else if (grades >= 70)
        {
            letter = "C";
           Console.WriteLine(letter); 
        }
        else if (grades >= 60)
        {
            letter = "D";
           Console.WriteLine(letter); 
        }
        else if (grades < 60 && grades > -1)
        {
            letter = "F";
            Console.WriteLine(letter);
        }
        else
        {
            Console.WriteLine("That is not a valid grade");
        }

        if (grades >= 70 && grades < 101)
        {
            Console.WriteLine("Congratulations! You've passed");
        }
        else if (grades >= 0 && grades < 70)
        {
            Console.WriteLine("You didn't pass. Maybe next time!");
        }
        
    }
}