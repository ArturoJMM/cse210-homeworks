public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "How are you feeling today?",
        "What was the highlight of your day?",
        "Was there a challenge you faced? How did you handle it?",
        "What made you laugh or smile today?",
        "Is there anything you are thankful for today?",
        "What Scripture verse did you read today?",
        "In what ways did you feel God's presence in your life today?",
        "What is a specific blessing you are thankful for today?",

    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}