namespace cSharp.Aufgaben.A7_2
{
  public class App
  {
    public static void Run()
    {
      Elefant elefant = new Elefant("Stampfi", 30);
      Nashorn nashorn = new Nashorn("Horny", 20);
      Wal wal = new Wal("Walther", 500);
      Delphin delphin = new Delphin("Flipper", 800);

      Tier t;

      t = elefant;
      elefant.Steckbrief();

      t = nashorn;
      nashorn.Steckbrief();

      t = wal;
      wal.Steckbrief();

      t = delphin;
      delphin.Steckbrief();
    }
  }
}