using Projekt_feladat.bejelentkezes;
using System.Text.Json;

public static class bejelentkezesSeged
{
    private static readonly string fajlUt = "bejelentkezes.json";

    public static void Mentes(bejelentkezesiAdatok adatok)
    {
        string json = JsonSerializer.Serialize(adatok);
        File.WriteAllText(fajlUt, json);
    }

    public static bejelentkezesiAdatok Betoltes()//betölti jsno fájlból a bejelentkezési adatot
    {
        try
        {
            if (!File.Exists(fajlUt))
                return null;

            string json = File.ReadAllText(fajlUt);
            return JsonSerializer.Deserialize<bejelentkezesiAdatok>(json);
        }
        catch (Exception ex)
        {
            
            try { File.Delete(fajlUt); } catch { }

            MessageBox.Show("A bejelentkezési fájl sérült, automatikus belépés kihagyva.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return null;
        }
    }

    public static void Torles()
    {
        if (File.Exists(fajlUt))
            File.Delete(fajlUt);
    }
    public static string GetSha256Hash(string input)
    {
        using (var sha256 = System.Security.Cryptography.SHA256.Create())
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            var hash = sha256.ComputeHash(bytes);
            var sb = new System.Text.StringBuilder();
            foreach (var b in hash)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }
    }
}