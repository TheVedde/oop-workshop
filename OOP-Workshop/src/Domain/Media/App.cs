class App : BaseMedia
{
    public string publisher;
    public int version;
    public string language;
    public string[] supportedPlatforms;

    public App(string title, string publisher, int version, string language, string[] supportedPlatforms)
    {
    }

    public void Execute()
    {
        Console.WriteLine($"You are now execitng {title}.");
        return;
    }
}
