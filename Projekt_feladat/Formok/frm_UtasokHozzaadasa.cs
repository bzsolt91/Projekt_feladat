using MySqlConnector;
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

        string constr = "Server=127.0.0.1;User ID=root;Password=;Database=utazast_kezelo";
        string? utazasDesztinacio = null;
        string? utazasIdoszak = null;
        string? utazasNeve = null;
        public frm_UtasokHozzaadasa()
        {
            InitializeComponent();
            utazasok_betoltes();
            lb_utazasok.DrawMode = DrawMode.OwnerDrawFixed;
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
                        // 1. Új utas beszúrása
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
                        { "@biztositas", kg_biztositas.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be }
                            }, conn, tr);

                        insertKapcsolt("megjegyzes", "utas_id, megjegyzes", "@utas_id, @megjegyzes",
                            new Dictionary<string, object> {
                        { "@utas_id", utasId },
                        { "@megjegyzes", kszm_megjegyzes.Texts }
                            }, conn, tr);

                        //  utazások hozzárendelése
                        foreach (string utStr in lb_utazasok.Items)
                        {
                           // - kiszedése
                            var parts = utStr.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
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
    }
}
