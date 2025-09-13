using System;

class Calculator
{
  // Fields (class-level variables)
  static int sophia1 = 93, sophia2 = 87, sophia3 = 98, sophia4 = 95, sophia5 = 100;
  static int nicolas1 = 80, nicolas2 = 83, nicolas3 = 82, nicolas4 = 88, nicolas5 = 85;
  static int zahirah1 = 84, zahirah2 = 96, zahirah3 = 73, zahirah4 = 85, zahirah5 = 79;
  static int jeong1 = 90, jeong2 = 92, jeong3 = 98, jeong4 = 100, jeong5 = 97;

  public static void calculator()
  {
    double sophia_average = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / 5.0;
    double nicolas_average = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / 5.0;
    double zahirah_average = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / 5.0;
    double jeong_average = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / 5.0;
    Console.WriteLine("Student\tGrade");
    Console.WriteLine($"Sophia\t{sophia_average} A");
    Console.WriteLine($"Nicolas\t{nicolas_average} B");
    Console.WriteLine($"Zahirah\t{zahirah_average} B");
    Console.WriteLine($"Jeong\t{jeong_average} A");
  }
}
