// using System;

namespace cSharp.Aufgaben.U5_1
{
  public class App
  {
    public static void Run()
    {
      Kunde kaiser = new Kunde("Kaiser", 789, "07.07.1977");
      Verkaeufer maier = new Verkaeufer("Maier");
      
      maier.kundendatenAbfrage(kaiser);

     
    }
  }
}