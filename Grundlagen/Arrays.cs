using System;

namespace cSharp.Grundlagen
{
  public class Arrays
  {
    public static void Run()
    {
      // Aufbau
      // TYP[] variablenName = new TYP[Plätze];

      double[] meinArray = new double[5];
      meinArray[0] = 1.1;

      //string[] zoo2 = new[] { "Hase", "Wurst" };
      string[] zoo = new string[5];
      zoo[0] = "Löwe";
      zoo[1] = "Giraffe";
      zoo[2] = "Elefant";
      zoo[3] = "Tiger";
      zoo[4] = "Affe";

      //Console.WriteLine($"Zootier auf index 2: {zoo[0]} ");

      for (int i = 0; i < zoo.Length; i++) Console.WriteLine($"Zootier auf index {i}: {zoo[i]} ");

      //KEY -> VALUE
      //produkt['NAME'] = "Bohrmaschine";
      //produkt['PREIS'] = 89.99;
      //produkt['BESCHREIUNG'] = "Richtig geiles Teil";
    }
  }
}