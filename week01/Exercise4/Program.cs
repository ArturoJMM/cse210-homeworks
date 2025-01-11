using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        bool play = true;
        
        Console.Write("Enter a list of numbers (negatives and positives), type 0 when finished. ");
       
        while (play)
        {
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
           
            if (userNumber == 0)
            {
                play = false;
            }

            else
            {
                numbers.Add(userNumber);
            }
        }
        
        foreach (int number in numbers)
        {
            Console.WriteLine($"Enter Number: {number}");
        }

        // Compute the sum - Core Requirement N°1
        int sum = numbers.Sum();
        // Compute the average of the total of numbers - Core requirement N°2
        float average = ((float)sum) / numbers.Count;
        average = (float)Math.Round(average, 3);
        // Extract the largest number of the list - Core requirement N°3
        int maxNum = numbers.Max();
        // Extract the smallest positive number. - Stretch Challenge N°1
        int smallPosNum = numbers.Where(n => n > 0).DefaultIfEmpty().Min();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number of the list is: {maxNum}");
        // Display Stretch Challenge N°1
        Console.WriteLine($"The smallest positive number of the list is: {smallPosNum}");
        // Stretch Challenge N°2
        numbers.Sort();
        Console.WriteLine("The Sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}