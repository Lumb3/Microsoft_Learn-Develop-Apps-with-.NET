using System;

class Program
{
  public static void Main()
  {
    MyClass.run(); // calling static method
    MyClass obj = new MyClass();  // created an object on the heap
    obj.call_obj();
    Calculator.first();
  }
  private static void Learning()
  {
    Console.WriteLine("Hello World");
    Console.WriteLine("HAHA");
    Console.Write("Hi");
    Console.WriteLine(" Eric HUU");
    Console.WriteLine("HAHA");
    Console.Write("Start");
    Console.WriteLine("Finish");
    char a = 'a';
    Console.WriteLine(a);
    decimal d = 1.241234m;  // Most precise C# data type
    Console.WriteLine(d);
    var message = "Hello World!"; // implicitly local variable "let the compiler figure out the type for me" 
                                  // var = auto in C++
    Console.WriteLine(message);
    Console.Write(34.40M + "\n"); // M means decimal (bigger double)
    Console.Write("Hello\nWorld\n");

    int fa = 94;
    double celsius = (fa - 32) * (5.0 / 9);
    Console.WriteLine(celsius);
  }
}