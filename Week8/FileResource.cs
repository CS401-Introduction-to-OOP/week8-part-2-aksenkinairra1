namespace Week8;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        if (!IsOpen)
        {
            IsOpen = true;
        }
    }
    public override void Close()
    {
        if (IsOpen)
        {
            IsOpen = false;
        }
    }
    public void Dispose()
    {
        Close();
    }
}