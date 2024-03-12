using System;

namespace cSharp.Aufgaben.V1_2
{
  public class Bank
  {
    public static void Run()
    {
      int userInput;
      double einzahlung, auszahlung;

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
      kunde1.Einzahlen(einzahlung);
      */

      // Console.WriteLine("Wieviel möchten Sie auszahlen?");
      // double auszahlung = Convert.ToDouble(Console.ReadLine());
      // kunde1.Auszahlen(auszahlung);
      //
      // Console.WriteLine(kunde1.GetKontostand());

      do
      {
        Console.WriteLine("Bankomat 1.0");
        Console.WriteLine("[1] Kontostand");
        Console.WriteLine("[2] Einzahlung");
        Console.WriteLine("[3] Auszahlung");
        Console.WriteLine("[-1] Beenden");

        userInput = Convert.ToInt32(Console.ReadLine());

        switch (userInput)
        {
          case 1:
            Console.WriteLine("Ihr Kontostand betraegt: " + kunde1.GetKontostand() + " Euro");
            break;
          case 2:
            Console.WriteLine("Wieviel möchte Sie einzahlen?");
            einzahlung = Convert.ToDouble(Console.ReadLine());
            kunde1.Einzahlen(einzahlung);
            break;
          case 3:
            Console.WriteLine("Wieviel möchten Sie auszahlen?");
            auszahlung = Convert.ToDouble(Console.ReadLine());
            kunde1.Auszahlen(auszahlung);
            break;
        }
      } while (userInput != -1);
    }
  }
}