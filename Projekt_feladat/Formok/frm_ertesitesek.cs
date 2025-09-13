using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySqlConnector;
using Projekt_feladat.egyeni_vezerlok;

namespace Projekt_feladat.Formok
{
    public partial class frm_ertesitesek : Form
    {
        private ToolTip? egyeniTooltip = new ToolTip();
        private readonly string kapcsolatString = string.Format(
            "Server={0};User ID={1};Password={2};Database={3}",
            "127.0.0.1",
            "utazast_kezelo",
            "utazast_kezelo1234",
            "utazast_kezelo");

        public frm_ertesitesek()
        {
            InitializeComponent();
            egyeniTooltip.OwnerDraw = true;
            egyeniTooltip.Draw += EgyeniTooltip_Draw;
            egyeniTooltip.Popup += EgyeniTooltip_Popup;
        }

        private void ablakUjrarajzolas()
        {
            int celMeret = this.ClientSize.Width;
            if (celMeret < 0) celMeret = 0;

            pl_terkezelo.Width = celMeret - 20;

            // Kényszerítsd az FLP-t, hogy újraszámolja a belső területét
            flp_rendezoPanel.PerformLayout();
            flp_rendezoPanel.Invalidate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (egyeniTooltip != null)
            {
                egyeniTooltip.RemoveAll();  // Az összes tooltip eltávolítása
                egyeniTooltip.Dispose();    // Tooltip tényleges felszabadítása
                egyeniTooltip = null;
            }

            base.OnFormClosing(e);
        }

        private void frm_ertesitesek_Load(object sender, EventArgs e)
        {
            ablakUjrarajzolas();
            BetoltesBiztonsagosan();
        }

        private void BetoltesBiztonsagosan()
        {

            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show("A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                                "Bejelentkezés szükséges",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                dgv_okmanyLejaratok.DataSource = new DataTable();
                dgv_elofoglalasok.DataSource = new DataTable();
                return;
            }
  
            try
            {
                using var kapcsolat = new MySqlConnection(kapcsolatString);
                kapcsolat.Open();

                // 1) Lejáró okmányok
                try
                {
                    string okmanyQuery = "SELECT * FROM lejaro_okmanyok;";
                    using var daOkmany = new MySqlDataAdapter(okmanyQuery, kapcsolat);
                    var dtOkmany = new DataTable();
                    daOkmany.Fill(dtOkmany);
                    dgv_okmanyLejaratok.DataSource = dtOkmany;
                }
                catch (MySqlException ex) when (ex.Number == 1146) // Table doesn't exist
                {
                    dgv_okmanyLejaratok.DataSource = new DataTable();
                    MessageBox.Show(
                        "A 'lejaro_okmanyok' tábla nem található az adatbázisban.",
                        "Hiányzó tábla",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                dgv_okmanyLejaratok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // 2) Előfoglalások (csak érdeklődők)
                try
                {
                    string elofoglalasQuery = @"
                        SELECT teljes_nev AS 'Név',
                               telefon AS 'Telefonszám',
                               regisztracio_idopont AS 'Regisztráció időpontja',
                               allapot AS 'Állapot'
                        FROM elofoglalas
                        WHERE allapot = 'érdeklődik';";

                    using var daElofoglalas = new MySqlDataAdapter(elofoglalasQuery, kapcsolat);
                    var dtElofoglalas = new DataTable();
                    daElofoglalas.Fill(dtElofoglalas);
                    dgv_elofoglalasok.DataSource = dtElofoglalas;
                }
                catch (MySqlException ex) when (ex.Number == 1146)
                {
                    dgv_elofoglalasok.DataSource = new DataTable();
                    MessageBox.Show(
                        "Az 'elofoglalas' tábla nem található az adatbázisban.",
                        "Hiányzó tábla",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                dgv_elofoglalasok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (MySqlException ex)
            {
                // Kapcsolódási / jogosultsági / adatbázis szintű hibák
                string uzenet = ex.Number switch
                {
                    1049 => "Az adatbázis nem található (Unknown database). Ellenőrizze a beállításokat!",
                    1045 => "Hibás felhasználónév/jelszó (Access denied).",
                    0 => "Nem sikerült elérni az adatbázis kiszolgálót.",
                    _ => $"MySQL hiba ({ex.Number}): {ex.Message}"
                };
                MessageBox.Show(uzenet, "Adatbázis hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Üres táblákhoz kötött nézetek inicializálása, hogy ne omoljon össze a UI
                dgv_okmanyLejaratok.DataSource = new DataTable();
                dgv_elofoglalasok.DataSource = new DataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok betöltésekor: " + ex.Message,
                                "Váratlan hiba",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                dgv_okmanyLejaratok.DataSource = new DataTable();
                dgv_elofoglalasok.DataSource = new DataTable();
            }
        }

        private void frm_ertesitesek_Resize(object sender, EventArgs e)
        {
            ablakUjrarajzolas();
        }

        private void EgyeniTooltip_Draw(object sender, DrawToolTipEventArgs e)
        {
            using Font font = new Font("Segoe UI", 14);
            using LinearGradientBrush brush = new LinearGradientBrush(e.Bounds, Color.BlueViolet, Color.BlueViolet, 90f);
            e.Graphics.FillRectangle(brush, e.Bounds);

            e.Graphics.DrawRectangle(Pens.DarkViolet, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1));
            TextRenderer.DrawText(e.Graphics, e.ToolTipText, font, e.Bounds, Color.White, TextFormatFlags.WordBreak);
        }

        private void EgyeniTooltip_Popup(object sender, PopupEventArgs e)
        {
            using Font font = new Font("Segoe UI", 18);

            // Itt a 'sender' a ToolTip objektum, tehát le tudjuk kérni belőle a szöveget
            ToolTip tooltip = (ToolTip)sender;
            string szoveg = tooltip.GetToolTip(e.AssociatedControl);

            Size meret = TextRenderer.MeasureText(szoveg, font, new Size(1000, 0), TextFormatFlags.WordBreak);
            e.ToolTipSize = new Size(meret.Width + 10, meret.Height + 10);
        }

        private void dgv_okmanyLejaratok_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var dgv = sender as DataGridView;
                if (dgv == null) return;

                var cella = dgv[e.ColumnIndex, e.RowIndex];
                if (cella.Value != null)
                {
                    string szoveg = cella.Value.ToString();

                    egyeniTooltip!.OwnerDraw = true; // saját rajzolás engedélyezése

                    Point kurzor = Cursor.Position;
                    Point formPozicio = this.PointToClient(kurzor);

                    egyeniTooltip.Show(szoveg, this, formPozicio.X + 10, formPozicio.Y + 20, 3000);
                }
            }
        }
    }
}
