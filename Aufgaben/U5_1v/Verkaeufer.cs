using System;

namespace cSharp.Aufgaben.U5_1v
{
  public class Verkaeufer
  {
    private string name;
    private Kunde kunde;

    public Verkaeufer(string name, Kunde kunde)
    {
      this.name = name;
      this.kunde = kunde;
    }

    public void NeuerVertrag()
    {
      Console.WriteLine("Bitte die Art des Vertages eingeben");
      string name = Console.ReadLine();

      Console.WriteLine("Bitte die ID des Vertrages eingeben:");
      int id = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Bitte geben sie ein Vertragsdatum(TT.MM.JJJJ) ein:");
      string datum = Console.ReadLine();

      Vertrag neuerVertrag = new Vertrag(name, id, datum);
      kunde.SetVertrag(neuerVertrag);
    }
  }
}