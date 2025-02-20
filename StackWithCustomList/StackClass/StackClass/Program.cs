using StackClass;

TheStack<int> stack = new TheStack<int>();

stack.Push(7);
stack.Push(15);
stack.Push(25);

Console.WriteLine($"Top Item: {stack.Peek()}");
Console.WriteLine($"Popped Item: {stack.Pop()}");
Console.WriteLine($"Top Item: {stack.Peek()}");