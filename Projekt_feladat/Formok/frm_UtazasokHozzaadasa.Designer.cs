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
            tlp_utazasTorlese = new DoubleBufferedTableLayoutPanel();
            rcb_desztinacio = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            rcb_utazasIdeje = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            rcb_utazasElnevezese = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            kg_utazasTorlese = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kszm_hozzaadas = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            tlp_ar = new DoubleBufferedTableLayoutPanel();
            kszm_ar = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            bl_ar = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            tlp_leiras = new DoubleBufferedTableLayoutPanel();
            bl_leiras = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            kszm_leiras = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            tlp_utazasIdeje = new DoubleBufferedTableLayoutPanel();
            dtp_indulas = new DateTimePicker();
            bl_utazasIdeje = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            tlp_indulasHelye = new DoubleBufferedTableLayoutPanel();
            kszm_indulasiHely = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            blbl_indulas_helye = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            tlp_erkezesiDatum = new DoubleBufferedTableLayoutPanel();
            dtp_vissza = new DateTimePicker();
            bl_erkezesiDatum = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            szp_utazasNeve = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            DoubleBufferedTableLayoutPanel1 = new DoubleBufferedTableLayoutPanel();
            kszm_desztinacio = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_utazasElnevezese = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            szinatmenetPanel1 = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            panel1 = new Panel();
            flp_rendezoPanel = new FlowLayoutPanel();
            pl_terkezelo = new Panel();
            szp_utazasAdatok = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            tlp_utazasAdatok = new DoubleBufferedTableLayoutPanel();
            szp_leiras = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            sznp_utazasModja = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            doubleBufferedTableLayoutPanel2 = new DoubleBufferedTableLayoutPanel();
            klm_utazasiMod = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            blbl_utazasModja = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            szp_borito = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            tlp_kep = new DoubleBufferedTableLayoutPanel();
            pcb_borito = new PictureBox();
            kg_boritoValasztas = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            ev_torles = new Projekt_feladat.egyeni_vezerlok.ellipszisVezerlo();
            ev_vezerloPanel = new Projekt_feladat.egyeni_vezerlok.ellipszisVezerlo();
            pnl_torles.SuspendLayout();
            pnl_vezerlopanel.SuspendLayout();
            tlp_utazasTorlese.SuspendLayout();
            tlp_ar.SuspendLayout();
            tlp_leiras.SuspendLayout();
            tlp_utazasIdeje.SuspendLayout();
            tlp_indulasHelye.SuspendLayout();
            tlp_erkezesiDatum.SuspendLayout();
            szp_utazasNeve.SuspendLayout();
            DoubleBufferedTableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flp_rendezoPanel.SuspendLayout();
            szp_utazasAdatok.SuspendLayout();
            tlp_utazasAdatok.SuspendLayout();
            szp_leiras.SuspendLayout();
            sznp_utazasModja.SuspendLayout();
            doubleBufferedTableLayoutPanel2.SuspendLayout();
            szp_borito.SuspendLayout();
            tlp_kep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_borito).BeginInit();
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
            pnl_torles.Location = new Point(1044, 84);
            pnl_torles.Margin = new Padding(3, 2, 3, 2);
            pnl_torles.Name = "pnl_torles";
            pnl_torles.Size = new Size(576, 286);
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
            kg_nem.Location = new Point(370, 217);
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
            kg_igen.Location = new Point(45, 217);
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
            lb_utazas.Location = new Point(100, 66);
            lb_utazas.Name = "lb_utazas";
            lb_utazas.Size = new Size(0, 30);
            lb_utazas.TabIndex = 1;
            // 
            // lb_torolni
            // 
            lb_torolni.AutoSize = true;
            lb_torolni.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lb_torolni.Location = new Point(100, 27);
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
            pnl_vezerlopanel.Location = new Point(0, 651);
            pnl_vezerlopanel.Margin = new Padding(3, 3, 15, 15);
            pnl_vezerlopanel.Name = "pnl_vezerlopanel";
            pnl_vezerlopanel.Padding = new Padding(0, 0, 20, 0);
            pnl_vezerlopanel.Size = new Size(960, 52);
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
            // tlp_utazasTorlese
            // 
            tlp_utazasTorlese.ColumnCount = 3;
            tlp_utazasTorlese.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlp_utazasTorlese.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlp_utazasTorlese.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlp_utazasTorlese.Controls.Add(rcb_desztinacio, 0, 0);
            tlp_utazasTorlese.Controls.Add(rcb_utazasIdeje, 1, 0);
            tlp_utazasTorlese.Controls.Add(rcb_utazasElnevezese, 2, 0);
            tlp_utazasTorlese.Controls.Add(kg_utazasTorlese, 2, 1);
            tlp_utazasTorlese.Dock = DockStyle.Fill;
            tlp_utazasTorlese.Location = new Point(0, 0);
            tlp_utazasTorlese.Name = "tlp_utazasTorlese";
            tlp_utazasTorlese.RowCount = 2;
            tlp_utazasTorlese.RowStyles.Add(new RowStyle(SizeType.Percent, 78.82528F));
            tlp_utazasTorlese.RowStyles.Add(new RowStyle(SizeType.Percent, 21.1747246F));
            tlp_utazasTorlese.Size = new Size(960, 703);
            tlp_utazasTorlese.TabIndex = 12;
            // 
            // rcb_desztinacio
            // 
            rcb_desztinacio.BackColor = Color.Transparent;
            rcb_desztinacio.CimPanelAlsoSzin = Color.White;
            rcb_desztinacio.CimPanelFelsoSzin = Color.White;
            rcb_desztinacio.ComboText = "Desztináció";
            rcb_desztinacio.EgerTrartasSzin = Color.LightGray;
            rcb_desztinacio.ForeColor = Color.Transparent;
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
            rcb_utazasIdeje.ForeColor = Color.Transparent;
            rcb_utazasIdeje.Ikon = (Image)resources.GetObject("rcb_utazasIdeje.Ikon");
            rcb_utazasIdeje.ItemHatterSzin = Color.WhiteSmoke;
            rcb_utazasIdeje.ItemPanelAlosSzin = Color.WhiteSmoke;
            rcb_utazasIdeje.ItemPanelFelsoSzin = Color.WhiteSmoke;
            rcb_utazasIdeje.KeretSzin = Color.BlueViolet;
            rcb_utazasIdeje.KeretVastagsag = 1.8F;
            rcb_utazasIdeje.KivalasztottElemSzin = Color.BlueViolet;
            rcb_utazasIdeje.LenyiloMagassag = 300;
            rcb_utazasIdeje.Location = new Point(329, 10);
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
            rcb_utazasElnevezese.ForeColor = Color.Transparent;
            rcb_utazasElnevezese.Ikon = (Image)resources.GetObject("rcb_utazasElnevezese.Ikon");
            rcb_utazasElnevezese.ItemHatterSzin = Color.WhiteSmoke;
            rcb_utazasElnevezese.ItemPanelAlosSzin = Color.WhiteSmoke;
            rcb_utazasElnevezese.ItemPanelFelsoSzin = Color.WhiteSmoke;
            rcb_utazasElnevezese.KeretSzin = Color.BlueViolet;
            rcb_utazasElnevezese.KeretVastagsag = 1.8F;
            rcb_utazasElnevezese.KivalasztottElemSzin = Color.BlueViolet;
            rcb_utazasElnevezese.LenyiloMagassag = 300;
            rcb_utazasElnevezese.Location = new Point(648, 10);
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
            kg_utazasTorlese.Location = new Point(648, 556);
            kg_utazasTorlese.Margin = new Padding(10, 2, 3, 2);
            kg_utazasTorlese.Name = "kg_utazasTorlese";
            kg_utazasTorlese.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_utazasTorlese.SarokSugar = 8;
            kg_utazasTorlese.Size = new Size(220, 52);
            kg_utazasTorlese.SzovegSzine = Color.White;
            kg_utazasTorlese.TabIndex = 10;
            kg_utazasTorlese.Text = "Utazás törlése";
            kg_utazasTorlese.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_utazasTorlese.UseVisualStyleBackColor = false;
            kg_utazasTorlese.Click += kg_utazasTorlese_Click;
            // 
            // kszm_hozzaadas
            // 
            kszm_hozzaadas.Anchor = AnchorStyles.Bottom;
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
            kszm_hozzaadas.Location = new Point(588, 566);
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
            // tlp_ar
            // 
            tlp_ar.ColumnCount = 2;
            tlp_ar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.45633F));
            tlp_ar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.54367F));
            tlp_ar.Controls.Add(kszm_ar, 1, 0);
            tlp_ar.Controls.Add(bl_ar, 0, 0);
            tlp_ar.Dock = DockStyle.Fill;
            tlp_ar.Location = new Point(352, 102);
            tlp_ar.Name = "tlp_ar";
            tlp_ar.RowCount = 1;
            tlp_ar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_ar.Size = new Size(344, 94);
            tlp_ar.TabIndex = 22;
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
            kszm_ar.Location = new Point(98, 28);
            kszm_ar.Margin = new Padding(4, 3, 4, 3);
            kszm_ar.Name = "kszm_ar";
            kszm_ar.Padding = new Padding(9, 6, 9, 6);
            kszm_ar.Size = new Size(242, 38);
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
            bl_ar.Size = new Size(88, 94);
            bl_ar.TabIndex = 4;
            bl_ar.Text = "Ár:";
            bl_ar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlp_leiras
            // 
            tlp_leiras.ColumnCount = 2;
            tlp_leiras.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.3942652F));
            tlp_leiras.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.6057358F));
            tlp_leiras.Controls.Add(bl_leiras, 0, 0);
            tlp_leiras.Controls.Add(kszm_leiras, 1, 0);
            tlp_leiras.Dock = DockStyle.Fill;
            tlp_leiras.Location = new Point(9, 9);
            tlp_leiras.Name = "tlp_leiras";
            tlp_leiras.RowCount = 1;
            tlp_leiras.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_leiras.Size = new Size(699, 129);
            tlp_leiras.TabIndex = 21;
            // 
            // bl_leiras
            // 
            bl_leiras.AutoSize = true;
            bl_leiras.Dock = DockStyle.Fill;
            bl_leiras.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bl_leiras.Location = new Point(3, 0);
            bl_leiras.Name = "bl_leiras";
            bl_leiras.Size = new Size(66, 129);
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
            kszm_leiras.Location = new Point(76, 4);
            kszm_leiras.Margin = new Padding(4);
            kszm_leiras.Name = "kszm_leiras";
            kszm_leiras.Padding = new Padding(10, 7, 10, 7);
            kszm_leiras.Size = new Size(619, 121);
            kszm_leiras.TabIndex = 20;
            kszm_leiras.Texts = "";
            kszm_leiras.TobbSor = true;
            // 
            // tlp_utazasIdeje
            // 
            tlp_utazasIdeje.ColumnCount = 2;
            tlp_utazasIdeje.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tlp_utazasIdeje.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tlp_utazasIdeje.Controls.Add(dtp_indulas, 1, 0);
            tlp_utazasIdeje.Controls.Add(bl_utazasIdeje, 0, 0);
            tlp_utazasIdeje.Dock = DockStyle.Fill;
            tlp_utazasIdeje.Location = new Point(3, 3);
            tlp_utazasIdeje.Name = "tlp_utazasIdeje";
            tlp_utazasIdeje.RowCount = 1;
            tlp_utazasIdeje.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_utazasIdeje.Size = new Size(343, 93);
            tlp_utazasIdeje.TabIndex = 15;
            // 
            // dtp_indulas
            // 
            dtp_indulas.Anchor = AnchorStyles.Left;
            dtp_indulas.CalendarFont = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_indulas.CalendarMonthBackground = Color.SlateBlue;
            dtp_indulas.CalendarTitleBackColor = Color.SlateBlue;
            dtp_indulas.CalendarTrailingForeColor = Color.SlateBlue;
            dtp_indulas.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_indulas.Location = new Point(131, 29);
            dtp_indulas.Margin = new Padding(3, 2, 3, 2);
            dtp_indulas.Name = "dtp_indulas";
            dtp_indulas.Size = new Size(209, 35);
            dtp_indulas.TabIndex = 2;
            // 
            // bl_utazasIdeje
            // 
            bl_utazasIdeje.Anchor = AnchorStyles.Left;
            bl_utazasIdeje.AutoSize = true;
            bl_utazasIdeje.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bl_utazasIdeje.Location = new Point(3, 16);
            bl_utazasIdeje.Name = "bl_utazasIdeje";
            bl_utazasIdeje.Size = new Size(81, 60);
            bl_utazasIdeje.TabIndex = 4;
            bl_utazasIdeje.Text = "Utazás ideje:";
            // 
            // tlp_indulasHelye
            // 
            tlp_indulasHelye.ColumnCount = 2;
            tlp_indulasHelye.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.45633F));
            tlp_indulasHelye.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.54367F));
            tlp_indulasHelye.Controls.Add(kszm_indulasiHely, 1, 0);
            tlp_indulasHelye.Controls.Add(blbl_indulas_helye, 0, 0);
            tlp_indulasHelye.Dock = DockStyle.Fill;
            tlp_indulasHelye.Location = new Point(3, 102);
            tlp_indulasHelye.Name = "tlp_indulasHelye";
            tlp_indulasHelye.RowCount = 1;
            tlp_indulasHelye.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_indulasHelye.Size = new Size(343, 94);
            tlp_indulasHelye.TabIndex = 23;
            // 
            // kszm_indulasiHely
            // 
            kszm_indulasiHely.AlahuzottStilus = false;
            kszm_indulasiHely.Anchor = AnchorStyles.Left;
            kszm_indulasiHely.BackColor = SystemColors.Window;
            kszm_indulasiHely.FokuszKeretSzin = Color.HotPink;
            kszm_indulasiHely.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_indulasiHely.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_indulasiHely.HelyorzoSzin = Color.DarkGray;
            kszm_indulasiHely.HelyorzoSzoveg = "Adja meg az indulás helyét";
            kszm_indulasiHely.JelszoKarakter = false;
            kszm_indulasiHely.KeretMeret = 2;
            kszm_indulasiHely.KeretSugar = 8;
            kszm_indulasiHely.KeretSzin = Color.MediumSlateBlue;
            kszm_indulasiHely.Location = new Point(98, 28);
            kszm_indulasiHely.Margin = new Padding(4, 3, 4, 3);
            kszm_indulasiHely.Name = "kszm_indulasiHely";
            kszm_indulasiHely.Padding = new Padding(9, 6, 9, 6);
            kszm_indulasiHely.Size = new Size(241, 38);
            kszm_indulasiHely.TabIndex = 5;
            kszm_indulasiHely.Texts = "";
            kszm_indulasiHely.TobbSor = true;
            // 
            // blbl_indulas_helye
            // 
            blbl_indulas_helye.Anchor = AnchorStyles.Left;
            blbl_indulas_helye.AutoSize = true;
            blbl_indulas_helye.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            blbl_indulas_helye.Location = new Point(3, 17);
            blbl_indulas_helye.Name = "blbl_indulas_helye";
            blbl_indulas_helye.Size = new Size(80, 60);
            blbl_indulas_helye.TabIndex = 4;
            blbl_indulas_helye.Text = "Indulás helye:";
            blbl_indulas_helye.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlp_erkezesiDatum
            // 
            tlp_erkezesiDatum.ColumnCount = 2;
            tlp_erkezesiDatum.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tlp_erkezesiDatum.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tlp_erkezesiDatum.Controls.Add(dtp_vissza, 1, 0);
            tlp_erkezesiDatum.Controls.Add(bl_erkezesiDatum, 0, 0);
            tlp_erkezesiDatum.Dock = DockStyle.Fill;
            tlp_erkezesiDatum.Location = new Point(352, 3);
            tlp_erkezesiDatum.Name = "tlp_erkezesiDatum";
            tlp_erkezesiDatum.RowCount = 1;
            tlp_erkezesiDatum.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_erkezesiDatum.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_erkezesiDatum.Size = new Size(344, 93);
            tlp_erkezesiDatum.TabIndex = 18;
            // 
            // dtp_vissza
            // 
            dtp_vissza.Anchor = AnchorStyles.Left;
            dtp_vissza.CalendarFont = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_vissza.CalendarMonthBackground = Color.SlateBlue;
            dtp_vissza.CalendarTitleBackColor = Color.SlateBlue;
            dtp_vissza.CalendarTrailingForeColor = Color.SlateBlue;
            dtp_vissza.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_vissza.Location = new Point(132, 29);
            dtp_vissza.Margin = new Padding(3, 2, 3, 2);
            dtp_vissza.Name = "dtp_vissza";
            dtp_vissza.Size = new Size(209, 35);
            dtp_vissza.TabIndex = 2;
            // 
            // bl_erkezesiDatum
            // 
            bl_erkezesiDatum.Anchor = AnchorStyles.Left;
            bl_erkezesiDatum.AutoSize = true;
            bl_erkezesiDatum.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bl_erkezesiDatum.Location = new Point(3, 16);
            bl_erkezesiDatum.Name = "bl_erkezesiDatum";
            bl_erkezesiDatum.Size = new Size(116, 60);
            bl_erkezesiDatum.TabIndex = 4;
            bl_erkezesiDatum.Text = "Visszaindulás:";
            // 
            // szp_utazasNeve
            // 
            szp_utazasNeve.BackColor = Color.Transparent;
            szp_utazasNeve.Controls.Add(DoubleBufferedTableLayoutPanel1);
            szp_utazasNeve.Dock = DockStyle.Fill;
            szp_utazasNeve.ForeColor = Color.Black;
            szp_utazasNeve.KeretSzin = Color.Black;
            szp_utazasNeve.KeretVastagsag = 0F;
            szp_utazasNeve.Location = new Point(60, 35);
            szp_utazasNeve.Margin = new Padding(60, 23, 60, 34);
            szp_utazasNeve.Name = "szp_utazasNeve";
            szp_utazasNeve.Padding = new Padding(9);
            szp_utazasNeve.SarkokLekerekitese = 20;
            szp_utazasNeve.Size = new Size(717, 147);
            szp_utazasNeve.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szp_utazasNeve.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szp_utazasNeve.SzinatmenetSzog = 90F;
            szp_utazasNeve.TabIndex = 7;
            // 
            // DoubleBufferedTableLayoutPanel1
            // 
            DoubleBufferedTableLayoutPanel1.ColumnCount = 1;
            DoubleBufferedTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            DoubleBufferedTableLayoutPanel1.Controls.Add(kszm_desztinacio, 0, 0);
            DoubleBufferedTableLayoutPanel1.Controls.Add(kszm_utazasElnevezese, 0, 1);
            DoubleBufferedTableLayoutPanel1.Dock = DockStyle.Fill;
            DoubleBufferedTableLayoutPanel1.Location = new Point(9, 9);
            DoubleBufferedTableLayoutPanel1.Name = "DoubleBufferedTableLayoutPanel1";
            DoubleBufferedTableLayoutPanel1.RowCount = 2;
            DoubleBufferedTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            DoubleBufferedTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            DoubleBufferedTableLayoutPanel1.Size = new Size(699, 129);
            DoubleBufferedTableLayoutPanel1.TabIndex = 0;
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
            kszm_desztinacio.Location = new Point(24, 20);
            kszm_desztinacio.Margin = new Padding(24, 20, 24, 20);
            kszm_desztinacio.Name = "kszm_desztinacio";
            kszm_desztinacio.Padding = new Padding(9, 6, 9, 6);
            kszm_desztinacio.Size = new Size(651, 38);
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
            kszm_utazasElnevezese.Location = new Point(24, 84);
            kszm_utazasElnevezese.Margin = new Padding(24, 20, 24, 50);
            kszm_utazasElnevezese.Name = "kszm_utazasElnevezese";
            kszm_utazasElnevezese.Padding = new Padding(9, 6, 9, 6);
            kszm_utazasElnevezese.Size = new Size(651, 38);
            kszm_utazasElnevezese.TabIndex = 1;
            kszm_utazasElnevezese.Texts = "";
            kszm_utazasElnevezese.TobbSor = false;
            // 
            // szinatmenetPanel1
            // 
            szinatmenetPanel1.BackColor = Color.Transparent;
            szinatmenetPanel1.Dock = DockStyle.Top;
            szinatmenetPanel1.ForeColor = Color.Black;
            szinatmenetPanel1.KeretSzin = Color.Black;
            szinatmenetPanel1.KeretVastagsag = 0F;
            szinatmenetPanel1.Location = new Point(30, 0);
            szinatmenetPanel1.Margin = new Padding(300, 340, 300, 340);
            szinatmenetPanel1.Name = "szinatmenetPanel1";
            szinatmenetPanel1.Padding = new Padding(20);
            szinatmenetPanel1.SarkokLekerekitese = 40;
            szinatmenetPanel1.Size = new Size(1015, 281);
            szinatmenetPanel1.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szinatmenetPanel1.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szinatmenetPanel1.SzinatmenetSzog = 90F;
            szinatmenetPanel1.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(szinatmenetPanel1);
            panel1.Location = new Point(702, 198);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30, 0, 30, 0);
            panel1.Size = new Size(1075, 535);
            panel1.TabIndex = 19;
            // 
            // flp_rendezoPanel
            // 
            flp_rendezoPanel.AutoScroll = true;
            flp_rendezoPanel.AutoSize = true;
            flp_rendezoPanel.BackColor = Color.FromArgb(50, 70, 90);
            flp_rendezoPanel.Controls.Add(pl_terkezelo);
            flp_rendezoPanel.Controls.Add(szp_utazasNeve);
            flp_rendezoPanel.Controls.Add(szp_utazasAdatok);
            flp_rendezoPanel.Controls.Add(szp_leiras);
            flp_rendezoPanel.Controls.Add(sznp_utazasModja);
            flp_rendezoPanel.Controls.Add(szp_borito);
            flp_rendezoPanel.Dock = DockStyle.Fill;
            flp_rendezoPanel.FlowDirection = FlowDirection.TopDown;
            flp_rendezoPanel.Location = new Point(0, 0);
            flp_rendezoPanel.Margin = new Padding(0);
            flp_rendezoPanel.Name = "flp_rendezoPanel";
            flp_rendezoPanel.Size = new Size(960, 651);
            flp_rendezoPanel.TabIndex = 20;
            flp_rendezoPanel.WrapContents = false;
            flp_rendezoPanel.Resize += flp_rendezoPanel_Resize;
            // 
            // pl_terkezelo
            // 
            pl_terkezelo.BackColor = Color.Transparent;
            pl_terkezelo.Location = new Point(0, 0);
            pl_terkezelo.Margin = new Padding(0);
            pl_terkezelo.Name = "pl_terkezelo";
            pl_terkezelo.Size = new Size(837, 12);
            pl_terkezelo.TabIndex = 8;
            // 
            // szp_utazasAdatok
            // 
            szp_utazasAdatok.BackColor = Color.Transparent;
            szp_utazasAdatok.Controls.Add(tlp_utazasAdatok);
            szp_utazasAdatok.Dock = DockStyle.Top;
            szp_utazasAdatok.ForeColor = Color.Black;
            szp_utazasAdatok.KeretSzin = Color.Black;
            szp_utazasAdatok.KeretVastagsag = 0F;
            szp_utazasAdatok.Location = new Point(60, 239);
            szp_utazasAdatok.Margin = new Padding(60, 23, 60, 34);
            szp_utazasAdatok.Name = "szp_utazasAdatok";
            szp_utazasAdatok.Padding = new Padding(9);
            szp_utazasAdatok.SarkokLekerekitese = 20;
            szp_utazasAdatok.Size = new Size(717, 217);
            szp_utazasAdatok.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szp_utazasAdatok.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szp_utazasAdatok.SzinatmenetSzog = 90F;
            szp_utazasAdatok.TabIndex = 9;
            // 
            // tlp_utazasAdatok
            // 
            tlp_utazasAdatok.ColumnCount = 2;
            tlp_utazasAdatok.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_utazasAdatok.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_utazasAdatok.Controls.Add(tlp_ar, 1, 1);
            tlp_utazasAdatok.Controls.Add(tlp_utazasIdeje, 0, 0);
            tlp_utazasAdatok.Controls.Add(tlp_erkezesiDatum, 1, 0);
            tlp_utazasAdatok.Controls.Add(tlp_indulasHelye, 0, 1);
            tlp_utazasAdatok.Dock = DockStyle.Fill;
            tlp_utazasAdatok.Location = new Point(9, 9);
            tlp_utazasAdatok.Name = "tlp_utazasAdatok";
            tlp_utazasAdatok.RowCount = 2;
            tlp_utazasAdatok.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_utazasAdatok.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_utazasAdatok.Size = new Size(699, 199);
            tlp_utazasAdatok.TabIndex = 0;
            // 
            // szp_leiras
            // 
            szp_leiras.BackColor = Color.Transparent;
            szp_leiras.Controls.Add(tlp_leiras);
            szp_leiras.Dock = DockStyle.Top;
            szp_leiras.ForeColor = Color.Black;
            szp_leiras.KeretSzin = Color.Black;
            szp_leiras.KeretVastagsag = 0F;
            szp_leiras.Location = new Point(60, 513);
            szp_leiras.Margin = new Padding(60, 23, 60, 34);
            szp_leiras.Name = "szp_leiras";
            szp_leiras.Padding = new Padding(9);
            szp_leiras.SarkokLekerekitese = 20;
            szp_leiras.Size = new Size(717, 147);
            szp_leiras.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szp_leiras.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szp_leiras.SzinatmenetSzog = 90F;
            szp_leiras.TabIndex = 10;
            // 
            // sznp_utazasModja
            // 
            sznp_utazasModja.BackColor = Color.Transparent;
            sznp_utazasModja.Controls.Add(doubleBufferedTableLayoutPanel2);
            sznp_utazasModja.Dock = DockStyle.Top;
            sznp_utazasModja.ForeColor = Color.Black;
            sznp_utazasModja.KeretSzin = Color.Black;
            sznp_utazasModja.KeretVastagsag = 0F;
            sznp_utazasModja.Location = new Point(60, 717);
            sznp_utazasModja.Margin = new Padding(60, 23, 60, 34);
            sznp_utazasModja.Name = "sznp_utazasModja";
            sznp_utazasModja.Padding = new Padding(9);
            sznp_utazasModja.SarkokLekerekitese = 20;
            sznp_utazasModja.Size = new Size(717, 246);
            sznp_utazasModja.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            sznp_utazasModja.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            sznp_utazasModja.SzinatmenetSzog = 90F;
            sznp_utazasModja.TabIndex = 12;
            // 
            // doubleBufferedTableLayoutPanel2
            // 
            doubleBufferedTableLayoutPanel2.ColumnCount = 2;
            doubleBufferedTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0824089F));
            doubleBufferedTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.91759F));
            doubleBufferedTableLayoutPanel2.Controls.Add(klm_utazasiMod, 1, 0);
            doubleBufferedTableLayoutPanel2.Controls.Add(blbl_utazasModja, 0, 0);
            doubleBufferedTableLayoutPanel2.Dock = DockStyle.Fill;
            doubleBufferedTableLayoutPanel2.Location = new Point(9, 9);
            doubleBufferedTableLayoutPanel2.Name = "doubleBufferedTableLayoutPanel2";
            doubleBufferedTableLayoutPanel2.RowCount = 1;
            doubleBufferedTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            doubleBufferedTableLayoutPanel2.Size = new Size(699, 228);
            doubleBufferedTableLayoutPanel2.TabIndex = 21;
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
            klm_utazasiMod.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            klm_utazasiMod.Location = new Point(177, 3);
            klm_utazasiMod.Margin = new Padding(2, 3, 2, 3);
            klm_utazasiMod.MinimumSize = new Size(150, 0);
            klm_utazasiMod.Name = "klm_utazasiMod";
            klm_utazasiMod.Radius = 10;
            klm_utazasiMod.Size = new Size(520, 63);
            klm_utazasiMod.TabIndex = 22;
            klm_utazasiMod.TitleLabelSzin = Color.Black;
            // 
            // blbl_utazasModja
            // 
            blbl_utazasModja.AutoSize = true;
            blbl_utazasModja.Dock = DockStyle.Fill;
            blbl_utazasModja.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            blbl_utazasModja.Location = new Point(3, 15);
            blbl_utazasModja.Margin = new Padding(3, 15, 3, 0);
            blbl_utazasModja.Name = "blbl_utazasModja";
            blbl_utazasModja.Size = new Size(169, 213);
            blbl_utazasModja.TabIndex = 21;
            blbl_utazasModja.Text = "Utazás módja";
            blbl_utazasModja.TextAlign = ContentAlignment.TopCenter;
            // 
            // szp_borito
            // 
            szp_borito.BackColor = Color.Transparent;
            szp_borito.Controls.Add(tlp_kep);
            szp_borito.Dock = DockStyle.Top;
            szp_borito.ForeColor = Color.Black;
            szp_borito.KeretSzin = Color.Black;
            szp_borito.KeretVastagsag = 0F;
            szp_borito.Location = new Point(60, 1020);
            szp_borito.Margin = new Padding(60, 23, 60, 34);
            szp_borito.Name = "szp_borito";
            szp_borito.Padding = new Padding(9);
            szp_borito.SarkokLekerekitese = 20;
            szp_borito.Size = new Size(717, 347);
            szp_borito.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szp_borito.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szp_borito.SzinatmenetSzog = 90F;
            szp_borito.TabIndex = 11;
            // 
            // tlp_kep
            // 
            tlp_kep.ColumnCount = 2;
            tlp_kep.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.7491531F));
            tlp_kep.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.25085F));
            tlp_kep.Controls.Add(pcb_borito, 1, 0);
            tlp_kep.Controls.Add(kg_boritoValasztas, 0, 0);
            tlp_kep.Dock = DockStyle.Fill;
            tlp_kep.Location = new Point(9, 9);
            tlp_kep.Name = "tlp_kep";
            tlp_kep.RowCount = 1;
            tlp_kep.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_kep.Size = new Size(699, 329);
            tlp_kep.TabIndex = 26;
            // 
            // pcb_borito
            // 
            pcb_borito.Dock = DockStyle.Fill;
            pcb_borito.Location = new Point(189, 3);
            pcb_borito.Name = "pcb_borito";
            pcb_borito.Size = new Size(507, 323);
            pcb_borito.SizeMode = PictureBoxSizeMode.Zoom;
            pcb_borito.TabIndex = 0;
            pcb_borito.TabStop = false;
            // 
            // kg_boritoValasztas
            // 
            kg_boritoValasztas.Anchor = AnchorStyles.Left;
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
            kg_boritoValasztas.Location = new Point(3, 126);
            kg_boritoValasztas.Margin = new Padding(3, 2, 3, 2);
            kg_boritoValasztas.Name = "kg_boritoValasztas";
            kg_boritoValasztas.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_boritoValasztas.SarokSugar = 15;
            kg_boritoValasztas.Size = new Size(180, 76);
            kg_boritoValasztas.SzovegSzine = Color.White;
            kg_boritoValasztas.TabIndex = 24;
            kg_boritoValasztas.Text = "Borító választás";
            kg_boritoValasztas.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_boritoValasztas.UseVisualStyleBackColor = false;
            kg_boritoValasztas.Click += kg_boritoValasztas_Click;
            // 
            // frm_UtazasokHozzaadasa
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 70, 90);
            ClientSize = new Size(960, 703);
            Controls.Add(kszm_hozzaadas);
            Controls.Add(flp_rendezoPanel);
            Controls.Add(pnl_vezerlopanel);
            Controls.Add(tlp_utazasTorlese);
            Controls.Add(pnl_torles);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_UtazasokHozzaadasa";
            Text = "frm_UtazasokHozzaadasa";
            Load += frm_UtazasokHozzaadasa_Load;
            Resize += frm_UtazasokHozzaadasa_Resize;
            pnl_torles.ResumeLayout(false);
            pnl_torles.PerformLayout();
            pnl_vezerlopanel.ResumeLayout(false);
            tlp_utazasTorlese.ResumeLayout(false);
            tlp_ar.ResumeLayout(false);
            tlp_ar.PerformLayout();
            tlp_leiras.ResumeLayout(false);
            tlp_leiras.PerformLayout();
            tlp_utazasIdeje.ResumeLayout(false);
            tlp_utazasIdeje.PerformLayout();
            tlp_indulasHelye.ResumeLayout(false);
            tlp_indulasHelye.PerformLayout();
            tlp_erkezesiDatum.ResumeLayout(false);
            tlp_erkezesiDatum.PerformLayout();
            szp_utazasNeve.ResumeLayout(false);
            DoubleBufferedTableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            flp_rendezoPanel.ResumeLayout(false);
            szp_utazasAdatok.ResumeLayout(false);
            tlp_utazasAdatok.ResumeLayout(false);
            szp_leiras.ResumeLayout(false);
            sznp_utazasModja.ResumeLayout(false);
            doubleBufferedTableLayoutPanel2.ResumeLayout(false);
            doubleBufferedTableLayoutPanel2.PerformLayout();
            szp_borito.ResumeLayout(false);
            tlp_kep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcb_borito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtp_indulas;
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
        private DoubleBufferedTableLayoutPanel tlp_utazasTorlese;
        private Panel pnl_vezerlopanel;
        private egyeni_vezerlok.KerekitettGomb kszm_utazasTorles;
        private egyeni_vezerlok.KerekitettGomb kszm_ujRegiFelhasznalo;
        private egyeni_vezerlok.BufferedLabel bl_utazasIdeje;
        private DoubleBufferedTableLayoutPanel tlp_utazasIdeje;
        private DoubleBufferedTableLayoutPanel tlp_erkezesiDatum;
        private egyeni_vezerlok.BufferedLabel bl_erkezesiDatum;
        private DateTimePicker dtp_vissza;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_leiras;
        private DoubleBufferedTableLayoutPanel tlp_leiras;
        private egyeni_vezerlok.BufferedLabel bl_leiras;
        private DoubleBufferedTableLayoutPanel tlp_ar;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_ar;
        private egyeni_vezerlok.BufferedLabel bl_ar;
        private DoubleBufferedTableLayoutPanel tlp_indulasHelye;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_indulasiHely;
        private egyeni_vezerlok.BufferedLabel blbl_indulas_helye;
        private egyeni_vezerlok.SzinatmenetPanel szp_utazasNeve;
        private DoubleBufferedTableLayoutPanel DoubleBufferedTableLayoutPanel1;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_desztinacio;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_utazasElnevezese;
        private egyeni_vezerlok.SzinatmenetPanel szinatmenetPanel1;
        private Panel panel1;
        private FlowLayoutPanel flp_rendezoPanel;
        private Panel pl_terkezelo;
        private egyeni_vezerlok.SzinatmenetPanel szp_utazasAdatok;
        private DoubleBufferedTableLayoutPanel tlp_utazasAdatok;
        private egyeni_vezerlok.SzinatmenetPanel szp_leiras;
        private egyeni_vezerlok.SzinatmenetPanel szp_borito;
        private DoubleBufferedTableLayoutPanel tlp_kep;
        private egyeni_vezerlok.KerekitettGomb kg_boritoValasztas;
        private PictureBox pcb_borito;
        private egyeni_vezerlok.SzinatmenetPanel sznp_utazasModja;
        private DoubleBufferedTableLayoutPanel doubleBufferedTableLayoutPanel2;
        private egyeni_vezerlok.BufferedLabel blbl_utazasModja;
        private egyeni_vezerlok.kerekitettLenyilloMenu klm_utazasiMod;
    }
}