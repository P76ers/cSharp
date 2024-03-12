using System;

namespace cSharp.Aufgaben.A6_2
{
  public class Zahl
  {
    public int zahl;

    public Zahl()
    {
    }

    public Zahl(int zahl)
    {
      if (zahl < 0 || zahl > 999)
      {
      }
      else
      {
        this.zahl = zahl;
      }
    }

    public void Spell()
    {
      int hunderter, zehner, einer;

      einer = zahl % 10;
      zehner = zahl / 10 % 10;
      hunderter = zahl / 100 % 10;

      Console.WriteLine($"Zahl {zahl}");
      Console.WriteLine($"einer {einer}");
      Console.WriteLine($"zehner {zehner}");
      Console.WriteLine($"hunderter {hunderter}");

      switch (hunderter)
      {
        case 1:
          Console.Write("ein");
          break;
      }

      Console.Write("hundert ");

      switch (einer)
      {
        case 3:
          Console.Write("drei");
          break;
      }

      switch (zehner)
      {
        case 2:
          Console.Write("undzwanzig");
          break;
      }
    }
  }
}