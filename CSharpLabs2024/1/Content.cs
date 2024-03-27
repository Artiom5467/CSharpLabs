public class Content
{
    private string _content;

    public Content(string content)
    {
        _content = content;
    }

    public void Show()
    {
        Console.WriteLine(_content);
    }
}