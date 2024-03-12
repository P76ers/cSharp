using System;

namespace cSharp.Aufgaben.A7_1
{
  public class Viereck : Grundform
  {
    private readonly Punkt p1;
    private readonly Punkt p2;
    private readonly Punkt p3;
    private readonly Punkt p4;


    public Viereck(double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y, double p4X, double p4Y,
      string bezeichnung)
    {
      p1.x = p1X;
      p1.y = p1Y;
      p2.x = p2X;
      p2.y = p2Y;
      p3.x = p3X;
      p3.y = p3Y;
      p4.x = p4X;
      p4.y = p4Y;
      this.bezeichnung = bezeichnung;
    }

    public void Ausgabe()
    {
      Console.WriteLine($"Das Viereck hat die Bezeichnung: {bezeichnung} ");
      Console.WriteLine("Die Punkte lauten:");
      Console.WriteLine($"({p1.x} | {p1.y} )");
      Console.WriteLine($"({p2.x} | {p2.y} )");
      Console.WriteLine($"({p3.x} | {p3.y} )");
      Console.WriteLine($"({p4.x} | {p4.y} )");
      Console.WriteLine("\n");
    }
  }
}