using System;

namespace cSharp.OOP.Pizza
{
  public class Pizza
  {
    public bool extraKaese;

    public int groesse;

    // Attribute
    public string name;
    public double preis;

    // Constructor
    public Pizza()
    {
      name = "Pizza";
      preis = 8.99;
      extraKaese = false;
      groesse = 10;
    }

    public Pizza(string name, double preis, bool extraK, int groesse)
    {
      this.name = name;
      this.preis = preis;
      extraKaese = extraK;
    }

    public void BerechneMWST()
    {
    }

    // Methode ohne Rückgabe
    public void DetailsAusgeben()
    {
      Console.WriteLine($"Name: {name}");
      Console.WriteLine($"Preis: {preis}");
      Console.WriteLine($"Extrakäse? : {extraKaese}");
      Console.WriteLine($"Größe: {groesse}");
    }

    public void DetailsAusgeben(string textZumAusgeben)
    {
      Console.WriteLine(textZumAusgeben);
    }

    // Methode mit Rückgabewert
    public double Gesamtpreis()
    {
      return 10;
    }
  }
}