using Projekt_feladat.egyeni_vezerlok;
using System.Windows.Forms;

namespace Projekt_feladat.Formok
{
    partial class Frm_UtazasokMegtekintese
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
            ellipszisVezerlo ev_szuroPanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UtazasokMegtekintese));
            ellipszisVezerlo ev_utasLista;
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            szpn_szuroPanel = new Panel();
            klm_utazasiMod = new kerekitettLenyilloMenu();
            kb_biztositas = new KapcsoloGomb();
            kb_befizetes = new KapcsoloGomb();
            kb_okmanyErvenyes = new KapcsoloGomb();
            kg_pipa = new KerekitettGomb();
            lbl_befizetes = new Label();
            lbl_okmanyErvenyes = new Label();
            lbl_biztositas = new Label();
            kszm_megjegyzes = new kerekitettSzovegMezo();
            kszm_okmanySzam = new kerekitettSzovegMezo();
            kszm_lakcim = new kerekitettSzovegMezo();
            kszm_telefon = new kerekitettSzovegMezo();
            kszm_email = new kerekitettSzovegMezo();
            kszm_utasNeve = new kerekitettSzovegMezo();
            pnl_utasLista = new Panel();
            lbl_utasLista = new Label();
            kg_UlNyomtatas = new KerekitettGomb();
            kg_kilepes = new KerekitettGomb();
            dgv_utasLista = new DoubleBufferedDataGridView();
            kszm_vezetoNeve2 = new kerekitettSzovegMezo();
            kszm_vezetoNeve1 = new kerekitettSzovegMezo();
            kszm_jarmuSzama = new kerekitettSzovegMezo();
            kszm_datum = new kerekitettSzovegMezo();
            kszm_uticel = new kerekitettSzovegMezo();
            kszm_indulasHelye = new kerekitettSzovegMezo();
            rcb_desztinacio = new kerekitettLenyilloMenu();
            rcb_idoszak = new kerekitettLenyilloMenu();
            dgv_utazasok = new DoubleBufferedDataGridView();
            rcb_utazasNeve = new kerekitettLenyilloMenu();
            pnl_vezerlok = new Panel();
            kszm_torles = new KerekitettGomb();
            kg_szures = new KerekitettGomb();
            kszm_nyomtatas = new KerekitettGomb();
            kszm_utasLista = new KerekitettGomb();
            btn_mentes = new KerekitettGomb();
            ev_vezerloPanel = new ellipszisVezerlo();
            pd_utasLista = new System.Drawing.Printing.PrintDocument();
            ppd_utasLista = new PrintPreviewDialog();
            pd_utazasok = new System.Drawing.Printing.PrintDocument();
            kszm_allampolgarsag = new kerekitettSzovegMezo();
            ev_szuroPanel = new ellipszisVezerlo();
            ev_utasLista = new ellipszisVezerlo();
            szpn_szuroPanel.SuspendLayout();
            pnl_utasLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_utasLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_utazasok).BeginInit();
            pnl_vezerlok.SuspendLayout();
            SuspendLayout();
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
            szpn_szuroPanel.Controls.Add(kb_biztositas);
            szpn_szuroPanel.Controls.Add(kb_befizetes);
            szpn_szuroPanel.Controls.Add(kb_okmanyErvenyes);
            szpn_szuroPanel.Controls.Add(kg_pipa);
            szpn_szuroPanel.Controls.Add(lbl_befizetes);
            szpn_szuroPanel.Controls.Add(lbl_okmanyErvenyes);
            szpn_szuroPanel.Controls.Add(lbl_biztositas);
            szpn_szuroPanel.Controls.Add(kszm_megjegyzes);
            szpn_szuroPanel.Controls.Add(kszm_okmanySzam);
            szpn_szuroPanel.Controls.Add(kszm_lakcim);
            szpn_szuroPanel.Controls.Add(kszm_telefon);
            szpn_szuroPanel.Controls.Add(kszm_email);
            szpn_szuroPanel.Controls.Add(kszm_utasNeve);
            szpn_szuroPanel.ForeColor = Color.Black;
            szpn_szuroPanel.Location = new Point(10, 11);
            szpn_szuroPanel.Margin = new Padding(3, 2, 3, 2);
            szpn_szuroPanel.Name = "szpn_szuroPanel";
            szpn_szuroPanel.Size = new Size(716, 475);
            szpn_szuroPanel.TabIndex = 11;
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
            klm_utazasiMod.Location = new Point(409, 46);
            klm_utazasiMod.Margin = new Padding(2, 3, 2, 3);
            klm_utazasiMod.MinimumSize = new Size(150, 0);
            klm_utazasiMod.Name = "klm_utazasiMod";
            klm_utazasiMod.Radius = 10;
            klm_utazasiMod.Size = new Size(251, 63);
            klm_utazasiMod.TabIndex = 14;
            klm_utazasiMod.TitleLabelSzin = Color.Black;
            // 
            // kb_biztositas
            // 
            kb_biztositas.AktualisAllas = KapcsoloGomb.KapcsoloAllas.Ki;
            kb_biztositas.Location = new Point(539, 150);
            kb_biztositas.Margin = new Padding(3, 2, 3, 2);
            kb_biztositas.MinimumSize = new Size(61, 18);
            kb_biztositas.Name = "kb_biztositas";
            kb_biztositas.Size = new Size(79, 29);
            kb_biztositas.TabIndex = 0;
            // 
            // kb_befizetes
            // 
            kb_befizetes.AktualisAllas = KapcsoloGomb.KapcsoloAllas.Ki;
            kb_befizetes.Location = new Point(539, 246);
            kb_befizetes.Margin = new Padding(3, 2, 3, 2);
            kb_befizetes.MinimumSize = new Size(61, 18);
            kb_befizetes.Name = "kb_befizetes";
            kb_befizetes.Size = new Size(79, 29);
            kb_befizetes.TabIndex = 1;
            // 
            // kb_okmanyErvenyes
            // 
            kb_okmanyErvenyes.AktualisAllas = KapcsoloGomb.KapcsoloAllas.Ki;
            kb_okmanyErvenyes.Location = new Point(539, 195);
            kb_okmanyErvenyes.Margin = new Padding(3, 2, 3, 2);
            kb_okmanyErvenyes.MinimumSize = new Size(61, 18);
            kb_okmanyErvenyes.Name = "kb_okmanyErvenyes";
            kb_okmanyErvenyes.Size = new Size(79, 29);
            kb_okmanyErvenyes.TabIndex = 2;
            // 
            // kg_pipa
            // 
            kg_pipa.BackColor = Color.WhiteSmoke;
            kg_pipa.BackgroundImage = (Image)resources.GetObject("kg_pipa.BackgroundImage");
            kg_pipa.BackgroundImageLayout = ImageLayout.Stretch;
            kg_pipa.BadgeMeret = 40;
            kg_pipa.EgerTartasHatterSzine = Color.DarkViolet;
            kg_pipa.ErtesitesMutatasa = false;
            kg_pipa.ErtesitesSzam = 0;
            kg_pipa.ErtesitesSzin = Color.Red;
            kg_pipa.ErtesitesSzovegSzin = Color.White;
            kg_pipa.FlatAppearance.BorderSize = 0;
            kg_pipa.FlatStyle = FlatStyle.Flat;
            kg_pipa.ForeColor = Color.White;
            kg_pipa.HatterSzine = Color.WhiteSmoke;
            kg_pipa.KeretMeret = 0;
            kg_pipa.KeretSzine = Color.PaleVioletRed;
            kg_pipa.Location = new Point(532, 318);
            kg_pipa.Margin = new Padding(3, 2, 3, 2);
            kg_pipa.Name = "kg_pipa";
            kg_pipa.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_pipa.SarokSugar = 20;
            kg_pipa.Size = new Size(92, 79);
            kg_pipa.SzovegSzine = Color.White;
            kg_pipa.TabIndex = 13;
            kg_pipa.UseVisualStyleBackColor = false;
            kg_pipa.Click += kg_pipa_Click;
            // 
            // lbl_befizetes
            // 
            lbl_befizetes.AutoSize = true;
            lbl_befizetes.Location = new Point(408, 258);
            lbl_befizetes.Name = "lbl_befizetes";
            lbl_befizetes.Size = new Size(95, 17);
            lbl_befizetes.TabIndex = 11;
            lbl_befizetes.Text = "Van befizetése:";
            // 
            // lbl_okmanyErvenyes
            // 
            lbl_okmanyErvenyes.AutoSize = true;
            lbl_okmanyErvenyes.Location = new Point(408, 207);
            lbl_okmanyErvenyes.Name = "lbl_okmanyErvenyes";
            lbl_okmanyErvenyes.Size = new Size(128, 17);
            lbl_okmanyErvenyes.TabIndex = 10;
            lbl_okmanyErvenyes.Text = "Érvényes az okmány:";
            // 
            // lbl_biztositas
            // 
            lbl_biztositas.AutoSize = true;
            lbl_biztositas.Location = new Point(408, 153);
            lbl_biztositas.Name = "lbl_biztositas";
            lbl_biztositas.Size = new Size(89, 17);
            lbl_biztositas.TabIndex = 9;
            lbl_biztositas.Text = "Biztosítás van:";
            // 
            // kszm_megjegyzes
            // 
            kszm_megjegyzes.AlahuzottStilus = false;
            kszm_megjegyzes.BackColor = SystemColors.Window;
            kszm_megjegyzes.FokuszKeretSzin = Color.HotPink;
            kszm_megjegyzes.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_megjegyzes.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_megjegyzes.HelyorzoSzin = Color.DarkGray;
            kszm_megjegyzes.HelyorzoSzoveg = "Megjegyzés";
            kszm_megjegyzes.JelszoKarakter = false;
            kszm_megjegyzes.KeretMeret = 2;
            kszm_megjegyzes.KeretSugar = 8;
            kszm_megjegyzes.KeretSzin = Color.MediumSlateBlue;
            kszm_megjegyzes.Location = new Point(39, 261);
            kszm_megjegyzes.Margin = new Padding(4, 3, 4, 3);
            kszm_megjegyzes.Name = "kszm_megjegyzes";
            kszm_megjegyzes.Padding = new Padding(9, 6, 9, 6);
            kszm_megjegyzes.Size = new Size(343, 30);
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
            kszm_okmanySzam.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_okmanySzam.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_okmanySzam.HelyorzoSzin = Color.DarkGray;
            kszm_okmanySzam.HelyorzoSzoveg = "Okmány szám";
            kszm_okmanySzam.JelszoKarakter = false;
            kszm_okmanySzam.KeretMeret = 2;
            kszm_okmanySzam.KeretSugar = 8;
            kszm_okmanySzam.KeretSzin = Color.MediumSlateBlue;
            kszm_okmanySzam.Location = new Point(39, 189);
            kszm_okmanySzam.Margin = new Padding(4, 3, 4, 3);
            kszm_okmanySzam.Name = "kszm_okmanySzam";
            kszm_okmanySzam.Padding = new Padding(9, 6, 9, 6);
            kszm_okmanySzam.Size = new Size(343, 30);
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
            kszm_lakcim.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_lakcim.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_lakcim.HelyorzoSzin = Color.DarkGray;
            kszm_lakcim.HelyorzoSzoveg = "Lakcím";
            kszm_lakcim.JelszoKarakter = false;
            kszm_lakcim.KeretMeret = 2;
            kszm_lakcim.KeretSugar = 8;
            kszm_lakcim.KeretSzin = Color.MediumSlateBlue;
            kszm_lakcim.Location = new Point(39, 153);
            kszm_lakcim.Margin = new Padding(4, 3, 4, 3);
            kszm_lakcim.Name = "kszm_lakcim";
            kszm_lakcim.Padding = new Padding(9, 6, 9, 6);
            kszm_lakcim.Size = new Size(343, 30);
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
            kszm_telefon.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_telefon.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_telefon.HelyorzoSzin = Color.DarkGray;
            kszm_telefon.HelyorzoSzoveg = "Telefon";
            kszm_telefon.JelszoKarakter = false;
            kszm_telefon.KeretMeret = 2;
            kszm_telefon.KeretSugar = 8;
            kszm_telefon.KeretSzin = Color.MediumSlateBlue;
            kszm_telefon.Location = new Point(39, 117);
            kszm_telefon.Margin = new Padding(4, 3, 4, 3);
            kszm_telefon.Name = "kszm_telefon";
            kszm_telefon.Padding = new Padding(9, 6, 9, 6);
            kszm_telefon.Size = new Size(343, 30);
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
            kszm_email.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            kszm_email.Size = new Size(343, 30);
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
            kszm_utasNeve.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_utasNeve.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_utasNeve.HelyorzoSzin = Color.DarkGray;
            kszm_utasNeve.HelyorzoSzoveg = "Utas Neve";
            kszm_utasNeve.JelszoKarakter = false;
            kszm_utasNeve.KeretMeret = 2;
            kszm_utasNeve.KeretSugar = 8;
            kszm_utasNeve.KeretSzin = Color.MediumSlateBlue;
            kszm_utasNeve.Location = new Point(39, 45);
            kszm_utasNeve.Margin = new Padding(4, 3, 4, 3);
            kszm_utasNeve.Name = "kszm_utasNeve";
            kszm_utasNeve.Padding = new Padding(9, 6, 9, 6);
            kszm_utasNeve.Size = new Size(343, 30);
            kszm_utasNeve.TabIndex = 0;
            kszm_utasNeve.Texts = "";
            kszm_utasNeve.TobbSor = false;
            kszm_utasNeve._SzovegValtoztatva += kszm_AutoComplete;
            kszm_utasNeve.KeyDown += SzovegMezo_KeyDown;
            kszm_utasNeve.Leave += kszm_Leave;
            // 
            // ev_utasLista
            // 
            ev_utasLista.SarokSugar = 80;
            ev_utasLista.TargetControl = pnl_utasLista;
            // 
            // pnl_utasLista
            // 
            pnl_utasLista.BackColor = Color.FromArgb(243, 244, 246);
            pnl_utasLista.Controls.Add(lbl_utasLista);
            pnl_utasLista.Controls.Add(kg_UlNyomtatas);
            pnl_utasLista.Controls.Add(kg_kilepes);
            pnl_utasLista.Controls.Add(dgv_utasLista);
            pnl_utasLista.Controls.Add(kszm_vezetoNeve2);
            pnl_utasLista.Controls.Add(kszm_vezetoNeve1);
            pnl_utasLista.Controls.Add(kszm_jarmuSzama);
            pnl_utasLista.Controls.Add(kszm_datum);
            pnl_utasLista.Controls.Add(kszm_uticel);
            pnl_utasLista.Controls.Add(kszm_indulasHelye);
            pnl_utasLista.Location = new Point(761, 118);
            pnl_utasLista.Margin = new Padding(3, 2, 3, 2);
            pnl_utasLista.Name = "pnl_utasLista";
            pnl_utasLista.Size = new Size(741, 596);
            pnl_utasLista.TabIndex = 14;
            pnl_utasLista.Visible = false;
            // 
            // lbl_utasLista
            // 
            lbl_utasLista.AutoSize = true;
            lbl_utasLista.Font = new Font("Segoe UI", 19F);
            lbl_utasLista.Location = new Point(290, 2);
            lbl_utasLista.Name = "lbl_utasLista";
            lbl_utasLista.Size = new Size(120, 38);
            lbl_utasLista.TabIndex = 9;
            lbl_utasLista.Text = "Utaslista";
            // 
            // kg_UlNyomtatas
            // 
            kg_UlNyomtatas.BackColor = Color.MediumSlateBlue;
            kg_UlNyomtatas.BadgeMeret = 40;
            kg_UlNyomtatas.EgerTartasHatterSzine = Color.SlateBlue;
            kg_UlNyomtatas.ErtesitesMutatasa = false;
            kg_UlNyomtatas.ErtesitesSzam = 0;
            kg_UlNyomtatas.ErtesitesSzin = Color.Red;
            kg_UlNyomtatas.ErtesitesSzovegSzin = Color.White;
            kg_UlNyomtatas.FlatAppearance.BorderSize = 0;
            kg_UlNyomtatas.FlatStyle = FlatStyle.Flat;
            kg_UlNyomtatas.ForeColor = Color.White;
            kg_UlNyomtatas.HatterSzine = Color.MediumSlateBlue;
            kg_UlNyomtatas.KeretMeret = 0;
            kg_UlNyomtatas.KeretSzine = Color.PaleVioletRed;
            kg_UlNyomtatas.Location = new Point(479, 541);
            kg_UlNyomtatas.Margin = new Padding(3, 2, 3, 2);
            kg_UlNyomtatas.Name = "kg_UlNyomtatas";
            kg_UlNyomtatas.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_UlNyomtatas.SarokSugar = 8;
            kg_UlNyomtatas.Size = new Size(164, 43);
            kg_UlNyomtatas.SzovegSzine = Color.White;
            kg_UlNyomtatas.TabIndex = 8;
            kg_UlNyomtatas.Text = "Nyomtatás";
            kg_UlNyomtatas.UseVisualStyleBackColor = false;
            kg_UlNyomtatas.Click += kg_UlNyomtatas_Click;
            // 
            // kg_kilepes
            // 
            kg_kilepes.BackColor = Color.MediumSlateBlue;
            kg_kilepes.BadgeMeret = 40;
            kg_kilepes.EgerTartasHatterSzine = Color.SlateBlue;
            kg_kilepes.ErtesitesMutatasa = false;
            kg_kilepes.ErtesitesSzam = 0;
            kg_kilepes.ErtesitesSzin = Color.Red;
            kg_kilepes.ErtesitesSzovegSzin = Color.White;
            kg_kilepes.FlatAppearance.BorderSize = 0;
            kg_kilepes.FlatStyle = FlatStyle.Flat;
            kg_kilepes.ForeColor = Color.White;
            kg_kilepes.HatterSzine = Color.MediumSlateBlue;
            kg_kilepes.KeretMeret = 0;
            kg_kilepes.KeretSzine = Color.PaleVioletRed;
            kg_kilepes.Location = new Point(71, 542);
            kg_kilepes.Margin = new Padding(3, 2, 3, 2);
            kg_kilepes.Name = "kg_kilepes";
            kg_kilepes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_kilepes.SarokSugar = 8;
            kg_kilepes.Size = new Size(164, 43);
            kg_kilepes.SzovegSzine = Color.White;
            kg_kilepes.TabIndex = 7;
            kg_kilepes.Text = "Elrejtés";
            kg_kilepes.UseVisualStyleBackColor = false;
            kg_kilepes.Click += kg_kilepes_Click;
            // 
            // dgv_utasLista
            // 
            dgv_utasLista.BackgroundColor = SystemColors.ButtonFace;
            dgv_utasLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_utasLista.EnableHeadersVisualStyles = false;
            dgv_utasLista.GridColor = SystemColors.InfoText;
            dgv_utasLista.Location = new Point(73, 175);
            dgv_utasLista.Margin = new Padding(3, 2, 3, 2);
            dgv_utasLista.Name = "dgv_utasLista";
            dgv_utasLista.RowHeadersVisible = false;
            dgv_utasLista.RowHeadersWidth = 51;
            dgv_utasLista.Size = new Size(570, 342);
            dgv_utasLista.TabIndex = 6;
            // 
            // kszm_vezetoNeve2
            // 
            kszm_vezetoNeve2.AlahuzottStilus = false;
            kszm_vezetoNeve2.BackColor = SystemColors.Window;
            kszm_vezetoNeve2.FokuszKeretSzin = Color.HotPink;
            kszm_vezetoNeve2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_vezetoNeve2.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_vezetoNeve2.HelyorzoSzin = Color.DarkGray;
            kszm_vezetoNeve2.HelyorzoSzoveg = "Vezető Neve 2";
            kszm_vezetoNeve2.JelszoKarakter = false;
            kszm_vezetoNeve2.KeretMeret = 2;
            kszm_vezetoNeve2.KeretSugar = 8;
            kszm_vezetoNeve2.KeretSzin = Color.MediumSlateBlue;
            kszm_vezetoNeve2.Location = new Point(370, 122);
            kszm_vezetoNeve2.Margin = new Padding(4, 3, 4, 3);
            kszm_vezetoNeve2.Name = "kszm_vezetoNeve2";
            kszm_vezetoNeve2.Padding = new Padding(9, 6, 9, 6);
            kszm_vezetoNeve2.Size = new Size(273, 30);
            kszm_vezetoNeve2.TabIndex = 5;
            kszm_vezetoNeve2.Texts = "";
            kszm_vezetoNeve2.TobbSor = false;
            // 
            // kszm_vezetoNeve1
            // 
            kszm_vezetoNeve1.AlahuzottStilus = false;
            kszm_vezetoNeve1.BackColor = SystemColors.Window;
            kszm_vezetoNeve1.FokuszKeretSzin = Color.HotPink;
            kszm_vezetoNeve1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_vezetoNeve1.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_vezetoNeve1.HelyorzoSzin = Color.DarkGray;
            kszm_vezetoNeve1.HelyorzoSzoveg = "Vezető Neve 1";
            kszm_vezetoNeve1.JelszoKarakter = false;
            kszm_vezetoNeve1.KeretMeret = 2;
            kszm_vezetoNeve1.KeretSugar = 8;
            kszm_vezetoNeve1.KeretSzin = Color.MediumSlateBlue;
            kszm_vezetoNeve1.Location = new Point(73, 122);
            kszm_vezetoNeve1.Margin = new Padding(4, 3, 4, 3);
            kszm_vezetoNeve1.Name = "kszm_vezetoNeve1";
            kszm_vezetoNeve1.Padding = new Padding(9, 6, 9, 6);
            kszm_vezetoNeve1.Size = new Size(273, 30);
            kszm_vezetoNeve1.TabIndex = 4;
            kszm_vezetoNeve1.Texts = "";
            kszm_vezetoNeve1.TobbSor = false;
            // 
            // kszm_jarmuSzama
            // 
            kszm_jarmuSzama.AlahuzottStilus = false;
            kszm_jarmuSzama.BackColor = SystemColors.Window;
            kszm_jarmuSzama.FokuszKeretSzin = Color.HotPink;
            kszm_jarmuSzama.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_jarmuSzama.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_jarmuSzama.HelyorzoSzin = Color.DarkGray;
            kszm_jarmuSzama.HelyorzoSzoveg = "Jármű Száma";
            kszm_jarmuSzama.JelszoKarakter = false;
            kszm_jarmuSzama.KeretMeret = 2;
            kszm_jarmuSzama.KeretSugar = 8;
            kszm_jarmuSzama.KeretSzin = Color.MediumSlateBlue;
            kszm_jarmuSzama.Location = new Point(370, 83);
            kszm_jarmuSzama.Margin = new Padding(4, 3, 4, 3);
            kszm_jarmuSzama.Name = "kszm_jarmuSzama";
            kszm_jarmuSzama.Padding = new Padding(9, 6, 9, 6);
            kszm_jarmuSzama.Size = new Size(273, 30);
            kszm_jarmuSzama.TabIndex = 3;
            kszm_jarmuSzama.Texts = "";
            kszm_jarmuSzama.TobbSor = false;
            // 
            // kszm_datum
            // 
            kszm_datum.AlahuzottStilus = false;
            kszm_datum.BackColor = SystemColors.Window;
            kszm_datum.FokuszKeretSzin = Color.HotPink;
            kszm_datum.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_datum.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_datum.HelyorzoSzin = Color.DarkGray;
            kszm_datum.HelyorzoSzoveg = "Dátum";
            kszm_datum.JelszoKarakter = false;
            kszm_datum.KeretMeret = 2;
            kszm_datum.KeretSugar = 8;
            kszm_datum.KeretSzin = Color.MediumSlateBlue;
            kszm_datum.Location = new Point(73, 83);
            kszm_datum.Margin = new Padding(4, 3, 4, 3);
            kszm_datum.Name = "kszm_datum";
            kszm_datum.Padding = new Padding(9, 6, 9, 6);
            kszm_datum.Size = new Size(273, 30);
            kszm_datum.TabIndex = 2;
            kszm_datum.Texts = "";
            kszm_datum.TobbSor = false;
            // 
            // kszm_uticel
            // 
            kszm_uticel.AlahuzottStilus = false;
            kszm_uticel.BackColor = SystemColors.Window;
            kszm_uticel.FokuszKeretSzin = Color.HotPink;
            kszm_uticel.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_uticel.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_uticel.HelyorzoSzin = Color.DarkGray;
            kszm_uticel.HelyorzoSzoveg = "Úticél";
            kszm_uticel.JelszoKarakter = false;
            kszm_uticel.KeretMeret = 2;
            kszm_uticel.KeretSugar = 8;
            kszm_uticel.KeretSzin = Color.MediumSlateBlue;
            kszm_uticel.Location = new Point(370, 45);
            kszm_uticel.Margin = new Padding(4, 3, 4, 3);
            kszm_uticel.Name = "kszm_uticel";
            kszm_uticel.Padding = new Padding(9, 6, 9, 6);
            kszm_uticel.Size = new Size(273, 30);
            kszm_uticel.TabIndex = 1;
            kszm_uticel.Texts = "";
            kszm_uticel.TobbSor = false;
            // 
            // kszm_indulasHelye
            // 
            kszm_indulasHelye.AlahuzottStilus = false;
            kszm_indulasHelye.BackColor = SystemColors.Window;
            kszm_indulasHelye.FokuszKeretSzin = Color.HotPink;
            kszm_indulasHelye.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_indulasHelye.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_indulasHelye.HelyorzoSzin = Color.DarkGray;
            kszm_indulasHelye.HelyorzoSzoveg = "Indulás helye";
            kszm_indulasHelye.JelszoKarakter = false;
            kszm_indulasHelye.KeretMeret = 2;
            kszm_indulasHelye.KeretSugar = 8;
            kszm_indulasHelye.KeretSzin = Color.MediumSlateBlue;
            kszm_indulasHelye.Location = new Point(73, 45);
            kszm_indulasHelye.Margin = new Padding(4, 3, 4, 3);
            kszm_indulasHelye.Name = "kszm_indulasHelye";
            kszm_indulasHelye.Padding = new Padding(9, 6, 9, 6);
            kszm_indulasHelye.Size = new Size(273, 30);
            kszm_indulasHelye.TabIndex = 0;
            kszm_indulasHelye.Texts = "";
            kszm_indulasHelye.TobbSor = false;
            // 
            // rcb_desztinacio
            // 
            rcb_desztinacio.adatForras = null;
            rcb_desztinacio.BackColor = Color.Transparent;
            rcb_desztinacio.CimPanelAlsoSzin = Color.White;
            rcb_desztinacio.CimPanelFelsoSzin = Color.White;
            rcb_desztinacio.ComboText = "Desztináció";
            rcb_desztinacio.EgerTrartasSzin = Color.LightGray;
            rcb_desztinacio.ForeColor = Color.White;
            rcb_desztinacio.Ikon = (Image)resources.GetObject("rcb_desztinacio.Ikon");
            rcb_desztinacio.ItemHatterSzin = Color.WhiteSmoke;
            rcb_desztinacio.ItemPanelAlosSzin = Color.WhiteSmoke;
            rcb_desztinacio.ItemPanelFelsoSzin = Color.WhiteSmoke;
            rcb_desztinacio.KeretSzin = Color.BlueViolet;
            rcb_desztinacio.KeretVastagsag = 1.8F;
            rcb_desztinacio.KivalasztottElemSzin = Color.BlueViolet;
            rcb_desztinacio.LenyiloMagassag = 300;
            rcb_desztinacio.Location = new Point(9, 11);
            rcb_desztinacio.Margin = new Padding(0);
            rcb_desztinacio.MinimumSize = new Size(150, 0);
            rcb_desztinacio.Name = "rcb_desztinacio";
            rcb_desztinacio.Padding = new Padding(0, 0, 0, 6);
            rcb_desztinacio.Radius = 20;
            rcb_desztinacio.Size = new Size(262, 65);
            rcb_desztinacio.TabIndex = 7;
            rcb_desztinacio.TitleLabelSzin = Color.Black;
            rcb_desztinacio.ElemKivalasztva += rcb_desztinacio_ElemKivalasztva;
            // 
            // rcb_idoszak
            // 
            rcb_idoszak.adatForras = null;
            rcb_idoszak.BackColor = Color.Transparent;
            rcb_idoszak.CimPanelAlsoSzin = Color.White;
            rcb_idoszak.CimPanelFelsoSzin = Color.White;
            rcb_idoszak.ComboText = "Időszak";
            rcb_idoszak.EgerTrartasSzin = Color.LightGray;
            rcb_idoszak.ForeColor = Color.Transparent;
            rcb_idoszak.Ikon = (Image)resources.GetObject("rcb_idoszak.Ikon");
            rcb_idoszak.ImeMode = ImeMode.NoControl;
            rcb_idoszak.ItemHatterSzin = Color.WhiteSmoke;
            rcb_idoszak.ItemPanelAlosSzin = Color.WhiteSmoke;
            rcb_idoszak.ItemPanelFelsoSzin = Color.WhiteSmoke;
            rcb_idoszak.KeretSzin = Color.BlueViolet;
            rcb_idoszak.KeretVastagsag = 1.8F;
            rcb_idoszak.KivalasztottElemSzin = Color.BlueViolet;
            rcb_idoszak.LenyiloMagassag = 300;
            rcb_idoszak.Location = new Point(293, 11);
            rcb_idoszak.Margin = new Padding(0);
            rcb_idoszak.MinimumSize = new Size(150, 0);
            rcb_idoszak.Name = "rcb_idoszak";
            rcb_idoszak.Padding = new Padding(0, 0, 0, 6);
            rcb_idoszak.Radius = 20;
            rcb_idoszak.Size = new Size(262, 65);
            rcb_idoszak.TabIndex = 6;
            rcb_idoszak.TitleLabelSzin = Color.Black;
            rcb_idoszak.ElemKivalasztva += rcb_idoszak_ElemKivalasztva;
            // 
            // dgv_utazasok
            // 
            dgv_utazasok.AllowUserToAddRows = false;
            dgv_utazasok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_utazasok.BackgroundColor = SystemColors.ControlLightLight;
            dgv_utazasok.BorderStyle = BorderStyle.None;
            dgv_utazasok.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgv_utazasok.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_utazasok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_utazasok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle5.SelectionForeColor = Color.BlueViolet;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_utazasok.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_utazasok.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv_utazasok.EnableHeadersVisualStyles = false;
            dgv_utazasok.GridColor = SystemColors.InactiveBorder;
            dgv_utazasok.Location = new Point(9, 79);
            dgv_utazasok.Name = "dgv_utazasok";
            dgv_utazasok.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_utazasok.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_utazasok.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv_utazasok.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv_utazasok.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgv_utazasok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_utazasok.ShowEditingIcon = false;
            dgv_utazasok.ShowRowErrors = false;
            dgv_utazasok.Size = new Size(940, 543);
            dgv_utazasok.TabIndex = 9;
            dgv_utazasok.CellMouseEnter += dataGridView1_CellMouseEnter;
            dgv_utazasok.CellValueChanged += dgv_utazasok_CellValueChanged;
            dgv_utazasok.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // rcb_utazasNeve
            // 
            rcb_utazasNeve.adatForras = null;
            rcb_utazasNeve.BackColor = Color.Transparent;
            rcb_utazasNeve.CimPanelAlsoSzin = Color.White;
            rcb_utazasNeve.CimPanelFelsoSzin = Color.White;
            rcb_utazasNeve.ComboText = "Utazás neve";
            rcb_utazasNeve.EgerTrartasSzin = Color.LightGray;
            rcb_utazasNeve.ForeColor = Color.White;
            rcb_utazasNeve.Ikon = (Image)resources.GetObject("rcb_utazasNeve.Ikon");
            rcb_utazasNeve.ItemHatterSzin = Color.WhiteSmoke;
            rcb_utazasNeve.ItemPanelAlosSzin = Color.WhiteSmoke;
            rcb_utazasNeve.ItemPanelFelsoSzin = Color.WhiteSmoke;
            rcb_utazasNeve.KeretSzin = Color.BlueViolet;
            rcb_utazasNeve.KeretVastagsag = 1.8F;
            rcb_utazasNeve.KivalasztottElemSzin = Color.BlueViolet;
            rcb_utazasNeve.LenyiloMagassag = 300;
            rcb_utazasNeve.Location = new Point(595, 8);
            rcb_utazasNeve.Margin = new Padding(0);
            rcb_utazasNeve.MinimumSize = new Size(150, 0);
            rcb_utazasNeve.Name = "rcb_utazasNeve";
            rcb_utazasNeve.Padding = new Padding(0, 0, 0, 6);
            rcb_utazasNeve.Radius = 20;
            rcb_utazasNeve.Size = new Size(262, 65);
            rcb_utazasNeve.TabIndex = 8;
            rcb_utazasNeve.TitleLabelSzin = Color.Black;
            rcb_utazasNeve.ElemKivalasztva += rcb_utazasNeve_ElemKivalasztva;
            // 
            // pnl_vezerlok
            // 
            pnl_vezerlok.BackColor = Color.DarkViolet;
            pnl_vezerlok.Controls.Add(kszm_torles);
            pnl_vezerlok.Controls.Add(kg_szures);
            pnl_vezerlok.Controls.Add(kszm_nyomtatas);
            pnl_vezerlok.Controls.Add(kszm_utasLista);
            pnl_vezerlok.Controls.Add(btn_mentes);
            pnl_vezerlok.Dock = DockStyle.Bottom;
            pnl_vezerlok.ForeColor = Color.CadetBlue;
            pnl_vezerlok.Location = new Point(0, 768);
            pnl_vezerlok.Margin = new Padding(3, 2, 3, 2);
            pnl_vezerlok.Name = "pnl_vezerlok";
            pnl_vezerlok.Size = new Size(999, 59);
            pnl_vezerlok.TabIndex = 10;
            // 
            // kszm_torles
            // 
            kszm_torles.BackColor = Color.MediumSlateBlue;
            kszm_torles.BadgeMeret = 40;
            kszm_torles.EgerTartasHatterSzine = Color.Crimson;
            kszm_torles.ErtesitesMutatasa = false;
            kszm_torles.ErtesitesSzam = 0;
            kszm_torles.ErtesitesSzin = Color.Red;
            kszm_torles.ErtesitesSzovegSzin = Color.White;
            kszm_torles.FlatAppearance.BorderSize = 0;
            kszm_torles.FlatStyle = FlatStyle.Flat;
            kszm_torles.Font = new Font("Segoe UI", 12F);
            kszm_torles.ForeColor = Color.White;
            kszm_torles.HatterSzine = Color.MediumSlateBlue;
            kszm_torles.Image = (Image)resources.GetObject("kszm_torles.Image");
            kszm_torles.ImageAlign = ContentAlignment.MiddleRight;
            kszm_torles.KeretMeret = 0;
            kszm_torles.KeretSzine = Color.PaleVioletRed;
            kszm_torles.Location = new Point(741, 6);
            kszm_torles.Margin = new Padding(3, 2, 3, 2);
            kszm_torles.Name = "kszm_torles";
            kszm_torles.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_torles.SarokSugar = 10;
            kszm_torles.Size = new Size(182, 43);
            kszm_torles.SzovegSzine = Color.White;
            kszm_torles.TabIndex = 5;
            kszm_torles.Text = "Utazásból törlés";
            kszm_torles.TextImageRelation = TextImageRelation.ImageBeforeText;
            kszm_torles.UseVisualStyleBackColor = false;
            kszm_torles.Click += kszm_torles_Click;
            // 
            // kg_szures
            // 
            kg_szures.BackColor = Color.MediumSlateBlue;
            kg_szures.BadgeMeret = 20;
            kg_szures.EgerTartasHatterSzine = Color.SlateBlue;
            kg_szures.ErtesitesMutatasa = true;
            kg_szures.ErtesitesSzam = 0;
            kg_szures.ErtesitesSzin = Color.Red;
            kg_szures.ErtesitesSzovegSzin = Color.White;
            kg_szures.FlatAppearance.BorderSize = 0;
            kg_szures.FlatStyle = FlatStyle.Flat;
            kg_szures.Font = new Font("Segoe UI", 12F);
            kg_szures.ForeColor = Color.White;
            kg_szures.HatterSzine = Color.MediumSlateBlue;
            kg_szures.Image = (Image)resources.GetObject("kg_szures.Image");
            kg_szures.ImageAlign = ContentAlignment.MiddleRight;
            kg_szures.KeretMeret = 0;
            kg_szures.KeretSzine = Color.PaleVioletRed;
            kg_szures.Location = new Point(189, 6);
            kg_szures.Margin = new Padding(3, 2, 3, 2);
            kg_szures.Name = "kg_szures";
            kg_szures.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_szures.SarokSugar = 10;
            kg_szures.Size = new Size(164, 43);
            kg_szures.SzovegSzine = Color.White;
            kg_szures.TabIndex = 4;
            kg_szures.Text = "Szűrés";
            kg_szures.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_szures.UseVisualStyleBackColor = false;
            kg_szures.Click += kerekitettGomb2_Click;
            // 
            // kszm_nyomtatas
            // 
            kszm_nyomtatas.BackColor = Color.MediumSlateBlue;
            kszm_nyomtatas.BadgeMeret = 40;
            kszm_nyomtatas.EgerTartasHatterSzine = Color.SlateBlue;
            kszm_nyomtatas.ErtesitesMutatasa = false;
            kszm_nyomtatas.ErtesitesSzam = 0;
            kszm_nyomtatas.ErtesitesSzin = Color.Red;
            kszm_nyomtatas.ErtesitesSzovegSzin = Color.White;
            kszm_nyomtatas.FlatAppearance.BorderSize = 0;
            kszm_nyomtatas.FlatStyle = FlatStyle.Flat;
            kszm_nyomtatas.Font = new Font("Segoe UI", 12F);
            kszm_nyomtatas.ForeColor = Color.White;
            kszm_nyomtatas.HatterSzine = Color.MediumSlateBlue;
            kszm_nyomtatas.Image = (Image)resources.GetObject("kszm_nyomtatas.Image");
            kszm_nyomtatas.ImageAlign = ContentAlignment.MiddleRight;
            kszm_nyomtatas.KeretMeret = 0;
            kszm_nyomtatas.KeretSzine = Color.PaleVioletRed;
            kszm_nyomtatas.Location = new Point(572, 6);
            kszm_nyomtatas.Margin = new Padding(3, 2, 3, 2);
            kszm_nyomtatas.Name = "kszm_nyomtatas";
            kszm_nyomtatas.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_nyomtatas.SarokSugar = 10;
            kszm_nyomtatas.Size = new Size(164, 43);
            kszm_nyomtatas.SzovegSzine = Color.White;
            kszm_nyomtatas.TabIndex = 3;
            kszm_nyomtatas.Text = "Nyomtatás";
            kszm_nyomtatas.TextImageRelation = TextImageRelation.ImageBeforeText;
            kszm_nyomtatas.UseVisualStyleBackColor = false;
            kszm_nyomtatas.Click += kszm_nyomtatas_Click;
            // 
            // kszm_utasLista
            // 
            kszm_utasLista.BackColor = Color.MediumSlateBlue;
            kszm_utasLista.BadgeMeret = 40;
            kszm_utasLista.EgerTartasHatterSzine = Color.SlateBlue;
            kszm_utasLista.ErtesitesMutatasa = false;
            kszm_utasLista.ErtesitesSzam = 0;
            kszm_utasLista.ErtesitesSzin = Color.Red;
            kszm_utasLista.ErtesitesSzovegSzin = Color.White;
            kszm_utasLista.FlatAppearance.BorderSize = 0;
            kszm_utasLista.FlatStyle = FlatStyle.Flat;
            kszm_utasLista.Font = new Font("Segoe UI", 12F);
            kszm_utasLista.ForeColor = Color.White;
            kszm_utasLista.HatterSzine = Color.MediumSlateBlue;
            kszm_utasLista.Image = (Image)resources.GetObject("kszm_utasLista.Image");
            kszm_utasLista.ImageAlign = ContentAlignment.MiddleRight;
            kszm_utasLista.KeretMeret = 0;
            kszm_utasLista.KeretSzine = Color.PaleVioletRed;
            kszm_utasLista.Location = new Point(368, 6);
            kszm_utasLista.Margin = new Padding(3, 2, 3, 2);
            kszm_utasLista.Name = "kszm_utasLista";
            kszm_utasLista.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_utasLista.RightToLeft = RightToLeft.No;
            kszm_utasLista.SarokSugar = 10;
            kszm_utasLista.Size = new Size(189, 43);
            kszm_utasLista.SzovegSzine = Color.White;
            kszm_utasLista.TabIndex = 1;
            kszm_utasLista.Text = "Utaslista készítése";
            kszm_utasLista.TextImageRelation = TextImageRelation.ImageBeforeText;
            kszm_utasLista.UseVisualStyleBackColor = false;
            kszm_utasLista.Click += kerekitettGomb3_Click;
            // 
            // btn_mentes
            // 
            btn_mentes.BackColor = Color.MediumSlateBlue;
            btn_mentes.BadgeMeret = 40;
            btn_mentes.EgerTartasHatterSzine = Color.SlateBlue;
            btn_mentes.ErtesitesMutatasa = false;
            btn_mentes.ErtesitesSzam = 0;
            btn_mentes.ErtesitesSzin = Color.Red;
            btn_mentes.ErtesitesSzovegSzin = Color.White;
            btn_mentes.FlatAppearance.BorderSize = 0;
            btn_mentes.FlatStyle = FlatStyle.Flat;
            btn_mentes.Font = new Font("Segoe UI", 12F);
            btn_mentes.ForeColor = Color.White;
            btn_mentes.HatterSzine = Color.MediumSlateBlue;
            btn_mentes.Image = (Image)resources.GetObject("btn_mentes.Image");
            btn_mentes.ImageAlign = ContentAlignment.MiddleRight;
            btn_mentes.KeretMeret = 0;
            btn_mentes.KeretSzine = Color.MediumVioletRed;
            btn_mentes.Location = new Point(10, 6);
            btn_mentes.Margin = new Padding(3, 2, 3, 2);
            btn_mentes.Name = "btn_mentes";
            btn_mentes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_mentes.RightToLeft = RightToLeft.No;
            btn_mentes.SarokSugar = 10;
            btn_mentes.Size = new Size(164, 43);
            btn_mentes.SzovegSzine = Color.White;
            btn_mentes.TabIndex = 0;
            btn_mentes.Text = "Mentés";
            btn_mentes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_mentes.UseVisualStyleBackColor = false;
            btn_mentes.Click += btn_mentes_Click;
            // 
            // ev_vezerloPanel
            // 
            ev_vezerloPanel.SarokSugar = 20;
            ev_vezerloPanel.TargetControl = pnl_vezerlok;
            // 
            // pd_utasLista
            // 
            pd_utasLista.PrintPage += pd_utasLista_PrintPage;
            // 
            // ppd_utasLista
            // 
            ppd_utasLista.AutoScrollMargin = new Size(0, 0);
            ppd_utasLista.AutoScrollMinSize = new Size(0, 0);
            ppd_utasLista.ClientSize = new Size(400, 300);
            ppd_utasLista.Enabled = true;
            ppd_utasLista.Icon = (Icon)resources.GetObject("ppd_utasLista.Icon");
            ppd_utasLista.Name = "ppd_utasLista";
            ppd_utasLista.Visible = false;
            // 
            // pd_utazasok
            // 
            pd_utazasok.PrintPage += pd_utazasok_PrintPage;
            // 
            // kszm_allampolgarsag
            // 
            kszm_allampolgarsag.AlahuzottStilus = false;
            kszm_allampolgarsag.BackColor = SystemColors.Window;
            kszm_allampolgarsag.FokuszKeretSzin = Color.HotPink;
            kszm_allampolgarsag.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            kszm_allampolgarsag.Size = new Size(343, 30);
            kszm_allampolgarsag.TabIndex = 15;
            kszm_allampolgarsag.Texts = "";
            kszm_allampolgarsag.TobbSor = true;
            // 
            // Frm_UtazasokMegtekintese
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(999, 827);
            Controls.Add(pnl_utasLista);
            Controls.Add(szpn_szuroPanel);
            Controls.Add(pnl_vezerlok);
            Controls.Add(rcb_idoszak);
            Controls.Add(rcb_desztinacio);
            Controls.Add(dgv_utazasok);
            Controls.Add(rcb_utazasNeve);
            Name = "Frm_UtazasokMegtekintese";
            Text = "Utazasok";
            Load += Frm_UtazasokMegtekintese_Load_1;
            Resize += Frm_UtazasokMegtekintese_Resize;
            szpn_szuroPanel.ResumeLayout(false);
            szpn_szuroPanel.PerformLayout();
            pnl_utasLista.ResumeLayout(false);
            pnl_utasLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_utasLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_utazasok).EndInit();
            pnl_vezerlok.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Frm_UtazasokMegtekintese_Load_1(object sender, EventArgs e)
        {
            szpn_szuroPanel.Visible = false;
            dgv_utazasok.SendToBack();
            vizualisrendezes();
            utazasok_betoltes();


        }

        #endregion

        private kerekitettLenyilloMenu rcb_desztinacio;
        private kerekitettLenyilloMenu rcb_idoszak;
        private DoubleBufferedDataGridView dgv_utazasok;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private KerekitettGomb kg_kilepes;
        private kerekitettLenyilloMenu rcb_utazasNeve;
        private Panel pnl_vezerlok;
        private KerekitettGomb kszm_nyomtatas;
        private KerekitettGomb kszm_utasLista;
        private KerekitettGomb btn_mentes;
        private KerekitettGomb kg_szures;
        private kerekitettSzovegMezo kszm_utasNeve;
        private kerekitettSzovegMezo kszm_email;
        private kerekitettSzovegMezo kszm_telefon;
        private kerekitettSzovegMezo kszm_lakcim;
        private kerekitettSzovegMezo kszm_okmanySzam;
        private Panel szpn_szuroPanel;
        private kerekitettSzovegMezo kszm_megjegyzes;
        private Label lbl_okmanyErvenyes;
        private Label lbl_biztositas;
     
  
        private Label lbl_befizetes;
        private KerekitettGomb kg_pipa;
        
        public ellipszisVezerlo ev_szuroPanel;
        private ellipszisVezerlo ev_vezerloPanel;
        private KapcsoloGomb kb_okmanyErvenyes;
        private KapcsoloGomb kb_biztositas;
        private KapcsoloGomb kb_befizetes;
        private Panel pnl_utasLista;
        private kerekitettSzovegMezo kszm_indulasHelye;
        private kerekitettSzovegMezo kszm_jarmuSzama;
        private kerekitettSzovegMezo kszm_datum;
        private kerekitettSzovegMezo kszm_uticel;
        private kerekitettSzovegMezo kszm_vezetoNeve2;
        private kerekitettSzovegMezo kszm_vezetoNeve1;
        private DoubleBufferedDataGridView  dgv_utasLista;
        private KerekitettGomb kg_UlNyomtatas;
        private ellipszisVezerlo ev_utasLista;
        private Label lbl_utasLista;
        private System.Drawing.Printing.PrintDocument pd_utasLista;
        private PrintPreviewDialog ppd_utasLista;
        private System.Drawing.Printing.PrintDocument pd_utazasok;
        private KerekitettGomb kszm_torles;
        private kerekitettLenyilloMenu klm_utazasiMod;
        private kerekitettSzovegMezo kszm_allampolgarsag;
    }
}