class Video_Game : BaseMedia
{
    public string publisher;
    public string genre;
    public int releaseYear;
    public string[] supportedPlatforms;
    public bool isCompleted;

    public Video_Game(string title, string publisher, string genre, int releaseYear, string[] supportedPlatforms, bool isCompleted)
    {
    }

    public void PlayGame()
    {
        Console.WriteLine($"You are now playing the game, {title}.");
        return;
    }
}
