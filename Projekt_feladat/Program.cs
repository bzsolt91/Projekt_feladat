using MySqlConnector;

namespace Projekt_feladat
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

       
        [STAThread]
        static void Main()
        {
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

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a bejelentkezési felhasználó létrehozásakor:\n" + ex.Message,
                              "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // kilépés, ha nem megy tovább
            }
        
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
           
            Application.Run(new frm_foForm());
        }
    }
}