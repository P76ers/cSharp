using System;

namespace cSharp.Aufgaben
{
  public class A5_2
  {
    public static void Run()
    {
      int tag, monat, jahr, limit;
      bool flag = false;

      do
      {
        Console.WriteLine("Bitte das Jahr eingeben:");
        jahr = Convert.ToInt32(Console.ReadLine());
      } while (jahr < 0 || jahr > 2500);

      do
      {
        Console.WriteLine("Bitte den Monat eingeben:");
        monat = Convert.ToInt32(Console.ReadLine());
      } while (monat < 1 || monat > 12);


      do
      {
        Console.WriteLine("Bitte den Tag eingeben:");
        tag = Convert.ToInt32(Console.ReadLine());

        limit = 30;
        if (monat % 2 == 1 && monat < 8) limit = 31;
        if (monat % 2 == 0 && monat > 7) limit = 31;

        if (monat == 2)
        {
          limit = 28;

          if ((jahr % 4 == 0 && jahr % 100 != 0) || jahr % 400 == 0) limit = 29;
          /* Alternativ
            if ((jahr % 4 == 0) && (jahr % 100 != 0)) limit = 29;
            if ((jahr % 400 == 0)) limit = 29;
          */
        }

        if (tag >= 1 && tag <= limit) flag = true;

        if (flag == false) Console.WriteLine("Datum ist nicht korrekt");
      } while (flag == false);

      Console.WriteLine("Dieses Datum ist korrekt");
    }
  }
}