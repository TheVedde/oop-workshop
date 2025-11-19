class Image : BaseMedia
{
    public string resolution;
    public string fileFormat;
    public double fileSize;
    public string dateTaken;

    public Image(string title, string resolution, string fileFormat, double fileSize, string dateTaken)
    {
        type = "Image";
        this.title = title;
        this.resolution = resolution;
        this.fileFormat = fileFormat;
        this.fileSize = fileSize;
        this.dateTaken = dateTaken;
    }

    public void Display()
    {
        Console.WriteLine($"You are now displaying {title}.");
        return;
    }
}
