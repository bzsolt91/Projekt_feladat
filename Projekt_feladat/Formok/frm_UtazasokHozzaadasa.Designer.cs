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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UtazasokHozzaadasa));
            egyeni_vezerlok.ellipszisVezerlo ev_vezerloPanel;
            pnl_torles = new Panel();
            kg_nem = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kg_igen = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            lb_utazas = new Label();
            tlp_utazasTorlese = new TableLayoutPanel();
            rcb_desztinacio = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            rcb_utazasIdeje = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            rcb_utazasElnevezese = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            kg_utazasTorlese = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            lb_torolni = new Label();
            pnl_vezerlopanel = new Panel();
            kszm_ujRegiFelhasznalo = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kszm_utazasTorles = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kszm_hozzaadas = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            tlp_ar = new TableLayoutPanel();
            kszm_ar = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            bl_ar = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            tlp_leiras = new TableLayoutPanel();
            bl_leiras = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            kszm_leiras = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            tlp_utazasIdeje = new TableLayoutPanel();
            dt_datumvalaszto = new DateTimePicker();
            bl_utazasIdeje = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            tlp_indulasHelye = new TableLayoutPanel();
            kerekitettSzovegMezo1 = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            bufferedLabel1 = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            tlp_erkezesiDatum = new TableLayoutPanel();
            dtp_erkezesiDatum = new DateTimePicker();
            bl_erkezesiDatum = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            szp_utazasNeve = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            kszm_desztinacio = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_utazasElnevezese = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            szinatmenetPanel1 = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            panel1 = new Panel();
            flp_rendezoPanel = new FlowLayoutPanel();
            pl_terkezelo = new Panel();
            szinatmenetPanel2 = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            szinatmenetPanel3 = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            szinatmenetPanel4 = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            tlp_kep = new TableLayoutPanel();
            pcb_borito = new PictureBox();
            kg_boritoValasztas = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            ev_torles = new Projekt_feladat.egyeni_vezerlok.ellipszisVezerlo();
            ev_vezerloPanel = new Projekt_feladat.egyeni_vezerlok.ellipszisVezerlo();
            pnl_torles.SuspendLayout();
            tlp_utazasTorlese.SuspendLayout();
            pnl_vezerlopanel.SuspendLayout();
            tlp_ar.SuspendLayout();
            tlp_leiras.SuspendLayout();
            tlp_utazasIdeje.SuspendLayout();
            tlp_indulasHelye.SuspendLayout();
            tlp_erkezesiDatum.SuspendLayout();
            szp_utazasNeve.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flp_rendezoPanel.SuspendLayout();
            szinatmenetPanel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            szinatmenetPanel3.SuspendLayout();
            szinatmenetPanel4.SuspendLayout();
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
            pnl_torles.Controls.Add(tlp_utazasTorlese);
            pnl_torles.Controls.Add(lb_torolni);
            pnl_torles.Location = new Point(1073, 11);
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
            tlp_utazasTorlese.Location = new Point(3, 74);
            tlp_utazasTorlese.Name = "tlp_utazasTorlese";
            tlp_utazasTorlese.RowCount = 2;
            tlp_utazasTorlese.RowStyles.Add(new RowStyle(SizeType.Percent, 78.82528F));
            tlp_utazasTorlese.RowStyles.Add(new RowStyle(SizeType.Percent, 21.1747246F));
            tlp_utazasTorlese.Size = new Size(1129, 126);
            tlp_utazasTorlese.TabIndex = 12;
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
            rcb_utazasIdeje.adatForras = null;
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
            rcb_utazasIdeje.Location = new Point(386, 10);
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
            rcb_utazasElnevezese.adatForras = null;
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
            rcb_utazasElnevezese.Location = new Point(762, 10);
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
            kg_utazasTorlese.Location = new Point(10, 101);
            kg_utazasTorlese.Margin = new Padding(10, 2, 3, 2);
            kg_utazasTorlese.Name = "kg_utazasTorlese";
            kg_utazasTorlese.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_utazasTorlese.SarokSugar = 8;
            kg_utazasTorlese.Size = new Size(199, 23);
            kg_utazasTorlese.SzovegSzine = Color.White;
            kg_utazasTorlese.TabIndex = 10;
            kg_utazasTorlese.Text = "Utazás törlése";
            kg_utazasTorlese.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_utazasTorlese.UseVisualStyleBackColor = false;
            kg_utazasTorlese.Click += kg_utazasTorlese_Click;
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
            pnl_vezerlopanel.Size = new Size(956, 52);
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
            kszm_hozzaadas.Location = new Point(586, -38);
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
            tlp_ar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.7355747F));
            tlp_ar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.26443F));
            tlp_ar.Controls.Add(kszm_ar, 1, 0);
            tlp_ar.Controls.Add(bl_ar, 0, 0);
            tlp_ar.Dock = DockStyle.Left;
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
            kszm_ar.Location = new Point(75, 28);
            kszm_ar.Margin = new Padding(4, 3, 4, 3);
            kszm_ar.Name = "kszm_ar";
            kszm_ar.Padding = new Padding(9, 6, 9, 6);
            kszm_ar.Size = new Size(265, 38);
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
            bl_ar.Size = new Size(65, 94);
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
            tlp_utazasIdeje.Controls.Add(dt_datumvalaszto, 1, 0);
            tlp_utazasIdeje.Controls.Add(bl_utazasIdeje, 0, 0);
            tlp_utazasIdeje.Dock = DockStyle.Left;
            tlp_utazasIdeje.Location = new Point(3, 3);
            tlp_utazasIdeje.Name = "tlp_utazasIdeje";
            tlp_utazasIdeje.RowCount = 1;
            tlp_utazasIdeje.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_utazasIdeje.Size = new Size(343, 93);
            tlp_utazasIdeje.TabIndex = 15;
            // 
            // dt_datumvalaszto
            // 
            dt_datumvalaszto.Anchor = AnchorStyles.Left;
            dt_datumvalaszto.CalendarFont = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dt_datumvalaszto.CalendarMonthBackground = Color.SlateBlue;
            dt_datumvalaszto.CalendarTitleBackColor = Color.SlateBlue;
            dt_datumvalaszto.CalendarTrailingForeColor = Color.SlateBlue;
            dt_datumvalaszto.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dt_datumvalaszto.Location = new Point(131, 29);
            dt_datumvalaszto.Margin = new Padding(3, 2, 3, 2);
            dt_datumvalaszto.Name = "dt_datumvalaszto";
            dt_datumvalaszto.Size = new Size(209, 35);
            dt_datumvalaszto.TabIndex = 2;
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
            tlp_indulasHelye.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.7355747F));
            tlp_indulasHelye.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.26443F));
            tlp_indulasHelye.Controls.Add(kerekitettSzovegMezo1, 1, 0);
            tlp_indulasHelye.Controls.Add(bufferedLabel1, 0, 0);
            tlp_indulasHelye.Dock = DockStyle.Left;
            tlp_indulasHelye.Location = new Point(3, 102);
            tlp_indulasHelye.Name = "tlp_indulasHelye";
            tlp_indulasHelye.RowCount = 1;
            tlp_indulasHelye.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_indulasHelye.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_indulasHelye.Size = new Size(343, 94);
            tlp_indulasHelye.TabIndex = 23;
            // 
            // kerekitettSzovegMezo1
            // 
            kerekitettSzovegMezo1.AlahuzottStilus = false;
            kerekitettSzovegMezo1.Anchor = AnchorStyles.Left;
            kerekitettSzovegMezo1.BackColor = SystemColors.Window;
            kerekitettSzovegMezo1.FokuszKeretSzin = Color.HotPink;
            kerekitettSzovegMezo1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kerekitettSzovegMezo1.ForeColor = Color.FromArgb(64, 64, 64);
            kerekitettSzovegMezo1.HelyorzoSzin = Color.DarkGray;
            kerekitettSzovegMezo1.HelyorzoSzoveg = "Adja meg az indulás helyét";
            kerekitettSzovegMezo1.JelszoKarakter = false;
            kerekitettSzovegMezo1.KeretMeret = 2;
            kerekitettSzovegMezo1.KeretSugar = 8;
            kerekitettSzovegMezo1.KeretSzin = Color.MediumSlateBlue;
            kerekitettSzovegMezo1.Location = new Point(75, 28);
            kerekitettSzovegMezo1.Margin = new Padding(4, 3, 4, 3);
            kerekitettSzovegMezo1.Name = "kerekitettSzovegMezo1";
            kerekitettSzovegMezo1.Padding = new Padding(9, 6, 9, 6);
            kerekitettSzovegMezo1.Size = new Size(264, 38);
            kerekitettSzovegMezo1.TabIndex = 5;
            kerekitettSzovegMezo1.Texts = "";
            kerekitettSzovegMezo1.TobbSor = true;
            // 
            // bufferedLabel1
            // 
            bufferedLabel1.Anchor = AnchorStyles.Left;
            bufferedLabel1.AutoSize = true;
            bufferedLabel1.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            bufferedLabel1.Location = new Point(3, 0);
            bufferedLabel1.Name = "bufferedLabel1";
            bufferedLabel1.Size = new Size(62, 94);
            bufferedLabel1.TabIndex = 4;
            bufferedLabel1.Text = "Indulás helye:";
            bufferedLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlp_erkezesiDatum
            // 
            tlp_erkezesiDatum.ColumnCount = 2;
            tlp_erkezesiDatum.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tlp_erkezesiDatum.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tlp_erkezesiDatum.Controls.Add(dtp_erkezesiDatum, 1, 0);
            tlp_erkezesiDatum.Controls.Add(bl_erkezesiDatum, 0, 0);
            tlp_erkezesiDatum.Dock = DockStyle.Left;
            tlp_erkezesiDatum.Location = new Point(352, 3);
            tlp_erkezesiDatum.Name = "tlp_erkezesiDatum";
            tlp_erkezesiDatum.RowCount = 1;
            tlp_erkezesiDatum.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_erkezesiDatum.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_erkezesiDatum.Size = new Size(344, 93);
            tlp_erkezesiDatum.TabIndex = 18;
            // 
            // dtp_erkezesiDatum
            // 
            dtp_erkezesiDatum.Anchor = AnchorStyles.Left;
            dtp_erkezesiDatum.CalendarFont = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_erkezesiDatum.CalendarMonthBackground = Color.SlateBlue;
            dtp_erkezesiDatum.CalendarTitleBackColor = Color.SlateBlue;
            dtp_erkezesiDatum.CalendarTrailingForeColor = Color.SlateBlue;
            dtp_erkezesiDatum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_erkezesiDatum.Location = new Point(132, 29);
            dtp_erkezesiDatum.Margin = new Padding(3, 2, 3, 2);
            dtp_erkezesiDatum.Name = "dtp_erkezesiDatum";
            dtp_erkezesiDatum.Size = new Size(209, 35);
            dtp_erkezesiDatum.TabIndex = 2;
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
            szp_utazasNeve.Controls.Add(tableLayoutPanel1);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(kszm_desztinacio, 0, 0);
            tableLayoutPanel1.Controls.Add(kszm_utazasElnevezese, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(9, 9);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(699, 129);
            tableLayoutPanel1.TabIndex = 0;
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
            flp_rendezoPanel.Controls.Add(szinatmenetPanel2);
            flp_rendezoPanel.Controls.Add(szinatmenetPanel3);
            flp_rendezoPanel.Controls.Add(szinatmenetPanel4);
            flp_rendezoPanel.Dock = DockStyle.Fill;
            flp_rendezoPanel.FlowDirection = FlowDirection.TopDown;
            flp_rendezoPanel.Location = new Point(0, 0);
            flp_rendezoPanel.Margin = new Padding(0);
            flp_rendezoPanel.Name = "flp_rendezoPanel";
            flp_rendezoPanel.Size = new Size(956, 535);
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
            // szinatmenetPanel2
            // 
            szinatmenetPanel2.BackColor = Color.Transparent;
            szinatmenetPanel2.Controls.Add(tableLayoutPanel2);
            szinatmenetPanel2.Dock = DockStyle.Top;
            szinatmenetPanel2.ForeColor = Color.Black;
            szinatmenetPanel2.KeretSzin = Color.Black;
            szinatmenetPanel2.KeretVastagsag = 0F;
            szinatmenetPanel2.Location = new Point(60, 239);
            szinatmenetPanel2.Margin = new Padding(60, 23, 60, 34);
            szinatmenetPanel2.Name = "szinatmenetPanel2";
            szinatmenetPanel2.Padding = new Padding(9);
            szinatmenetPanel2.SarkokLekerekitese = 20;
            szinatmenetPanel2.Size = new Size(717, 217);
            szinatmenetPanel2.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szinatmenetPanel2.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szinatmenetPanel2.SzinatmenetSzog = 90F;
            szinatmenetPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tlp_ar, 1, 1);
            tableLayoutPanel2.Controls.Add(tlp_utazasIdeje, 0, 0);
            tableLayoutPanel2.Controls.Add(tlp_erkezesiDatum, 1, 0);
            tableLayoutPanel2.Controls.Add(tlp_indulasHelye, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(9, 9);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(699, 199);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // szinatmenetPanel3
            // 
            szinatmenetPanel3.BackColor = Color.Transparent;
            szinatmenetPanel3.Controls.Add(tlp_leiras);
            szinatmenetPanel3.Dock = DockStyle.Top;
            szinatmenetPanel3.ForeColor = Color.Black;
            szinatmenetPanel3.KeretSzin = Color.Black;
            szinatmenetPanel3.KeretVastagsag = 0F;
            szinatmenetPanel3.Location = new Point(60, 513);
            szinatmenetPanel3.Margin = new Padding(60, 23, 60, 34);
            szinatmenetPanel3.Name = "szinatmenetPanel3";
            szinatmenetPanel3.Padding = new Padding(9);
            szinatmenetPanel3.SarkokLekerekitese = 20;
            szinatmenetPanel3.Size = new Size(717, 147);
            szinatmenetPanel3.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szinatmenetPanel3.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szinatmenetPanel3.SzinatmenetSzog = 90F;
            szinatmenetPanel3.TabIndex = 10;
            // 
            // szinatmenetPanel4
            // 
            szinatmenetPanel4.BackColor = Color.Transparent;
            szinatmenetPanel4.Controls.Add(tlp_kep);
            szinatmenetPanel4.Dock = DockStyle.Top;
            szinatmenetPanel4.ForeColor = Color.Black;
            szinatmenetPanel4.KeretSzin = Color.Black;
            szinatmenetPanel4.KeretVastagsag = 0F;
            szinatmenetPanel4.Location = new Point(60, 717);
            szinatmenetPanel4.Margin = new Padding(60, 23, 60, 34);
            szinatmenetPanel4.Name = "szinatmenetPanel4";
            szinatmenetPanel4.Padding = new Padding(9);
            szinatmenetPanel4.SarkokLekerekitese = 20;
            szinatmenetPanel4.Size = new Size(717, 347);
            szinatmenetPanel4.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szinatmenetPanel4.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szinatmenetPanel4.SzinatmenetSzog = 90F;
            szinatmenetPanel4.TabIndex = 11;
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
            pcb_borito.Image = (Image)resources.GetObject("pcb_borito.Image");
            pcb_borito.Location = new Point(189, 3);
            pcb_borito.Name = "pcb_borito";
            pcb_borito.Size = new Size(507, 323);
            pcb_borito.SizeMode = PictureBoxSizeMode.StretchImage;
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
            // 
            // frm_UtazasokHozzaadasa
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 70, 90);
            ClientSize = new Size(956, 587);
            Controls.Add(kszm_hozzaadas);
            Controls.Add(flp_rendezoPanel);
            Controls.Add(pnl_vezerlopanel);
            Controls.Add(pnl_torles);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_UtazasokHozzaadasa";
            Text = "frm_UtazasokHozzaadasa";
            Load += frm_UtazasokHozzaadasa_Load;
            Resize += frm_UtazasokHozzaadasa_Resize;
            pnl_torles.ResumeLayout(false);
            pnl_torles.PerformLayout();
            tlp_utazasTorlese.ResumeLayout(false);
            pnl_vezerlopanel.ResumeLayout(false);
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
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            flp_rendezoPanel.ResumeLayout(false);
            szinatmenetPanel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            szinatmenetPanel3.ResumeLayout(false);
            szinatmenetPanel4.ResumeLayout(false);
            tlp_kep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcb_borito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private egyeni_vezerlok.BufferedLabel bl_utazasIdeje;
        private TableLayoutPanel tlp_utazasIdeje;
        private TableLayoutPanel tlp_erkezesiDatum;
        private egyeni_vezerlok.BufferedLabel bl_erkezesiDatum;
        private DateTimePicker dtp_erkezesiDatum;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_leiras;
        private TableLayoutPanel tlp_leiras;
        private egyeni_vezerlok.BufferedLabel bl_leiras;
        private TableLayoutPanel tlp_ar;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_ar;
        private egyeni_vezerlok.BufferedLabel bl_ar;
        private TableLayoutPanel tlp_indulasHelye;
        private egyeni_vezerlok.kerekitettSzovegMezo kerekitettSzovegMezo1;
        private egyeni_vezerlok.BufferedLabel bufferedLabel1;
        private egyeni_vezerlok.SzinatmenetPanel szp_utazasNeve;
        private TableLayoutPanel tableLayoutPanel1;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_desztinacio;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_utazasElnevezese;
        private egyeni_vezerlok.SzinatmenetPanel szinatmenetPanel1;
        private Panel panel1;
        private FlowLayoutPanel flp_rendezoPanel;
        private Panel pl_terkezelo;
        private egyeni_vezerlok.SzinatmenetPanel szinatmenetPanel2;
        private TableLayoutPanel tableLayoutPanel2;
        private egyeni_vezerlok.SzinatmenetPanel szinatmenetPanel3;
        private egyeni_vezerlok.SzinatmenetPanel szinatmenetPanel4;
        private TableLayoutPanel tlp_kep;
        private egyeni_vezerlok.KerekitettGomb kg_boritoValasztas;
        private PictureBox pcb_borito;
    }
}