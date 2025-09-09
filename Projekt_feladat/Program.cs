using MySqlConnector; // NuGet: MySqlConnector
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Projekt_feladat
{
    internal static class Program
    {
        // --- Beállítások: szükség szerint módosíthatod ---
        private const string CelAdatbazisNeve = "utazast_kezelo";
        private const string AppFelhasznalo = "utazast_kezelo";
        private const string AppJelszo = "utazast_kezelo1234";

        // Root kapcsolat a "mysql" db-hez (mert lehet, hogy a céldb még nem létezik)
        private static readonly string RootConnStr = "server=localhost;uid=root;pwd=;database=mysql;";

        // App kapcsolat a céldb-hez (ha már létezik)
        private static readonly string AppConnStr =
            $"server=localhost;uid={AppFelhasznalo};pwd={AppJelszo};database={CelAdatbazisNeve};";

        /// <summary> Belépési pont. </summary>
        [STAThread]
        static void Main()
        {
            // 1) MySQL szerver ellenőrzés
            if (!FutEaSzerver())
            {
                MessageBox.Show("A MySQL szerver nem fut. Indítsd el, majd próbáld újra!",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 2) App felhasználó és jogosultságok létrehozása (idempotens)
                LetrehozFelhasznaloEsJogok();

                // 3) Céladatbázis létezik?
                bool letezik = AdatbazisLetezik(CelAdatbazisNeve);

                if (!letezik)
                {
                    // 3/a) Ha nem létezik: létrehozás és feltöltés dumpból
                    var dumpPath = TalaldMegDumpFajlt();
                    if (dumpPath == null)
                    {
                        MessageBox.Show(
                            "Az adatbázis nem létezik, és nem találtam SQL dumpot a létrehozásához.\n" +
                            "Helyezd a dumpot a futtatható mellé (adatbazis_mentes_20250903_1006.sql) vagy add meg a pontos útvonalat a kódban.",
                            "Hiányzó SQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Biztonság kedvéért hozd létre az üres adatbázist is (ha a dump nem tartalmaz CREATE DATABASE-t)
                    CreateDatabaseIfNotExists(CelAdatbazisNeve);

                    // Dump lefuttatása (root kapcsolatból, vagy közvetlenül a céldb-re)
                    // A legbiztosabb: root + USE utazast_kezelo az elején
                    FuttasdSqlScriptetRootbol(dumpPath, CelAdatbazisNeve);

                    // Újraellenőrzés
                    letezik = AdatbazisLetezik(CelAdatbazisNeve);
                    if (!letezik)
                    {
                        MessageBox.Show("Az adatbázis létrehozása a dump lefuttatása után sem sikerült.",
                            "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Indítási hiba: " + ex.Message, "Hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4) WinForms inicializálás és indulás
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            ApplicationConfiguration.Initialize();
            Application.Run(new frm_foForm());
        }

        /// <summary>
        /// Ellenőrzi, hogy a MySQL szerver elérhető-e (root/mysql kapcsolattal).
        /// </summary>
        public static bool FutEaSzerver()
        {
            using var connection = new MySqlConnection(RootConnStr);
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL kapcsolat hiba: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Általános hiba: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Létrehozza az alkalmazás felhasználót és jogokat. Idempotens (IF NOT EXISTS).
        /// </summary>
        private static void LetrehozFelhasznaloEsJogok()
        {
            using var kapcsolat = new MySqlConnection(RootConnStr);
            kapcsolat.Open();

            string sql = $@"
                CREATE USER IF NOT EXISTS '{AppFelhasznalo}'@'localhost' IDENTIFIED BY '{AppJelszo}';
                GRANT ALL PRIVILEGES ON {CelAdatbazisNeve}.* TO '{AppFelhasznalo}'@'localhost';
                FLUSH PRIVILEGES;";

            using var cmd = new MySqlCommand(sql, kapcsolat);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Megmondja, létezik-e a megadott adatbázis.
        /// </summary>
        private static bool AdatbazisLetezik(string schemaName)
        {
            using var kapcsolat = new MySqlConnection(RootConnStr);
            kapcsolat.Open();

            string sql = "SELECT 1 FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @db LIMIT 1;";
            using var cmd = new MySqlCommand(sql, kapcsolat);
            cmd.Parameters.AddWithValue("@db", schemaName);

            var result = cmd.ExecuteScalar();
            return result != null;
        }

        /// <summary>
        /// Létrehozza az adatbázist, ha nem létezik.
        /// </summary>
        private static void CreateDatabaseIfNotExists(string schemaName)
        {
            using var kapcsolat = new MySqlConnection(RootConnStr);
            kapcsolat.Open();

            string sql = $"CREATE DATABASE IF NOT EXISTS `{schemaName}` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;";
            using var cmd = new MySqlCommand(sql, kapcsolat);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Megpróbálja megtalálni a dump fájlt a futtatható mappájában.
        /// </summary>
        private static string? TalaldMegDumpFajlt()
        {
            try
            {
                string exeDir = AppDomain.CurrentDomain.BaseDirectory;
                string alapNev = "ures_adatbazis.sql";
                string jelolt = Path.Combine(exeDir, alapNev);
                if (File.Exists(jelolt)) return jelolt;

                // Ha szeretnéd, itt kereshetsz alternatív helyeken is:
                // pl. var masik = Path.Combine(exeDir, "sql", alapNev);

                return null;
            }
            catch { return null; }
        }

        /// <summary>
        /// Dump lefuttatása root kapcsolatból. A script elejére illeszt egy USE db; parancsot.
        /// Kezeli a DELIMITER váltást is.
        /// </summary>
        private static void FuttasdSqlScriptetRootbol(string scriptPath, string useDatabase)
        {
            string fullScript = File.ReadAllText(scriptPath, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));

            // A script elejére illesztünk egy 'USE adatbazis;' parancsot, hogy a továbbiak biztosan oda menjenek:
            fullScript = $"USE `{useDatabase}`;\nSET FOREIGN_KEY_CHECKS=0;\n" + fullScript + "\nSET FOREIGN_KEY_CHECKS=1;";

            var parancsok = FelbontSqlParancsokra(fullScript);

            using var kapcsolat = new MySqlConnection(RootConnStr);
            kapcsolat.Open();

            int ok = 0, fail = 0;
            foreach (var sql in parancsok)
            {
                if (string.IsNullOrWhiteSpace(sql)) continue;

                try
                {
                    using var cmd = new MySqlCommand(sql, kapcsolat);
                    cmd.CommandTimeout = 0; // nagy dump esetére
                    cmd.ExecuteNonQuery();
                    ok++;
                }
                catch (MySqlException ex)
                {
                    fail++;
                    // Sok dump tartalmaz olyan objektumot, ami már létezhet, vagy ideiglenesen hibázik → napló + folytatás
                    Console.WriteLine($"SQL hiba: {ex.Number} - {ex.Message}\nRészlet: {ElsoNKarakter(sql, 200)}\n");
                }
                catch (Exception ex)
                {
                    fail++;
                    Console.WriteLine($"Általános SQL hiba: {ex.Message}\nRészlet: {ElsoNKarakter(sql, 200)}\n");
                }
            }

            MessageBox.Show($"Adatbázis szkript futtatva.\nSikeres utasítások: {ok}\nSikertelenek: {fail}",
                "Létrehozás kész", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Egyszerű (de robusztus) szkriptdaraboló:
        /// - Kezeli a DELIMITER váltást (pl. TRIGGER/PROCEDURE esetén).
        /// - Nem darabol fel az aktuális delimiteren belül.
        /// - Átugorja a megjegyzéseket (--, #, /* ... */).
        /// </summary>
        private static List<string> FelbontSqlParancsokra(string script)
        {
            var res = new List<string>();
            string delimiter = ";";

            // Többsoros kommentek kiszűrése (vigyázat: ez egyszerűsített; a legtöbb dumpnál elég)
            script = EltavolitMultilineKomment(script);

            using var reader = new StringReader(script);
            var sb = new StringBuilder();
            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                string trimmed = line.Trim();

                // Üres sor → hozzáadjuk, hogy megmaradjon a formátum (nem feltétlen szükséges)
                if (trimmed.Length == 0)
                {
                    sb.AppendLine();
                    continue;
                }

                // Egysoros kommentek átugrása
                if (trimmed.StartsWith("--") || trimmed.StartsWith("#"))
                    continue;

                // DELIMITER váltás?
                // pl.: DELIMITER $$   vagy  DELIMITER //
                if (trimmed.StartsWith("DELIMITER ", StringComparison.OrdinalIgnoreCase))
                {
                    // előző puffer kilapátolása, ha nem üres
                    var prev = sb.ToString().Trim();
                    if (prev.Length > 0)
                    {
                        res.Add(prev);
                        sb.Clear();
                    }

                    delimiter = trimmed.Substring("DELIMITER ".Length).Trim();
                    continue;
                }

                sb.AppendLine(line);

                // Akkor zárunk le, ha a puffer vége pont az aktuális delimiterre végződik
                if (SorVegsDelimeterrel(sb, delimiter))
                {
                    string parancs = LevagAScriptVegerol(sb.ToString(), delimiter);
                    if (!string.IsNullOrWhiteSpace(parancs))
                        res.Add(parancs.Trim());

                    sb.Clear();
                }
            }

            // maradék
            var rest = sb.ToString().Trim();
            if (rest.Length > 0) res.Add(rest);

            return res;
        }

        private static string EltavolitMultilineKomment(string input)
        {
            // nagyon egyszerű eltávolítás: /* ... */ blokkok kivágása
            var sb = new StringBuilder(input.Length);
            int i = 0;
            while (i < input.Length)
            {
                if (i + 1 < input.Length && input[i] == '/' && input[i + 1] == '*')
                {
                    // keresd a lezárást
                    int end = input.IndexOf("*/", i + 2, StringComparison.Ordinal);
                    if (end == -1) break; // nincs lezárás – ritka; ekkor eldobhatjuk a maradékot
                    i = end + 2;
                }
                else
                {
                    sb.Append(input[i]);
                    i++;
                }
            }
            return sb.ToString();
        }

        private static bool SorVegsDelimeterrel(StringBuilder sb, string delimiter)
        {
            // Összevetjük a véget (trim nélkül, mert lehet delimiter után whitespace)
            var txt = sb.ToString();
            // Keressük az utolsó nem-whitespace véget a delimiterrel
            int idx = txt.LastIndexOf(delimiter, StringComparison.Ordinal);
            if (idx < 0) return false;

            // A delimiter után csak whitespace állhat a blokk végéig
            for (int j = idx + delimiter.Length; j < txt.Length; j++)
            {
                if (!char.IsWhiteSpace(txt[j])) return false;
            }
            return true;
        }

        private static string LevagAScriptVegerol(string text, string delimiter)
        {
            // Az utolsó előfordulást levágjuk a végéről
            int idx = text.LastIndexOf(delimiter, StringComparison.Ordinal);
            if (idx >= 0) return text.Substring(0, idx);
            return text;
        }

        private static string ElsoNKarakter(string s, int n)
            => s.Length <= n ? s : s.Substring(0, n) + "...";
    }
}
