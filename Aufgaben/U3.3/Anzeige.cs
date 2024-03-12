using System;

namespace cSharp.Aufgaben.U3._3
{
  public class Anzeige
  {
    public double Flaeche(Kreis k)
    {
      return Math.PI * Math.Pow(k.GetRadius(), 2);
    }

    public double Flaeche(Rechteck r)
    {
      double flaeche;

      Punkt p1 = r.GetP1();
      Punkt p2 = r.GetP2();
      Punkt p3 = r.GetP3();

      double p1X = p1.GetX();
      double p1Y = p1.GetY();

      double p2X = p2.GetX();
      double p2Y = p2.GetY();

      double p3X = p3.GetX();
      double p3Y = p3.GetY();

      double diffP1P2 = p1Y - p2Y;
      // Console.WriteLine($"Differenz p2-p1 = {diffP1P2}");
      double diffP2P3 = p3X - p2X;
      // Console.WriteLine($"Differenz p2-p1 = {diffP2P3}");

      flaeche = diffP1P2 * diffP2P3;

      return Math.Abs(flaeche);
    }

    public double Laenge(Linie l)
    {
      // Pythagoras  c = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))

      Punkt p1 = l.GetP1();
      Punkt p2 = l.GetP2();

      double p1X = p1.GetX();
      double p1Y = p1.GetY();

      double p2X = p2.GetX();
      double p2Y = p2.GetY();

      double c;
      double diffX;
      double diffY;

      diffX = p2X - p1X;
      diffY = p2Y - p1Y;

      c = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));

      return c;
    }
  }
}