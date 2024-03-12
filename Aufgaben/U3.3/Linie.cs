namespace cSharp.Aufgaben.U3._3
{
  public class Linie
  {
    private Anzeige anz;
    private Punkt p1;
    private Punkt p2;

    public Punkt GetP1()
    {
      return p1;
    }

    public Punkt GetP2()
    {
      return p2;
    }

    public void SetP1(Punkt p1)
    {
      this.p1 = p1;
    }

    public void SetP2(Punkt p2)
    {
      this.p2 = p2;
    }

    public double RufeAnzeige(Anzeige anzeige, Linie linie)
    {
      anz = anzeige;
      return anz.Laenge(linie);
    }
  }
}