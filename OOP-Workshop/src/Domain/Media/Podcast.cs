class PodcastEpisode : BaseMedia
{
    public string[] hosts;
    public string[] guests;
    public int episodeNumber;
    public int releaseYear;
    public string language;
    public bool episodeIsComplete;

    public PodcastEpisode(string title, string[] hosts, string[] guests, int episodeNumber, int releaseYear, string language, bool episodeIsComplete)
    {
        this.title = title;
        this.hosts = hosts;
        this.guests = guests;
        this.episodeNumber = episodeNumber;
        this.releaseYear = releaseYear;
        this.language = language;
        this.episodeIsComplete = episodeIsComplete;
    }

    public void PlayPodcast()
    {
        Console.WriteLine($"You are now listening to {title}.");
        return;
    }
}
