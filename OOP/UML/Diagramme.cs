using System;

namespace cSharp.OOP.UML
{
  public class Diagramme
  {
    public static void Run()
    {
      Diagram diagram = new Diagram();

      Console.WriteLine("Anzahl der Objekte ", diagram.GetAnzahl());
    }
  }
}