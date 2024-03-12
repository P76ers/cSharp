using System;

namespace cSharp.Aufgaben
{
  public class A5_3
  {
    public static void Run()
    {
      int i, j, k;
      k = 0;
      for (i = 1; i < 10; i++) k += i;
      Console.WriteLine("Wert von k: " + k);

      k = 0;
      for (i = 2; i < 10; i += 2) k += i;
      Console.WriteLine("Wert von k: " + k);

      k = 0;
      for (i = 1, j = 5; i < 5 && j > 1; i++, j--) k += i * j;
      Console.WriteLine("Wert von k: " + k);

      k = 0;
      for (i = 1; i < 5; i++)
      {
        if (i == 3) continue;
        k += i;
      }

      Console.WriteLine("Wert von k: " + k);

      k = 0;
      for (i = 1; i < 10; i++)
      {
        k += i;
        if (i == 6) break;
      }

      Console.WriteLine("Wert von k: " + k);
    }
  }
}