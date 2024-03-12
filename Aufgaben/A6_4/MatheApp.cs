using System;

namespace cSharp.Aufgaben.A6_4
{
  public class MatheApp
  {
    public static void Run()
    {
      double zahl1 = 5;
      int zahl2 = 3;
      Console.WriteLine($"Potenz {zahl1} hoch {zahl2} = " + Mathe.Potenz(ref zahl1, zahl2));
      Console.WriteLine("5! = " + Mathe.Fakultaet(5));
      Console.WriteLine("Quersumme 15 = " + Mathe.Quersumme(15));
      Console.WriteLine("Dreiecksprüfung = " + Mathe.Dreieck(3, 4, 5));
      Console.WriteLine("Pi = " + Mathe.Pi());
    }
  }
}