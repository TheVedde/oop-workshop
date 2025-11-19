class E_Book : BaseMedia
{
    public string author;
    public int pages;
    public int publishYear;
    public string ISBN;
    public string language;

    public E_Book(string title, string author, int pages, int publishYear, string ISBN, string language)
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
        this.publishYear = publishYear;
        this.ISBN = ISBN;
        this.language = language;
    }

    public void View()
    {
        Console.WriteLine($"You are now viewing {title}.");
        return;
    }
}
