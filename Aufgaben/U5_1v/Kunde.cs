using System;

namespace cSharp.Aufgaben.U5_1v
{
  public class Kunde
  {
    private string name;
    private int id;
    private string geburtsdatum;
    private Vertrag vertrag;

    public Kunde(string name, int id, string geburtsdatum)
    {
      this.name = name;
      this.id = id;
      this.geburtsdatum = geburtsdatum;
    }

    public void SetVertrag(Vertrag vertrag)
    {
      this.vertrag = vertrag;
    }

    public void VertagsdatenAusgeben()
    {
      if (vertrag == null)
      {
        Console.WriteLine("Kein Vertrag vorhanden!");
      }
      else
      {
        vertrag.Ausgabe();
      }
    }
  }
}