using System;

namespace cSharp.Grundlagen
{
  public class Operatoren
  {
    public static void Run()
    {
      // Arithmetrische Operatoren
      string name = "Susi";
      string stringZusammen = "Hallo " + name + " wie gehts?";
      string stringZusammen2 = $"Hallo {name} wie gehts?";

      int addition = 5 + 5;
      int subtraktion = 5 - 5;
      int multiplikation = 5 * 5;
      int division = 5 / 5;
      int modulo = 5 % 5;

      // kurzschreibweise
      addition = addition + 5;
      addition += 5;
      subtraktion -= 5;
      multiplikation *= 5;
      division /= 5;

      // Post - inkrement
      addition = addition + 1;
      addition++;

      // Post - dekrement
      addition--;

      // Pre - inkrement / dekrement
      ++addition;
      --addition;

      int a = 5;
      int b = a++;

      // Vergleichsoperatoren
      // == IST GLEICH
      // != UNGLEICH
      // < KLEINER
      // > GRÖßER
      // >= GRÖßER GLEICH
      // <= KLEINER GLEICH

      int x = 5;
      int y = 10;
      int z = 5;

      Console.WriteLine(x > z); // false
      Console.WriteLine(x < y); // true
      Console.WriteLine(x >= z); // true (yo)
      Console.WriteLine(x <= z); // true
      Console.WriteLine(x == y); // false
      Console.WriteLine(x != y); // true


      // Bit Logische Operatoren
      bool b1 = true, b2 = false, b3 = true, b4 = false;

      // AND / UND
      Console.WriteLine(b1 & b3); // true
      Console.WriteLine(b1 & b2); // false

      // OR / ODER
      Console.WriteLine(b1 | b2); // true
      Console.WriteLine(b2 | b4); // false


      // && ||

      // LOGISCHE NICHT / LOGICAL NOT
      bool wahrheit = true;
      bool luegner = !wahrheit;
      Console.WriteLine(luegner);

      bool schalter = false;

      schalter = !schalter;
    }
  }
}