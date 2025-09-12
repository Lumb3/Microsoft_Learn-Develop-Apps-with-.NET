using System;
class MyClass
{
  public static void run()   // public function that runs without need of creating object in the Main method
  {
    Console.WriteLine("No need to create an object to call this function.");
  }
  public void call_obj()  // must create an object to call this method
  {
    Console.WriteLine("Need to create an object to call this function.");
  }
}