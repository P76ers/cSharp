using System;

namespace cSharp.Aufgaben.U5_1v
{
  public enum AppState
  {
    Init,
    Running,
    Quitting
  }

  public class VertragApp
  {
    public static AppState currentAppstate = AppState.Init;

    public static void Run()
    {
      currentAppstate = AppState.Running;

      Console.WriteLine("Vertrag App 2024");

      Console.WriteLine("Bitte geben sie einen Namen ein:");
      string name = Console.ReadLine();

      Console.WriteLine("Bitte geben sie eine ID ein:");
      int id = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Bitte geben sie ein Geburtsdatum(TT.MM.JJJJ) ein:");
      string geburtsdatum = Console.ReadLine();

      Kunde kaiser = new Kunde(name, id, geburtsdatum);

      Console.WriteLine("Bitte geben sie den Namen des Verkäufers ein");
      string name2 = Console.ReadLine();

      Verkaeufer maier = new Verkaeufer(name2, kaiser);
      maier.NeuerVertrag();

      kaiser.VertagsdatenAusgeben();


      currentAppstate = AppState.Quitting;
    }
  }
}