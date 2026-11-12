using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (choice != "0")
        {
            Console.WriteLine("1. Add an entry");
            Console.WriteLine("2. Show previous entries");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("0. Quit");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = prompt;
                    entry._entryText = response;
                    journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                
                Console.WriteLine("Choose the filename");
                string fileName = Console.ReadLine();
                journal.LoadFile(fileName);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Choose the filename");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (choice == "0")
            {
                Console.WriteLine("Quitting");
            }
            else
            {
                Console.WriteLine("Invalid Option, choose again.");
            }
        } 
    }
}