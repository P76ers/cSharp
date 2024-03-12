namespace cSharp.Aufgaben.A8_1
{
  public class Person
  {
    private string vorname;
    private string name;
    private int telefon;
    private string geburtsdatum;

    public Person(string vorname, string name, int telefon, string geburtsdatum)
    {
      this.vorname = vorname;
      this.name = name;
      this.telefon = telefon;
      this.geburtsdatum = geburtsdatum;
    }
    
    public static bool operator ==(Person a, Person b)
    {
      if (ReferenceEquals(a, b)) return true;
      if (ReferenceEquals(a, null)) return false;
      return a.Equals(b);
    }
    
    public static bool operator !=(Person a, Person b)
    {
      if (ReferenceEquals(a, b)) return true;
      if (ReferenceEquals(a, null)) return false;
      return a.Equals(b);
    }
  }
}