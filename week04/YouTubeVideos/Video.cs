public class Video
{
    // Properties to track the title, author, and length of the video.
    private string _title;
    private string _author;
    private int _videoLength;
    
     // List to store the comments related to the video.
    private List<Comment> comments = new List<Comment>();

    // Constructor to initialize the video.
    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
    }

    public void DisplayVideoInfo()
    {
        string videoData = $"Title: {_title} \nAuthor: {_author}\nLength: {_videoLength} seconds";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(videoData);
    }

    // Method to add a comment to the video.
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

     // Method to return the number of comments.
    public int GetCommentCount()
    {
        return comments.Count;
    }

     // Method to get the comments.
    public List<Comment> GetComments()
    {
        return comments;
    }

    public void DisplayComment(Comment comment)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"The user {comment.GetCommenterName()} wrote: ");
        Console.ResetColor();
        Console.WriteLine($"'{comment.GetText()}'");
    }

}