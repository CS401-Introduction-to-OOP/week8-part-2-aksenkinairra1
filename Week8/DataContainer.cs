namespace Week8;

using System.Collections.Generic;

public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();
    public void AddItem(T item)
    {
// TODO: add item to internal list
        throw new NotImplementedException();
    }
    public long GetTotalSize()
    {
// TODO: sum size of all items
        throw new NotImplementedException();
    }
}