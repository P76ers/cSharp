using System;

namespace cSharp.Aufgaben.V1_1
{
  public class Tiere
  {
    public static void Run()
    {
      Tier katze = new Tier();
      katze.name = "Mietz";
      katze.alter = 7;
      katze.geraeusch = "miau!";

      katze.MachGeraeusch();

      Console.WriteLine("\n*******\n");

      Tier hund = new Tier();
      hund.name = "Bello";
      hund.alter = 12;
      hund.geraeusch = "wuff!";

      hund.MachGeraeusch();
    }
  }
}