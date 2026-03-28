using System.Collections.Generic;
namespace Week8;

public class ResourceManager<T> where T : Resource
{
    private readonly List<T> _resources = new();
    public void Add(T resource)
    {
// TODO: add resource to list
        throw new NotImplementedException();
    }
    public void OpenAll()
    {
// TODO: open every resource
        throw new NotImplementedException();
    }
    public void CloseAll()
    {
// TODO: close every resource
        throw new NotImplementedException();
    }
}