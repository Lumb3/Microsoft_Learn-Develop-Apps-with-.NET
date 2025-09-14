using System;
// All of the class Names and method Names must be in uppercase
class Run
{
  public static void Main()
  {
    Console.WriteLine($"The larger value is: {Larger()}");
  }
  private static int Larger()
  {
    int firstValue = 500;
    int secondValue = 600;
    int largerValue = Math.Max(firstValue, secondValue);
    return largerValue;
  }
}