using System;

namespace cSharp.Grundlagen
{
  public class Schleifen
  {
    public static void Run()
    {
      int zaehler = 0;

      // WHILE
      while (zaehler < 10)
      {
        Console.WriteLine("Hello World");
        zaehler++;
      }

      zaehler = 0;
      // DO - WHILE
      do
      {
        Console.WriteLine("Hello World");
        zaehler++;
      } while (zaehler < 10);


      string[] zoo = { "Opposum", "Stinkdachs", "Wombat" };

      // FOR
      for (int i = 0; i < 10; i++) Console.WriteLine("Hello World");

      // FOR EACH


      foreach (string tiername in zoo)
      {
        Console.WriteLine(tiername);

        if (tiername.Equals("Stinkdachs"))
        {
          // email an account schicken
        }
      }


      for (int i = 0; i < 10; i++)
      {
        if (i == 5)
          continue;

        Console.WriteLine(i);
      }
    }
  }
}