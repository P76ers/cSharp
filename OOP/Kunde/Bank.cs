using System;

namespace cSharp.OOP.Kunde
{
  public class Bank
  {
    public static void Run()
    {
      Kunde kunde1 = new Kunde(
        "Susi",
        "Sorglos",
        "Fake Straße",
        "65",
        12345,
        "Musterdorf",
        "0123456789",
        "DE-123456789",
        100,
        1000);

      /*
      Console.WriteLine("Wieviel möchte Sie einzahlen?");
      double einzahlung = Convert.ToDouble(Console.ReadLine());
      kunde1.Einzahlen(einzahlung);*/

      Console.WriteLine("Wieviel möchten Sie auszahlen?");
      double auszahlung = Convert.ToDouble(Console.ReadLine());
      kunde1.Auszahlen(auszahlung);

      Console.WriteLine(kunde1.GetKontostand());
    }
  }
}