using System;

namespace cSharp.Aufgaben.U5_1v
{
  public enum DataVolumes
  {
    FUENF,
    ZEHN,
    UNLIMITED
  }

  public class Vertrag
  {
    private string artikel;
    private int id;
    private string datum;
    private DataVolumes datenvolumen = DataVolumes.FUENF;

    public Vertrag(string artikel, int id, string datum)
    {
      this.artikel = artikel;
      this.id = id;
      this.datum = datum;
    }

    public void Ausgabe()
    {
      Console.WriteLine();
      Console.WriteLine("---- VERTRAGSDATEN ----");
      Console.WriteLine("ARTIKEL: " + artikel);
      Console.WriteLine("ID: " + id);
      Console.WriteLine("DATUM: " + datum);

      switch (datenvolumen)
      {
        case DataVolumes.FUENF:
          Console.WriteLine("Sie haben " + datenvolumen + " Volumen");
          break;

        case DataVolumes.ZEHN:
          break;

        case DataVolumes.UNLIMITED:
          break;
      }
    }
  }
}