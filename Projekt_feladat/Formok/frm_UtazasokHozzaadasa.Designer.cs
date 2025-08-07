namespace Projekt_feladat.Formok
{
    partial class frm_UtazasokHozzaadasa
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
            egyeni_vezerlok.ellipszisVezerlo ev_torles;
            egyeni_vezerlok.ellipszisVezerlo ev_vezerloPanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UtazasokHozzaadasa));
            pnl_torles = new Panel();
            kg_nem = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kg_igen = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            lb_utazas = new Label();
            lb_torolni = new Label();
            pnl_vezerlopanel = new Panel();
            kszm_ujRegiFelhasznalo = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kszm_utazasTorles = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kszm_desztinacio = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_utazasElnevezese = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            dt_datumvalaszto = new DateTimePicker();
            kszm_hozzaadas = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            rcb_desztinacio = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            rcb_utazasIdeje = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            rcb_utazasElnevezese = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            kg_utazasTorlese = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            tlp_utazasTorlese = new TableLayoutPanel();
            tlp_utazasHozzaadasa = new TableLayoutPanel();
            kg_boritoValasztas = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            tableLayoutPanel2 = new TableLayoutPanel();
            kerekitettSzovegMezo1 = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            bufferedLabel1 = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            kszm_ar = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            bl_ar = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            tlp_leiras = new TableLayoutPanel();
            bl_leiras = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            kszm_leiras = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            tlp_erkezesiDatum = new TableLayoutPanel();
            bl_erkezesiDatum = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            dtp_erkezesiDatum = new DateTimePicker();
            tlp_utazasIdeje = new TableLayoutPanel();
            bl_utazasIdeje = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            pictureBox1 = new PictureBox();
            ev_torles = new Projekt_feladat.egyeni_vezerlok.ellipszisVezerlo();
            ev_vezerloPanel = new Projekt_feladat.egyeni_vezerlok.ellipszisVezerlo();
            pnl_torles.SuspendLayout();
            pnl_vezerlopanel.SuspendLayout();
            tlp_utazasTorlese.SuspendLayout();
            tlp_utazasHozzaadasa.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tlp_leiras.SuspendLayout();
            tlp_erkezesiDatum.SuspendLayout();
            tlp_utazasIdeje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ev_torles
            // 
            ev_torles.SarokSugar = 80;
            ev_torles.TargetControl = pnl_torles;
            // 
            // pnl_torles
            // 
            pnl_torles.BackColor = Color.WhiteSmoke;
            pnl_torles.Controls.Add(kg_nem);
            pnl_torles.Controls.Add(kg_igen);
            pnl_torles.Controls.Add(lb_utazas);
            pnl_torles.Controls.Add(lb_torolni);
            pnl_torles.Location = new Point(1056, 19);
            pnl_torles.Margin = new Padding(3, 2, 3, 2);
            pnl_torles.Name = "pnl_torles";
            pnl_torles.Size = new Size(454, 219);
            pnl_torles.TabIndex = 11;
            pnl_torles.Visible = false;
            // 
            // kg_nem
            // 
            kg_nem.BackColor = Color.MediumSlateBlue;
            kg_nem.EgerTartasHatterSzine = Color.SlateBlue;
            kg_nem.FlatAppearance.BorderSize = 0;
            kg_nem.FlatStyle = FlatStyle.Flat;
            kg_nem.ForeColor = Color.White;
            kg_nem.HatterSzine = Color.MediumSlateBlue;
            kg_nem.KeretMeret = 0;
            kg_nem.KeretSzine = Color.PaleVioletRed;
            kg_nem.Location = new Point(239, 139);
            kg_nem.Margin = new Padding(3, 2, 3, 2);
            kg_nem.Name = "kg_nem";
            kg_nem.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_nem.SarokSugar = 8;
            kg_nem.Size = new Size(164, 43);
            kg_nem.SzovegSzine = Color.White;
            kg_nem.TabIndex = 3;
            kg_nem.Text = "Nem";
            kg_nem.UseVisualStyleBackColor = false;
            kg_nem.Click += kg_nem_Click;
            // 
            // kg_igen
            // 
            kg_igen.BackColor = Color.Crimson;
            kg_igen.EgerTartasHatterSzine = Color.SlateBlue;
            kg_igen.FlatAppearance.BorderSize = 0;
            kg_igen.FlatStyle = FlatStyle.Flat;
            kg_igen.ForeColor = Color.White;
            kg_igen.HatterSzine = Color.Crimson;
            kg_igen.KeretMeret = 0;
            kg_igen.KeretSzine = Color.PaleVioletRed;
            kg_igen.Location = new Point(44, 139);
            kg_igen.Margin = new Padding(3, 2, 3, 2);
            kg_igen.Name = "kg_igen";
            kg_igen.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_igen.SarokSugar = 8;
            kg_igen.Size = new Size(164, 43);
            kg_igen.SzovegSzine = Color.White;
            kg_igen.TabIndex = 2;
            kg_igen.Text = "Igen";
            kg_igen.UseVisualStyleBackColor = false;
            kg_igen.Click += kg_igen_Click;
            // 
            // lb_utazas
            // 
            lb_utazas.AutoSize = true;
            lb_utazas.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lb_utazas.Location = new Point(59, 67);
            lb_utazas.Name = "lb_utazas";
            lb_utazas.Size = new Size(0, 30);
            lb_utazas.TabIndex = 1;
            // 
            // lb_torolni
            // 
            lb_torolni.AutoSize = true;
            lb_torolni.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lb_torolni.Location = new Point(59, 28);
            lb_torolni.Name = "lb_torolni";
            lb_torolni.Size = new Size(364, 30);
            lb_torolni.TabIndex = 0;
            lb_torolni.Text = "Ön törölni készül a következő utazást:";
            // 
            // ev_vezerloPanel
            // 
            ev_vezerloPanel.SarokSugar = 8;
            ev_vezerloPanel.TargetControl = pnl_vezerlopanel;
            // 
            // pnl_vezerlopanel
            // 
            pnl_vezerlopanel.BackColor = Color.DarkViolet;
            pnl_vezerlopanel.Controls.Add(kszm_ujRegiFelhasznalo);
            pnl_vezerlopanel.Controls.Add(kszm_utazasTorles);
            pnl_vezerlopanel.Dock = DockStyle.Bottom;
            pnl_vezerlopanel.Location = new Point(0, 535);
            pnl_vezerlopanel.Name = "pnl_vezerlopanel";
            pnl_vezerlopanel.Size = new Size(1075, 52);
            pnl_vezerlopanel.TabIndex = 13;
            // 
            // kszm_ujRegiFelhasznalo
            // 
            kszm_ujRegiFelhasznalo.BackColor = Color.Peru;
            kszm_ujRegiFelhasznalo.EgerTartasHatterSzine = Color.SlateBlue;
            kszm_ujRegiFelhasznalo.FlatAppearance.BorderSize = 0;
            kszm_ujRegiFelhasznalo.FlatStyle = FlatStyle.Flat;
            kszm_ujRegiFelhasznalo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_ujRegiFelhasznalo.ForeColor = Color.White;
            kszm_ujRegiFelhasznalo.HatterSzine = Color.Peru;
            kszm_ujRegiFelhasznalo.Image = (Image)resources.GetObject("kszm_ujRegiFelhasznalo.Image");
            kszm_ujRegiFelhasznalo.ImageAlign = ContentAlignment.TopCenter;
            kszm_ujRegiFelhasznalo.KeretMeret = 0;
            kszm_ujRegiFelhasznalo.KeretSzine = Color.PaleVioletRed;
            kszm_ujRegiFelhasznalo.Location = new Point(18, 10);
            kszm_ujRegiFelhasznalo.Name = "kszm_ujRegiFelhasznalo";
            kszm_ujRegiFelhasznalo.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_ujRegiFelhasznalo.SarokSugar = 8;
            kszm_ujRegiFelhasznalo.Size = new Size(251, 35);
            kszm_ujRegiFelhasznalo.SzovegSzine = Color.White;
            kszm_ujRegiFelhasznalo.TabIndex = 1;
            kszm_ujRegiFelhasznalo.Text = "Új hozzáadása";
            kszm_ujRegiFelhasznalo.TextImageRelation = TextImageRelation.ImageBeforeText;
            kszm_ujRegiFelhasznalo.UseVisualStyleBackColor = false;
            kszm_ujRegiFelhasznalo.Click += kszm_ujRegiFelhasznalo_Click;
            // 
            // kszm_utazasTorles
            // 
            kszm_utazasTorles.BackColor = Color.Crimson;
            kszm_utazasTorles.EgerTartasHatterSzine = Color.SlateBlue;
            kszm_utazasTorles.FlatAppearance.BorderSize = 0;
            kszm_utazasTorles.FlatStyle = FlatStyle.Flat;
            kszm_utazasTorles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_utazasTorles.ForeColor = Color.White;
            kszm_utazasTorles.HatterSzine = Color.Crimson;
            kszm_utazasTorles.Image = (Image)resources.GetObject("kszm_utazasTorles.Image");
            kszm_utazasTorles.ImageAlign = ContentAlignment.MiddleRight;
            kszm_utazasTorles.KeretMeret = 0;
            kszm_utazasTorles.KeretSzine = Color.PaleVioletRed;
            kszm_utazasTorles.Location = new Point(289, 10);
            kszm_utazasTorles.Name = "kszm_utazasTorles";
            kszm_utazasTorles.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_utazasTorles.SarokSugar = 8;
            kszm_utazasTorles.Size = new Size(237, 35);
            kszm_utazasTorles.SzovegSzine = Color.White;
            kszm_utazasTorles.TabIndex = 0;
            kszm_utazasTorles.Text = "Meglévő utazás törlése";
            kszm_utazasTorles.TextAlign = ContentAlignment.MiddleLeft;
            kszm_utazasTorles.TextImageRelation = TextImageRelation.ImageBeforeText;
            kszm_utazasTorles.UseVisualStyleBackColor = false;
            kszm_utazasTorles.Click += kszm_utazasTorles_Click;
            // 
            // kszm_desztinacio
            // 
            kszm_desztinacio.AlahuzottStilus = false;
            kszm_desztinacio.BackColor = SystemColors.Window;
            kszm_desztinacio.Dock = DockStyle.Top;
            kszm_desztinacio.FokuszKeretSzin = Color.HotPink;
            kszm_desztinacio.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_desztinacio.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_desztinacio.HelyorzoSzin = Color.DarkGray;
            kszm_desztinacio.HelyorzoSzoveg = "Densztináció";
            kszm_desztinacio.JelszoKarakter = false;
            kszm_desztinacio.KeretMeret = 2;
            kszm_desztinacio.KeretSugar = 8;
            kszm_desztinacio.KeretSzin = Color.MediumSlateBlue;
            kszm_desztinacio.Location = new Point(4, 3);
            kszm_desztinacio.Margin = new Padding(4, 3, 4, 3);
            kszm_desztinacio.Name = "kszm_desztinacio";
            kszm_desztinacio.Padding = new Padding(9, 6, 9, 6);
            kszm_desztinacio.Size = new Size(529, 38);
            kszm_desztinacio.TabIndex = 0;
            kszm_desztinacio.Texts = "";
            kszm_desztinacio.TobbSor = false;
            // 
            // kszm_utazasElnevezese
            // 
            kszm_utazasElnevezese.AlahuzottStilus = false;
            kszm_utazasElnevezese.BackColor = SystemColors.Window;
            kszm_utazasElnevezese.Dock = DockStyle.Top;
            kszm_utazasElnevezese.FokuszKeretSzin = Color.HotPink;
            kszm_utazasElnevezese.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_utazasElnevezese.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_utazasElnevezese.HelyorzoSzin = Color.DarkGray;
            kszm_utazasElnevezese.HelyorzoSzoveg = "Utazás Elnevezése";
            kszm_utazasElnevezese.JelszoKarakter = false;
            kszm_utazasElnevezese.KeretMeret = 2;
            kszm_utazasElnevezese.KeretSugar = 8;
            kszm_utazasElnevezese.KeretSzin = Color.MediumSlateBlue;
            kszm_utazasElnevezese.Location = new Point(541, 3);
            kszm_utazasElnevezese.Margin = new Padding(4, 3, 4, 3);
            kszm_utazasElnevezese.Name = "kszm_utazasElnevezese";
            kszm_utazasElnevezese.Padding = new Padding(9, 6, 9, 6);
            kszm_utazasElnevezese.Size = new Size(530, 38);
            kszm_utazasElnevezese.TabIndex = 1;
            kszm_utazasElnevezese.Texts = "";
            kszm_utazasElnevezese.TobbSor = false;
            // 
            // dt_datumvalaszto
            // 
            dt_datumvalaszto.CalendarFont = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dt_datumvalaszto.CalendarMonthBackground = Color.SlateBlue;
            dt_datumvalaszto.CalendarTitleBackColor = Color.SlateBlue;
            dt_datumvalaszto.CalendarTrailingForeColor = Color.SlateBlue;
            dt_datumvalaszto.Dock = DockStyle.Fill;
            dt_datumvalaszto.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dt_datumvalaszto.Location = new Point(202, 2);
            dt_datumvalaszto.Margin = new Padding(3, 2, 3, 2);
            dt_datumvalaszto.Name = "dt_datumvalaszto";
            dt_datumvalaszto.Size = new Size(326, 35);
            dt_datumvalaszto.TabIndex = 2;
            // 
            // kszm_hozzaadas
            // 
            kszm_hozzaadas.BackColor = Color.MediumSlateBlue;
            kszm_hozzaadas.EgerTartasHatterSzine = Color.SlateBlue;
            kszm_hozzaadas.FlatAppearance.BorderSize = 0;
            kszm_hozzaadas.FlatStyle = FlatStyle.Flat;
            kszm_hozzaadas.Font = new Font("Segoe UI", 14F);
            kszm_hozzaadas.ForeColor = Color.White;
            kszm_hozzaadas.HatterSzine = Color.MediumSlateBlue;
            kszm_hozzaadas.Image = (Image)resources.GetObject("kszm_hozzaadas.Image");
            kszm_hozzaadas.ImageAlign = ContentAlignment.MiddleRight;
            kszm_hozzaadas.KeretMeret = 0;
            kszm_hozzaadas.KeretSzine = Color.PaleVioletRed;
            kszm_hozzaadas.Location = new Point(3, 467);
            kszm_hozzaadas.Margin = new Padding(3, 2, 3, 2);
            kszm_hozzaadas.Name = "kszm_hozzaadas";
            kszm_hozzaadas.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_hozzaadas.SarokSugar = 15;
            kszm_hozzaadas.Size = new Size(247, 54);
            kszm_hozzaadas.SzovegSzine = Color.White;
            kszm_hozzaadas.TabIndex = 3;
            kszm_hozzaadas.Text = "Hozzáadás";
            kszm_hozzaadas.TextImageRelation = TextImageRelation.ImageBeforeText;
            kszm_hozzaadas.UseVisualStyleBackColor = false;
            kszm_hozzaadas.Click += kszm_hozzaadas_Click;
            // 
            // rcb_desztinacio
            // 
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
            rcb_desztinacio.Location = new Point(10, 10);
            rcb_desztinacio.Margin = new Padding(10, 10, 0, 0);
            rcb_desztinacio.MinimumSize = new Size(150, 0);
            rcb_desztinacio.Name = "rcb_desztinacio";
            rcb_desztinacio.Padding = new Padding(0, 0, 0, 11);
            rcb_desztinacio.Radius = 20;
            rcb_desztinacio.Size = new Size(304, 65);
            rcb_desztinacio.TabIndex = 7;
            rcb_desztinacio.TitleLabelSzin = Color.Black;
            rcb_desztinacio.ElemKivalasztva += rcb_desztinacio_ElemKivalasztva;
            rcb_desztinacio.Load += rcb_desztinacio_Load;
            // 
            // rcb_utazasIdeje
            // 
            rcb_utazasIdeje.BackColor = Color.Transparent;
            rcb_utazasIdeje.CimPanelAlsoSzin = Color.White;
            rcb_utazasIdeje.CimPanelFelsoSzin = Color.White;
            rcb_utazasIdeje.ComboText = "Utazás ideje";
            rcb_utazasIdeje.EgerTrartasSzin = Color.LightGray;
            rcb_utazasIdeje.ForeColor = Color.White;
            rcb_utazasIdeje.Ikon = (Image)resources.GetObject("rcb_utazasIdeje.Ikon");
            rcb_utazasIdeje.ItemHatterSzin = Color.WhiteSmoke;
            rcb_utazasIdeje.ItemPanelAlosSzin = Color.WhiteSmoke;
            rcb_utazasIdeje.ItemPanelFelsoSzin = Color.WhiteSmoke;
            rcb_utazasIdeje.KeretSzin = Color.BlueViolet;
            rcb_utazasIdeje.KeretVastagsag = 1.8F;
            rcb_utazasIdeje.KivalasztottElemSzin = Color.BlueViolet;
            rcb_utazasIdeje.LenyiloMagassag = 300;
            rcb_utazasIdeje.Location = new Point(368, 10);
            rcb_utazasIdeje.Margin = new Padding(10, 10, 0, 0);
            rcb_utazasIdeje.MinimumSize = new Size(150, 0);
            rcb_utazasIdeje.Name = "rcb_utazasIdeje";
            rcb_utazasIdeje.Padding = new Padding(0, 0, 0, 11);
            rcb_utazasIdeje.Radius = 20;
            rcb_utazasIdeje.Size = new Size(304, 65);
            rcb_utazasIdeje.TabIndex = 8;
            rcb_utazasIdeje.TitleLabelSzin = Color.Black;
            rcb_utazasIdeje.ElemKivalasztva += rcb_idoszak_ElemKivalasztva;
            rcb_utazasIdeje.Load += rcb_utazasIdeje_Load;
            // 
            // rcb_utazasElnevezese
            // 
            rcb_utazasElnevezese.BackColor = Color.Transparent;
            rcb_utazasElnevezese.CimPanelAlsoSzin = Color.White;
            rcb_utazasElnevezese.CimPanelFelsoSzin = Color.White;
            rcb_utazasElnevezese.ComboText = "Utazás elnevezése";
            rcb_utazasElnevezese.EgerTrartasSzin = Color.LightGray;
            rcb_utazasElnevezese.ForeColor = Color.White;
            rcb_utazasElnevezese.Ikon = (Image)resources.GetObject("rcb_utazasElnevezese.Ikon");
            rcb_utazasElnevezese.ItemHatterSzin = Color.WhiteSmoke;
            rcb_utazasElnevezese.ItemPanelAlosSzin = Color.WhiteSmoke;
            rcb_utazasElnevezese.ItemPanelFelsoSzin = Color.WhiteSmoke;
            rcb_utazasElnevezese.KeretSzin = Color.BlueViolet;
            rcb_utazasElnevezese.KeretVastagsag = 1.8F;
            rcb_utazasElnevezese.KivalasztottElemSzin = Color.BlueViolet;
            rcb_utazasElnevezese.LenyiloMagassag = 300;
            rcb_utazasElnevezese.Location = new Point(726, 10);
            rcb_utazasElnevezese.Margin = new Padding(10, 10, 0, 0);
            rcb_utazasElnevezese.MinimumSize = new Size(150, 0);
            rcb_utazasElnevezese.Name = "rcb_utazasElnevezese";
            rcb_utazasElnevezese.Padding = new Padding(0, 0, 0, 6);
            rcb_utazasElnevezese.Radius = 20;
            rcb_utazasElnevezese.Size = new Size(304, 65);
            rcb_utazasElnevezese.TabIndex = 9;
            rcb_utazasElnevezese.TitleLabelSzin = Color.Black;
            rcb_utazasElnevezese.ElemKivalasztva += rcb_utazasNeve_ElemKivalasztva;
            rcb_utazasElnevezese.Load += rcb_utazasElnevezese_Load;
            // 
            // kg_utazasTorlese
            // 
            kg_utazasTorlese.BackColor = Color.Crimson;
            kg_utazasTorlese.EgerTartasHatterSzine = Color.SlateBlue;
            kg_utazasTorlese.FlatAppearance.BorderSize = 0;
            kg_utazasTorlese.FlatStyle = FlatStyle.Flat;
            kg_utazasTorlese.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kg_utazasTorlese.ForeColor = Color.White;
            kg_utazasTorlese.HatterSzine = Color.Crimson;
            kg_utazasTorlese.Image = (Image)resources.GetObject("kg_utazasTorlese.Image");
            kg_utazasTorlese.ImageAlign = ContentAlignment.MiddleRight;
            kg_utazasTorlese.KeretMeret = 0;
            kg_utazasTorlese.KeretSzine = Color.PaleVioletRed;
            kg_utazasTorlese.Location = new Point(10, 464);
            kg_utazasTorlese.Margin = new Padding(10, 2, 3, 2);
            kg_utazasTorlese.Name = "kg_utazasTorlese";
            kg_utazasTorlese.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_utazasTorlese.SarokSugar = 8;
            kg_utazasTorlese.Size = new Size(199, 60);
            kg_utazasTorlese.SzovegSzine = Color.White;
            kg_utazasTorlese.TabIndex = 10;
            kg_utazasTorlese.Text = "Utazás törlése";
            kg_utazasTorlese.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_utazasTorlese.UseVisualStyleBackColor = false;
            kg_utazasTorlese.Click += kg_utazasTorlese_Click;
            // 
            // tlp_utazasTorlese
            // 
            tlp_utazasTorlese.ColumnCount = 3;
            tlp_utazasTorlese.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlp_utazasTorlese.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlp_utazasTorlese.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlp_utazasTorlese.Controls.Add(rcb_desztinacio, 0, 0);
            tlp_utazasTorlese.Controls.Add(rcb_utazasIdeje, 1, 0);
            tlp_utazasTorlese.Controls.Add(rcb_utazasElnevezese, 2, 0);
            tlp_utazasTorlese.Controls.Add(kg_utazasTorlese, 0, 1);
            tlp_utazasTorlese.Dock = DockStyle.Fill;
            tlp_utazasTorlese.Location = new Point(0, 0);
            tlp_utazasTorlese.Name = "tlp_utazasTorlese";
            tlp_utazasTorlese.RowCount = 2;
            tlp_utazasTorlese.RowStyles.Add(new RowStyle(SizeType.Percent, 78.82528F));
            tlp_utazasTorlese.RowStyles.Add(new RowStyle(SizeType.Percent, 21.1747246F));
            tlp_utazasTorlese.Size = new Size(1075, 587);
            tlp_utazasTorlese.TabIndex = 12;
            // 
            // tlp_utazasHozzaadasa
            // 
            tlp_utazasHozzaadasa.ColumnCount = 2;
            tlp_utazasHozzaadasa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_utazasHozzaadasa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_utazasHozzaadasa.Controls.Add(kg_boritoValasztas, 0, 4);
            tlp_utazasHozzaadasa.Controls.Add(tableLayoutPanel2, 1, 3);
            tlp_utazasHozzaadasa.Controls.Add(tableLayoutPanel1, 0, 3);
            tlp_utazasHozzaadasa.Controls.Add(tlp_leiras, 1, 1);
            tlp_utazasHozzaadasa.Controls.Add(tlp_erkezesiDatum, 1, 1);
            tlp_utazasHozzaadasa.Controls.Add(kszm_utazasElnevezese, 1, 0);
            tlp_utazasHozzaadasa.Controls.Add(kszm_desztinacio, 0, 0);
            tlp_utazasHozzaadasa.Controls.Add(tlp_utazasIdeje, 0, 1);
            tlp_utazasHozzaadasa.Controls.Add(kszm_hozzaadas, 0, 6);
            tlp_utazasHozzaadasa.Controls.Add(pictureBox1, 1, 4);
            tlp_utazasHozzaadasa.Dock = DockStyle.Fill;
            tlp_utazasHozzaadasa.Location = new Point(0, 0);
            tlp_utazasHozzaadasa.Name = "tlp_utazasHozzaadasa";
            tlp_utazasHozzaadasa.RowCount = 7;
            tlp_utazasHozzaadasa.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9358644F));
            tlp_utazasHozzaadasa.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1181431F));
            tlp_utazasHozzaadasa.RowStyles.Add(new RowStyle(SizeType.Percent, 20.1969051F));
            tlp_utazasHozzaadasa.RowStyles.Add(new RowStyle(SizeType.Percent, 20.1969051F));
            tlp_utazasHozzaadasa.RowStyles.Add(new RowStyle(SizeType.Percent, 8.559866F));
            tlp_utazasHozzaadasa.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4961529F));
            tlp_utazasHozzaadasa.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4961529F));
            tlp_utazasHozzaadasa.Size = new Size(1075, 535);
            tlp_utazasHozzaadasa.TabIndex = 14;
            // 
            // kg_boritoValasztas
            // 
            kg_boritoValasztas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kg_boritoValasztas.BackColor = Color.MediumSlateBlue;
            kg_boritoValasztas.EgerTartasHatterSzine = Color.SlateBlue;
            kg_boritoValasztas.FlatAppearance.BorderSize = 0;
            kg_boritoValasztas.FlatStyle = FlatStyle.Flat;
            kg_boritoValasztas.Font = new Font("Segoe UI", 14F);
            kg_boritoValasztas.ForeColor = Color.White;
            kg_boritoValasztas.HatterSzine = Color.MediumSlateBlue;
            kg_boritoValasztas.Image = (Image)resources.GetObject("kg_boritoValasztas.Image");
            kg_boritoValasztas.ImageAlign = ContentAlignment.MiddleRight;
            kg_boritoValasztas.KeretMeret = 0;
            kg_boritoValasztas.KeretSzine = Color.PaleVioletRed;
            kg_boritoValasztas.Location = new Point(145, 356);
            kg_boritoValasztas.Margin = new Padding(3, 2, 3, 2);
            kg_boritoValasztas.Name = "kg_boritoValasztas";
            kg_boritoValasztas.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_boritoValasztas.SarokSugar = 15;
            kg_boritoValasztas.Size = new Size(247, 41);
            kg_boritoValasztas.SzovegSzine = Color.White;
            kg_boritoValasztas.TabIndex = 24;
            kg_boritoValasztas.Text = "Borító választás";
            kg_boritoValasztas.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_boritoValasztas.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.7355747F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.26443F));
            tableLayoutPanel2.Controls.Add(kerekitettSzovegMezo1, 1, 0);
            tableLayoutPanel2.Controls.Add(bufferedLabel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(540, 249);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(532, 102);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // kerekitettSzovegMezo1
            // 
            kerekitettSzovegMezo1.AlahuzottStilus = false;
            kerekitettSzovegMezo1.BackColor = SystemColors.Window;
            kerekitettSzovegMezo1.Dock = DockStyle.Fill;
            kerekitettSzovegMezo1.FokuszKeretSzin = Color.HotPink;
            kerekitettSzovegMezo1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kerekitettSzovegMezo1.ForeColor = Color.FromArgb(64, 64, 64);
            kerekitettSzovegMezo1.HelyorzoSzin = Color.DarkGray;
            kerekitettSzovegMezo1.HelyorzoSzoveg = "Adja meg az utazás árát";
            kerekitettSzovegMezo1.JelszoKarakter = false;
            kerekitettSzovegMezo1.KeretMeret = 2;
            kerekitettSzovegMezo1.KeretSugar = 8;
            kerekitettSzovegMezo1.KeretSzin = Color.MediumSlateBlue;
            kerekitettSzovegMezo1.Location = new Point(114, 3);
            kerekitettSzovegMezo1.Margin = new Padding(4, 3, 4, 3);
            kerekitettSzovegMezo1.Name = "kerekitettSzovegMezo1";
            kerekitettSzovegMezo1.Padding = new Padding(9, 6, 9, 6);
            kerekitettSzovegMezo1.Size = new Size(414, 96);
            kerekitettSzovegMezo1.TabIndex = 5;
            kerekitettSzovegMezo1.Texts = "";
            kerekitettSzovegMezo1.TobbSor = true;
            // 
            // bufferedLabel1
            // 
            bufferedLabel1.AutoSize = true;
            bufferedLabel1.Dock = DockStyle.Fill;
            bufferedLabel1.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bufferedLabel1.Location = new Point(3, 0);
            bufferedLabel1.Name = "bufferedLabel1";
            bufferedLabel1.Size = new Size(104, 102);
            bufferedLabel1.TabIndex = 4;
            bufferedLabel1.Text = "Indulás helye:";
            bufferedLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.7355747F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.26443F));
            tableLayoutPanel1.Controls.Add(kszm_ar, 1, 0);
            tableLayoutPanel1.Controls.Add(bl_ar, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 249);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(531, 102);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // kszm_ar
            // 
            kszm_ar.AlahuzottStilus = false;
            kszm_ar.Anchor = AnchorStyles.Left;
            kszm_ar.BackColor = SystemColors.Window;
            kszm_ar.FokuszKeretSzin = Color.HotPink;
            kszm_ar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_ar.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_ar.HelyorzoSzin = Color.DarkGray;
            kszm_ar.HelyorzoSzoveg = "Adja meg az utazás árát";
            kszm_ar.JelszoKarakter = false;
            kszm_ar.KeretMeret = 2;
            kszm_ar.KeretSugar = 8;
            kszm_ar.KeretSzin = Color.MediumSlateBlue;
            kszm_ar.Location = new Point(114, 32);
            kszm_ar.Margin = new Padding(4, 3, 4, 3);
            kszm_ar.Name = "kszm_ar";
            kszm_ar.Padding = new Padding(9, 6, 9, 6);
            kszm_ar.Size = new Size(413, 38);
            kszm_ar.TabIndex = 5;
            kszm_ar.Texts = "";
            kszm_ar.TobbSor = false;
            // 
            // bl_ar
            // 
            bl_ar.AutoSize = true;
            bl_ar.Dock = DockStyle.Fill;
            bl_ar.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bl_ar.Location = new Point(3, 0);
            bl_ar.Name = "bl_ar";
            bl_ar.Size = new Size(104, 102);
            bl_ar.TabIndex = 4;
            bl_ar.Text = "Ár:";
            bl_ar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlp_leiras
            // 
            tlp_leiras.ColumnCount = 2;
            tlp_utazasHozzaadasa.SetColumnSpan(tlp_leiras, 2);
            tlp_leiras.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.3942652F));
            tlp_leiras.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.6057358F));
            tlp_leiras.Controls.Add(bl_leiras, 0, 0);
            tlp_leiras.Controls.Add(kszm_leiras, 1, 0);
            tlp_leiras.Dock = DockStyle.Fill;
            tlp_leiras.Location = new Point(3, 141);
            tlp_leiras.Name = "tlp_leiras";
            tlp_leiras.RowCount = 1;
            tlp_leiras.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_leiras.Size = new Size(1069, 102);
            tlp_leiras.TabIndex = 21;
            // 
            // bl_leiras
            // 
            bl_leiras.AutoSize = true;
            bl_leiras.Dock = DockStyle.Fill;
            bl_leiras.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bl_leiras.Location = new Point(3, 0);
            bl_leiras.Name = "bl_leiras";
            bl_leiras.Size = new Size(105, 102);
            bl_leiras.TabIndex = 21;
            bl_leiras.Text = "Leírás:";
            bl_leiras.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kszm_leiras
            // 
            kszm_leiras.AlahuzottStilus = false;
            kszm_leiras.BackColor = SystemColors.Window;
            kszm_leiras.Dock = DockStyle.Fill;
            kszm_leiras.FokuszKeretSzin = Color.HotPink;
            kszm_leiras.Font = new Font("Microsoft Sans Serif", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_leiras.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_leiras.HelyorzoSzin = Color.DarkGray;
            kszm_leiras.HelyorzoSzoveg = "Ide gépelje be az utazás leírását";
            kszm_leiras.JelszoKarakter = false;
            kszm_leiras.KeretMeret = 2;
            kszm_leiras.KeretSugar = 8;
            kszm_leiras.KeretSzin = Color.MediumSlateBlue;
            kszm_leiras.Location = new Point(115, 4);
            kszm_leiras.Margin = new Padding(4);
            kszm_leiras.Name = "kszm_leiras";
            kszm_leiras.Padding = new Padding(10, 7, 10, 7);
            kszm_leiras.Size = new Size(950, 94);
            kszm_leiras.TabIndex = 20;
            kszm_leiras.Texts = "";
            kszm_leiras.TobbSor = true;
            // 
            // tlp_erkezesiDatum
            // 
            tlp_erkezesiDatum.ColumnCount = 2;
            tlp_erkezesiDatum.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tlp_erkezesiDatum.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tlp_erkezesiDatum.Controls.Add(bl_erkezesiDatum, 0, 0);
            tlp_erkezesiDatum.Controls.Add(dtp_erkezesiDatum, 1, 0);
            tlp_erkezesiDatum.Dock = DockStyle.Fill;
            tlp_erkezesiDatum.Location = new Point(540, 77);
            tlp_erkezesiDatum.Name = "tlp_erkezesiDatum";
            tlp_erkezesiDatum.RowCount = 1;
            tlp_erkezesiDatum.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_erkezesiDatum.Size = new Size(532, 58);
            tlp_erkezesiDatum.TabIndex = 18;
            // 
            // bl_erkezesiDatum
            // 
            bl_erkezesiDatum.AutoSize = true;
            bl_erkezesiDatum.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bl_erkezesiDatum.Location = new Point(3, 0);
            bl_erkezesiDatum.Name = "bl_erkezesiDatum";
            bl_erkezesiDatum.Size = new Size(141, 30);
            bl_erkezesiDatum.TabIndex = 4;
            bl_erkezesiDatum.Text = "Visszaindulás:";
            // 
            // dtp_erkezesiDatum
            // 
            dtp_erkezesiDatum.CalendarFont = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_erkezesiDatum.CalendarMonthBackground = Color.SlateBlue;
            dtp_erkezesiDatum.CalendarTitleBackColor = Color.SlateBlue;
            dtp_erkezesiDatum.CalendarTrailingForeColor = Color.SlateBlue;
            dtp_erkezesiDatum.Dock = DockStyle.Fill;
            dtp_erkezesiDatum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_erkezesiDatum.Location = new Point(202, 2);
            dtp_erkezesiDatum.Margin = new Padding(3, 2, 3, 2);
            dtp_erkezesiDatum.Name = "dtp_erkezesiDatum";
            dtp_erkezesiDatum.Size = new Size(327, 35);
            dtp_erkezesiDatum.TabIndex = 2;
            // 
            // tlp_utazasIdeje
            // 
            tlp_utazasIdeje.ColumnCount = 2;
            tlp_utazasIdeje.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tlp_utazasIdeje.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tlp_utazasIdeje.Controls.Add(dt_datumvalaszto, 1, 0);
            tlp_utazasIdeje.Controls.Add(bl_utazasIdeje, 0, 0);
            tlp_utazasIdeje.Dock = DockStyle.Fill;
            tlp_utazasIdeje.Location = new Point(3, 77);
            tlp_utazasIdeje.Name = "tlp_utazasIdeje";
            tlp_utazasIdeje.RowCount = 1;
            tlp_utazasIdeje.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_utazasIdeje.Size = new Size(531, 58);
            tlp_utazasIdeje.TabIndex = 15;
            // 
            // bl_utazasIdeje
            // 
            bl_utazasIdeje.AutoSize = true;
            bl_utazasIdeje.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bl_utazasIdeje.Location = new Point(3, 0);
            bl_utazasIdeje.Name = "bl_utazasIdeje";
            bl_utazasIdeje.Size = new Size(130, 30);
            bl_utazasIdeje.TabIndex = 4;
            bl_utazasIdeje.Text = "Utazás ideje:";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(540, 357);
            pictureBox1.Name = "pictureBox1";
            tlp_utazasHozzaadasa.SetRowSpan(pictureBox1, 3);
            pictureBox1.Size = new Size(532, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // frm_UtazasokHozzaadasa
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1075, 587);
            Controls.Add(tlp_utazasHozzaadasa);
            Controls.Add(pnl_vezerlopanel);
            Controls.Add(tlp_utazasTorlese);
            Controls.Add(pnl_torles);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_UtazasokHozzaadasa";
            Text = "frm_UtazasokHozzaadasa";
            Load += frm_UtazasokHozzaadasa_Load;
            pnl_torles.ResumeLayout(false);
            pnl_torles.PerformLayout();
            pnl_vezerlopanel.ResumeLayout(false);
            tlp_utazasTorlese.ResumeLayout(false);
            tlp_utazasHozzaadasa.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tlp_leiras.ResumeLayout(false);
            tlp_leiras.PerformLayout();
            tlp_erkezesiDatum.ResumeLayout(false);
            tlp_erkezesiDatum.PerformLayout();
            tlp_utazasIdeje.ResumeLayout(false);
            tlp_utazasIdeje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private egyeni_vezerlok.kerekitettSzovegMezo kszm_desztinacio;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_utazasElnevezese;
        private DateTimePicker dt_datumvalaszto;
        private egyeni_vezerlok.KerekitettGomb kszm_hozzaadas;
        private egyeni_vezerlok.kerekitettLenyilloMenu kerekitettLenyilloMenu1;
        private egyeni_vezerlok.kerekitettLenyilloMenu rcb_desztinacio;
        private egyeni_vezerlok.kerekitettLenyilloMenu rcb_utazasIdeje;
        private egyeni_vezerlok.kerekitettLenyilloMenu rcb_utazasElnevezese;
        private egyeni_vezerlok.KerekitettGomb kg_utazasTorlese;
        private Panel pnl_torles;
        private Label lb_torolni;
        private Label lb_utazas;
        private egyeni_vezerlok.KerekitettGomb kg_nem;
        private egyeni_vezerlok.KerekitettGomb kg_igen;
        private egyeni_vezerlok.ellipszisVezerlo ev_torles;
        private TableLayoutPanel tlp_utazasTorlese;
        private Panel pnl_vezerlopanel;
        private egyeni_vezerlok.KerekitettGomb kszm_utazasTorles;
        private egyeni_vezerlok.KerekitettGomb kszm_ujRegiFelhasznalo;
        private TableLayoutPanel tlp_utazasHozzaadasa;
        private egyeni_vezerlok.BufferedLabel bl_utazasIdeje;
        private TableLayoutPanel tlp_utazasIdeje;
        private TableLayoutPanel tlp_erkezesiDatum;
        private egyeni_vezerlok.BufferedLabel bl_erkezesiDatum;
        private DateTimePicker dtp_erkezesiDatum;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_leiras;
        private TableLayoutPanel tlp_leiras;
        private egyeni_vezerlok.BufferedLabel bl_leiras;
        private TableLayoutPanel tableLayoutPanel1;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_ar;
        private egyeni_vezerlok.BufferedLabel bl_ar;
        private TableLayoutPanel tableLayoutPanel2;
        private egyeni_vezerlok.kerekitettSzovegMezo kerekitettSzovegMezo1;
        private egyeni_vezerlok.BufferedLabel bufferedLabel1;
        private egyeni_vezerlok.KerekitettGomb kg_boritoValasztas;
        private PictureBox pictureBox1;
    }
}