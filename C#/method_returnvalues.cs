// If you want the method to return a value, you can use a primitive data type (such as int or double) instead of void, and use the return keyword inside the method:

static int MyMethod(int x) 
{
  return 5 + x;
}

static void Main(string[] args)
{
  Console.WriteLine(MyMethod(3));
}

// Outputs 8 (5 + 3)
