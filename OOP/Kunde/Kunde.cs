
using System;

namespace cSharp.OOP.Kunde
{
  public class Kunde
  {
    public double dispo = 1000;
    public string hausnummer;

    public string iban;
    private double kontostand;
    public string name;
    public string ort;
    public int postleitzahl;
    public string strasse;
    public string telefon;
    public string vorname;

    public Kunde(string vorname, string name, string strasse, string hausnummer, int postleitzahl, string ort,
      string telefon, string iban, double kontostand, double dispo)
    {
      this.vorname = vorname;
      this.name = name;
      this.strasse = strasse;
      this.hausnummer = hausnummer;
      this.postleitzahl = postleitzahl;
      this.ort = ort;
      this.telefon = telefon;
      this.iban = iban;
      this.kontostand = kontostand;
      this.dispo = dispo;
    }

    public void SetKontostand(double kontostand)
    {
      this.kontostand = kontostand;
    }

    public double GetKontostand()
    {
      return kontostand;
    }

    public void Einzahlen(double wert)
    {
      if (wert > 10000) Console.WriteLine("Nachricht an die Datenbank");

      kontostand += wert;
    }

    public void Auszahlen(double wert)
    {
      // wenn der kontostand kleiner als 0 + dispo ist
      if (kontostand - wert >= 0 - dispo)
      {
        // abheben erlaubt
        kontostand -= wert;
        Console.WriteLine("Neuer Kontostand" + kontostand);
      }
      else
      {
        Console.WriteLine("Betrag nicht auszahlbar.\n Bitte wenden Sie sich an Ihre Hausbank.");
      }
    }
  }
}