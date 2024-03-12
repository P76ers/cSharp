using System;

namespace cSharp.Aufgaben
{
  public class A3_3
  {
    public static void Run()
    {
      double fixKosten, produktKosten, erloes, gewinn;
      int menge;

      Console.WriteLine("Gewinnberechnung Version 1.0");
      Console.WriteLine("Bitte geben Sie die fixen Kosten ein:");
      fixKosten = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Bitte geben sie Kosten fuer ein Produkt ein:");
      produktKosten = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Bitte geben Sie den Erloes fuer ein Produkt ein:");
      erloes = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Wie viele Produkte sollen hergestellt werden:");
      menge = Convert.ToInt32(Console.ReadLine());

      gewinn = menge * (erloes - produktKosten) - fixKosten;

      Console.WriteLine($"\n\nDer Gewinn betraegt: {gewinn:F2} Euro!");
    }
  }
}