using MySqlConnector;
using Projekt_feladat.egyeni_vezerlok;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Projekt_feladat.Formok
{
    public partial class Frm_UtasokMegtekintese : Form
    {
        string constr = String.Format("Server={0};User ID={1};Password={2};Database={3}", "127.0.0.1", "utazast_kezelo", "utazast_kezelo1234", "utazast_kezelo");
        const int lim = 50;
        private int aktualisOldal = 1;
        private int maxOldal;
        int szurtSorok = 0; // tárolni a sorok számát az aktív szűrők alapján, vagy az összes sort
        private bool szuresAktiv = false;
        ListBox lst_talalatok = new ListBox();
        private int sorIndexAHolFolytatniKell = 0;
        ToolTip? egyeniTooltip = new ToolTip();
        private bool vanValtozas = false;
        public Frm_UtasokMegtekintese()
        {
            InitializeComponent();
            dgv_utasok.ShowCellToolTips = false;
            egyeniTooltip.OwnerDraw = true;
            egyeniTooltip.Draw += EgyeniTooltip_Draw;
            egyeniTooltip.Popup += EgyeniTooltip_Popup;
        }

        private void Frm_Utasok_Load(object sender, EventArgs e)
        {
            // Kezdeti betöltés: Oldalszámok beállítása az összes sor alapján

            nud_oldalValaszto.Minimum = 1;
            nud_oldalValaszto.Value = aktualisOldal;
            lst_talalatok.DrawMode = DrawMode.OwnerDrawFixed;

            szpn_szuroPanel.Controls.Add(lst_talalatok);
            lst_talalatok.Visible = false;
            lst_talalatok.DrawMode = DrawMode.OwnerDrawFixed;
            lst_talalatok.DrawItem += lst_talalatok_DrawItem;
            lst_talalatok.MouseDown += lst_talalatok_MouseDown;
            lst_talalatok.Width = kszm_utasNeve.Width;
            szpn_szuroPanel.Location = new Point((this.Width / 2) - (szpn_szuroPanel.Width / 2), this.Height / 2 - szpn_szuroPanel.Height / 2);
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
        private void lst_talalatok_MouseDown(object? sender, MouseEventArgs e)
        {
            int index = lst_talalatok.IndexFromPoint(e.Location);
            if (index >= 0)
            {
                lst_talalatok.SelectedIndex = index;

                if (lst_talalatok.Tag is kerekitettSzovegMezo aktivMezo)
                {
                    aktivMezo.Texts = lst_talalatok.Items[index].ToString();
                    aktivMezo.Focus();
                }

                lst_talalatok.Visible = false;
            }
        }

        private void lst_talalatok_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var listBox = sender as ListBox;
            var item = listBox.Items[e.Index].ToString();
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // A simítás és a szöveg renderelésének beállítása
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // A kijelölés hátterének kitöltése, függetlenül attól, hogy ki van-e jelölve.
            // Így elkerüljük a maradék pixeleket a korábbi rajzolásból.
            e.Graphics.FillRectangle(new SolidBrush(listBox.BackColor), e.Bounds);

            // Kerekített háttérrajzolás, ha ki van jelölve
            if (isSelected)
            {
                int radius = 8; // Kerekítés mértéke
                                // Kicsi margót hagyunk a kijelölés körül
                Rectangle selectionBounds = new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 1, e.Bounds.Width - 4, e.Bounds.Height - 2);

                using (GraphicsPath path = GetRoundedRectanglePath(selectionBounds, radius))
                using (Brush bgBrush = new SolidBrush(Color.DarkViolet))
                {
                    e.Graphics.FillPath(bgBrush, path);
                }
            }

            // Szöveg rajzolása a megfelelő színekkel
            using (Brush textBrush = new SolidBrush(isSelected ? Color.White : listBox.ForeColor))
            {
                // A szöveg rajzolásához érdemes egy kicsit beljebb húzódni, hogy ne érjen a lekerekített szélhez
                Rectangle textBounds = new Rectangle(e.Bounds.X + 6, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                TextRenderer.DrawText(e.Graphics, item, e.Font, textBounds, isSelected ? Color.White : listBox.ForeColor, TextFormatFlags.VerticalCenter);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

            // Bal felső sarok
            path.AddArc(arc, 180, 90);

            // Jobb felső sarok
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Jobb alsó sarok
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bal alsó sarok
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        public void lekerdezes()
        {
            try
            {
                if (!bejelentkezes.bejelentkezes.Bejelentkezve())
                {
                    MessageBox.Show("A művelet végrehajtásához be kell jelentkeznie a főoldalon.", "Bejelentkezés szükséges", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var mc_mysqlcon = new MySqlConnection(constr))
                {
                    mc_mysqlcon.Open();
                    var dt = new DataTable();
                    var cmd = new MySqlCommand();
                    cmd.Connection = mc_mysqlcon;

                    var feltetelek = new List<string>();

                    // -- Szűrési feltételek feldolgozása
                    if (szuresAktiv)
                    {
                        if (!string.IsNullOrWhiteSpace(kszm_utasNeve.Texts))
                        {
                            var nevReszek = kszm_utasNeve.Texts.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            int nevIndex = 0;

                            foreach (var szo in nevReszek)
                            {
                                string paramNev = "@nev" + nevIndex++;
                                feltetelek.Add($@"(
                            u.titulus LIKE {paramNev}
                            OR u.vezeteknev LIKE {paramNev}
                            OR u.keresztnev1 LIKE {paramNev}
                            OR u.keresztnev2 LIKE {paramNev}
                        )");
                                cmd.Parameters.AddWithValue(paramNev, "%" + szo + "%");
                            }
                        }

                        if (!string.IsNullOrWhiteSpace(kszm_telefon.Texts))
                        {
                            feltetelek.Add("telefon.telefon LIKE @telefon");
                            cmd.Parameters.AddWithValue("@telefon", "%" + kszm_telefon.Texts + "%");
                        }

                        if (!string.IsNullOrWhiteSpace(kszm_okmanySzam.Texts))
                        {
                            feltetelek.Add("szemelyi.szemelyi_vagy_utlevel LIKE @okmany");
                            cmd.Parameters.AddWithValue("@okmany", "%" + kszm_okmanySzam.Texts + "%");
                        }
                        if (!string.IsNullOrWhiteSpace(kszm_allampolgarsag.Texts))
                        {
                            feltetelek.Add("szemelyi.allampolgarsag LIKE @allamp");
                            cmd.Parameters.AddWithValue("@allamp", "%" + kszm_allampolgarsag.Texts + "%");
                        }

                        if (kb_okmanyErvenyes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Kozep)
                            feltetelek.Add("szemelyi.okmany_lejarat < CURDATE()");
                        else if (kb_okmanyErvenyes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be)
                            feltetelek.Add("szemelyi.okmany_lejarat >= CURDATE()");

                        if (!string.IsNullOrWhiteSpace(kszm_lakcim.Texts))
                        {
                            feltetelek.Add("cim.lakcim LIKE @lakcim");
                            cmd.Parameters.AddWithValue("@lakcim", "%" + kszm_lakcim.Texts + "%");
                        }

                        if (!string.IsNullOrWhiteSpace(kszm_email.Texts))
                        {
                            feltetelek.Add("cim.email_cim LIKE @email");
                            cmd.Parameters.AddWithValue("@email", "%" + kszm_email.Texts + "%");
                        }

                        if (kb_befizetes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Kozep)
                            feltetelek.Add("fizetes.befizetett_osszeg = 0");
                        else if (kb_befizetes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be)
                            feltetelek.Add("fizetes.befizetett_osszeg > 0");

                        if (kb_biztositas.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Kozep)
                            feltetelek.Add("fizetes.biztositas = 'nem'");
                        else if (kb_biztositas.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be)
                            feltetelek.Add("fizetes.biztositas = 'igen'");

                        if (!string.IsNullOrWhiteSpace(kszm_megjegyzes.Texts))
                        {
                            feltetelek.Add("megjegyzes.megjegyzes LIKE @megjegyzes");
                            cmd.Parameters.AddWithValue("@megjegyzes", "%" + kszm_megjegyzes.Texts + "%");
                        }
                        string mod = klm_utazasiMod.ComboText.ToLower();
                        if (mod != "mind" && mod != "utazási mód")
                        {
                            feltetelek.Add("t_ossz.utazas_modja = @kozmod");
                            cmd.Parameters.AddWithValue("@kozmod", klm_utazasiMod.ComboText);
                        }
                    }

                    // SQL lekérdezés
                    string alapSelect = @"
                        SELECT
                            u.utas_id AS 'Sorszám',
                            u.titulus AS 'Titulus',
                            u.vezeteknev AS 'Vezetéknév',
                            u.keresztnev1 AS 'Keresztnév',
                            u.keresztnev2 AS 'Második keresztnév',
                            u.szuletesi_datum AS 'Születési dátum',
                            telefon.telefon AS 'Telefonszám',
                            szemelyi.szemelyi_vagy_utlevel AS 'Okmány',
                            szemelyi.allampolgarsag AS 'Állampolgárság',
                            szemelyi.okmany_lejarat AS 'Érvényesség',
                            cim.lakcim AS 'Lakcím',
                            cim.email_cim AS 'Email',
                            fizetes.befizetett_osszeg AS 'Befizetett összeg',
                            fizetes.biztositas AS 'Biztosítás van',
                            megjegyzes.megjegyzes AS 'Megjegyzés',
                            GROUP_CONCAT(CONCAT(t_ossz.desztinacio, ' - ', t_ossz.utazas_ideje, ' - ', t_ossz.utazas_elnevezese) SEPARATOR '\n') AS 'Utazások'
                        FROM utas AS u
                        INNER JOIN utas_utazasai AS uu_ossz ON u.utas_id = uu_ossz.utas_id
                        INNER JOIN utazas AS t_ossz ON uu_ossz.utazas_id = t_ossz.utazas_id
                        LEFT JOIN telefon ON u.utas_id = telefon.utas_id
                        LEFT JOIN cim ON u.utas_id = cim.utas_id
                        LEFT JOIN fizetes ON u.utas_id = fizetes.utas_id
                        LEFT JOIN szemelyi ON u.utas_id = szemelyi.utas_id
                        LEFT JOIN megjegyzes ON u.utas_id = megjegyzes.utas_id
                        ";

                    string alapCount = @"
                        SELECT COUNT(*) FROM (
                            SELECT u.utas_id
                            FROM utas AS u
                            INNER JOIN utas_utazasai AS uu_ossz ON u.utas_id = uu_ossz.utas_id
                            INNER JOIN utazas AS t_ossz ON uu_ossz.utazas_id = t_ossz.utazas_id
                            LEFT JOIN telefon ON u.utas_id = telefon.utas_id
                            LEFT JOIN cim ON u.utas_id = cim.utas_id
                            LEFT JOIN fizetes ON u.utas_id = fizetes.utas_id
                            LEFT JOIN szemelyi ON u.utas_id = szemelyi.utas_id
                            LEFT JOIN megjegyzes ON u.utas_id = megjegyzes.utas_id
                        ";

                    string whereClause = feltetelek.Count > 0 ? "WHERE " + string.Join(" AND ", feltetelek) : "";

                    // --- Lekérdezzük a szűrt sorok számát
                    cmd.CommandText = alapCount + " " + whereClause + " GROUP BY u.utas_id ) AS al";
                    szurtSorok = Convert.ToInt32(cmd.ExecuteScalar());

                    // Lapozás számítása
                    maxOldal = (int)Math.Ceiling((double)szurtSorok / lim);
                    nud_oldalValaszto.Maximum = Math.Max(1, maxOldal);
                    if (aktualisOldal > maxOldal)
                        aktualisOldal = Math.Max(1, maxOldal);
                    nud_oldalValaszto.Value = aktualisOldal;

                    // Adatok lekérése
                    int offset = (aktualisOldal - 1) * lim;
                    cmd.CommandText = alapSelect + " " +
                                      whereClause + " " +
                                      "GROUP BY u.utas_id " +
                                      "ORDER BY u.utas_id " +
                                      "LIMIT @lim OFFSET @offset";

                    cmd.Parameters.AddWithValue("@lim", lim);
                    cmd.Parameters.AddWithValue("@offset", offset);

                    var da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgv_utasok.DataSource = dt;
                    dgv_utasok.Columns[0].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Unable to conn"))
                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz.", "Adatbázis elérés");
                else
                    MessageBox.Show(ex.Message);
            }
        }

        // A korábbi osszesSorSzam() és SzurtSorokSzama() metódusok továbbra is eltávolíthatók,
        // mivel a lekerdezes() kezeli a teljes számolási logikát.


        private void kg_kovetkezo_Click(object sender, EventArgs e)
        {
            if (aktualisOldal < maxOldal)
            {
                aktualisOldal++;
                lekerdezes();
            }
        }

        private void kg_elozo_Click(object sender, EventArgs e)
        {
            if (aktualisOldal > 1)
            {
                aktualisOldal--;
                lekerdezes();
            }
        }

        private void nud_oldalValaszto_ValueChanged(object sender, EventArgs e)
        {

            if (nud_oldalValaszto.Value > nud_oldalValaszto.Maximum)
                nud_oldalValaszto.Value = nud_oldalValaszto.Maximum;
            if (nud_oldalValaszto.Value < nud_oldalValaszto.Minimum)
                nud_oldalValaszto.Value = nud_oldalValaszto.Minimum;

            aktualisOldal = (int)nud_oldalValaszto.Value;

            lekerdezes();
        }

        private void szpn_szuroPanel_Click(object sender, EventArgs e)
        {
            szpn_szuroPanel.Focus();
        }

        private void kg_pipa_Click(object sender, EventArgs e)
        {
            lst_talalatok.Visible = false;
            szpn_szuroPanel.Visible = false;

            // --- Szűrők számolása ---
            int szurokSzama = 0;
            if (!string.IsNullOrWhiteSpace(kszm_utasNeve.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_email.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_lakcim.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_megjegyzes.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_okmanySzam.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_telefon.Texts)) szurokSzama++;
            if (!string.IsNullOrWhiteSpace(kszm_allampolgarsag.Texts)) szurokSzama++;
            if (kb_befizetes.AktualisAllas != KapcsoloGomb.KapcsoloAllas.Ki) szurokSzama++;
            if (kb_biztositas.AktualisAllas != KapcsoloGomb.KapcsoloAllas.Ki) szurokSzama++;
            if (kb_okmanyErvenyes.AktualisAllas != KapcsoloGomb.KapcsoloAllas.Ki) szurokSzama++;
            if (klm_utazasiMod.ComboText.ToLower() != "mind" &&
                klm_utazasiMod.ComboText.ToLower() != "utazási mód")
                szurokSzama++;

            bool barmiszuroaktiv = szurokSzama > 0;

            if (barmiszuroaktiv)
            {
                kg_szuro.HatterSzine = Color.Orange;
                kg_szuro.ErtesitesSzam = szurokSzama;  // <-- kiírjuk a darabszámot
                szuresAktiv = true;
            }
            else
            {
                kg_szuro.HatterSzine = Color.MediumSlateBlue;
                kg_szuro.ErtesitesSzam = 0;            // <-- nullázzuk ha nincs szűrés
                szuresAktiv = false;
            }

            aktualisOldal = 1;
            lekerdezes();
        }

        private void kszm_Leave(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                if (!lst_talalatok.Bounds.Contains(PointToClient(Cursor.Position)) &&
                    !lst_talalatok.Focused)
                {
                    lst_talalatok.Visible = false;
                }
            }));
        }



        private void SzovegMezo_KeyDown(object sender, KeyEventArgs e)
        {
            if (!lst_talalatok.Visible) return;

            var aktivMezo = sender as Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo;
            if (aktivMezo == null) return;

            if (e.KeyCode == Keys.Down && lst_talalatok.SelectedIndex < lst_talalatok.Items.Count - 1)
            {
                lst_talalatok.SelectedIndex++;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up && lst_talalatok.SelectedIndex > 0)
            {
                lst_talalatok.SelectedIndex--;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter && lst_talalatok.SelectedItem != null)
            {
                aktivMezo.Texts = lst_talalatok.SelectedItem.ToString();
                lst_talalatok.Visible = false;
                e.Handled = true;
            }
        }

        private void kszm_AutoComplete(object sender, EventArgs e)
        {

            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show(
                    "A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            var aktivMezo = sender as Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo;
            if (aktivMezo == null) return;
            lst_talalatok.Tag = aktivMezo;
            lst_talalatok.Visible = true;

            lst_talalatok.Location = new Point(aktivMezo.Location.X, aktivMezo.Location.Y + aktivMezo.Height + 10);
            lst_talalatok.BringToFront();
            var lista = new List<string>();
            var nev = aktivMezo.Name;

            try
            {
                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    string sql = "";
                    var cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    switch (nev)
                    {
                        case "kszm_utasNeve":
                            sql = @"SELECT u.titulus, u.vezeteknev, u.keresztnev1, u.keresztnev2
                                FROM utas AS u
                                INNER JOIN utas_utazasai AS uu ON u.utas_id = uu.utas_id
                                INNER JOIN utazas AS t ON uu.utazas_id = t.utazas_id
                               WHERE LOWER(CONCAT_WS(' ', u.titulus, u.vezeteknev, u.keresztnev1, u.keresztnev2)) LIKE @nev
                                GROUP BY u.utas_id
                                LIMIT 4";

                            cmd.Parameters.AddWithValue("@nev", "%" + aktivMezo.Texts.Trim().ToLower() + "%");
                            break;


                        case "kszm_email":
                            sql = "SELECT DISTINCT email_cim FROM cim WHERE email_cim LIKE @szoveg LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");
                            break;

                        case "kszm_telefon":
                            sql = "SELECT DISTINCT telefon FROM telefon WHERE telefon LIKE @szoveg LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");
                            break;

                        case "kszm_lakcim":
                            sql = "SELECT DISTINCT lakcim FROM cim WHERE lakcim LIKE @szoveg LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");
                            break;

                        case "kszm_okmanySzam":
                            sql = "SELECT DISTINCT szemelyi_vagy_utlevel FROM szemelyi WHERE szemelyi_vagy_utlevel LIKE @szoveg LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");
                            break;

                        case "kszm_megjegyzes":
                            sql = "SELECT DISTINCT megjegyzes FROM megjegyzes WHERE megjegyzes LIKE @szoveg LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");
                            break;

                        default:
                            return;
                    }

                    cmd.CommandText = sql;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (nev == "kszm_utasNeve")
                            {
                                string titulus = reader.IsDBNull(0) ? "" : reader.GetString(0);
                                string vezeteknev = reader.IsDBNull(1) ? "" : reader.GetString(1);
                                string keresztnev1 = reader.IsDBNull(2) ? "" : reader.GetString(2);
                                string keresztnev2 = reader.IsDBNull(3) ? "" : reader.GetString(3);

                                string teljesNev = $"{titulus} {vezeteknev} {keresztnev1} {keresztnev2}".Trim();
                                lista.Add(teljesNev);
                            }
                            else
                            {
                                lista.Add(reader.GetString(0));
                            }
                        }
                    }

                    lst_talalatok.DataSource = null;
                    lst_talalatok.DataSource = lista;
                }
            }
            catch (Exception xe)
            {
                if (xe.Message.StartsWith("Unable to conn"))
                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázishoz.", "Adatbázis elérés");
                else
                    MessageBox.Show(xe.Message);
            }
        }

        private void kg_szuro_Click(object sender, EventArgs e)
        {
            // A szűrőpanel láthatóságának váltása
            szpn_szuroPanel.Visible = !szpn_szuroPanel.Visible;

            // Ha a panel láthatóvá válik, állítsd rá a fókuszt
            if (szpn_szuroPanel.Visible)
            {
                szpn_szuroPanel.Focus();
            }
        }


        private void dgv_utasok_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

         

            vanValtozas = true;
            kg_mentes.HatterSzine = Color.Red;

        }

        private void kg_mentes_Click(object sender, EventArgs e)
        {

            if (!vanValtozas)
            {
                MessageBox.Show("Jelenleg nincs mentendő változtatás.");
                return;
            }

            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show(
                    "A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (bejelentkezes.bejelentkezes.Jogosultsag == 0)
            {
                MessageBox.Show(
                    "A művelet végrehajtásához nincs engedélye.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            using (var kapcsolat = new MySqlConnection(constr))
            {
                kapcsolat.Open();
                int frissitettSorok = 0;

                foreach (DataGridViewRow sor in dgv_utasok.Rows)
                {
                    if (sor.IsNewRow) continue;

                    int utasId = Convert.ToInt32(sor.Cells["Sorszám"].Value);

                    string titulus = sor.Cells["Titulus"].Value?.ToString();
                    string vezeteknev = sor.Cells["Vezetéknév"].Value?.ToString();
                    string keresztnev1 = sor.Cells["Keresztnév"].Value?.ToString();
                    string keresztnev2 = sor.Cells["Második keresztnév"].Value?.ToString();
                    string telefon = sor.Cells["Telefonszám"].Value?.ToString();
                    string okmany = sor.Cells["Okmány"].Value?.ToString();
                    string allampolgarsag = sor.Cells["Állampolgárság"].Value?.ToString();
                    DateTime ervenyesseg = Convert.ToDateTime(sor.Cells["Érvényesség"].Value);
                    string lakcim = sor.Cells["Lakcím"].Value?.ToString();
                    string email = sor.Cells["Email"].Value?.ToString();
                    int befizetett = Convert.ToInt32(sor.Cells["Befizetett összeg"].Value);
                    string biztositas = sor.Cells["Biztosítás van"].Value.ToString();
                    string megjegyzes = sor.Cells["Megjegyzés"].Value?.ToString();

                    using (var cmd = new MySqlCommand(@"UPDATE utas SET 
                titulus = @titulus, vezeteknev = @vezeteknev, keresztnev1 = @kn1, keresztnev2 = @kn2 
                WHERE utas_id = @id", kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@titulus", titulus);
                        cmd.Parameters.AddWithValue("@vezeteknev", vezeteknev);
                        cmd.Parameters.AddWithValue("@kn1", keresztnev1);
                        cmd.Parameters.AddWithValue("@kn2", keresztnev2);
                        cmd.Parameters.AddWithValue("@id", utasId);
                        frissitettSorok += cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new MySqlCommand(@"UPDATE telefon SET telefon = @telefon WHERE utas_id = @id", kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@telefon", telefon);
                        cmd.Parameters.AddWithValue("@id", utasId);
                        frissitettSorok += cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new MySqlCommand(@"UPDATE szemelyi 
                SET szemelyi_vagy_utlevel = @okmany, 
                    okmany_lejarat = @ervenyesseg,
                    allampolgarsag = @allamp
                WHERE utas_id = @id", kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@okmany", okmany);
                        cmd.Parameters.AddWithValue("@ervenyesseg", ervenyesseg);
                        cmd.Parameters.AddWithValue("@allamp", allampolgarsag);
                        cmd.Parameters.AddWithValue("@id", utasId);
                        frissitettSorok += cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new MySqlCommand(@"UPDATE cim SET lakcim = @lakcim, email_cim = @email WHERE utas_id = @id", kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@lakcim", lakcim);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@id", utasId);
                        frissitettSorok += cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new MySqlCommand(@"UPDATE fizetes SET befizetett_osszeg = @osszeg, biztositas = @bizt WHERE utas_id = @id", kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@osszeg", befizetett);
                        cmd.Parameters.AddWithValue("@bizt", biztositas);
                        cmd.Parameters.AddWithValue("@id", utasId);
                        frissitettSorok += cmd.ExecuteNonQuery();
                    }

                    using (var cmd = new MySqlCommand(@"UPDATE megjegyzes SET megjegyzes = @megj WHERE utas_id = @id", kapcsolat))
                    {
                        cmd.Parameters.AddWithValue("@megj", megjegyzes);
                        cmd.Parameters.AddWithValue("@id", utasId);
                        frissitettSorok += cmd.ExecuteNonQuery();
                    }
                }

                kg_mentes.HatterSzine = Color.MediumSlateBlue;
                MessageBox.Show(
                    frissitettSorok > 0 ? "Az adatok sikeresen frissültek!" : "Nem történt változás az adatokban.",
                    "Mentés",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            vanValtozas = false; 
            kg_mentes.HatterSzine = Color.MediumSlateBlue;
        }

        private void kg_torles_Click(object sender, EventArgs e)
        {

            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show(
                    "A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (bejelentkezes.bejelentkezes.Jogosultsag == 0)
            {
                MessageBox.Show(
                    "A művelet végrehajtásához nincs engedélye.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            // Ellenőrizzük, van-e kijelölt sor
            if (dgv_utasok.SelectedRows.Count == 0)
            {
                MessageBox.Show("Kérlek jelölj ki egy sort a törléshez!", "Nincs kijelölés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Csak az első kijelölt sort vesszük figyelembe
            DataGridViewRow selectedRow = dgv_utasok.SelectedRows[0];


            int utasId;
            if (!int.TryParse(selectedRow.Cells["Sorszám"].Value.ToString(), out utasId))
            {
                MessageBox.Show("Hiba az utas azonosító feldolgozásakor.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Megerősítő kérdés
            DialogResult result = MessageBox.Show(
                $"Biztosan törölni szeretnéd a(z) '{selectedRow.Cells["Vezetéknév"].Value} {selectedRow.Cells["Keresztnév"].Value}' nevű utast és minden hozzá kapcsolódó adatot?",
                "Törlés megerősítése",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                using (var kapcsolat = new MySqlConnection(constr))
                {
                    // Tranzakció indítása
                    MySqlTransaction? tranzakcio = null;
                    try
                    {
                        kapcsolat.Open();
                        tranzakcio = kapcsolat.BeginTransaction();

                        MySqlCommand cmd = kapcsolat.CreateCommand();
                        cmd.Transaction = tranzakcio;

                        // Törlés az utas_utazasai táblából
                        cmd.CommandText = "DELETE FROM utas_utazasai WHERE utas_id = @utasId";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@utasId", utasId);
                        cmd.ExecuteNonQuery();

                        // Törlés a telefon táblából
                        cmd.CommandText = "DELETE FROM telefon WHERE utas_id = @utasId";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@utasId", utasId);
                        cmd.ExecuteNonQuery();

                        // Törlés a szemelyi táblából
                        cmd.CommandText = "DELETE FROM szemelyi WHERE utas_id = @utasId";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@utasId", utasId);
                        cmd.ExecuteNonQuery();

                        // Törlés a cim táblából
                        cmd.CommandText = "DELETE FROM cim WHERE utas_id = @utasId";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@utasId", utasId);
                        cmd.ExecuteNonQuery();

                        // Törlés a fizetes táblából
                        cmd.CommandText = "DELETE FROM fizetes WHERE utas_id = @utasId";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@utasId", utasId);
                        cmd.ExecuteNonQuery();

                        // Törlés a megjegyzes táblából
                        cmd.CommandText = "DELETE FROM megjegyzes WHERE utas_id = @utasId";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@utasId", utasId);
                        cmd.ExecuteNonQuery();

                        // Végül törlés az utas táblából
                        cmd.CommandText = "DELETE FROM utas WHERE utas_id = @utasId";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@utasId", utasId);
                        cmd.ExecuteNonQuery();

                        // Tranzakció véglegesítése
                        tranzakcio.Commit();
                        MessageBox.Show("Az utas és minden kapcsolódó adata sikeresen törölve.", "Sikeres törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        lekerdezes();
                    }
                    catch (Exception ex)
                    {
                        // Hiba esetén visszavonjuk a tranzakciót
                        tranzakcio?.Rollback();
                        MessageBox.Show($"Hiba történt az utas törlése során: {ex.Message}", "Törlési hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void kg_nyomtatas_Click(object sender, EventArgs e)
        {
            if (!bejelentkezes.bejelentkezes.Bejelentkezve())
            {
                MessageBox.Show(
                    "A művelet végrehajtásához be kell jelentkeznie a főoldalon.",
                    "Bejelentkezés szükséges",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            sorIndexAHolFolytatniKell = 0;

            
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd_utasok; 
            printPreviewDialog.ShowDialog();
        }

        private void pd_utasok_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int marginLeft = 50;
            int y = 50;
            int rowHeight = 25;
            Brush brush = Brushes.Black;

            // Oszlopfejlécek (csak az első oldalon vagy minden oldalon, ha akarod)
            // Jelenleg úgy van, hogy minden oldalon megjelennek
            Font fejlec = new Font("Arial", 12, FontStyle.Bold);
            Font normal = new Font("Arial", 10);

            // Fejlécek kirajzolása (csak az első oldalon, vagy ha szeretnéd, minden oldalon)
            // Ha csak az első oldalon akarod, akkor egy if-fel kellene ellenőrizni, hogy sorIndexAHolFolytatniKell == 0
            e.Graphics.DrawString("Titulus", fejlec, brush, marginLeft, y);
            e.Graphics.DrawString("Vezetéknév", fejlec, brush, marginLeft + 75, y);
            e.Graphics.DrawString("Keresztnév", fejlec, brush, marginLeft + 180, y);
            e.Graphics.DrawString("Email", fejlec, brush, marginLeft + 325, y); // Példa: email oszlop
            e.Graphics.DrawString("Telefonszám", fejlec, brush, marginLeft + 550, y); // Példa: telefonszám oszlop
            // ... add hozzá a többi fejlécet is, amit nyomtatni szeretnél

            y += rowHeight + 10; // Hely a fejléc és az első sor között

            // --- FONTOS VÁLTOZÁS: FOR CIKLUS ÉS AZ OSZTÁLYSZINTŰ VÁLTOZÓ HASZNÁLATA ---
            // A ciklus az eltárolt sorIndexAHolFolytatniKell-től indul
            for (; sorIndexAHolFolytatniKell < dgv_utasok.Rows.Count; sorIndexAHolFolytatniKell++)
            {
                DataGridViewRow row = dgv_utasok.Rows[sorIndexAHolFolytatniKell];

                if (row.IsNewRow) // Kihagyjuk az új (üres) sort a végén
                {
                    continue; // Átugorja az isNewRow-t, és folytatja a következő iterációval, ha van még
                }


                // Ellenőrizd, hogy az oszlopindexek helyesek-e a DataGridView-ben!
                // Feltételezve, hogy az oszlopok sorrendje: 0:Sorszám, 1:Titulus, 2:Vezetéknév, 3:Keresztnév, 4:Második Keresztnév, 5:Telefonszám, 6:Okmány...
                string s1 = row.Cells["Titulus"].Value?.ToString() ?? "";       // Index 1
                string s2 = row.Cells["Vezetéknév"].Value?.ToString() ?? "";    // Index 2
                string s3 = row.Cells["Keresztnév"].Value?.ToString() ?? "";    // Index 3
                string s4 = row.Cells["Email"].Value?.ToString() ?? "";         // Példa: email oszlop (megfelelő index vagy név kell ide!)
                string s5 = row.Cells["Telefonszám"].Value?.ToString() ?? "";   // Példa: telefonszám oszlop (megfelelő index vagy név kell ide!)
                                                                                // string s6 = row.Cells[6].Value?.ToString() ?? ""; // Ezt nem használtad fel az alábbi DrawString-ekben


                e.Graphics.DrawString(s1, normal, brush, marginLeft, y);
                e.Graphics.DrawString(s2, normal, brush, marginLeft + 75, y);
                e.Graphics.DrawString(s3, normal, brush, marginLeft + 180, y);
                e.Graphics.DrawString(s4, normal, brush, marginLeft + 325, y); // Példa
                e.Graphics.DrawString(s5, normal, brush, marginLeft + 550, y); // Példa

                y += rowHeight;

                // Oldaltörés ellenőrzése
                if (y >= e.MarginBounds.Bottom) // Ha elérjük az oldal alját, vagy túlhaladjuk
                {
                    e.HasMorePages = true; // Jelzi, hogy van még nyomtatnivaló
                    sorIndexAHolFolytatniKell++; // Növeljük az indexet, hogy a következő oldal a következő sorral kezdődjön
                    return; // Fontos: Kilépünk a metódusból!
                }
            }

            // Ha a ciklus lefutott a végéig, és nincs több sor
            e.HasMorePages = false; // Nincs több oldal
            sorIndexAHolFolytatniKell = 0; // Visszaállítjuk az indexet 0-ra a következő nyomtatás elindításához
        }

        private void Frm_UtasokMegtekintese_Resize(object sender, EventArgs e)
        {
            szpn_szuroPanel.Location = new Point((this.Width / 2) - (szpn_szuroPanel.Width / 2), this.Height / 2 - szpn_szuroPanel.Height / 2);
        }

        private void dgv_utasok_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cella = dgv_utasok[e.ColumnIndex, e.RowIndex];
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

        private void kb_befizetes_Load(object sender, EventArgs e)
        {

        }
    }


}