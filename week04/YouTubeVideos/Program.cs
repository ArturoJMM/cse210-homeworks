using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.ResetColor();
        Console.WriteLine();

        Video video1 = new Video("Class with Benji Monroy | “The Hearts of Children Will Turn to Parents” | D&C 2", "Scripture Central", 3997);

        video1.AddComment(new Comment("@ibismoraza8355", "Hello Benji, my dear young teacher. Your classes inspire us. I read Come Follow Me daily."));
        video1.AddComment(new Comment("@mariatamayo7992", "Thank you brother Benji for the messages that leave a lot of reflection in our lives that helps us improve within the many experiences we have day to day."));
        video1.AddComment(new Comment("@ediceiamartinez3971", "Hello brother, thank you for this wonderful class and your enlightening drawings."));

        Video video2 = new Video("Class with Benji Monroy | “We Have Entered into a Covenant with Him” | Mosiah 18-24", "Scripture Central", 4130);

        video2.AddComment(new Comment("@denicegore3620", "Hello my friend Benji, thanks for this class that completes the come follow me and how good it is to know that you are well"));
        video2.AddComment(new Comment("@miriamreiser9145", "Hello my beloved benji happy rest day and also to my beautiful brothers"));
        video2.AddComment(new Comment("@mariajara142", "Thank you brother for your words of comfort and hope in God."));

        Video video3 = new Video("Class with Benji Monroy | “They were called the people of God” | Mosiah 25-28", "Scripture Central",4471);

        video3.AddComment(new Comment("@trovador1107", "I look forward to the next presentation. Blessings and greetings from Peru."));
        video3.AddComment(new Comment("@angelamoya8047", "We are not perfect, but the Lord is molding us"));
        video3.AddComment(new Comment("@sandrapineda9873", "Brother Benji, thank you for your beautiful classes, they help me a lot."));
        video3.AddComment(new Comment("@fortunataorellana", "I too wonder what my life would be like without the gospel in my life or the lives of my children."));

        List<Video> videos = new List<Video> {video1, video2, video3};

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.ResetColor();

            foreach (var comment in video.GetComments())
            {
                video.DisplayComment(comment);
            }
            Console.WriteLine();
        }

    }
}