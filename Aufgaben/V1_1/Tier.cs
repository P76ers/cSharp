using System;

namespace cSharp.Aufgaben.V1_1
{
  public class Tier
  {
    public int alter;

    public string geraeusch;

    // Attribute name, alter geräusch
    public string name;

    // methode macheGeraeusch

    public void MachGeraeusch()
    {
      Console.WriteLine($"Mein name ist: {name}");
      Console.WriteLine($"Ich bin {alter} Jahre alt.");
      Console.WriteLine($"{geraeusch}");
    }
  }
}