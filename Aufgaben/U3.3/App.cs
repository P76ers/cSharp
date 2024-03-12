using System;

namespace cSharp.Aufgaben.U3._3
{
  public class App
  {
    public static void Run()
    {
      // Kreis
      Punkt punktKreis = new Punkt();
      punktKreis.SetX(9);
      punktKreis.SetY(7);

      Kreis kreis = new Kreis();
      kreis.SetRadius(2);

      Anzeige kreisAnzeige = new Anzeige();
      Console.WriteLine($"Fläche Kreis: {kreis.RufeAnzeige(kreisAnzeige, kreis)}");

      // Linie
      Punkt punktLinie1 = new Punkt();
      Punkt punktLinie2 = new Punkt();

      punktLinie1.SetX(7);
      punktLinie1.SetY(1);
      punktLinie2.SetX(12);
      punktLinie2.SetY(5);

      Linie linie = new Linie();
      linie.SetP1(punktLinie1);
      linie.SetP2(punktLinie2);

      Anzeige linieAnzeige = new Anzeige();
      Console.WriteLine($"Länge der Linie: {linie.RufeAnzeige(linieAnzeige, linie)}");


      // Rechteck
      Punkt punktRechteck1 = new Punkt();
      Punkt punktRechteck2 = new Punkt();
      Punkt punktRechteck3 = new Punkt();

      punktRechteck1.SetX(3);
      punktRechteck1.SetY(4);
      //Console.WriteLine($"Punkt1: x-{punktRechteck1.GetX()} y-{punktRechteck1.GetY()}");

      punktRechteck2.SetX(3);
      punktRechteck2.SetY(6);
      // Console.WriteLine($"Punkt2: x-{punktRechteck2.GetX()} y-{punktRechteck2.GetY()}");

      punktRechteck3.SetX(6);
      punktRechteck3.SetY(6);
      // Console.WriteLine($"Punkt3: x-{punktRechteck3.GetX()} y-{punktRechteck3.GetY()}");

      Rechteck rechteck = new Rechteck();
      rechteck.SetP1(punktRechteck1);
      rechteck.SetP2(punktRechteck2);
      rechteck.SetP3(punktRechteck3);

      Anzeige rechteckAnzeige = new Anzeige();
      Console.WriteLine($"Länge der Linie: {rechteck.RufeAnzeige(rechteckAnzeige, rechteck)}");
    }
  }
}