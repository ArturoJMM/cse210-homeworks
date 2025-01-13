using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2021;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Computer Technician";
        job2._company = "Apple";
        job2._startYear = 2018;
        job2._endYear = 2021;

        //job1.DisplayDetails();
        //job2.DisplayDetails();

        Resume myresume = new Resume();
        myresume._name = "Allison Rose";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        //Console.WriteLine(myresume._jobs[0]._jobTitle);
        myresume.Display();

    }
}