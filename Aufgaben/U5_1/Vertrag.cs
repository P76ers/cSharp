namespace cSharp.Aufgaben.U5_1
{
  public class Vertrag
  {
    private static int vertragsID;
    private Kunde kunde;

    public Vertrag()
    {
    }

    public Vertrag(int vertragsID)
    {
    }

    public  bool Check(Kunde kunde)
    {
      // vertragsID++;
      if (kunde.kundenID > 0 && kunde.kundenID < 100000)
      {
        return true;
      }
      else
      {
      return false;
      }
    }
  }
}