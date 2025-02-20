namespace StackClass;

public class MyList<T>
{
    private T[] _items;
    
    public MyList()
    {
        _items = new T[0];
    }

    public T[] GetItems()
    {
        Console.WriteLine(string.Join(", ", _items));
        return _items;
    }
    
    public T GetItemAt(int index)
    {
        if (index < 0 || index >= _items.Length)
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }
        
        return _items[index];
    }
    
    public void SetItemAt(int index, T value)
    {
        if (index < 0 || index >= _items.Length)
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }
        _items[index] = value;
    }

    public void Add(T newValue)
    {
        T[] updated = new T[_items.Length + 1];
        
        for (int i = 0; i < _items.Length; i++)
        {
            updated[i] = _items[i];
        }
        
        updated[_items.Length] = newValue;
        _items = updated;
    }
    
    
}