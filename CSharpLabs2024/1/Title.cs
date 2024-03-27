public class Title
{
    private readonly string _title;

    public Title(string title)
    {
        _title = title;
    }

    public void Show()
    {
        Console.WriteLine(_title);
    }
}