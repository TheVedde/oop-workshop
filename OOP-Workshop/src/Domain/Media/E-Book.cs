class E_Book : BaseMedia
{
    public string author;
    public int pages;
    public int publishYear;
    public string ISBN;
    public string language;

    public E_Book(string title, string author, int pages, int publishYear, string ISBN, string language)
    {
    }

    public void View()
    {
        Console.WriteLine($"You are now viewing {title}.");
        return;
    }
}
