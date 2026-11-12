using System;

public class PromptGenerator
{
     List<string> questions = new List<string> {"What was the best part of your day?", "Did you talk to someone interesting", "Is it something you would do again?", 
"Did your day lack anything?", "From 1 to 10, how would you rate your day?"};

    public string GetRandomPrompt()
    {
    Random random = new Random();
    int number = random.Next(questions.Count);
    return questions[number];
    }
}
