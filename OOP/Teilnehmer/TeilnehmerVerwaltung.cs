using System;

namespace cSharp.OOP.Teilnehmer
{
  public class TeilnehmerVerwaltung
  {
    public static void Run()
    {
      string neueID;

      Teilnehmer lamberty = new Teilnehmer("IT-0723-1");
      Teilnehmer wilhelms = new Teilnehmer("Max", "Power");
      Teilnehmer wang = new Teilnehmer("IT-0723-2", "Max", "Power");

      Console.WriteLine("ID von Wang: " + wang.GetID());

      Console.WriteLine("Bitte geben sie die neue ID ein:");
      neueID = Console.ReadLine();
      wang.SetID(neueID);

      wang.Id = "TEST";

      for (int i = 0; i < 100; i++) wilhelms.IsToLate();

      //lamberty.id = "IT0723-1";
      //lamberty.vorname = "Max";
      //lamberty.nachname = "Power";

      Teilnehmer obj = new Teilnehmer("DFDFD");
    }
  }
}