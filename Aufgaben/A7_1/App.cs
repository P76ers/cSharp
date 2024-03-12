using System;

namespace cSharp.Aufgaben.A7_1
{
  public class App
  {
    public static void Run()
    {
      Viereck v = new Viereck(1, 3, 4, 3, 5, 8, 1, 8, "Viereck1");
      v.Ausgabe();
    
      Kreis k = new Kreis(1, 3, 2.5, "Kreis1");
      k.Ausgabe();
    }

  }
}