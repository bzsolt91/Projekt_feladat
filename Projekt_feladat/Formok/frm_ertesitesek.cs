
using MySqlConnector;
using Projekt_feladat.egyeni_vezerlok;
using System.Data;
using System.Drawing.Drawing2D; // Kell a MySQL connector

namespace Projekt_feladat.Formok
{
    public partial class frm_ertesitesek : Form
    {
        ToolTip? egyeniTooltip = new ToolTip();
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

            string kapcsolatString = String.Format(
                "Server={0};User ID={1};Password={2};Database={3}",
                "127.0.0.1",
                "utazast_kezelo",
                "utazast_kezelo1234",
                "utazast_kezelo"
            );

            using (MySqlConnection kapcsolat = new MySqlConnection(kapcsolatString))
            {
                try
                {
                    kapcsolat.Open();

                    // 1. Lejáró okmányok betöltése
                    string okmanyQuery = "SELECT * FROM lejaro_okmanyok;";
                    MySqlDataAdapter daOkmany = new MySqlDataAdapter(okmanyQuery, kapcsolat);
                    System.Data.DataTable dtOkmany = new DataTable();
                    daOkmany.Fill(dtOkmany);
                    dgv_okmanyLejaratok.DataSource = dtOkmany;
                    dgv_okmanyLejaratok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    // 2. Előfoglalások betöltése (csak érdeklődők)
                    string elofoglalasQuery = @"
                        SELECT teljes_nev as 'Név',
                                telefon as 'Telefonszám',
                                regisztracio_idopont as 'Regisztráció időpontja',
                                allapot as 'Állapot'
                        FROM elofoglalas 
                        WHERE allapot = 'érdeklődik';
                    ";
                    MySqlDataAdapter daElofoglalas = new MySqlDataAdapter(elofoglalasQuery, kapcsolat);
                    DataTable dtElofoglalas = new DataTable();
                    daElofoglalas.Fill(dtElofoglalas);
                    dgv_elofoglalasok.DataSource = dtElofoglalas;
                    dgv_elofoglalasok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt az adatok betöltésekor: " + ex.Message);
                }
            }
        }

        private void frm_ertesitesek_Resize(object sender, EventArgs e)
        {

            ablakUjrarajzolas();
        }
        private void EgyeniTooltip_Draw(object sender, DrawToolTipEventArgs e)
        {
            Font font = new Font("Segoe UI", 14);
            using (LinearGradientBrush brush = new LinearGradientBrush(e.Bounds, Color.BlueViolet, Color.BlueViolet, 90f))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            e.Graphics.DrawRectangle(Pens.DarkViolet, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1));
            TextRenderer.DrawText(e.Graphics, e.ToolTipText, font, e.Bounds, Color.White, TextFormatFlags.WordBreak);
        }

        private void EgyeniTooltip_Popup(object sender, PopupEventArgs e)
        {
            Font font = new Font("Segoe UI", 18);

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
                // A sender maga a DataGridView, nem a cella
                var dgv = sender as DataGridView;
                if (dgv == null) return;

                var cella = dgv[e.ColumnIndex, e.RowIndex];
                if (cella.Value != null)
                {
                    string szoveg = cella.Value.ToString();

                    egyeniTooltip.OwnerDraw = true; // saját rajzolás engedélyezése

                    Point kurzor = Cursor.Position;
                    Point formPozicio = this.PointToClient(kurzor);

                    egyeniTooltip.Show(szoveg, this, formPozicio.X + 10, formPozicio.Y + 20, 3000);
                }
            }
        }
    }
}
