using System;

namespace cSharp.OOP.AutoScout
{
  public class Auto
  {
    public int aktuelleGeschwindigkeit;

    public int baujahr;

    //Attribute
    public string hersteller;
    public double laufleistung;
    public int leistung;
    public string modell;
    public double preis;

    // Constructur
    public Auto(string hersteller, string modell, int baujahr, double preis, double laufleistung, int leistung,
      int aktuelleGeschwindigkeit)
    {
      this.hersteller = hersteller;
      this.modell = modell;
      this.baujahr = baujahr;
      this.preis = preis;
      this.laufleistung = laufleistung;
      this.leistung = leistung;
      this.aktuelleGeschwindigkeit = aktuelleGeschwindigkeit;
    }


    // gasgeben
    public void GasGeben()
    {
      aktuelleGeschwindigkeit += 10;
      Console.WriteLine("Geschwindigkeit: " + aktuelleGeschwindigkeit);
    }

    // bremsen
    public void Bremsen()
    {
      aktuelleGeschwindigkeit -= 10;

      if (aktuelleGeschwindigkeit <= 0)
        aktuelleGeschwindigkeit = 0;

      Console.WriteLine("Geschwindigkeit: " + aktuelleGeschwindigkeit);
    }
  }
}