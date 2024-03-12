using System;

namespace cSharp.Aufgaben.A6_4
{
  public class Mathe
  {
    private static readonly double pi = 3.1415;

    public static double Potenz(ref double basis, int exponent)
    {
      double ergebnis = 1;
      if (exponent == 0) return 1;

      // return Math.Pow(basis, exponent);

      for (int i = 0; i < exponent; i++) ergebnis *= basis;

      return ergebnis;
    }

    public static int Fakultaet(int zahl)
    {
      int ergebnis = 1;
      for (int i = 2; i <= zahl; i++) ergebnis *= i;

      return ergebnis;
    }

    public static int Quersumme(int zahl)
    {
      int ergebnis = 0;

      while (zahl > 0)
      {
        ergebnis += zahl % 10;
        zahl /= 10;
      }

      return ergebnis;
    }

    public static bool Dreieck(int seiteA, int seiteB, int seiteC)
    {
      // if (a * a + b * b == c * c)
      if (Math.Pow(seiteC, 2) == Math.Pow(seiteA, 2) + Math.Pow(seiteB, 2))
        return true;

      return false;
    }

    public static double Pi()
    {
      return pi;
    }
  }
}