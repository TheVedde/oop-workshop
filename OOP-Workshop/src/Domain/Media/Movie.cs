class Movie : BaseMedia
{
    public string director;
    public string genre;
    public int releaseYear;
    public string language;
    public int duration;

    public Movie(string title, string director, string genre, int releaseYear, string language, int duration)
    {
        type = "Movie";
        this.title = title;
        this.director = director;
        this.genre = genre;
        this.releaseYear = releaseYear;
        this.language = language;
        this.duration = duration;
    }

    public void Watch()
    {
        Console.WriteLine($"You are now watching {title}.");
        return;
    }
}
