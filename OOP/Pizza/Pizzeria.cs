namespace cSharp.OOP.Pizza
{
  public class Pizzeria
  {
    public static void Run()
    {
      /*
      string pizza1 = "Magharita";
      double pizzapreis1 = 8.99;
      bool extrakaese1 = false;

      string pizza2 = "Salami";
      double pizzapreis2 = 9.99;
      bool extrakaese2 = false;

      string pizza3 = "Funghi";
      double pizzapreis3 = 9.99;
      bool extrakaese3 = false;*/

      Pizza pizzaMagherita = new Pizza();
      pizzaMagherita.name = "Magherita";
      pizzaMagherita.preis = 8.99;
      pizzaMagherita.extraKaese = true;
      pizzaMagherita.groesse = 38;

      pizzaMagherita.DetailsAusgeben();

      Pizza pizzaFunghi = new Pizza();
      pizzaFunghi.name = "Funghi";
      pizzaFunghi.preis = 9.99;
      pizzaFunghi.extraKaese = false;
      pizzaFunghi.groesse = 28;

      pizzaFunghi.DetailsAusgeben();

      Pizza[] pizzen = new Pizza[5];
      pizzen[0] = pizzaMagherita;


      double zwischensumme = pizzaFunghi.Gesamtpreis();
    }
  }
}