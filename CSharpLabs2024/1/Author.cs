public class Author
{
    private string _authorName;

    public Author(string authorName)
    {
        _authorName = authorName;
    }

    public void Show()
    {
        Console.WriteLine(_authorName);
    }
}