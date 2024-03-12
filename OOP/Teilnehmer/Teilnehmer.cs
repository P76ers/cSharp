using System;

namespace cSharp.OOP.Teilnehmer
{
  public class Teilnehmer
  {
    private int fehltage;

    // 1. ATTRIBUTE   // public - private sind ZUGRIFFS MODIFIKATOREN
    private string nachname;
    public string vorname;

    // 2. CONSTRUCTOR
    public Teilnehmer(string id)
    {
      this.Id = id;
    }

    public Teilnehmer(string vorname, string nachname)
    {
      this.vorname = vorname;
      this.nachname = nachname;
    }

    public Teilnehmer(string id, string vorname, string nachname)
    {
      this.Id = id;
      this.vorname = vorname;
      this.nachname = nachname;
    }

    // Properties / Eigenschaften
    public string Id { get; set; }

    // 3. GETTER / SETTER
    public string GetID()
    {
      return Id;
    }

    public void SetID(string id)
    {
      this.Id = id;
    }

    // 4. EIGENE METHODEN

    public void IsToLate()
    {
      Console.WriteLine("Eintrag in der Klassenliste");
      fehltage++;
    }
  }
}