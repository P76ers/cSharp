using System;

namespace cSharp.Aufgaben
{
  public class A4_1
  {
    public static void Run()
    {
      int a = 10;
      int b = 20;
      int x;

      x = 3 * (a + b) - b / 8;
      Console.WriteLine($"Wert von x = {x}");

      x = a++ + ++b; // b = 21
      Console.WriteLine($"Wert von x = {x}");


      a = 10;
      b = 20;
      x = a % b % (b % ++a); // a = 12
      Console.WriteLine($"Wert von x = {x}");
    }
  }
}