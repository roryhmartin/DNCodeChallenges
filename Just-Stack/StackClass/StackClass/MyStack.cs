namespace StackClass;

public class MyStack<T>
{
    private List<T> _list = new List<T>();

    public void push(T item)
    {
        _list.Add(item);
    }

    public void pop()
    {
        if (_list.Count > 0)
        {
            _list.RemoveAt(_list.Count - 1);
        }
    }
    
    public T peek()
    {
        if (_list.Count > 0)
        {
            return _list[_list.Count - 1];
        }
        return default(T);
    }

    public int size()
    {
        return _list.Count;
    }

}