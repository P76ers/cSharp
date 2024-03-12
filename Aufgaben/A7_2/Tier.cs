namespace cSharp.Aufgaben.A7_2
{
  public abstract class Tier
  {
    protected string name;

    public Tier()
    {
    }

    public Tier(string name)
    {
      this.name = name;
    }

    public abstract void Steckbrief();
  }
}