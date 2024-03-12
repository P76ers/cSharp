using System;

namespace cSharp.OOP
{
  public class Person
  {
    public static int Anzahl;
    public int alter;

    // Attribute
    private string name;

    // Standard Constructor
    public Person()
    {
      Anzahl++;
    }

    // Parameter Constructor
    public Person(string name, int alter)
    {
      Anzahl++;
      this.name = name;
      this.alter = alter;
    }

    // Getter
    public string GetName()
    {
      return name;
    }

    // Setter
    public void SetName(string name)
    {
      this.name = name;
    }

    // Methode
    public void Winken()
    {
      Console.WriteLine($"{name} winkt Euch zu!");
    }

    // Methode überladen
    public void Winken(string name)
    {
      this.name = name;
      Console.WriteLine($"{name} winkt Euch zu!");
    }
  }
}