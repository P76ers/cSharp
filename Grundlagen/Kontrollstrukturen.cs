using System;

namespace cSharp.Grundlagen
{
  public class Kontrollstrukturen
  {
    public static void Run()
    {
      int preis = 1000;
      int rabatt = 300;

      // EINFACHER iF
      if (true)
      {
        // Code...
      }

      // IF - ELSE
      if (preis == 1000)
      {
        // Führe hier den weiteren Code aus
      }

      // Mache lieber das hier auf jeden fall
      // Einzeilig
      if (preis > 500)
        preis = 100;
      else
        preis = 220;

      // Ternäre Operator - Kurz für IF-ELSE
      // Aufbau: name (bedingung) ? (wenn wahr) : (wenn nicht wahr)
      bool sonderangebot = preis < 500 ? true : false;

      if (preis < 500)
        sonderangebot = true;
      else
        sonderangebot = false;

      if (sonderangebot) Console.WriteLine("Sie kriegen Rabatt");

      // IF - ELSE IF
      if (preis == 1000)
      {
        // Führe hier den weiteren Code aus
      }
      else if (preis >= 500)
      {
        // Mache lieber das hier
      }

      // Andernfalls
      // Strings vergleichen
      string nachtwache = "John Schnee";

      if (nachtwache.Equals("Khal Drago"))
      {
        // Code...
      }

      if (nachtwache == "Sersei")
      {
      }
    }
  }
}