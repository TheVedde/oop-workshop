class Movie : BaseMedia
{
    public string director;
    public string genre;
    public int releaseYear;
    public string language;
    public int duration;

    public Movie(string title, string director, string genre, int releaseYear, string language, int duration)
    {
    }

    public void Watch()
    {
        Console.WriteLine($"You are now watching {title}.");
        return;
    }
}
