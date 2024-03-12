using System;

namespace cSharp.Aufgaben.U5_1
{
  public class Kunde
  {
    public string name;
    public int kundenID;
    public string geburtsdatum;

    public Kunde()
    {
      }
    
    public Kunde(string name, int kundenID, string geburtsdatum)
    {
      this.name = name;
      this.kundenID = kundenID;
      this.geburtsdatum = geburtsdatum;
    }
    
    // public Kunde DatenSenden()
    // {
    //   Verkaeufer verkaeufer = new Verkaeufer();
    //   return this;
    // }
    
    public Kunde DatenSenden()
    {
      Console.WriteLine($"{this.name} \n{this.kundenID} \n{this.geburtsdatum}");
      return this;
    }
  }
}