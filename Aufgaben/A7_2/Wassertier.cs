using System;

namespace cSharp.Aufgaben.A7_2
{
  public class Wassertier : Tier, ITauchzeit
  {
    public int Tauchzeit { get; set; }

    public override void Steckbrief()
    {
      Console.WriteLine($"Name des Tiers: {name}");
      Console.WriteLine($"Tauchzeit: {Tauchzeit}\n");
    }
  }
}