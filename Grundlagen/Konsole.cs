using System;

namespace cSharp.Grundlagen
{
  public class Konsole
  {
    public static void Run()
    {
      // Konsoleneingabe
      Console.WriteLine("Bitte Namen eingeben:");
      string name = Console.ReadLine();

      Console.WriteLine($"Moin {name}!");

      Console.WriteLine("Bitte Alter eingeben:");
      int alter = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine($"Sie sind {alter} Jahre alt!");
    }
  }
}