using Projekt_feladat.egyeni_vezerlok;
using System.Windows.Forms;

namespace Projekt_feladat.Formok
{
    partial class Frm_UtasokMegtekintese
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ellipszisVezerlo ev_vezerlo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UtasokMegtekintese));
            ellipszisVezerlo ev_szuroPanel;
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnl_vezerlo = new Panel();
            nud_oldalValaszto = new KerekitettNumericUpDown();
            kg_nyomtatas = new KerekitettGomb();
            kg_torles = new KerekitettGomb();
            kg_mentes = new KerekitettGomb();
            kg_szuro = new KerekitettGomb();
            kg_kovetkezo = new KerekitettGomb();
            kg_elozo = new KerekitettGomb();
            szpn_szuroPanel = new Panel();
            klm_utazasiMod = new kerekitettLenyilloMenu();
            kszm_megjegyzes = new kerekitettSzovegMezo();
            kszm_okmanySzam = new kerekitettSzovegMezo();
            kszm_lakcim = new kerekitettSzovegMezo();
            kszm_telefon = new kerekitettSzovegMezo();
            kszm_email = new kerekitettSzovegMezo();
            kszm_utasNeve = new kerekitettSzovegMezo();
            kb_biztositas = new KapcsoloGomb();
            kb_befizetes = new KapcsoloGomb();
            kb_okmanyErvenyes = new KapcsoloGomb();
            kg_pipa = new KerekitettGomb();
            lbl_befizetes = new Label();
            lbl_okmanyErvenyes = new Label();
            lbl_biztositas = new Label();
            dgv_utasok = new DoubleBufferedDataGridView();
            pd_utasok = new System.Drawing.Printing.PrintDocument();
            ppd_utasok = new PrintPreviewDialog();
            kszm_allampolgarsag = new kerekitettSzovegMezo();
            ev_vezerlo = new ellipszisVezerlo();
            ev_szuroPanel = new ellipszisVezerlo();
            pnl_vezerlo.SuspendLayout();
            szpn_szuroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_utasok).BeginInit();
            SuspendLayout();
            // 
            // ev_vezerlo
            // 
            ev_vezerlo.SarokSugar = 8;
            ev_vezerlo.TargetControl = pnl_vezerlo;
            // 
            // pnl_vezerlo
            // 
            pnl_vezerlo.BackColor = Color.DarkViolet;
            pnl_vezerlo.Controls.Add(nud_oldalValaszto);
            pnl_vezerlo.Controls.Add(kg_nyomtatas);
            pnl_vezerlo.Controls.Add(kg_torles);
            pnl_vezerlo.Controls.Add(kg_mentes);
            pnl_vezerlo.Controls.Add(kg_szuro);
            pnl_vezerlo.Controls.Add(kg_kovetkezo);
            pnl_vezerlo.Controls.Add(kg_elozo);
            pnl_vezerlo.Dock = DockStyle.Bottom;
            pnl_vezerlo.Location = new Point(0, 468);
            pnl_vezerlo.Margin = new Padding(3, 2, 3, 2);
            pnl_vezerlo.Name = "pnl_vezerlo";
            pnl_vezerlo.Size = new Size(1127, 75);
            pnl_vezerlo.TabIndex = 0;
            // 
            // nud_oldalValaszto
            // 
            nud_oldalValaszto.BackColor = Color.Transparent;
            nud_oldalValaszto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            nud_oldalValaszto.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nud_oldalValaszto.KeretSzin = Color.Gray;
            nud_oldalValaszto.KeretVastagsag = 1.5F;
            nud_oldalValaszto.Location = new Point(194, 16);
            nud_oldalValaszto.Margin = new Padding(3, 2, 3, 2);
            nud_oldalValaszto.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            nud_oldalValaszto.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nud_oldalValaszto.MinimumSize = new Size(70, 22);
            nud_oldalValaszto.Name = "nud_oldalValaszto";
            nud_oldalValaszto.Radius = 10;
            nud_oldalValaszto.Size = new Size(70, 39);
            nud_oldalValaszto.TabIndex = 8;
            nud_oldalValaszto.Value = new decimal(new int[] { 0, 0, 0, 0 });
            nud_oldalValaszto.ValueChanged += nud_oldalValaszto_ValueChanged;
            // 
            // kg_nyomtatas
            // 
            kg_nyomtatas.BackColor = Color.MediumSlateBlue;
            kg_nyomtatas.BadgeMeret = 40;
            kg_nyomtatas.EgerTartasHatterSzine = Color.SlateBlue;
            kg_nyomtatas.ErtesitesMutatasa = false;
            kg_nyomtatas.ErtesitesSzam = 0;
            kg_nyomtatas.ErtesitesSzin = Color.Red;
            kg_nyomtatas.ErtesitesSzovegSzin = Color.White;
            kg_nyomtatas.FlatAppearance.BorderSize = 0;
            kg_nyomtatas.FlatStyle = FlatStyle.Flat;
            kg_nyomtatas.Font = new Font("Segoe UI", 12F);
            kg_nyomtatas.ForeColor = Color.White;
            kg_nyomtatas.HatterSzine = Color.MediumSlateBlue;
            kg_nyomtatas.Image = (Image)resources.GetObject("kg_nyomtatas.Image");
            kg_nyomtatas.ImageAlign = ContentAlignment.MiddleRight;
            kg_nyomtatas.KeretMeret = 0;
            kg_nyomtatas.KeretSzine = Color.PaleVioletRed;
            kg_nyomtatas.Location = new Point(693, 16);
            kg_nyomtatas.Margin = new Padding(3, 2, 3, 2);
            kg_nyomtatas.Name = "kg_nyomtatas";
            kg_nyomtatas.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_nyomtatas.SarokSugar = 8;
            kg_nyomtatas.Size = new Size(146, 43);
            kg_nyomtatas.SzovegSzine = Color.White;
            kg_nyomtatas.TabIndex = 7;
            kg_nyomtatas.Text = "Nyomtatás";
            kg_nyomtatas.TextAlign = ContentAlignment.MiddleRight;
            kg_nyomtatas.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_nyomtatas.UseVisualStyleBackColor = false;
            kg_nyomtatas.Click += kg_nyomtatas_Click;
            // 
            // kg_torles
            // 
            kg_torles.BackColor = Color.MediumSlateBlue;
            kg_torles.BadgeMeret = 40;
            kg_torles.EgerTartasHatterSzine = Color.Crimson;
            kg_torles.ErtesitesMutatasa = false;
            kg_torles.ErtesitesSzam = 0;
            kg_torles.ErtesitesSzin = Color.Red;
            kg_torles.ErtesitesSzovegSzin = Color.White;
            kg_torles.FlatAppearance.BorderSize = 0;
            kg_torles.FlatStyle = FlatStyle.Flat;
            kg_torles.Font = new Font("Segoe UI", 12F);
            kg_torles.ForeColor = Color.White;
            kg_torles.HatterSzine = Color.MediumSlateBlue;
            kg_torles.Image = (Image)resources.GetObject("kg_torles.Image");
            kg_torles.ImageAlign = ContentAlignment.MiddleRight;
            kg_torles.KeretMeret = 0;
            kg_torles.KeretSzine = Color.PaleVioletRed;
            kg_torles.Location = new Point(561, 16);
            kg_torles.Margin = new Padding(3, 25, 3, 25);
            kg_torles.Name = "kg_torles";
            kg_torles.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_torles.SarokSugar = 8;
            kg_torles.Size = new Size(122, 43);
            kg_torles.SzovegSzine = Color.White;
            kg_torles.TabIndex = 6;
            kg_torles.Text = "Törlés";
            kg_torles.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_torles.UseVisualStyleBackColor = false;
            kg_torles.Click += kg_torles_Click;
            // 
            // kg_mentes
            // 
            kg_mentes.BackColor = Color.MediumSlateBlue;
            kg_mentes.BadgeMeret = 40;
            kg_mentes.EgerTartasHatterSzine = Color.SlateBlue;
            kg_mentes.ErtesitesMutatasa = false;
            kg_mentes.ErtesitesSzam = 0;
            kg_mentes.ErtesitesSzin = Color.Red;
            kg_mentes.ErtesitesSzovegSzin = Color.White;
            kg_mentes.FlatAppearance.BorderSize = 0;
            kg_mentes.FlatStyle = FlatStyle.Flat;
            kg_mentes.Font = new Font("Segoe UI", 12F);
            kg_mentes.ForeColor = Color.White;
            kg_mentes.HatterSzine = Color.MediumSlateBlue;
            kg_mentes.Image = (Image)resources.GetObject("kg_mentes.Image");
            kg_mentes.ImageAlign = ContentAlignment.MiddleRight;
            kg_mentes.KeretMeret = 0;
            kg_mentes.KeretSzine = Color.PaleVioletRed;
            kg_mentes.Location = new Point(430, 16);
            kg_mentes.Margin = new Padding(3, 25, 3, 25);
            kg_mentes.Name = "kg_mentes";
            kg_mentes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_mentes.SarokSugar = 8;
            kg_mentes.Size = new Size(122, 43);
            kg_mentes.SzovegSzine = Color.White;
            kg_mentes.TabIndex = 4;
            kg_mentes.Text = "Mentés";
            kg_mentes.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_mentes.UseVisualStyleBackColor = false;
            kg_mentes.Click += kg_mentes_Click;
            // 
            // kg_szuro
            // 
            kg_szuro.BackColor = Color.MediumSlateBlue;
            kg_szuro.BadgeMeret = 20;
            kg_szuro.EgerTartasHatterSzine = Color.SlateBlue;
            kg_szuro.ErtesitesMutatasa = true;
            kg_szuro.ErtesitesSzam = 0;
            kg_szuro.ErtesitesSzin = Color.Red;
            kg_szuro.ErtesitesSzovegSzin = Color.White;
            kg_szuro.FlatAppearance.BorderSize = 0;
            kg_szuro.FlatStyle = FlatStyle.Flat;
            kg_szuro.Font = new Font("Segoe UI", 12F);
            kg_szuro.ForeColor = Color.White;
            kg_szuro.HatterSzine = Color.MediumSlateBlue;
            kg_szuro.Image = (Image)resources.GetObject("kg_szuro.Image");
            kg_szuro.ImageAlign = ContentAlignment.MiddleRight;
            kg_szuro.KeretMeret = 0;
            kg_szuro.KeretSzine = Color.PaleVioletRed;
            kg_szuro.Location = new Point(298, 15);
            kg_szuro.Margin = new Padding(3, 25, 3, 25);
            kg_szuro.Name = "kg_szuro";
            kg_szuro.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_szuro.SarokSugar = 8;
            kg_szuro.Size = new Size(122, 43);
            kg_szuro.SzovegSzine = Color.White;
            kg_szuro.TabIndex = 3;
            kg_szuro.Text = "Szűrő";
            kg_szuro.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_szuro.UseVisualStyleBackColor = false;
            kg_szuro.Click += kg_szuro_Click;
            // 
            // kg_kovetkezo
            // 
            kg_kovetkezo.BackColor = Color.MediumSlateBlue;
            kg_kovetkezo.BadgeMeret = 40;
            kg_kovetkezo.EgerTartasHatterSzine = Color.SlateBlue;
            kg_kovetkezo.ErtesitesMutatasa = false;
            kg_kovetkezo.ErtesitesSzam = 0;
            kg_kovetkezo.ErtesitesSzin = Color.Red;
            kg_kovetkezo.ErtesitesSzovegSzin = Color.White;
            kg_kovetkezo.FlatAppearance.BorderSize = 0;
            kg_kovetkezo.FlatStyle = FlatStyle.Flat;
            kg_kovetkezo.ForeColor = Color.White;
            kg_kovetkezo.HatterSzine = Color.MediumSlateBlue;
            kg_kovetkezo.Image = (Image)resources.GetObject("kg_kovetkezo.Image");
            kg_kovetkezo.KeretMeret = 0;
            kg_kovetkezo.KeretSzine = Color.PaleVioletRed;
            kg_kovetkezo.Location = new Point(98, 15);
            kg_kovetkezo.Margin = new Padding(3, 2, 3, 2);
            kg_kovetkezo.Name = "kg_kovetkezo";
            kg_kovetkezo.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_kovetkezo.SarokSugar = 8;
            kg_kovetkezo.Size = new Size(75, 43);
            kg_kovetkezo.SzovegSzine = Color.White;
            kg_kovetkezo.TabIndex = 1;
            kg_kovetkezo.UseVisualStyleBackColor = false;
            kg_kovetkezo.Click += kg_kovetkezo_Click;
            // 
            // kg_elozo
            // 
            kg_elozo.BackColor = Color.MediumSlateBlue;
            kg_elozo.BadgeMeret = 40;
            kg_elozo.EgerTartasHatterSzine = Color.SlateBlue;
            kg_elozo.ErtesitesMutatasa = false;
            kg_elozo.ErtesitesSzam = 0;
            kg_elozo.ErtesitesSzin = Color.Red;
            kg_elozo.ErtesitesSzovegSzin = Color.White;
            kg_elozo.FlatAppearance.BorderSize = 0;
            kg_elozo.FlatStyle = FlatStyle.Flat;
            kg_elozo.ForeColor = Color.White;
            kg_elozo.HatterSzine = Color.MediumSlateBlue;
            kg_elozo.Image = (Image)resources.GetObject("kg_elozo.Image");
            kg_elozo.KeretMeret = 0;
            kg_elozo.KeretSzine = Color.PaleVioletRed;
            kg_elozo.Location = new Point(10, 15);
            kg_elozo.Margin = new Padding(3, 2, 3, 2);
            kg_elozo.Name = "kg_elozo";
            kg_elozo.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_elozo.SarokSugar = 8;
            kg_elozo.Size = new Size(75, 43);
            kg_elozo.SzovegSzine = Color.White;
            kg_elozo.TabIndex = 0;
            kg_elozo.UseVisualStyleBackColor = false;
            kg_elozo.Click += kg_elozo_Click;
            // 
            // ev_szuroPanel
            // 
            ev_szuroPanel.SarokSugar = 80;
            ev_szuroPanel.TargetControl = szpn_szuroPanel;
            // 
            // szpn_szuroPanel
            // 
            szpn_szuroPanel.BackColor = Color.FromArgb(243, 244, 246);
            szpn_szuroPanel.Controls.Add(kszm_allampolgarsag);
            szpn_szuroPanel.Controls.Add(klm_utazasiMod);
            szpn_szuroPanel.Controls.Add(kszm_megjegyzes);
            szpn_szuroPanel.Controls.Add(kszm_okmanySzam);
            szpn_szuroPanel.Controls.Add(kszm_lakcim);
            szpn_szuroPanel.Controls.Add(kszm_telefon);
            szpn_szuroPanel.Controls.Add(kszm_email);
            szpn_szuroPanel.Controls.Add(kszm_utasNeve);
            szpn_szuroPanel.Controls.Add(kb_biztositas);
            szpn_szuroPanel.Controls.Add(kb_befizetes);
            szpn_szuroPanel.Controls.Add(kb_okmanyErvenyes);
            szpn_szuroPanel.Controls.Add(kg_pipa);
            szpn_szuroPanel.Controls.Add(lbl_befizetes);
            szpn_szuroPanel.Controls.Add(lbl_okmanyErvenyes);
            szpn_szuroPanel.Controls.Add(lbl_biztositas);
            szpn_szuroPanel.ForeColor = Color.Black;
            szpn_szuroPanel.Location = new Point(139, 23);
            szpn_szuroPanel.Margin = new Padding(3, 2, 3, 2);
            szpn_szuroPanel.Name = "szpn_szuroPanel";
            szpn_szuroPanel.Size = new Size(672, 433);
            szpn_szuroPanel.TabIndex = 6;
            szpn_szuroPanel.Visible = false;
            szpn_szuroPanel.Click += szpn_szuroPanel_Click;
            // 
            // klm_utazasiMod
            // 
            klm_utazasiMod.adatForras = new string[]
    {
    "Mind",
    "Busz",
    "Repülő",
    "Hajó",
    "Egyéni"
    };
            klm_utazasiMod.BackColor = Color.Transparent;
            klm_utazasiMod.CimPanelAlsoSzin = Color.White;
            klm_utazasiMod.CimPanelFelsoSzin = Color.White;
            klm_utazasiMod.ComboText = "Utazási mód";
            klm_utazasiMod.EgerTrartasSzin = Color.CornflowerBlue;
            klm_utazasiMod.ForeColor = Color.White;
            klm_utazasiMod.Ikon = (Image)resources.GetObject("klm_utazasiMod.Ikon");
            klm_utazasiMod.ItemHatterSzin = Color.White;
            klm_utazasiMod.ItemPanelAlosSzin = Color.White;
            klm_utazasiMod.ItemPanelFelsoSzin = Color.White;
            klm_utazasiMod.KeretSzin = Color.MediumSlateBlue;
            klm_utazasiMod.KeretVastagsag = 2F;
            klm_utazasiMod.KivalasztottElemSzin = Color.BlueViolet;
            klm_utazasiMod.LenyiloMagassag = 150;
            klm_utazasiMod.Location = new Point(400, 44);
            klm_utazasiMod.Margin = new Padding(2, 3, 2, 3);
            klm_utazasiMod.MinimumSize = new Size(150, 0);
            klm_utazasiMod.Name = "klm_utazasiMod";
            klm_utazasiMod.Radius = 10;
            klm_utazasiMod.Size = new Size(251, 63);
            klm_utazasiMod.TabIndex = 2;
            klm_utazasiMod.TitleLabelSzin = Color.Black;
            // 
            // kszm_megjegyzes
            // 
            kszm_megjegyzes.AlahuzottStilus = false;
            kszm_megjegyzes.BackColor = SystemColors.Window;
            kszm_megjegyzes.FokuszKeretSzin = Color.HotPink;
            kszm_megjegyzes.Font = new Font("Microsoft Sans Serif", 10F);
            kszm_megjegyzes.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_megjegyzes.HelyorzoSzin = Color.DarkGray;
            kszm_megjegyzes.HelyorzoSzoveg = "Megjegyzés";
            kszm_megjegyzes.JelszoKarakter = false;
            kszm_megjegyzes.KeretMeret = 2;
            kszm_megjegyzes.KeretSugar = 8;
            kszm_megjegyzes.KeretSzin = Color.MediumSlateBlue;
            kszm_megjegyzes.Location = new Point(39, 262);
            kszm_megjegyzes.Margin = new Padding(4, 3, 4, 3);
            kszm_megjegyzes.Name = "kszm_megjegyzes";
            kszm_megjegyzes.Padding = new Padding(9, 6, 9, 6);
            kszm_megjegyzes.Size = new Size(343, 31);
            kszm_megjegyzes.TabIndex = 6;
            kszm_megjegyzes.Texts = "";
            kszm_megjegyzes.TobbSor = true;
            kszm_megjegyzes._SzovegValtoztatva += kszm_AutoComplete;
            kszm_megjegyzes.KeyDown += SzovegMezo_KeyDown;
            kszm_megjegyzes.Leave += kszm_Leave;
            // 
            // kszm_okmanySzam
            // 
            kszm_okmanySzam.AlahuzottStilus = false;
            kszm_okmanySzam.BackColor = SystemColors.Window;
            kszm_okmanySzam.FokuszKeretSzin = Color.HotPink;
            kszm_okmanySzam.Font = new Font("Microsoft Sans Serif", 10F);
            kszm_okmanySzam.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_okmanySzam.HelyorzoSzin = Color.DarkGray;
            kszm_okmanySzam.HelyorzoSzoveg = "Okmány szám";
            kszm_okmanySzam.JelszoKarakter = false;
            kszm_okmanySzam.KeretMeret = 2;
            kszm_okmanySzam.KeretSugar = 8;
            kszm_okmanySzam.KeretSzin = Color.MediumSlateBlue;
            kszm_okmanySzam.Location = new Point(39, 188);
            kszm_okmanySzam.Margin = new Padding(4, 3, 4, 3);
            kszm_okmanySzam.Name = "kszm_okmanySzam";
            kszm_okmanySzam.Padding = new Padding(9, 6, 9, 6);
            kszm_okmanySzam.Size = new Size(343, 31);
            kszm_okmanySzam.TabIndex = 4;
            kszm_okmanySzam.Texts = "";
            kszm_okmanySzam.TobbSor = false;
            kszm_okmanySzam._SzovegValtoztatva += kszm_AutoComplete;
            kszm_okmanySzam.KeyDown += SzovegMezo_KeyDown;
            kszm_okmanySzam.Leave += kszm_Leave;
            // 
            // kszm_lakcim
            // 
            kszm_lakcim.AlahuzottStilus = false;
            kszm_lakcim.BackColor = SystemColors.Window;
            kszm_lakcim.FokuszKeretSzin = Color.HotPink;
            kszm_lakcim.Font = new Font("Microsoft Sans Serif", 10F);
            kszm_lakcim.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_lakcim.HelyorzoSzin = Color.DarkGray;
            kszm_lakcim.HelyorzoSzoveg = "Lakcím";
            kszm_lakcim.JelszoKarakter = false;
            kszm_lakcim.KeretMeret = 2;
            kszm_lakcim.KeretSugar = 8;
            kszm_lakcim.KeretSzin = Color.MediumSlateBlue;
            kszm_lakcim.Location = new Point(39, 155);
            kszm_lakcim.Margin = new Padding(4, 3, 4, 3);
            kszm_lakcim.Name = "kszm_lakcim";
            kszm_lakcim.Padding = new Padding(9, 6, 9, 6);
            kszm_lakcim.Size = new Size(343, 31);
            kszm_lakcim.TabIndex = 3;
            kszm_lakcim.Texts = "";
            kszm_lakcim.TobbSor = false;
            kszm_lakcim._SzovegValtoztatva += kszm_AutoComplete;
            kszm_lakcim.KeyDown += SzovegMezo_KeyDown;
            kszm_lakcim.Leave += kszm_Leave;
            // 
            // kszm_telefon
            // 
            kszm_telefon.AlahuzottStilus = false;
            kszm_telefon.BackColor = SystemColors.Window;
            kszm_telefon.FokuszKeretSzin = Color.HotPink;
            kszm_telefon.Font = new Font("Microsoft Sans Serif", 10F);
            kszm_telefon.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_telefon.HelyorzoSzin = Color.DarkGray;
            kszm_telefon.HelyorzoSzoveg = "Telefon";
            kszm_telefon.JelszoKarakter = false;
            kszm_telefon.KeretMeret = 2;
            kszm_telefon.KeretSugar = 8;
            kszm_telefon.KeretSzin = Color.MediumSlateBlue;
            kszm_telefon.Location = new Point(39, 118);
            kszm_telefon.Margin = new Padding(4, 3, 4, 3);
            kszm_telefon.Name = "kszm_telefon";
            kszm_telefon.Padding = new Padding(9, 6, 9, 6);
            kszm_telefon.Size = new Size(343, 31);
            kszm_telefon.TabIndex = 2;
            kszm_telefon.Texts = "";
            kszm_telefon.TobbSor = false;
            kszm_telefon._SzovegValtoztatva += kszm_AutoComplete;
            kszm_telefon.KeyDown += SzovegMezo_KeyDown;
            kszm_telefon.Leave += kszm_Leave;
            // 
            // kszm_email
            // 
            kszm_email.AlahuzottStilus = false;
            kszm_email.BackColor = SystemColors.Window;
            kszm_email.FokuszKeretSzin = Color.HotPink;
            kszm_email.Font = new Font("Microsoft Sans Serif", 10F);
            kszm_email.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_email.HelyorzoSzin = Color.DarkGray;
            kszm_email.HelyorzoSzoveg = "Email";
            kszm_email.JelszoKarakter = false;
            kszm_email.KeretMeret = 2;
            kszm_email.KeretSugar = 8;
            kszm_email.KeretSzin = Color.MediumSlateBlue;
            kszm_email.Location = new Point(39, 81);
            kszm_email.Margin = new Padding(4, 3, 4, 3);
            kszm_email.Name = "kszm_email";
            kszm_email.Padding = new Padding(9, 6, 9, 6);
            kszm_email.Size = new Size(343, 31);
            kszm_email.TabIndex = 1;
            kszm_email.Texts = "";
            kszm_email.TobbSor = false;
            kszm_email._SzovegValtoztatva += kszm_AutoComplete;
            kszm_email.KeyDown += SzovegMezo_KeyDown;
            kszm_email.Leave += kszm_Leave;
            // 
            // kszm_utasNeve
            // 
            kszm_utasNeve.AlahuzottStilus = false;
            kszm_utasNeve.BackColor = SystemColors.Window;
            kszm_utasNeve.FokuszKeretSzin = Color.HotPink;
            kszm_utasNeve.Font = new Font("Microsoft Sans Serif", 10F);
            kszm_utasNeve.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_utasNeve.HelyorzoSzin = Color.DarkGray;
            kszm_utasNeve.HelyorzoSzoveg = "Utas Neve";
            kszm_utasNeve.JelszoKarakter = false;
            kszm_utasNeve.KeretMeret = 2;
            kszm_utasNeve.KeretSugar = 8;
            kszm_utasNeve.KeretSzin = Color.MediumSlateBlue;
            kszm_utasNeve.Location = new Point(39, 44);
            kszm_utasNeve.Margin = new Padding(4, 3, 4, 3);
            kszm_utasNeve.Name = "kszm_utasNeve";
            kszm_utasNeve.Padding = new Padding(9, 6, 9, 6);
            kszm_utasNeve.Size = new Size(343, 31);
            kszm_utasNeve.TabIndex = 0;
            kszm_utasNeve.Texts = "";
            kszm_utasNeve.TobbSor = false;
            kszm_utasNeve._SzovegValtoztatva += kszm_AutoComplete;
            kszm_utasNeve.KeyDown += SzovegMezo_KeyDown;
            kszm_utasNeve.Leave += kszm_Leave;
            // 
            // kb_biztositas
            // 
            kb_biztositas.AktualisAllas = KapcsoloGomb.KapcsoloAllas.Ki;
            kb_biztositas.Location = new Point(555, 139);
            kb_biztositas.Margin = new Padding(3, 2, 3, 2);
            kb_biztositas.MinimumSize = new Size(61, 18);
            kb_biztositas.Name = "kb_biztositas";
            kb_biztositas.Size = new Size(79, 29);
            kb_biztositas.TabIndex = 0;
            // 
            // kb_befizetes
            // 
            kb_befizetes.AktualisAllas = KapcsoloGomb.KapcsoloAllas.Ki;
            kb_befizetes.Location = new Point(553, 240);
            kb_befizetes.Margin = new Padding(3, 2, 3, 2);
            kb_befizetes.MinimumSize = new Size(61, 18);
            kb_befizetes.Name = "kb_befizetes";
            kb_befizetes.Size = new Size(79, 29);
            kb_befizetes.TabIndex = 0;
            kb_befizetes.Load += kb_befizetes_Load;
            // 
            // kb_okmanyErvenyes
            // 
            kb_okmanyErvenyes.AktualisAllas = KapcsoloGomb.KapcsoloAllas.Ki;
            kb_okmanyErvenyes.Location = new Point(555, 188);
            kb_okmanyErvenyes.Margin = new Padding(3, 2, 3, 2);
            kb_okmanyErvenyes.MinimumSize = new Size(61, 18);
            kb_okmanyErvenyes.Name = "kb_okmanyErvenyes";
            kb_okmanyErvenyes.Size = new Size(79, 29);
            kb_okmanyErvenyes.TabIndex = 2;
            // 
            // kg_pipa
            // 
            kg_pipa.BackColor = Color.WhiteSmoke;
            kg_pipa.BackgroundImageLayout = ImageLayout.Center;
            kg_pipa.BadgeMeret = 40;
            kg_pipa.EgerTartasHatterSzine = Color.DarkViolet;
            kg_pipa.ErtesitesMutatasa = false;
            kg_pipa.ErtesitesSzam = 0;
            kg_pipa.ErtesitesSzin = Color.Red;
            kg_pipa.ErtesitesSzovegSzin = Color.White;
            kg_pipa.FlatAppearance.BorderSize = 0;
            kg_pipa.FlatStyle = FlatStyle.Flat;
            kg_pipa.ForeColor = Color.Violet;
            kg_pipa.HatterSzine = Color.WhiteSmoke;
            kg_pipa.Image = (Image)resources.GetObject("kg_pipa.Image");
            kg_pipa.KeretMeret = 0;
            kg_pipa.KeretSzine = Color.PaleVioletRed;
            kg_pipa.Location = new Point(474, 283);
            kg_pipa.Margin = new Padding(3, 2, 3, 2);
            kg_pipa.Name = "kg_pipa";
            kg_pipa.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_pipa.SarokSugar = 20;
            kg_pipa.Size = new Size(92, 79);
            kg_pipa.SzovegSzine = Color.Violet;
            kg_pipa.TabIndex = 13;
            kg_pipa.UseVisualStyleBackColor = false;
            kg_pipa.Click += kg_pipa_Click;
            // 
            // lbl_befizetes
            // 
            lbl_befizetes.AutoSize = true;
            lbl_befizetes.Font = new Font("Segoe UI", 9F);
            lbl_befizetes.Location = new Point(414, 245);
            lbl_befizetes.Name = "lbl_befizetes";
            lbl_befizetes.Size = new Size(99, 19);
            lbl_befizetes.TabIndex = 11;
            lbl_befizetes.Text = "Van befizetése:";
            // 
            // lbl_okmanyErvenyes
            // 
            lbl_okmanyErvenyes.AutoSize = true;
            lbl_okmanyErvenyes.Font = new Font("Segoe UI", 9F);
            lbl_okmanyErvenyes.Location = new Point(414, 194);
            lbl_okmanyErvenyes.Name = "lbl_okmanyErvenyes";
            lbl_okmanyErvenyes.Size = new Size(136, 19);
            lbl_okmanyErvenyes.TabIndex = 10;
            lbl_okmanyErvenyes.Text = "Érvényes az okmány:";
            // 
            // lbl_biztositas
            // 
            lbl_biztositas.AutoSize = true;
            lbl_biztositas.Font = new Font("Segoe UI", 9F);
            lbl_biztositas.Location = new Point(414, 139);
            lbl_biztositas.Name = "lbl_biztositas";
            lbl_biztositas.Size = new Size(95, 19);
            lbl_biztositas.TabIndex = 9;
            lbl_biztositas.Text = "Biztosítás van:";
            // 
            // dgv_utasok
            // 
            dgv_utasok.AllowUserToAddRows = false;
            dgv_utasok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_utasok.BackgroundColor = SystemColors.ControlLightLight;
            dgv_utasok.BorderStyle = BorderStyle.None;
            dgv_utasok.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgv_utasok.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_utasok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_utasok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle5.SelectionForeColor = Color.BlueViolet;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_utasok.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_utasok.Dock = DockStyle.Fill;
            dgv_utasok.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv_utasok.EnableHeadersVisualStyles = false;
            dgv_utasok.GridColor = SystemColors.InactiveBorder;
            dgv_utasok.Location = new Point(0, 0);
            dgv_utasok.Name = "dgv_utasok";
            dgv_utasok.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_utasok.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_utasok.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv_utasok.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv_utasok.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgv_utasok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_utasok.ShowEditingIcon = false;
            dgv_utasok.ShowRowErrors = false;
            dgv_utasok.Size = new Size(1127, 468);
            dgv_utasok.TabIndex = 1;
            dgv_utasok.CellMouseEnter += dgv_utasok_CellMouseEnter;
            dgv_utasok.CellValueChanged += dgv_utasok_CellValueChanged;
            // 
            // pd_utasok
            // 
            pd_utasok.PrintPage += pd_utasok_PrintPage;
            // 
            // ppd_utasok
            // 
            ppd_utasok.AutoScrollMargin = new Size(0, 0);
            ppd_utasok.AutoScrollMinSize = new Size(0, 0);
            ppd_utasok.ClientSize = new Size(400, 300);
            ppd_utasok.Enabled = true;
            ppd_utasok.Icon = (Icon)resources.GetObject("ppd_utasok.Icon");
            ppd_utasok.Name = "ppd_utasok";
            ppd_utasok.Visible = false;
            // 
            // kszm_allampolgarsag
            // 
            kszm_allampolgarsag.AlahuzottStilus = false;
            kszm_allampolgarsag.BackColor = SystemColors.Window;
            kszm_allampolgarsag.FokuszKeretSzin = Color.HotPink;
            kszm_allampolgarsag.Font = new Font("Microsoft Sans Serif", 10F);
            kszm_allampolgarsag.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_allampolgarsag.HelyorzoSzin = Color.DarkGray;
            kszm_allampolgarsag.HelyorzoSzoveg = "Állampolgárság";
            kszm_allampolgarsag.JelszoKarakter = false;
            kszm_allampolgarsag.KeretMeret = 2;
            kszm_allampolgarsag.KeretSugar = 8;
            kszm_allampolgarsag.KeretSzin = Color.MediumSlateBlue;
            kszm_allampolgarsag.Location = new Point(39, 225);
            kszm_allampolgarsag.Margin = new Padding(4, 3, 4, 3);
            kszm_allampolgarsag.Name = "kszm_allampolgarsag";
            kszm_allampolgarsag.Padding = new Padding(9, 6, 9, 6);
            kszm_allampolgarsag.Size = new Size(343, 31);
            kszm_allampolgarsag.TabIndex = 14;
            kszm_allampolgarsag.Texts = "";
            kszm_allampolgarsag.TobbSor = true;
            // 
            // Frm_UtasokMegtekintese
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 543);
            Controls.Add(szpn_szuroPanel);
            Controls.Add(dgv_utasok);
            Controls.Add(pnl_vezerlo);
            Name = "Frm_UtasokMegtekintese";
            Text = "Utasok";
            Load += Frm_Utasok_Load;
            Resize += Frm_UtasokMegtekintese_Resize;
            pnl_vezerlo.ResumeLayout(false);
            szpn_szuroPanel.ResumeLayout(false);
            szpn_szuroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_utasok).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel pnl_vezerlo;
      
        private egyeni_vezerlok.KerekitettGomb kg_kovetkezo;
        private egyeni_vezerlok.KerekitettGomb kg_elozo;
        private egyeni_vezerlok.DoubleBufferedDataGridView dgv_utasok;
        private egyeni_vezerlok.KerekitettGomb kg_mentes;
        private egyeni_vezerlok.KerekitettGomb kg_szuro;
     
        private Panel szpn_szuroPanel;
        private KapcsoloGomb kb_biztositas;
        private KapcsoloGomb kb_befizetes;
        private KapcsoloGomb kb_okmanyErvenyes;
        private KerekitettGomb kg_pipa;
        private Label lbl_befizetes;
        private Label lbl_utasLista;
        private Label lbl_okmanyErvenyes;
        private Label lbl_biztositas;
        private kerekitettSzovegMezo kszm_megjegyzes;
        private kerekitettSzovegMezo kszm_okmanySzam;
        private kerekitettSzovegMezo kszm_lakcim;
        private kerekitettSzovegMezo kszm_telefon;
        private kerekitettSzovegMezo kszm_email;
        private kerekitettSzovegMezo kszm_utasNeve;
        private ellipszisVezerlo ev_szuroPanel;
        private KerekitettGomb kg_torles;
        private KerekitettGomb kg_nyomtatas;
        private System.Drawing.Printing.PrintDocument pd_utasok;
        private PrintPreviewDialog ppd_utasok;
        private KerekitettNumericUpDown nud_oldalValaszto;
        private kerekitettLenyilloMenu klm_utazasiMod;
        private kerekitettSzovegMezo kszm_allampolgarsag;
    }
}