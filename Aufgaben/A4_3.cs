using System;

namespace cSharp.Aufgaben
{
  public class A4_3
  {
    public static void Run()
    {
      int eingabe, ergebnis;

      // v1
      Console.WriteLine("Bitte Zahl eingeben:");
      eingabe = Convert.ToInt32(Console.ReadLine());

      ergebnis = eingabe;

      for (int i = 2; i <= 32; i *= 2)
      {
        ergebnis += ergebnis;

        if (i == 2 || i == 4 || i == 32) Console.WriteLine($"{eingabe} * {i} = {ergebnis}");
      }

      // v2 Bitweise Verschiebung
      Console.WriteLine("*******");
      Console.WriteLine($"{eingabe} * 2 = {eingabe << 1}");
      Console.WriteLine($"{eingabe} * 4 = {eingabe << 2}");
      Console.WriteLine($"{eingabe} * 32 = {eingabe << 5}");
    }
  }
}