namespace cSharp.Aufgaben.U5_1
{
  public class Verkaeufer
  {
    private string name;
    private Vertrag vertrag;

    public Verkaeufer()
    {
      
    }
    public Verkaeufer(string name)
    {
      this.name = name;
    }
    
    public void kundendatenAbfrage(Kunde kunde)
    {
      kunde.DatenSenden();
    }

    public void ErzeugeVertrag(Kunde kunde)
    {
      vertrag.Check(kunde);
    }
    
  }
}