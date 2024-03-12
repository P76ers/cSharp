namespace cSharp.Aufgaben.U3._3
{
  public class Kreis
  {
    private Anzeige anz;
    private Punkt p1;
    private double radius;

    public Punkt GetP1()
    {
      return p1;
    }

    public double GetRadius()
    {
      return radius;
    }

    public void SetP1(Punkt p1)
    {
      this.p1 = p1;
    }

    public void SetRadius(double radius)
    {
      this.radius = radius;
    }

    public double RufeAnzeige(Anzeige anzeige, Kreis kreis)
    {
      anz = anzeige;
      return anz.Flaeche(kreis);
    }
  }
}