using System;

namespace cSharp.OOP.abstrakteKlassen
{
  public class Dwarf : Humanoid
  {
    public override void TakeDamage()
    {
      health -= 20;
      Console.WriteLine("DAWRF CURRENT HP: " + health);
    }
  }
}