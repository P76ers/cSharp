namespace cSharp.Aufgaben.U3._3_v2
{
  public class Linie
  {
    private Punkt p1;
    private Punkt p2;

    public Linie()
    {
    }

    public Linie(double p1X, double p1Y, double p2X, double p2Y)
    {
      p1 = new Punkt(p1X, p1Y);
      p2 = new Punkt(p2X, p2Y);
    }

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

    public void RufeAnzeige()
    {
      Anzeige anzeige = new Anzeige();
      anzeige.Laenge(this);
    }
  }
}