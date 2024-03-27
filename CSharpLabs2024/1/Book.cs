public class Book
{
    private readonly Title _title;
    private Author _author;
    private Content _content;

    public Book(string title)
    {
        _title = new Title(title);
    }

    public Author Author
    {
        get => _author;
        set => _author = value;
    }

    public Content Content
    {
        get => _content;
        set => _content = value;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        _title.Show();

        Console.ForegroundColor = ConsoleColor.Yellow;
        _author.Show();

        Console.ForegroundColor = ConsoleColor.White;
        _content.Show();
    }
}