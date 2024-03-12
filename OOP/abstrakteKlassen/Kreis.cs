using System;

namespace cSharp.OOP.abstrakteKlassen
{
  public class Kreis : GrafikObjekt
  {
    public override void Zeichnen()
    {
      Console.WriteLine("KREIS WIRD GEZEICHNET");
    }
  }
}