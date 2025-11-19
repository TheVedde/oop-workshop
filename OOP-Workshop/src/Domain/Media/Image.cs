class Image : BaseMedia
{
    public string resolution;
    public string fileFormat;
    public long fileSize;
    public string dateTaken;

    public Image(string title, string resolution, string fileFormat, long fileSize, string dateTaken)
    {
    }

    public void Display()
    {
        Console.WriteLine($"You are now displaying {title}.");
        return;
    }
}
