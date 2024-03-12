using System;

namespace cSharp.Aufgaben.U6_2
{
  public class Auswertung
  {
    private double[] werte;
    private bool sorted = true;
    private int anz;
    private double hilf;

    public Auswertung(int anzahl)
    {
      werte = new double[anzahl];
    }

    public void ArrayFuellen()
    {
      double eingabe;

      for (int i = 0; i < werte.Length; i++)
      {
        Console.WriteLine("Bitte Wert eingeben:");
        eingabe = Convert.ToDouble(Console.ReadLine());
        werte[i] = eingabe;
      }
    }

    public void ArrayZeigen()
    {
      foreach (double value in werte)
      {
        Console.Write(value);
      }
    }

    public void ArraySort()
    {
      anz = werte.Length;
      do
      {
        sorted = false;
        anz--;
        for (int i = 0; i < anz; i++)
        {
          if (werte[i] > werte[i + 1])
          {
            hilf = werte[i];
            werte[i] = werte[i + 1];
            werte[i + 1] = hilf;
          }
        }
      } while (sorted == true);

      foreach (double value in werte)
      {
        Console.Write($"{value} ");
      }
    }

    public int Anz
    {
      get => anz;
      set => anz = value;
    }

    public void Auswahl()
    {
      int wahl;
      Console.WriteLine("Bitte wählen");
      Console.WriteLine("[1]: Minimum");
      Console.WriteLine("[2]: Mittlere Abweichung");
      Console.WriteLine("[3]: Maximum");

      wahl = Convert.ToInt32(Console.ReadLine());

      if (wahl == 1)
      {
        Minimum();
      }
      else if (wahl == 2)
      {
        Abweichung();
      }else Maximum();
    }

    public void Minimum()
    {
      
    }
    
    public void Abweichung()
    {
      
    }
    
    public  void Maximum()
    {
      
    }
  }
}