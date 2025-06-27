using MySqlConnector;
using Projekt_feladat.egyeni_vezerlok;
using System.Data;

namespace Projekt_feladat.Formok
{
    public partial class Frm_UtasokMegtekintese : Form
    {
        string constr = String.Format("Server={0};User ID={1};Password={2};Database={3}", "127.0.0.1", "root", "", "utazast_kezelo");
        const int lim = 50;
        private int aktualisOldal = 1;
        private int maxOldal;
        private bool szuresAktiv = false;
        ListBox lst_talalatok = new ListBox();
     //   Panel arnyek = new Panel();
        public Frm_UtasokMegtekintese()
        {
            InitializeComponent();
        }

        private void Frm_Utasok_Load(object sender, EventArgs e)
        {
            int osszSor = osszesSorSzam();
            maxOldal = (int)Math.Ceiling((double)osszSor / lim);
            nud_oldalValaszto.Maximum = maxOldal;
            nud_oldalValaszto.Minimum = 1;
            nud_oldalValaszto.Value = aktualisOldal;
            nud_oldalValaszto.ReadOnly = true;
            lekerdezes();
            szpn_szuroPanel.Controls.Add(lst_talalatok);
            lst_talalatok.Visible = false;
            lst_talalatok.DrawMode = DrawMode.OwnerDrawFixed;
            lst_talalatok.DrawItem += lst_talalatok_DrawItem;
            lst_talalatok.MouseDown += lst_talalatok_MouseDown;
            lst_talalatok.Width = kszm_utasNeve.Width;

          
           /// arnyek.Size = szpn_szuroPanel.Size;
         //   arnyek.Location = new Point(szpn_szuroPanel.Left + 5, szpn_szuroPanel.Top + 5);
         //   arnyek.BackColor = Color.FromArgb(80, Color.Black); // áttetsző fekete
           
         //   arnyek.Visible = false;
            
        //    this.Controls.Add(arnyek);

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

        private void lst_talalatok_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var listBox = sender as ListBox;
            var item = listBox.Items[e.Index].ToString();

            // Kiválasztott elem
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // Háttérszín
            e.Graphics.FillRectangle(new SolidBrush(isSelected ? Color.DarkViolet : listBox.BackColor), e.Bounds);

            // Szövegszín
            using (Brush textBrush = new SolidBrush(isSelected ? Color.White : listBox.ForeColor))
            {
                e.Graphics.DrawString(item, e.Font, textBrush, e.Bounds.X, e.Bounds.Y);
            }

            // Fókuszkeret (opcionális)
            e.DrawFocusRectangle();
        }

        public void lekerdezes()
        {
            try
            {
                using (var mc_mysqlcon = new MySqlConnection(constr))
                {
                    var dt = new DataTable();
                    string sql = @" SELECT DISTINCT 
                            u.utas_id AS 'Sorszám',
                            u.titulus AS 'Titulus',
                            u.vezeteknev AS 'Vezetéknév',
                            u.keresztnev1 AS 'Keresztnév',
                            u.keresztnev2 AS 'Második keresztnév',
                            telefon.telefon AS 'Telefonszám', 
                            szemelyi.szemelyi_vagy_utlevel AS 'Okmány',
                            szemelyi.okmany_lejarat AS 'Érvényesség',
                            cim.lakcim AS 'Lakcím',
                            cim.email_cim AS 'Email',
                            fizetes.befizetett_osszeg AS 'Befizetett összeg',
                            fizetes.biztositas AS 'Biztosítás van',
                            megjegyzes.megjegyzes AS 'Megjegyzés'
                        FROM
                            utas AS u
                        INNER JOIN
                            utas_utazasai AS uu ON u.utas_id = uu.utas_id
                        INNER JOIN
                            utazas AS t ON uu.utazas_id = t.utazas_id 
                        LEFT JOIN 
                            telefon ON u.utas_id = telefon.utas_id
                        LEFT JOIN
                            cim ON u.utas_id = cim.utas_id
                        LEFT JOIN
                            fizetes ON u.utas_id = fizetes.utas_id
                        LEFT JOIN
                            szemelyi ON u.utas_id = szemelyi.utas_id
                        LEFT JOIN
                            megjegyzes ON u.utas_id = megjegyzes.utas_id
                      ORDER BY u.utas_id
                      LIMIT @lim OFFSET @offset";

                    int offset = (aktualisOldal - 1) * lim;

                    var cmd = new MySqlCommand(sql, mc_mysqlcon);
                    cmd.Parameters.AddWithValue("@lim", lim);
                    cmd.Parameters.AddWithValue("@offset", offset);

                    var da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgv_utasok.DataSource = dt;
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

        public int osszesSorSzam()
        {
            int osszes = 0;
            try
            {
                using (var con = new MySqlConnection(constr))
                {
                    string sql = @"SELECT COUNT(DISTINCT u.utas_id)
                                    FROM utas AS u
                                    INNER JOIN utas_utazasai AS uu ON u.utas_id = uu.utas_id
                                    INNER JOIN utazas AS t ON uu.utazas_id = t.utazas_id";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        con.Open();
                        osszes = Convert.ToInt32(cmd.ExecuteScalar());
                        return osszes;
                    }

                }
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a sorok számolásánál: " + ex.Message);
                return 0;
            }
        }
        private int SzurtSorokSzama(List<MySqlParameter> parameterek, string whereResz)
        {
            int ossz = 0;
            try
            {
                using (var con = new MySqlConnection(constr))
                {
                    con.Open();

                    string sql = @"SELECT COUNT(DISTINCT u.utas_id)
                        FROM utas AS u
                        INNER JOIN utas_utazasai AS uu ON u.utas_id = uu.utas_id
                        INNER JOIN utazas AS t ON uu.utazas_id = t.utazas_id
                        LEFT JOIN telefon ON u.utas_id = telefon.utas_id
                        LEFT JOIN cim ON u.utas_id = cim.utas_id
                        LEFT JOIN fizetes ON u.utas_id = fizetes.utas_id
                        LEFT JOIN szemelyi ON u.utas_id = szemelyi.utas_id
                        LEFT JOIN megjegyzes ON u.utas_id = megjegyzes.utas_id";

                    if (!string.IsNullOrWhiteSpace(whereResz))
                        sql += " WHERE " + whereResz;

                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        foreach (var p in parameterek)
                        {
                            cmd.Parameters.AddWithValue(p.ParameterName, p.Value);
                        }

                        ossz = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Szűrt sorok számolása közben hiba: " + ex.Message);
            }
            return ossz;
        }

        private void kg_kovetkezo_Click(object sender, EventArgs e)
        {
            if (aktualisOldal < maxOldal)
            {
                aktualisOldal++;
                nud_oldalValaszto.Value = aktualisOldal;

                lekerdezes();
            }
        }

        private void kg_elozo_Click(object sender, EventArgs e)
        {
            if (aktualisOldal > 1)
            {
                aktualisOldal--;
                nud_oldalValaszto.Value = aktualisOldal;

                lekerdezes();
            }
        }

        private void nud_oldalValaszto_ValueChanged(object sender, EventArgs e)
        {
            aktualisOldal = (int)nud_oldalValaszto.Value;

            lekerdezes();
        }
        private void szpn_szuroPanel_Click(object sender, EventArgs e)
        {
            szpn_szuroPanel.Focus();
        }

        private void kg_pipa_Click(object sender, EventArgs e)
        {
            szuresAktiv = true;
            lst_talalatok.Visible = false;
            szpn_szuroPanel.Visible = false;
            //  arnyek.Visible = false;

           
            try
            {
                using (var mc_mysqlcon = new MySqlConnection(constr))
                {
                    var dt = new DataTable();
                    var whereszekvencia = new List<string>();
                    var cmd = new MySqlCommand();
                    cmd.Connection = mc_mysqlcon;

                    string sql = @"SELECT
                            u.utas_id AS 'Sorszám',
                            u.titulus AS 'Titulus',
                            u.vezeteknev AS 'Vezetéknév',
                            u.keresztnev1 AS 'Keresztnév',
                            u.keresztnev2 AS 'Második keresztnév',
                            telefon.telefon AS 'Telefonszám', 
                            szemelyi.szemelyi_vagy_utlevel AS 'Okmány',
                            szemelyi.okmany_lejarat AS 'Érvényesség',
                            cim.lakcim AS 'Lakcím',
                            cim.email_cim AS 'Email',
                            fizetes.befizetett_osszeg AS 'Befizetett összeg',
                            fizetes.biztositas AS 'Biztosítás van',
                            megjegyzes.megjegyzes AS 'Megjegyzés'
                        FROM
                            utas AS u
                        INNER JOIN
                            utas_utazasai AS uu ON u.utas_id = uu.utas_id
                        INNER JOIN
                            utazas AS t ON uu.utazas_id = t.utazas_id 
                        LEFT JOIN 
                            telefon ON u.utas_id = telefon.utas_id
                        LEFT JOIN
                            cim ON u.utas_id = cim.utas_id
                        LEFT JOIN
                            fizetes ON u.utas_id = fizetes.utas_id
                        LEFT JOIN
                            szemelyi ON u.utas_id = szemelyi.utas_id
                        LEFT JOIN
                            megjegyzes ON u.utas_id = megjegyzes.utas_id";

                    // Szűrők hozzáadása
                     string where = string.Join(" AND ", whereszekvencia);
                    var parameterek = cmd.Parameters.Cast<MySqlParameter>().ToList();
                    int szurtSorok = SzurtSorokSzama(parameterek, where);

                    maxOldal = (int)Math.Ceiling((double)szurtSorok / lim);
                    nud_oldalValaszto.Maximum = Math.Max(1, maxOldal);

                    if (!string.IsNullOrWhiteSpace(kszm_utasNeve.Texts))
                    {
                        var nevReszek = kszm_utasNeve.Texts.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        int nevIndex = 0;

                        foreach (var szo in nevReszek)//az autokomplete miatt muszály szétszedni szóközönként a szűrésnél a névrészeket
                        {
                            string paramNev = "@nev" + nevIndex;
                            nevIndex++;

                            whereszekvencia.Add($@"(
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
                        whereszekvencia.Add("telefon.telefon LIKE @telefon");
                        cmd.Parameters.AddWithValue("@telefon", "%" + kszm_telefon.Texts + "%");
                    }

                    if (!string.IsNullOrWhiteSpace(kszm_okmanySzam.Texts))
                    {
                        whereszekvencia.Add("szemelyi.szemelyi_vagy_utlevel LIKE @okmany");
                        cmd.Parameters.AddWithValue("@okmany", "%" + kszm_okmanySzam.Texts + "%");
                    }

                    if (kb_okmanyErvenyes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Kozep)
                    {
                        whereszekvencia.Add("szemelyi.okmany_lejarat < CURDATE()");
                    }
                    else if (kb_okmanyErvenyes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be)
                    {
                        whereszekvencia.Add("szemelyi.okmany_lejarat >= CURDATE()");
                    }

                    if (!string.IsNullOrWhiteSpace(kszm_lakcim.Texts))
                    {
                        whereszekvencia.Add("cim.lakcim LIKE @lakcim");
                        cmd.Parameters.AddWithValue("@lakcim", "%" + kszm_lakcim.Texts + "%");
                    }

                    if (!string.IsNullOrWhiteSpace(kszm_email.Texts))
                    {
                        whereszekvencia.Add("cim.email_cim LIKE @email");
                        cmd.Parameters.AddWithValue("@email", "%" + kszm_email.Texts + "%");
                    }

                    if (kb_befizetes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Kozep)
                    {
                        whereszekvencia.Add("fizetes.befizetett_osszeg = 0");
                    }
                    else if (kb_befizetes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be)
                    {
                        whereszekvencia.Add("fizetes.befizetett_osszeg > 0");
                    }

                    if (kb_biztositas.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Kozep)
                    {
                        whereszekvencia.Add("fizetes.biztositas = 'nem'");
                    }
                    else if (kb_biztositas.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Be)
                    {
                        whereszekvencia.Add("fizetes.biztositas = 'igen'");
                    }

                    if (!string.IsNullOrWhiteSpace(kszm_megjegyzes.Texts))
                    {
                        whereszekvencia.Add("megjegyzes.megjegyzes LIKE @megjegyzes");
                        cmd.Parameters.AddWithValue("@megjegyzes", "%" + kszm_megjegyzes.Texts + "%");
                    }


                    if (whereszekvencia.Count > 0)
                    {
                        sql += " WHERE " + string.Join(" AND ", whereszekvencia);
                    }
                   
                    sql += " ORDER BY u.utas_id LIMIT @lim OFFSET @offset";
                    int offset = (aktualisOldal - 1) * lim;
                    cmd.Parameters.AddWithValue("@lim", lim);
                    cmd.Parameters.AddWithValue("@offset", offset);

                    cmd.CommandText = sql;
                    var da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgv_utasok.DataSource = dt;

                    //ha szűrés nincs visszaáll a szűrő gomb színe
                    if (string.IsNullOrWhiteSpace(kszm_utasNeve.Texts) && string.IsNullOrWhiteSpace(kszm_email.Texts) && string.IsNullOrWhiteSpace(kszm_lakcim.Texts) && string.IsNullOrWhiteSpace(kszm_megjegyzes.Texts)
                        && string.IsNullOrWhiteSpace(kszm_okmanySzam.Texts) && string.IsNullOrWhiteSpace(kszm_telefon.Texts) && kb_befizetes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Ki
                        && kb_biztositas.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Ki && kb_okmanyErvenyes.AktualisAllas == KapcsoloGomb.KapcsoloAllas.Ki)
                    {
                        kg_szuro.HatterSzine = Color.MediumSlateBlue;
                      
                        szuresAktiv = false;
                        aktualisOldal = 1;
                        lekerdezes();
                    }
                    else
                        kg_szuro.HatterSzine = Color.Orange;
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

        private void kszm_utasNeve_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
                            WHERE 
                                  u.titulus LIKE @nev OR
                                  u.vezeteknev LIKE @nev OR
                                  u.keresztnev1 LIKE @nev OR
                                  u.keresztnev2 LIKE @nev
                              
                            GROUP BY u.utas_id
                            LIMIT 4";

                            cmd.Parameters.AddWithValue("@nev", "%" + aktivMezo.Texts.Trim() + "%");
                       
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
            if (szpn_szuroPanel.Visible == false)
            {
                szpn_szuroPanel.Visible = true;
            //    arnyek.Visible = true;
            }
            else
            {
                szpn_szuroPanel.Visible = false;
            //    arnyek.Visible = false;
            }

            }

        private void dgv_utasok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
