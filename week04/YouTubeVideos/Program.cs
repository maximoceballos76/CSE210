using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Make Perfect Coffee", "BaristaPro", 420);
        video1.AddComment(new Comment("Ana", "This changed my mornings!"));
        video1.AddComment(new Comment("Luis", "What grinder do you use?"));
        video1.AddComment(new Comment("Sofia", "Great tips, thanks."));

        Video video2 = new Video("Top 5 Budget Headphones", "TechReviewer", 615);
        video2.AddComment(new Comment("Marco", "I bought the second pair, love them."));
        video2.AddComment(new Comment("Julia", "You forgot the battery life on #3."));
        video2.AddComment(new Comment("Pedro", "Very clear review."));
        video2.AddComment(new Comment("Carla", "Can you test gaming headsets next?"));

        Video video3 = new Video("Beginner Running Shoes Guide", "RunWithMe", 380);
        video3.AddComment(new Comment("Diego", "Finally a guide that makes sense."));
        video3.AddComment(new Comment("Lucia", "Are these good for trail running?"));
        video3.AddComment(new Comment("Tomas", "Subscribed!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
