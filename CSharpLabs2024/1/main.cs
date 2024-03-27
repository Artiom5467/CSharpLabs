using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        Book book = new Book("Володар перснів");
        book.Author = new Author("Дж. Р. Р. Толкін");
        book.Content = new Content("У далекому королівстві...");

        book.Show();
    }
}