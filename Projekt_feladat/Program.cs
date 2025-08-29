using MySqlConnector; // Érdemes a MySql.Data.MySqlClient helyett ezt használni, ha már ezt importálod
using System;
using System.Windows.Forms; // Szükséges a MessageBox.Show() miatt

namespace Projekt_feladat
{
    internal static class Program
    {
        /// <summary>
        /// A fő belépési pont az alkalmazás számára.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //  ellenőrizzük, hogy fut-e a MySQL szerver
            if (!futeaSzerver())
            {
                // Ha a szerver nem fut, kilépünk a programból, vagy kezeljük másképp
                MessageBox.Show("A MySQL szerver nem fut. Kérjük, indítsa el, majd próbálja újra!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

    

            try
            {
                // Root felhasználóval csatlakozunk a MySQL szerverhez
                using var kapcsolat = new MySqlConnection("server=localhost;uid=root;pwd=;");
                kapcsolat.Open();

                var parancs = kapcsolat.CreateCommand();
                parancs.CommandText = @"
                    CREATE USER IF NOT EXISTS 'utazast_kezelo'@'localhost' IDENTIFIED BY 'utazast_kezelo1234';
                    GRANT ALL PRIVILEGES ON utazast_kezelo.* TO 'utazast_kezelo'@'localhost';
                    FLUSH PRIVILEGES;";

                parancs.ExecuteNonQuery();
             //   MessageBox.Show("A felhasználó sikeresen létrehozva és a jogosultságok beállítva.", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a bejelentkezési felhasználó létrehozásakor:\n" + ex.Message,
                                "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // kilépés, ha nem megy tovább
            }

            // A felhasználó létrehozása után az alkalmazás további inicializálása
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new frm_foForm());
        }

        /// <summary>
        /// Ellenőrzi, hogy a MySQL szerver fut-e, megpróbálva csatlakozni hozzá.
        /// </summary>
        /// <returns>Igaz, ha a szerver fut és lehet csatlakozni; különben hamis.</returns>
        public static bool futeaSzerver() // A metódusnak statikusnak kell lennie a Main függvényben való használathoz
        {
          
            string connectionString = "server=localhost;uid=root;pwd=;database=mysql;";

            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                  
                    return true;
                }
                catch (MySqlException ex)
                {
                 
                    Console.WriteLine($"Hiba a MySQL szerverhez való csatlakozáskor: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                 
                    Console.WriteLine($"Általános hiba történt az adatbázis ellenőrzése során: {ex.Message}");
                    return false;
                }
            }
        }
    }
}