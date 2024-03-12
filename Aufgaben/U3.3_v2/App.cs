namespace cSharp.Aufgaben.U3._3_v2
{
  public class App
  {
    public static void Run()
    {
      // Kreis
      Kreis kreis = new Kreis(9, 7, 2);
      kreis.RufeAnzeige();

      // Linie
      Linie linie = new Linie(7, 1, 12, 5);
      linie.RufeAnzeige();

      // Rechteck
      Rechteck rechteck = new Rechteck(3, 4, 3, 6, 6, 6);
      rechteck.RufeAnzeige();
    }
  }
}