using MySqlConnector;
using Projekt_feladat.bejelentkezes;
using Projekt_feladat.egyeni_vezerlok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu;

namespace Projekt_feladat.Formok
{
    public partial class frm_UtasokHozzaadasa : Form
    {
        ListBox lst_talalatok = new ListBox();
        string constr = String.Format("Server={0};User ID={1};Password={2};Database={3}", "127.0.0.1", "utazast_kezelo", "utazast_kezelo1234", "utazast_kezelo");
        string? utazasDesztinacio = null;
        string? utazasIdoszak = null;
        string? utazasNeve = null;
        public frm_UtasokHozzaadasa()
        {
            InitializeComponent();
            utazasok_betoltes();
            lb_utazasok.DrawMode = DrawMode.OwnerDrawFixed;
            lst_talalatok.Visible = false;
            lst_talalatok.DrawMode = DrawMode.OwnerDrawFixed;
            lst_talalatok.DrawItem += lst_talalatok_DrawItem;
            lst_talalatok.MouseDown += lst_talalatok_MouseDown;

            this.Controls.Add(lst_talalatok);
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
            lst_talalatok.Width = aktivMezo.Width;
            Point vezetoPont = aktivMezo.PointToScreen(new Point(0, aktivMezo.Height + 5));
            Point formhozKepest = this.PointToClient(vezetoPont);
            lst_talalatok.Location = formhozKepest;

            lst_talalatok.BringToFront();
            var lista = new List<string>();
            var nev = aktivMezo.Name;

            try
            {


                ////////

                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    string sql = "";
                    var cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    switch (nev)
                    {

                        case "kszm_titulus":
                            sql = @"SELECT DISTINCT u.titulus
                                FROM utas AS u
                                WHERE u.titulus LIKE @szoveg
                                LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");
                            break;
                        case "kszm_vezeteknev":
                            sql = @"SELECT DISTINCT u.vezeteknev
                                    FROM utas AS u
                                    WHERE  u.vezeteknev LIKE @szoveg
                                    LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");

                            break;

                        case "kszm_keresztnev1":
                            sql = @"SELECT DISTINCT u.keresztnev1
                                    FROM utas AS u
                                    WHERE  u.keresztnev1 LIKE @szoveg
                                    LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");

                            break;

                        case "kszm_keresztnev2":
                            sql = @"SELECT DISTINCT u.keresztnev2
                                    FROM utas AS u
                                    WHERE u.keresztnev2 LIKE @szoveg
                                    LIMIT 4";
                            cmd.Parameters.AddWithValue("@szoveg", "%" + aktivMezo.Texts.Trim() + "%");

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
                            lista.Add(reader.GetString(0));
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
        private void kszm_Leave(object sender, EventArgs e)
        {

            if (
                 !lst_talalatok.Focused)
            {
                lst_talalatok.Visible = false;
            }

            /*
            this.BeginInvoke(new Action(() =>
            {
                // Csak akkor zárjuk be a ListBox-ot, ha az egér nincs rajta és nem aktív vezérlő
                if (!lst_talalatok.Bounds.Contains(PointToClient(Cursor.Position)) &&
                    !lst_talalatok.Focused)
                {
                    lst_talalatok.Visible = false;
                }
            }));*/
        }
        private void rcb_desztinacio_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {
            if (e.Ertek != null)
            {
                if (e.Ertek != utazasDesztinacio)
                {
                    rcb_utazasIdeje.ComboText = "Időszak";
                    rcb_utazasElnevezese.ComboText = "Utazás neve";
                    rcb_utazasIdeje.adatForras = new string[0];
                    rcb_utazasElnevezese.adatForras = new string[0];
                    utazasIdoszak = null;
                    utazasNeve = null;
                }

                utazasDesztinacio = e.Ertek;

                // Töröljük a további két combobox tartalmát
                rcb_utazasIdeje.adatForras = new string[0];
                rcb_utazasElnevezese.adatForras = new string[0];
                utazasIdoszak = null;
                utazasNeve = null;

                // Betöltjük az időszakokat az 2-es comboboxba
                idoszak_betoltes();
            }
            else
                return;
        }
        private void utazasok_betoltes()
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

            try
            {
                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    var lista = new List<string>();
                    string sql = "SELECT DISTINCT desztinacio FROM utazas ORDER BY desztinacio";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(reader.GetString(0));
                        }
                    }

                    rcb_desztinacio.adatForras = lista.ToArray();
                }
            }
            catch (Exception e)
            {
                if (e.Message.StartsWith("Unable to conn"))
                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázihoz.", "Adatbázis elérés");
                else
                    MessageBox.Show(e.Message);
            }
        }
        private void rcb_idoszak_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {
            if (e.Ertek != null)
            {
                if (e.Ertek != utazasIdoszak)
                {

                    rcb_utazasElnevezese.ComboText = "Utazás neve";
                    rcb_utazasElnevezese.adatForras = new string[0];
                    utazasNeve = null;
                }
                utazasIdoszak = e.Ertek;
                if (utazasIdoszak != null && utazasDesztinacio != null)
                    utazasneve_betoltes();
            }
            else
                return;
        }
        private void idoszak_betoltes()
        {
            try
            {
                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    var lista = new List<string>();
                    string sql = "SELECT DISTINCT utazas_ideje FROM utazas WHERE desztinacio = @desztinacio ORDER BY utazas_ideje";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@desztinacio", utazasDesztinacio);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime datum = reader.GetDateTime(0);
                                lista.Add(datum.ToString("yyyy-MM-dd"));
                            }
                        }
                    }

                    rcb_utazasIdeje.adatForras = lista.ToArray();
                }
            }
            catch (Exception e)
            {
                if (e.Message.StartsWith("Unable to conn"))
                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázihoz.", "Adatbázis elérés");
                else
                    MessageBox.Show(e.Message);
            }
        }

        private void rcb_utazasNeve_ElemKivalasztva(object sender, ElemKivalasztvaEventArgs e)
        {
            if (e.Ertek != null)
                utazasNeve = e.Ertek;

            if (utazasIdoszak != null && utazasDesztinacio != null && utazasNeve != null)
            {
                string osszeallitottSzoveg = utazasDesztinacio + " - " + utazasIdoszak + " -  " + utazasNeve;

                if (!lb_utazasok.Items.Contains(osszeallitottSzoveg)) // csak akkor adja hozzá ha még nincs benne
                {
                    lb_utazasok.Items.Add(osszeallitottSzoveg);
                }

                rcb_utazasIdeje.ComboText = "Időszak";
                rcb_utazasElnevezese.ComboText = "Utazás neve";
                rcb_utazasIdeje.adatForras = new string[0];
                rcb_utazasElnevezese.adatForras = new string[0];
                utazasIdoszak = null;
                utazasNeve = null;
            }
        }

        private void utazasneve_betoltes()
        {
            try
            {
                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    var lista = new List<string>();
                    string sql = "SELECT DISTINCT utazas_elnevezese FROM utazas WHERE desztinacio = @desztinacio AND utazas_ideje = @idoszak ORDER BY utazas_elnevezese";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@desztinacio", utazasDesztinacio);
                        cmd.Parameters.AddWithValue("@idoszak", DateTime.Parse(utazasIdoszak));

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(reader.GetString(0));
                            }
                        }
                    }
                    rcb_utazasElnevezese.adatForras = lista.ToArray();
                }
            }
            catch (Exception e)
            {
                if (e.Message.StartsWith("Unable to conn"))
                    MessageBox.Show("Nem sikerült kapcsolódni az adatbázihoz.", "Adatbázis elérés");
                else
                    MessageBox.Show(e.Message);
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


        // A GetRoundedRectanglePath metódus javítása, amely pontosabban adja hozzá az íveket és vonalakat.
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
     
        private void kszm_utazasTorlese_Click(object sender, EventArgs e)
        {
            if (lb_utazasok.SelectedItem != null)
            {
                lb_utazasok.Items.Remove(lb_utazasok.SelectedItem);
            }
        }

        private void kszm_mentes_Click(object sender, EventArgs e)
        {
            // --- Jogosultság ellenőrzés ---
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
                    "Nincs jogosultság",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // --- Ha meglévő utashoz rendelünk utazást ---
            if (pnl_meglevoutasokhozAdas.Visible)
            {
                if (dgv_meglevoUtasok.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Kérlek, jelölj ki pontosan egy utast a listából.");
                    return;
                }

                if (lb_utazasok.Items.Count == 0)
                {
                    MessageBox.Show("Nincs kiválasztott utazás.");
                    return;
                }

                try
                {
                    using (var conn = new MySqlConnection(constr))
                    {
                        conn.Open();
                        using (var tr = conn.BeginTransaction())
                        {
                            long utasId = Convert.ToInt64(dgv_meglevoUtasok.SelectedRows[0].Cells["ID"].Value);

                            foreach (string str in lb_utazasok.Items)
                            {
                                var parts = str.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                                if (parts.Length == 3)
                                {
                                    string deszt = parts[0].Trim();
                                    DateTime ido = DateTime.Parse(parts[1].Trim());
                                    string nev = parts[2].Trim();

                                    string getId = @"SELECT utazas_id FROM utazas
                                             WHERE desztinacio = @d AND utazas_ideje = @i AND utazas_elnevezese = @n
                                             LIMIT 1";

                                    long? utazasId = null;
                                    using (var cmd = new MySqlCommand(getId, conn, tr))
                                    {
                                        cmd.Parameters.AddWithValue("@d", deszt);
                                        cmd.Parameters.AddWithValue("@i", ido);
                                        cmd.Parameters.AddWithValue("@n", nev);
                                        var result = cmd.ExecuteScalar();
                                        if (result != null)
                                            utazasId = Convert.ToInt64(result);
                                    }

                                    if (utazasId != null)
                                    {
                                        // Ne duplikáljuk
                                        string ellenorzo = @"SELECT COUNT(*) FROM utas_utazasai 
                                                     WHERE utas_id = @uid AND utazas_id = @tid";

                                        using (var cmd = new MySqlCommand(ellenorzo, conn, tr))
                                        {
                                            cmd.Parameters.AddWithValue("@uid", utasId);
                                            cmd.Parameters.AddWithValue("@tid", utazasId);
                                            long darab = Convert.ToInt64(cmd.ExecuteScalar());

                                            if (darab == 0)
                                            {
                                                string insert = "INSERT INTO utas_utazasai (utas_id, utazas_id) VALUES (@uid, @tid)";
                                                using (var insertCmd = new MySqlCommand(insert, conn, tr))
                                                {
                                                    insertCmd.Parameters.AddWithValue("@uid", utasId);
                                                    insertCmd.Parameters.AddWithValue("@tid", utazasId);
                                                    insertCmd.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            tr.Commit();
                            MessageBox.Show("Az utazások sikeresen hozzá lettek rendelve a meglévő utashoz.");
                            Close();
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba a meglévő utas hozzárendelése során: " + ex.Message);
                    return;
                }
            }

            // --- Új utas hozzáadása ---
            try
            {
                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    using (var tr = conn.BeginTransaction())
                    {
                        string insertUtas = @"INSERT INTO utas (titulus, vezeteknev, keresztnev1, keresztnev2, szuletesi_datum)
                                      VALUES (@titulus, @vezeteknev, @keresztnev1, @keresztnev2, @szuldatum);
                                      SELECT LAST_INSERT_ID();";

                        long utasId;
                        using (var cmd = new MySqlCommand(insertUtas, conn, tr))
                        {
                            cmd.Parameters.AddWithValue("@titulus", kszm_titulus.Texts);
                            cmd.Parameters.AddWithValue("@vezeteknev", kszm_vezeteknev.Texts);
                            cmd.Parameters.AddWithValue("@keresztnev1", kszm_keresztnev1.Texts);
                            cmd.Parameters.AddWithValue("@keresztnev2", kszm_keresztnev2.Texts);
                            cmd.Parameters.AddWithValue("@szuldatum", dtp_szulido.Value.Date);
                            utasId = Convert.ToInt64(cmd.ExecuteScalar());
                        }

                        // Kapcsolt adatok
                        insertKapcsolt("telefon", "utas_id, telefon", "@utas_id, @ertek",
                            new Dictionary<string, object> { { "@utas_id", utasId }, { "@ertek", kszm_telefon.Texts } }, conn, tr);

                        insertKapcsolt("cim", "utas_id, email_cim, lakcim", "@utas_id, @email, @lakcim",
                            new Dictionary<string, object> {
                        { "@utas_id", utasId },
                        { "@email", kszm_email.Texts },
                        { "@lakcim", kszm_lakcim.Texts }
                            }, conn, tr);

                        insertKapcsolt("szemelyi", "utas_id, szemelyi_vagy_utlevel, okmany_lejarat", "@utas_id, @szam, @lejarat",
                            new Dictionary<string, object> {
                        { "@utas_id", utasId },
                        { "@szam", kszm_okmanySzam.Texts },
                        { "@lejarat", dtp_okmany.Value.Date }
                            }, conn, tr);

                        insertKapcsolt("fizetes", "utas_id, befizetett_osszeg, biztositas", "@utas_id, @osszeg, @biztositas",
                            new Dictionary<string, object> {
                        { "@utas_id", utasId },
                        { "@osszeg", decimal.TryParse(kszm_befizetettOsszeg.Texts, out decimal ossz) ? ossz : 0 },
                        { "@biztositas", kg_biztositas.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be ? "igen" : "nem" }
                            }, conn, tr);

                        insertKapcsolt("megjegyzes", "utas_id, megjegyzes", "@utas_id, @megjegyzes",
                            new Dictionary<string, object> {
                        { "@utas_id", utasId },
                        { "@megjegyzes", kszm_megjegyzes.Texts }
                            }, conn, tr);

                        // Utazások hozzárendelése
                        foreach (string str in lb_utazasok.Items)
                        {
                            var parts = str.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                            if (parts.Length == 3)
                            {
                                string deszt = parts[0].Trim();
                                DateTime ido = DateTime.Parse(parts[1].Trim());
                                string nev = parts[2].Trim();

                                string getId = @"SELECT utazas_id FROM utazas
                                         WHERE desztinacio = @d AND utazas_ideje = @i AND utazas_elnevezese = @n
                                         LIMIT 1";

                                long? utazasId = null;
                                using (var cmd = new MySqlCommand(getId, conn, tr))
                                {
                                    cmd.Parameters.AddWithValue("@d", deszt);
                                    cmd.Parameters.AddWithValue("@i", ido);
                                    cmd.Parameters.AddWithValue("@n", nev);

                                    var result = cmd.ExecuteScalar();
                                    if (result != null)
                                        utazasId = Convert.ToInt64(result);
                                }

                                if (utazasId != null)
                                {
                                    string insertKapcs = "INSERT INTO utas_utazasai (utas_id, utazas_id) VALUES (@uid, @tid)";
                                    using (var cmd = new MySqlCommand(insertKapcs, conn, tr))
                                    {
                                        cmd.Parameters.AddWithValue("@uid", utasId);
                                        cmd.Parameters.AddWithValue("@tid", utazasId);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        tr.Commit();
                        MessageBox.Show("Sikeres mentés.");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a mentés során: " + ex.Message);
            }
        }

        private void insertKapcsolt(string tabla, string mezok, string ertekek, Dictionary<string, object> parameterek, MySqlConnection conn, MySqlTransaction tr)
        {
            string sql = $"INSERT INTO {tabla} ({mezok}) VALUES ({ertekek})";
            using (var cmd = new MySqlCommand(sql, conn, tr))
            {
                foreach (var kv in parameterek)
                {
                    cmd.Parameters.AddWithValue(kv.Key, kv.Value ?? DBNull.Value);
                }
                cmd.ExecuteNonQuery();
            }
        }

        private void frm_UtasokHozzaadasa_Click(object sender, EventArgs e)
        {
            lst_talalatok.Visible = false;
        }



        private void kszm_ujRegiFelhasznalo_Click(object sender, EventArgs e)
        {
            kszm_ujRegiFelhasznalo.ImageAlign = ContentAlignment.TopRight;
            kszm_ujRegiFelhasznalo.Padding = new Padding(0, 5, 0, 0);


            if (pnl_ujhozzaadas.Visible)
            {

                pnl_ujhozzaadas.Visible = false;
                kszm_ujRegiFelhasznalo.HatterSzine = Color.Chocolate;
                pnl_meglevoutasokhozAdas.Visible = true;
                kszm_ujRegiFelhasznalo.Text = "Új felhasználó hozzáadása";
            }
            else
            {

                pnl_ujhozzaadas.Visible = true;
                kszm_ujRegiFelhasznalo.HatterSzine = Color.SteelBlue;
                pnl_meglevoutasokhozAdas.Visible = false;
                kszm_ujRegiFelhasznalo.Text = "Meglévő felhasználóhoz adás";
            }
        }
        private void KeresesiSzuroValtozott(object sender, EventArgs e)
        {
            string nev = kszm_reginev.Texts.Trim();
            string okmany = kszm_regiokmanyszam.Texts.Trim();
            DateTime datum = dtp_regiSzulido.Value.Date;

            using (var conn = new MySqlConnection(constr))
            {
                try
                {
                    conn.Open();

                    var whereFeltetelek = new List<string>();
                    var cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    string baseSql = @"
                SELECT u.utas_id AS 'ID',
                       u.titulus AS 'Titulus',
                       u.vezeteknev AS 'Vezetéknév',
                       u.keresztnev1 AS 'Keresztnév',
                       u.keresztnev2 AS 'Második név',
                       u.szuletesi_datum AS 'Születési dátum',
                       s.szemelyi_vagy_utlevel AS 'Okmányszám'
                FROM utas u
                LEFT JOIN szemelyi s ON u.utas_id = s.utas_id
            ";

                    if (!string.IsNullOrWhiteSpace(nev))
                    {
                        whereFeltetelek.Add("LOWER(CONCAT_WS(' ', u.titulus, u.vezeteknev, u.keresztnev1, u.keresztnev2)) LIKE @nev");
                        cmd.Parameters.AddWithValue("@nev", $"%{nev.ToLower()}%");
                    }

                    if (!string.IsNullOrWhiteSpace(okmany))
                    {
                        whereFeltetelek.Add("s.szemelyi_vagy_utlevel LIKE @okmany");
                        cmd.Parameters.AddWithValue("@okmany", $"%{okmany}%");
                    }

                    if (datum != DateTime.Today)
                    {
                        whereFeltetelek.Add("u.szuletesi_datum = @datum");
                        cmd.Parameters.AddWithValue("@datum", datum);
                    }

                    if (whereFeltetelek.Count > 0)
                        baseSql += " WHERE " + string.Join(" AND ", whereFeltetelek);

                    baseSql += " ORDER BY u.vezeteknev, u.keresztnev1 LIMIT 20";
                    cmd.CommandText = baseSql;

                    var da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_meglevoUtasok.DataSource = dt;

                    if (dgv_meglevoUtasok.Rows.Count > 0)
                        dgv_meglevoUtasok.Rows[0].Selected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba a keresés közben: " + ex.Message);
                }
            }
        }

       
    }

}
