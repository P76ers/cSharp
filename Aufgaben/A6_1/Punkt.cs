using System;

namespace cSharp.Aufgaben.A6_1
{
  public class Punkt
  {
    public double x;
    public double y;

    public Punkt()
    {
      x = 0;
      y = 0;
    }

    public Punkt(double x, double y)
    {
      this.x = x;
      this.y = y;
    }

    public Punkt(Punkt p)
    {
      x = p.x;
      y = p.y;
    }

    public double Abstand()
    {
      double c;
      // a² + b² = c² ➡️ c = sqrt(a² + b²)

      return c = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
    }
  }
}