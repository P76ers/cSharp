using System;

namespace cSharp.OOP.Schule
{
    public class Schule
    {
        public Klasse[] klassen = new Klasse[10];

        public Schule()
        {
            klassen[0] = new Klasse("Klasse 1");

            Console.WriteLine(klassen[0].schueler[0].name);

        }
    }
}