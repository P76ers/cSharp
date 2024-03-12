using System;

namespace cSharp.Aufgaben
{
  public class A3_1
  {
    public static void Run()
    {
      double startKapital, zinsSatz, endKapital = 0;

      Console.WriteLine("Bitte Startkapital eingeben");
      startKapital = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Bitte Zinssatz eingeben");
      zinsSatz = Convert.ToDouble(Console.ReadLine());

      for (var i = 0; i < 3; i++)
      {
        endKapital = startKapital * (1 + zinsSatz / 100);
        startKapital = endKapital;
      }

      Console.WriteLine($"Ihr Endkapital nach 3 Jahren = {endKapital:F2} EUR");
    }
  }
}