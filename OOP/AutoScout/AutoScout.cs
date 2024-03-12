using System;

namespace cSharp.OOP.AutoScout
{
  public class AutoScout
  {
    public static void Run()
    {
      Auto mercedes = new Auto("Daimler Benz", "190", 2024, 55000, 0, 100, 0);
      Auto vw = new Auto("Volkswagen", "Passat", 2024, 55000, 0, 100, 0);
      Auto fiat = new Auto("Fiat", "190", 2024, 55000, 0, 100, 0);

      Werkstatt jamliService = new Werkstatt();
      // jamliService.Einchecken(fiat);


      Console.WriteLine("Auto Simulator 1.0");
      Console.WriteLine("Bitte geben Sie den Hersteller ein:");
      string hersteller = Console.ReadLine();

      Console.WriteLine("Bitte geben Sie den Modell ein:");
      string modell = Console.ReadLine();

      Console.WriteLine("Bitte geben Sie das Baujahr ein:");
      int baujahr = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Bitte geben Sie das Preis ein:");
      double preis = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Bitte geben Sie das Laufleistung ein:");
      double laufleistung = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Bitte geben Sie das Leistung ein:");
      int leistung = Convert.ToInt32(Console.ReadLine());


      Auto auto = new Auto(hersteller, modell, baujahr, preis, laufleistung, leistung, 0);


      auto.GasGeben();


      /*
      int userInput = 0;

      do
      {
          Console.WriteLine("Auto Simulator 1.0");
          Console.WriteLine("[1] Gas Geben");
          Console.WriteLine("[2] Bremsen");

          userInput = Convert.ToInt32(Console.ReadLine());

          switch (userInput)
          {
              case 1:
                  mercedes.GasGeben();
                  break;

              case 2:
                  mercedes.Bremsen();
                  break;
          }

      } while (userInput != -1);
      */
    }
  }
}