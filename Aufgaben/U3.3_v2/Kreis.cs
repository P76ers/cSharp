namespace cSharp.Aufgaben.U3._3_v2
{
  public class Kreis
  {
    private Punkt p1;
    private double radius;

    public Kreis()
    {
    }

    public Kreis(double x, double y, double radius)
    {
      p1 = new Punkt(x, y);
      this.radius = radius;
    }

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

    public void RufeAnzeige()
    {
      Anzeige anzeige = new Anzeige();
      anzeige.Flaeche(this);
    }
  }
}