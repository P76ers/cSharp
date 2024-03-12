using System;

namespace cSharp.Grundlagen
{
  public class SwitchBeispiel
  {
    public static void Run()
    {
      int wuerfel = 7;
      int gegnerwurf = 6;

      switch (wuerfel)
      {
        case 1:
          Console.WriteLine("Sie haben 1 gewürfelt");
          break;
        case 2:
          Console.WriteLine("Sie haben 2 gewürfelt");
          break;
        case 3:
          Console.WriteLine("Sie haben 3 gewürfelt");
          break;
        case 4:
          Console.WriteLine("Sie haben 4 gewürfelt");
          break;
        case 5:
          Console.WriteLine("Sie haben 5 gewürfelt");
          break;
        case 6:
          Console.WriteLine("Sie haben 6 gewürfelt");
          break;

        default:
          Console.WriteLine("Gezinkte Würfel!");
          break;
      }


      switch (wuerfel)
      {
        case 1:
        case 3:
        case 5:
          Console.WriteLine("Sie haben ungerade gewürfelt");
          break;

        case 2:
        case 4:
        case 6:
          Console.WriteLine("Sie haben gerade gewürfelt");
          break;
      }


      if (wuerfel < 6)
      {
      }
    }
  }
}