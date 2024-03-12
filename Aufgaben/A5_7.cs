using System;
using System.Linq;

namespace cSharp.Aufgaben
{
  public class A5_7
  {
    public static void Run()
    {
      int anzahl = 0, fehlversuch = 0;
      char eingabe = ' ';
      char[] arrEingabe = new char[4];
      char[] arrPwd = { 'P', 'R', 'O', 'G' };
      var passOk = false;

      do
      {
        Console.WriteLine("Bitte char eingeben");
        eingabe = char.ToUpper(Convert.ToChar(Console.ReadLine()));

        if (arrEingabe.Contains(eingabe)) fehlversuch++;

        arrEingabe[anzahl] = eingabe;
        // Console.WriteLine(arrEingabe[anzahl]);

        if (!arrPwd.Contains(eingabe)) fehlversuch++;

        if (fehlversuch == 3)
        {
          Console.WriteLine("Zuviel Fehlversuche");
          break;
        }

        anzahl++;
        // Console.WriteLine(fehlversuch);
      } while (anzahl < 4);

      Array.Sort(arrPwd);
      Array.Sort(arrEingabe);
      passOk = arrEingabe.SequenceEqual(arrPwd);

      if (passOk)
        Console.WriteLine("Login korrekt");
      else
        Console.WriteLine("Falsches Login");
    }
  }
}