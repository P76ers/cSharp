using System;

namespace cSharp.Aufgaben.U6_2
{
  public class App
  {
    public static void Run()
    {
      int anzahl;
      
      
      Console.WriteLine("Bitte Größe des Arrays eingeben:");
      anzahl = Convert.ToInt32(Console.ReadLine());
      Auswertung auswertung = new Auswertung(anzahl);
      auswertung.ArrayFuellen();
      // auswertung.ArrayZeigen();
      auswertung.ArraySort();

      
    }
  }
}