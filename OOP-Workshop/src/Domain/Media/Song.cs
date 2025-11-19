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
        this.title = title;
        this.composer = composer;
        this.singer = singer;
        this.genre = genre;
        this.fileType = fileType;
        this.language = language;
        this.duration = duration;
    }

    public void PlaySong()
    {
        Console.WriteLine($"You are now playing the song, {title}.");
        return;
    }
}
