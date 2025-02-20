namespace StackClass;

public class TheStack<T>
{
    private MyList<T> _list;
    
    public TheStack()
    {
        _list = new MyList<T>();
    }
    
    public void Push(T item)
    {
        _list.Add(item);
    }

    public T Pop()
    {
        if (_list.GetItems().Length == 0)
        {
            throw new InvalidOperationException("The stack is empty");
        }
        
        T topItem = _list.GetItemAt(_list.GetItems().Length - 1);
        
        T[] newItems = new T[_list.GetItems().Length - 1];
        
        for (int i = 0; i < newItems.Length; i++)
        {
            newItems[i] = _list.GetItemAt(i);
        }
        
        _list = new MyList<T>();
        foreach (var item in newItems)
        {
            _list.Add(item);
        }
        
        
        
        // T topItem = _list.GetItemAt(_list.GetItems().Length - 1);
        // _list.SetItemAt(_list.GetItems().Length -1, default);
        return topItem;
    }

    public T Peek()
    {
        if (_list.GetItems().Length == 0)
        {
            throw new InvalidOperationException("The stack is empty");
        }

        return _list.GetItemAt(_list.GetItems().Length - 1);
    }
}