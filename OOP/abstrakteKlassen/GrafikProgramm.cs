namespace cSharp.OOP.abstrakteKlassen
{
  public class GrafikProgramm
  {
    public static void Run()
    {
      Orc lohrengel = new Orc();
      Dwarf sahin = new Dwarf();

      Humanoid[] spieler = new Humanoid[2];
      spieler[0] = lohrengel;
      spieler[1] = sahin;

      for (int i = 0; i < 2; i++)
      {
        spieler[i].TakeDamage();
      }
    }
  }
}