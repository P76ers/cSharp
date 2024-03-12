using System;

namespace cSharp.Aufgaben.A7_2
{
  public class Landtier : Tier, IGeschwindigkeit
  {
    public int Geschwindigkeit { get; set; }

    public override void Steckbrief()
    {
      Console.WriteLine($"Name des Tiers: {name}");
      Console.WriteLine($"Geschindigkeit: {Geschwindigkeit}\n");
    }
  }
}