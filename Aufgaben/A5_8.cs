using System;

namespace cSharp.Aufgaben
{
  public class A5_8
  {
    public static void Run()
    {
      int eingabe, eingabeFirst, eingabeLast, sum;
      bool authorized = false;

      do
      {
        Console.WriteLine("Bitte Zahl eingeben:");
        eingabe = Convert.ToInt32(Console.ReadLine());

        sum = 0;
        eingabeFirst = eingabe;
        eingabeLast = eingabe % 10;

        while (eingabeFirst > 10)
        {
          eingabeFirst = eingabeFirst / 10;
          sum += eingabeFirst % 10;
        }

        // Console.WriteLine($"Summe 4: {sum}");
        sum = sum % 7;
        // Console.WriteLine($"Summe %: {sum}");

        if (eingabeFirst == 1) authorized = eingabeLast == 1 ? true : false;
        // eingabe = 100000;
        // Console.WriteLine("Reset");
        if (
          eingabe > 99999 || eingabe < 10000 ||
          eingabe % 3 == 0 ||
          eingabe % 5 == 0 ||
          eingabe % 7 == 0 ||
          sum != eingabeLast
        )
          authorized = false;
        else
          authorized = true;

        // Console.WriteLine($"eingabeLast: {eingabeLast}");
        // Console.WriteLine(authorized);
      } while (!authorized);

      Console.WriteLine("Eingabe korrekt");
    }
  }
}