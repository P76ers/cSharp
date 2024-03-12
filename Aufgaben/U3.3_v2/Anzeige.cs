using System;

namespace cSharp.Aufgaben.U3._3_v2
{
  public class Anzeige
  {
    public void Flaeche(Kreis k)
    {
      Console.WriteLine($"Fläche Kreis: {Math.PI * Math.Pow(k.GetRadius(), 2):F2}");
    }

    public void Flaeche(Rechteck r)
    {
      Console.WriteLine(
        $"Fläche Rechteck: {Math.Abs((r.GetP1().GetY() - r.GetP2().GetY()) * (r.GetP3().GetX() - r.GetP2().GetX()))}");
    }

    public void Laenge(Linie l)
    {
      Console.WriteLine(
        $"Länge Linie: {Math.Sqrt(Math.Pow(l.GetP2().GetX() - l.GetP1().GetX(), 2) + Math.Pow(l.GetP2().GetY() - l.GetP1().GetY(), 2)):F2}");
    }
  }
}