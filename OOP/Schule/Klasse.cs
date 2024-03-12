namespace cSharp.OOP.Schule
{
    public class Klasse
    {
        public string name;
        public Schueler[] schueler = new Schueler[10];
        public Lehrer[] lehrer = new Lehrer[10];

        public Klasse(string name)
        {
            this.name = name;
            
            schueler[0] = new Schueler("Susi");
            lehrer[0] = new Lehrer();
            lehrer[0].faecher[0] = new Fach("Mathe");

        }
    }
}