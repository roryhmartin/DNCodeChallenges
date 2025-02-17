using System.Collections;
using System.Runtime.InteropServices;

int[,] grid =
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
};


// ---------------------- Start Recursive Flood Fill ----------------------
// Console.WriteLine("Before Flood Fill:");
// PrintGrid(grid);
//
// FloodFill(grid, 2, 10, 0, 7);
//
// Console.WriteLine("After Flood Fill:");
// PrintGrid(grid);
//
// static void FloodFill(int[,] grid, int x, int y, int target, int replacement)
// {
//   if (!isValid(grid, x, y, target))
//   {
//     return;
//   }
//
//
//   grid[x, y] = replacement;
//
//   //Console.Clear();
//   ////Console.SetCursorPosition(0, 0);
//   //PrintGrid(grid);
//   //Thread.Sleep(200);
//
//
//   FloodFill(grid, x - 1, y, target, replacement);
//   FloodFill(grid, x + 1, y, target, replacement);
//   FloodFill(grid, x, y + 1, target, replacement);
//   FloodFill(grid, x, y - 1, target, replacement);
//   FloodFill(grid, x - 1, y + 1, target, replacement);
//   FloodFill(grid, x + 1, y + 1, target, replacement);
//   FloodFill(grid, x + 1, y - 1, target, replacement);
//   FloodFill(grid, x - 1, y - 1, target, replacement);
// }
// ---------------------- End Recursive Flood Fill ----------------------

// ---------------------- Start Stack Fill ----------------------
// last in first out

// Console.WriteLine("Before Stack Fill:");
// PrintGrid(grid);
//
// StackFill(grid, 2, 10, 0, 7);
//
// Console.WriteLine("After Stack Fill:");
// PrintGrid(grid);
//
// static void StackFill(int[,] grid, int x, int y, int target, int replacement)
// {
//   if (!isValid(grid, x, y, target))
//   {
//     return;
//   }
//
//   var stack = new Stack<(int, int)>();
//   stack.Push((x, y));
//
//   while (stack.Count > 0)
//   {
//     var (currentX, currentY) = stack.Pop();
//
//     if (!isValid(grid, currentX, currentY, target))
//     {
//       continue;
//     }
//
//     Console.Clear();
//     PrintGrid(grid);
//     Thread.Sleep(200);
//
//     if (grid[currentX, currentY] == target)
//     {
//       grid[currentX, currentY] = replacement;
//
//       stack.Push((currentX, currentY + 1));
//       stack.Push((currentX + 1, currentY));
//       stack.Push((currentX, currentY - 1));
//       stack.Push((currentX - 1, currentY));
//     }
//   }
//
// }

// ---------------------- End Stack Fill ----------------------

// ---------------------- Start Stack Stuff - Stack test area ----------------------

Stack myStack = new Stack();
myStack.Push("Hello");
myStack.Push("World");
myStack.Push("!");

Console.WriteLine("myStack");
Console.WriteLine("Count: {0}", myStack.Count);
Console.Write("Values:");
PrintValues(myStack);

static void PrintValues(IEnumerable myCollection)
{
  foreach (Object obj in myCollection)
  {
    Console.Write(" {0}", obj);
  }

  Console.WriteLine();
}
// ----------------------  End Stack Stuff ----------------------


// ---------------------- Start Queue Fill ----------------------
// first in first out

Console.WriteLine("Before Queue Fill:");
PrintGrid(grid);

QueueFill(grid, 2, 10, 0, 7);

Console.WriteLine("After Queue Fill:");
PrintGrid(grid);

static void QueueFill(int[,] grid, int x, int y, int target, int replacement)
{
  if (!isValid(grid, x, y, target))
  {
    return;
  }

  Queue<(int, int)> queue = new Queue<(int, int)>();

  queue.Enqueue((x, y));

  while (queue.Count > 0)
  {
    var (currentX, currentY) = queue.Dequeue();

    if (!isValid(grid, currentX, currentY, target))
    {
      continue;
    }



    grid[currentX, currentY] = replacement;

    if (isValid(grid, currentX - 1, currentY, target))
    {
      queue.Enqueue((currentX - 1, currentY));

    }

    if (isValid(grid, currentX + 1, currentY, target))
    {
      queue.Enqueue((currentX + 1, currentY));
    }

    if (isValid(grid, currentX, currentY - 1, target))
    {
      queue.Enqueue((currentX, currentY - 1));
    }

    if (isValid(grid, currentX, currentY + 1, target))
    {
      queue.Enqueue((currentX, currentY + 1));
    }

    Console.Clear();
    PrintGrid(grid);
    Thread.Sleep(200);
  }
}

// ---------------------- End Queue Fill ----------------------

// ---------------------- Start Queue Stuff - Queue test area----------------------

// Enqueue adds element to the end of the queue

// Dequeue removes the oldest element from the start of the queue

// Create a queue
// Using Queue class
Queue testQueue = new Queue();

// Adding elements in Queue
// Using Enqueue() method
testQueue.Enqueue(1);
testQueue.Enqueue(2);
testQueue.Enqueue(3);
testQueue.Enqueue(4);
testQueue.Enqueue(5);
testQueue.Enqueue("6");

// Accessing the elements
// of q Queue
// Using foreach loop
foreach (var i in testQueue)
{
  Console.WriteLine($"Queue item: {i}");
}

// ---------------------- End Queue Stuff ----------------------



static bool isValid(int[,] grid, int x, int y, int target)
{
  if (x < 0 || x >= grid.GetLength(0) || y < 0 || y >= grid.GetLength(1))
  {
    return false;
  }

  if (grid[x, y] != target)
  {
    return false;
  }

  return true;
}


static void PrintGrid(int[,] grid)
{
  for (int i = 0; i < grid.GetLength(0); i++)
  {
    for (int j = 0; j < grid.GetLength(1); j++)
    {
      if (grid[i, j] == 0)
      {
        Console.ForegroundColor = ConsoleColor.Green;

      }
      else if (grid[i, j] == 7)
      {
        Console.ForegroundColor = ConsoleColor.Red;
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.White;
      }
      Console.Write(grid[i, j] + " ");
      //Console.Write("\u2588");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}
//Console.ResetColor();