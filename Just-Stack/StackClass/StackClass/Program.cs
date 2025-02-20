using StackClass;

// MyStack<int> stack = new MyStack<int>();
//
// stack.push(1);
// stack.push(2);
// stack.push(3);
//
// Console.WriteLine($"The top element is: {stack.peek()}");


MyStack<string> stringStack = new MyStack<string>();

stringStack.push("One");
stringStack.push("Two");
stringStack.push("Three");

Console.WriteLine($"The top element is: {stringStack.peek()}");
Console.WriteLine($"The size of the stack is: {stringStack.size()}");