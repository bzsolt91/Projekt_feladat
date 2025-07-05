namespace Projekt_feladat.bejelentkezes
{
    public class bejelentkezesiAdatok
    {
        public int Id { get; set; }
        public string Felhasznalonev { get; set; }
        public string Jelszo { get; set; } // HASH-elt jelszó
        public int Jogosultsag { get; set; }//0 az  csak olvasas az 1 olvasás írás
        public bool MaradBejelentkezve { get; set; }
    }
}