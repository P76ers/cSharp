namespace cSharp.OOP.UML
{
  public class Diagram
  {
    private const double KONSTANTE = 3.14;
    private static int zaehler;
    private int wert = 50;

    public Diagram()
    {
    }

    public Diagram(int wert)
    {
      this.wert = wert;
    }

    public void SetWert(int wert)
    {
      this.wert = wert;
    }

    public int GetWert()
    {
      return wert;
    }

    public double GetKonstante()
    {
      return KONSTANTE;
    }

    public void Berechnung()
    {
    }

    public int GetAnzahl()
    {
      return zaehler;
    }
  }
}