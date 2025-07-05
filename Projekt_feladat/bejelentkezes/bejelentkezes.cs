namespace Projekt_feladat.bejelentkezes
{
    public static class bejelentkezes
    {
        public static int Id { get; private set; }
        public static string Felhasznalonev { get; private set; }
        public static string Jelszo { get; private set; } 

        public static int Jogosultsag { get; private set; } //0 az csak olvasas az 1 olvasás írás
        public static void Beallit(int id, string nev, string jelszo,int jogosultsag)
        {
            Id = id;
            Felhasznalonev = nev;
            Jelszo = jelszo;
            Jogosultsag = jogosultsag;
        }

        public static void Kijelentkezes()
        {
            Id = 0;
            Felhasznalonev = null;
            Jelszo = null;
            Jogosultsag = 0;
        }
    }
}
