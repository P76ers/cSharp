namespace cSharp.Aufgaben.U3._3
{
  public class Rechteck
  {
    private Anzeige anz;
    private Punkt p1;
    private Punkt p2;
    private Punkt p3;
    private Punkt p4;

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

    public double RufeAnzeige(Anzeige anzeige, Rechteck rechteck)
    {
      anz = anzeige;
      return anz.Flaeche(rechteck);
    }
  }
}