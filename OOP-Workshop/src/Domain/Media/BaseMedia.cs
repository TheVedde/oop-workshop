/*
The base class for all Media Classes.
 */

public abstract class BaseMedia
{
    public string title;
    public string type;
    public void Download()
    {
        Console.WriteLine($"You have downloaded {title}");
        return;
    }
}
