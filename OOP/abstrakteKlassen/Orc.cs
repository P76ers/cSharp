using System;

namespace cSharp.OOP.abstrakteKlassen
{
  public class Orc : Humanoid
  {
    public override void TakeDamage()
    {
      health -= 10;
      Console.WriteLine("ORC CURRENT HP: " + health);
    }
  }
}