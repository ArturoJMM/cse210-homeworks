using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.\n");
        Console.ResetColor();

        List<Activity> activities = new List<Activity>
            {
                new Running(DateTime.Now, 30, 3),
                new Cycling(DateTime.Now, 45, 12),
                new Swimming(DateTime.Now, 60, 40),
                new Running(DateTime.Now.AddDays(-1), 10, 1.2),
                new Cycling(DateTime.Now.AddDays(-1), 50, 18),
                new Swimming(DateTime.Now.AddDays(-1), 40, 27),
            };

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine();
            }

    }
}