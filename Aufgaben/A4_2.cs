using System;

namespace cSharp.Aufgaben
{
  public class A4_2
  {
    public static void Run()
    {
      int a, b, rest;

      Console.WriteLine("Bitte erste Zahl eingeben");
      a = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Bitte zweite Zahl eingeben");
      b = Convert.ToInt32(Console.ReadLine());

      // v1
      /*if (a < b)
      {
          Console.WriteLine($"Der Rest von {a} % {b} = {a}");
      }
      else
      {
          Console.Write($"Der Rest von {a} % {b} ");
          while (a >= b)
          {
              a += b;
          }

          Console.WriteLine($"= {b}");
      }*/

      // v2
      //rest = a / b;
      //rest = a - (rest * b);

      rest = a - a / b * b;
      // 7 - 7 / 20 * 20
      // 7 - 0 * 20
      // 7 - 0
      // 7

      // 20 - ((20 / 7) * 7)
      // 20 - (2 * 7)
      // 20 - 14
      // 6
      Console.WriteLine("********");
      Console.WriteLine($"Der Rest von {a} % {b} = {rest}");
    }
  }
}