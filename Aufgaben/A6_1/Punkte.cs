using System;

namespace cSharp.Aufgaben.A6_1
{
  public class Punkte
  {
    public static void Run()
    {
      Punkt a = new Punkt(10, 20);
      Punkt b = new Punkt(a);
      Punkt c = new Punkt();

      c.x = 30;
      c.y = 40;

      Console.WriteLine($"Punkt B<{b.x}|{b.y}>");
      Console.WriteLine($"Abstand von Punkt b zu <0|0>: {b.Abstand()}");

      Console.WriteLine("*******");
      Punkt myPunkt = new Punkt(10, 20);
      double erg = myPunkt.Abstand();
      Console.WriteLine(erg);
    }
  }
}