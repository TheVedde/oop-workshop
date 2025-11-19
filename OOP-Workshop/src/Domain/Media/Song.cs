class Song : BaseMedia
{
    public string composer;
    public string singer;
    public string genre;
    public string fileType;
    public string language;
    public int duration;

    public Song(string title, string composer, string singer, string genre, string fileType, string language, int duration)
    {
    }

    public void PlaySong()
    {
        Console.WriteLine($"You are now playing the song, {title}.");
        return;
    }
}
