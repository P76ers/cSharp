using System;

namespace cSharp.Aufgaben
{
  public class A5_5
  {
    public static void Run()
    {
      int eingabe, x;

      Console.WriteLine("Bitte Zahl eingeben:");
      eingabe = Convert.ToInt32(Console.ReadLine());

      Console.Write("Natürliche Zahlen: ");
      for (int i = 1; i <= eingabe; i++) Console.Write($"{i} ");

      Console.WriteLine("\n\n********");
      Console.Write("Alle geraden Zahlen: ");
      for (int i = eingabe; i >= 2; i--)
        if (i % 2 == 0)
          Console.Write($"{i} ");

      Console.WriteLine("\n\n********");
      Console.Write("Hoch- und Runterzaehlen:");
      for (int i = 1, j = 19; i <= 19 && j >= 1; i++, j--)
      {
        x = i <= 10 ? i : j;
        Console.Write($"{x} ");

        // alternativ
        // if (i <= 10)
        // {
        //     Console.Write($"{i} ");
        // }
        // else
        // {
        //     Console.Write($"{j} ");
        // }
        //
      }
    }
  }
}