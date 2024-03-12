using System;

namespace cSharp.Aufgaben.A7_1
{
  public class Grundform
  {
    public string bezeichnung;

    public void Ausgabe()
    {
      Console.WriteLine("Ausgabe von der Baissklasse");
    }

    public struct Punkt
    {
      public double x;
      public double y;

      public Punkt(double x, double y)
      {
        this.x = x;
        this.y = y;
      }

      public void SetX(double x, double y)
      {
        this.x = x;
        this.y = y;
      }
    }
  }
}