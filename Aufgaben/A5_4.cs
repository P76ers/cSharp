using System;

namespace cSharp.Aufgaben
{
  public class A5_4
  {
    public static void Run()
    {
      for (int i = 11; i >= 0; i--)
      {
        for (int j = i - 1; j >= 0; j--) Console.Write($"{j} ");

        Console.WriteLine();
      }
    }
  }
}