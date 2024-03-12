using System;

namespace cSharp.Aufgaben
{
  public class A3_4
  {
    public static void Run()
    {
      Console.WriteLine("Lineare Gleichung Version 1.0");

      Console.WriteLine("Bitte den Wert für a:");
      int a = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Bitte den Wert für b:");
      int b = Convert.ToInt32(Console.ReadLine());

      int x = -b / a;

      Console.WriteLine($"Die Lösung lautet: {x}");
    }
  }
}