public class ListingActivity : Activity
{
    private List<string> _prompts =new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int _count;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
    }
     
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"---> {prompt} <---");
    }

    public List<string> GetListFormUser()
    {
        List<string> items = new List<string>();
        return items;
    }

     public void Start()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        List<string> items = GetListFormUser();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
            _count++;
        }

        Console.WriteLine($"You listed {_count} responses.");
        DisplayEndingMessage();

    }
}