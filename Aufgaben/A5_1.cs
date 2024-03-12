using System;

namespace cSharp.Aufgaben
{
  public class A5_1
  {
    public static void Run()
    {
      float zahl1, zahl2, zahl3, min, max;

      Console.WriteLine("Bitte Zahl 1 eingeben:"); // 5
      zahl1 = Convert.ToSingle(Console.ReadLine());

      Console.WriteLine("Bitte Zahl 2 eingeben:"); // 33
      zahl2 = Convert.ToSingle(Console.ReadLine());

      Console.WriteLine("Bitte Zahl 3 eingeben:"); // 22
      zahl3 = Convert.ToSingle(Console.ReadLine());

      min = zahl1; // 5
      max = zahl2; // 33

      if (zahl1 > zahl2)
      {
        min = zahl2;
        max = zahl1;
      }

      if (max < zahl3) max = zahl3;

      if (zahl3 < min) min = zahl3;

      Console.WriteLine($"Min: {min} Max: {max}");
    }
  }
}