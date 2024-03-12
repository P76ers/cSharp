using System;

namespace cSharp.OOP
{
  public class Personen
  {
    public static void Run()
    {
      // Erzeugen des Objekts mit Standard-Constructor
      Person john = new Person();
      john.SetName("John");
      john.alter = 18;

      // Erzeugen mit Parameter-Constructor
      Person jane = new Person("Jane", 22);

      jane.Winken();

      Console.WriteLine($"Anzahl an Personen-Objekten: {Person.Anzahl}");
    }
  }
}