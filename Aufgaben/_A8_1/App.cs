using System;

namespace cSharp.Aufgaben.A8_1
{
  public class App
  {
    public static void Run()
    {
      Person einePerson = new Person("John", "Doe", 1121, "20.10.1990");
      Person zweitePerson = new Person("Jane", "Doe", 1121, "31.12.1983");

      if (einePerson == zweitePerson)
      {
        Console.WriteLine("Die Personen sind gleich");
      }

      if (einePerson != zweitePerson)
      {
        Console.WriteLine("Die Personen sind nicht gleich");
      }
    }
  }
}