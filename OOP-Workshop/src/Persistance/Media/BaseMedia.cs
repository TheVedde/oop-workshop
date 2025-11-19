public abstract class BaseMedia
{
    public abstract string Name { get; }

    public virtual void Download();
}