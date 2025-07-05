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
        private bool automatikusKitoltes = false;
        private bool felhasznaloGepel = false;
        string constr = $"Server=127.0.0.1;User ID={bejelentkezes.bejelentkezes.Felhasznalonev};Password={bejelentkezes.bejelentkezes.Jelszo};Database=utazast_kezelo";
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
            // lst_talalatok.Width = kszm_utasNeve.Width; dinamikusan kell
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
            if (automatikusKitoltes) return;

            felhasznaloGepel = true;
            nevEllenorzoTimer.Stop();
            nevEllenorzoTimer.Start();
            var aktivMezo = sender as Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo;
            if (aktivMezo == null) return;
            lst_talalatok.Tag = aktivMezo;
            lst_talalatok.Visible = true;
            lst_talalatok.Width = aktivMezo.Width;
            lst_talalatok.Location = new Point(aktivMezo.Location.X, aktivMezo.Location.Y + aktivMezo.Height + 10);
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
                INNER JOIN utas_utazasai AS uu ON u.utas_id = uu.utas_id
                INNER JOIN utazas AS t ON uu.utazas_id = t.utazas_id
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
                            if (nev == "kszm_utasNeve")
                            {
                                string ttitulus = reader.IsDBNull(0) ? "" : reader.GetString(0);
                                string tvezeteknev = reader.IsDBNull(1) ? "" : reader.GetString(1);
                                string tkeresztnev1 = reader.IsDBNull(2) ? "" : reader.GetString(2);
                                string tkeresztnev2 = reader.IsDBNull(3) ? "" : reader.GetString(3);

                                string teljesNev = $"{ttitulus} {tvezeteknev} {tkeresztnev1} {tkeresztnev2}".Trim();
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

        private void AutomatikusKitoltes()
        {
            automatikusKitoltes = true;

            string titulus = kszm_titulus.Texts.Trim();
            string vezeteknev = kszm_vezeteknev.Texts.Trim();
            string keresztnev1 = kszm_keresztnev1.Texts.Trim();
            string keresztnev2 = kszm_keresztnev2.Texts.Trim();

            if (string.IsNullOrWhiteSpace(vezeteknev) || string.IsNullOrWhiteSpace(keresztnev1))
            {
                automatikusKitoltes = false;
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();

                    string sql = @"
                SELECT u.titulus, u.vezeteknev, u.keresztnev1, u.keresztnev2,
                       c.email_cim, c.lakcim,
                       t.telefon,
                       s.szemelyi_vagy_utlevel,
                       m.megjegyzes
                FROM utas AS u
                LEFT JOIN cim AS c ON c.utas_id = u.utas_id
                LEFT JOIN telefon AS t ON t.utas_id = u.utas_id
                LEFT JOIN szemelyi AS s ON s.utas_id = u.utas_id
                LEFT JOIN megjegyzes AS m ON m.utas_id = u.utas_id
                WHERE u.vezeteknev = @vezeteknev AND u.keresztnev1 = @keresztnev1
            ";

                    if (!string.IsNullOrWhiteSpace(titulus) && !string.IsNullOrWhiteSpace(keresztnev2))
                    {
                        sql += " AND u.titulus = @titulus AND u.keresztnev2 = @keresztnev2";
                    }

                    sql += " LIMIT 1";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@vezeteknev", vezeteknev);
                        cmd.Parameters.AddWithValue("@keresztnev1", keresztnev1);

                        if (!string.IsNullOrWhiteSpace(titulus) && !string.IsNullOrWhiteSpace(keresztnev2))
                        {
                            cmd.Parameters.AddWithValue("@titulus", titulus);
                            cmd.Parameters.AddWithValue("@keresztnev2", keresztnev2);
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // MEZŐK KITÖLTÉSE (ez fog nem újból triggerelni autocomplete-ot)
                                kszm_titulus.Texts = reader.IsDBNull(0) ? "" : reader.GetString(0);
                                kszm_vezeteknev.Texts = reader.IsDBNull(1) ? "" : reader.GetString(1);
                                kszm_keresztnev1.Texts = reader.IsDBNull(2) ? "" : reader.GetString(2);
                                kszm_keresztnev2.Texts = reader.IsDBNull(3) ? "" : reader.GetString(3);
                                kszm_email.Texts = reader.IsDBNull(4) ? "" : reader.GetString(4);
                                kszm_lakcim.Texts = reader.IsDBNull(5) ? "" : reader.GetString(5);
                                kszm_telefon.Texts = reader.IsDBNull(6) ? "" : reader.GetString(6);
                                kszm_okmanySzam.Texts = reader.IsDBNull(7) ? "" : reader.GetString(7);
                                kszm_megjegyzes.Texts = reader.IsDBNull(8) ? "" : reader.GetString(8);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a névkitöltés közben: " + ex.Message);
            }
            finally
            {
                automatikusKitoltes = false;
                lst_talalatok.Visible = false;
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
            this.BeginInvoke(new Action(() =>
            {
                // Csak akkor zárjuk be a ListBox-ot, ha az egér nincs rajta és nem aktív vezérlő
                if (!lst_talalatok.Bounds.Contains(PointToClient(Cursor.Position)) &&
                    !lst_talalatok.Focused)
                {
                    lst_talalatok.Visible = false;
                }
            }));
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

            Rectangle bounds = e.Bounds;
            int radius = 8; // kerekítés mértéke

            // Kerekített kijelölés háttér
            if (isSelected)
            {
                using (GraphicsPath path = GetRoundedRectanglePath(bounds, radius))
                using (Brush bgBrush = new SolidBrush(Color.DarkViolet))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillPath(bgBrush, path);
                }
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(listBox.BackColor), bounds);
            }

            // Szöveg
            using (Brush textBrush = new SolidBrush(isSelected ? Color.White : listBox.ForeColor))
            {
                e.Graphics.DrawString(item, e.Font, textBrush, bounds.X + 4, bounds.Y + 1);
            }

            // Ne rajzolj fókuszkeretet, ha nem illik a stílusba:
            // e.DrawFocusRectangle();
        }
        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.StartFigure();

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddLine(rect.Right - radius, rect.Bottom, rect.X + radius, rect.Bottom);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.AddLine(rect.X, rect.Bottom - radius, rect.X, rect.Y + radius);

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
            try
            {
                using (var conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    using (var tr = conn.BeginTransaction())
                    {
                        //  utas beszúrása
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

                        //  kapcsolódó adatok beszúrása

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

                        //  utazások hozzárendelése
                        foreach (string str in lb_utazasok.Items)
                        {
                            // - kiszedése
                            var parts = str.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                            if (parts.Length == 3)
                            {
                                string deszt = parts[0].Trim();
                                DateTime ido = DateTime.Parse(parts[1].Trim());
                                string nev = parts[2].Trim();

                                // Lekérjük az utazas_id-t
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

        private void nevEllenorzoTimer_Tick(object sender, EventArgs e)
        {

            nevEllenorzoTimer.Stop();

            if (felhasznaloGepel)
            {
                felhasznaloGepel = false;  // most már elfogadjuk, hogy nem gépel a user
                AutomatikusKitoltes();
            }
        }
    
    }
}
