using System;

namespace cSharp.Aufgaben
{
  public class A5_6
  {
    public static void Run()
    {
      int eingabe, anzahl = 0, min = 0, max = 0;

      do
      {
        Console.WriteLine("Bitte Zahl eingeben:");
        eingabe = Convert.ToInt32(Console.ReadLine());

        if (eingabe < 0)
        {
          Console.WriteLine("Nur positive Zahlen");
        }
        else if (eingabe > 0)
        {
          if (anzahl == 0)
            min = max = eingabe;
          else if (eingabe < min)
            min = eingabe;
          else if (eingabe > max) max = eingabe;

          anzahl++;
        }
      } while (eingabe != 0);

      Console.WriteLine($"Anzahl: {anzahl}");
      Console.WriteLine($"Max: {max}");
      Console.WriteLine($"Min: {min}");
    }
  }
}