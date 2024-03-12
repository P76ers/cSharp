using System;

namespace cSharp.Aufgaben.A7_1
{
  public class Kreis : Grundform
  {
    private readonly Punkt p1;
    private double radius;

    public Kreis(double x, double y, double radius, string bezeichnung)
    {
      p1.x = x;
      p1.y = y;
      this.radius = radius;
      this.bezeichnung = bezeichnung;
    }

    public Kreis(string bezeichnung)
    {
      this.bezeichnung = bezeichnung;
    }

    public void SetRadius(double radius)
    {
      this.radius = radius;
    }

    public void Ausgabe()
    {
      Console.WriteLine($"Der Kreis hat die Bezeichnung {bezeichnung}");
      Console.WriteLine($"Der Punkt lautet: ({p1.x}|{p1.y})");
      Console.WriteLine($"Der Radius lautet: {radius}");
    }
  }
}