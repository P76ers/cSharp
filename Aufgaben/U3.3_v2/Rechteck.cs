namespace cSharp.Aufgaben.U3._3_v2
{
  public class Rechteck
  {
    private Punkt p1;
    private Punkt p2;
    private Punkt p3;
    private Punkt p4;

    public Rechteck()
    {
    }

    public Rechteck(double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y)
    {
      p1 = new Punkt(p1X, p1Y);
      p2 = new Punkt(p2X, p2Y);
      p3 = new Punkt(p3X, p3Y);
    }

    public Punkt GetP1()
    {
      return p1;
    }

    public Punkt GetP2()
    {
      return p2;
    }

    public Punkt GetP3()
    {
      return p3;
    }

    public Punkt GetP4()
    {
      return p4;
    }

    public void SetP1(Punkt p1)
    {
      this.p1 = p1;
    }

    public void SetP2(Punkt p2)
    {
      this.p2 = p2;
    }

    public void SetP3(Punkt p3)
    {
      this.p3 = p3;
    }

    public void SetP4(Punkt p4)
    {
      this.p4 = p4;
    }

    public void RufeAnzeige()
    {
      Anzeige anzeige = new Anzeige();
      anzeige.Flaeche(this);
    }
  }
}