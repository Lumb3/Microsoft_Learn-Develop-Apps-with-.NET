using System;
using Humanizer;
class Program
{
  public static void Main()
  {
    MyClass.run(); // calling static method
    MyClass obj = new MyClass();  // created an object on the heap
    obj.call_obj();
    Calculator.calculator();
    GPA.GPA_Calculator();
    Console.WriteLine("Hi");
    static void HumanizeQuantities()
    {
      Console.WriteLine("case".ToQuantity(0));
      Console.WriteLine("case".ToQuantity(1));
      Console.WriteLine("case".ToQuantity(5));
    }

    static void HumanizeDates()
    {
      Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
      Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
      Console.WriteLine(TimeSpan.FromDays(1).Humanize());
      Console.WriteLine(TimeSpan.FromDays(16).Humanize());
    }
    Console.WriteLine("Quantities:");
    HumanizeQuantities();

    Console.WriteLine("\nDate/Time Manipulation:");
    HumanizeDates();

    // Calling different kinds of methods in the .NET Class Library
    Random dice = new Random();
    int roll = dice.Next(1, 7);
    Console.WriteLine($"Random dice between 1 and 7: {roll}");
    int result = dice.Next();
    Console.WriteLine($"Random number: {result}");
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