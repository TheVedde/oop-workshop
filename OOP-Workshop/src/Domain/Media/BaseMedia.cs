/*
The base class for all Media Classes.
 */

abstract class BaseMedia
{
    public string title;

    public void Download()
    {
        Console.WriteLine($"You have downloaded {title}");
        return;
    }
}
