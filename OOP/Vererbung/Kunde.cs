namespace cSharp.OOP.Vererbung
{
  public class Kunde : Person
  {
    public int id;

    public void SetId(int id)
    {
      this.id = id;
    }

    public int GetId()
    {
      return id;
    }
  }
}