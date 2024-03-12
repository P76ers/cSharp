using System;

namespace cSharp.Aufgaben.A6_3
{
  public class App
  {
    public static void Run()
    {
      // IPAdresse ip = new IPAdresse();
      // if (ip.SetIP("12.111.222.123") == true)
      // {
      //   Console.WriteLine("IPAdresse ist ok!");
      // }
      // else
      // {
      //   Console.WriteLine("IPAdresse ist nicht ok");
      // }

      string ip = "12.111.222.123";

      string[] ipStr = ip.Split('.');
      int[] ipInt = new int[4];

      int i = 0;
      foreach (string val in ipStr)
      {
        ipInt[i] = Convert.ToInt32(val);
        Console.WriteLine(ipInt[i]);
        i++;
      }

      foreach (int ipX in ipInt)
      {
        
      }
    }
  }
}