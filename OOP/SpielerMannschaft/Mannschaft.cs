namespace cSharp.OOP.SpielerMannschaft
{
  public class Mannschaft
  {
    public Spieler[] spieler = new Spieler[10];

    public void AddSpieler()
    {
      spieler[0] = new Spieler();
      spieler[0].trikotnummer = 1;
    }
  }
}