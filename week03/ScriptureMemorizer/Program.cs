// Exceeding requirements:
// 1. A library of scriptures is stored and one is chosen at random each run.
// 2. HideRandomWords only picks words that are not already hidden.
// 3. Punctuation stays visible when a word is hidden (Example: "world," -> "_____,") as a memory help.

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = new List<Scripture>();
        library.Add(new Scripture(new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        library.Add(new Scripture(new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        library.Add(new Scripture(new Reference("Moroni", 10, 4),
            "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."));

        Random random = new Random();
        int choice = random.Next(library.Count);
        Scripture scripture = library[choice];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
