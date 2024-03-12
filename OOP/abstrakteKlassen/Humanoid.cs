using System;

namespace cSharp.OOP.abstrakteKlassen
{
  public class Humanoid
  {
    public int health = 100;

    public virtual void TakeDamage()
    {
      health -= 10;
      Console.WriteLine("ORC CURRENT HP: " + health);
    }
  }
}