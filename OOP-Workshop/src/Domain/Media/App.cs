class App : BaseMedia
{
    public string publisher;
    public int version;
    public string language;
    public string[] supportedPlatforms;

    public App(string title, string publisher, int version, string language, string[] supportedPlatforms)
    {
        this.title = title;
        this.publisher = publisher;
        this.version = version;
        this.language = language;
        this.supportedPlatforms = supportedPlatforms;
    }

    public void Execute()
    {
        Console.WriteLine($"You are now executing {title}.");
        return;
    }
}
