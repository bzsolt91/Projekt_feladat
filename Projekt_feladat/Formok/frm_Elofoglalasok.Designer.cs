namespace Projekt_feladat.Formok
{
    partial class frm_Elofoglalasok
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
            egyeni_vezerlok.ellipszisVezerlo ev_szuroPanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Elofoglalasok));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            szpn_szuroPanel = new Panel();
            blbl_datum = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            dtp_relativDatum = new DateTimePicker();
            klm_allapot = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            kszm_lakcim = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_telefon = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_email = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_utasNeve = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kg_pipa = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            pnl_vezerlopanel = new Panel();
            tlp_szerkesztes = new TableLayoutPanel();
            kg_felvetelUtasnak = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kg_mentes = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            pnl_segedPanel = new Panel();
            lbl_allapotModositas = new Label();
            kg_torles = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            tlp_fomenu = new TableLayoutPanel();
            kszm_szerkesztes = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kg_telefonszamMasolas = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kg_szures = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kg_email = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            klm_foglalasiAllapot = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            dgv_utasok = new Projekt_feladat.egyeni_vezerlok.DoubleBufferedDataGridView();
            ev_fomenu = new Projekt_feladat.egyeni_vezerlok.ellipszisVezerlo();
            nud_oldalszam = new Projekt_feladat.egyeni_vezerlok.KerekitettNumericUpDown();
            ev_szuroPanel = new Projekt_feladat.egyeni_vezerlok.ellipszisVezerlo();
            szpn_szuroPanel.SuspendLayout();
            pnl_vezerlopanel.SuspendLayout();
            tlp_szerkesztes.SuspendLayout();
            tlp_fomenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_utasok).BeginInit();
            SuspendLayout();
            // 
            // ev_szuroPanel
            // 
            ev_szuroPanel.SarokSugar = 40;
            ev_szuroPanel.TargetControl = szpn_szuroPanel;
            // 
            // szpn_szuroPanel
            // 
            szpn_szuroPanel.BackColor = Color.FromArgb(243, 244, 246);
            szpn_szuroPanel.Controls.Add(blbl_datum);
            szpn_szuroPanel.Controls.Add(dtp_relativDatum);
            szpn_szuroPanel.Controls.Add(klm_allapot);
            szpn_szuroPanel.Controls.Add(kszm_lakcim);
            szpn_szuroPanel.Controls.Add(kszm_telefon);
            szpn_szuroPanel.Controls.Add(kszm_email);
            szpn_szuroPanel.Controls.Add(kszm_utasNeve);
            szpn_szuroPanel.Controls.Add(kg_pipa);
            szpn_szuroPanel.ForeColor = Color.Black;
            szpn_szuroPanel.Location = new Point(234, 174);
            szpn_szuroPanel.Margin = new Padding(3, 2, 3, 2);
            szpn_szuroPanel.Name = "szpn_szuroPanel";
            szpn_szuroPanel.Size = new Size(672, 433);
            szpn_szuroPanel.TabIndex = 9;
            szpn_szuroPanel.Visible = false;
            // 
            // blbl_datum
            // 
            blbl_datum.AutoSize = true;
            blbl_datum.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            blbl_datum.Location = new Point(36, 253);
            blbl_datum.Name = "blbl_datum";
            blbl_datum.Size = new Size(226, 30);
            blbl_datum.TabIndex = 15;
            blbl_datum.Text = "Relatív dátum választó:";
            // 
            // dtp_relativDatum
            // 
            dtp_relativDatum.CalendarFont = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_relativDatum.Checked = false;
            dtp_relativDatum.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_relativDatum.Location = new Point(39, 300);
            dtp_relativDatum.Name = "dtp_relativDatum";
            dtp_relativDatum.ShowCheckBox = true;
            dtp_relativDatum.Size = new Size(343, 35);
            dtp_relativDatum.TabIndex = 14;
            // 
            // klm_allapot
            // 
            klm_allapot.adatForras = new string[]
    {
    "Mind",
    "érdeklődik",
    "foglalva ",
    "lemondva"
    };
            klm_allapot.BackColor = Color.Transparent;
            klm_allapot.CimPanelAlsoSzin = Color.White;
            klm_allapot.CimPanelFelsoSzin = Color.White;
            klm_allapot.ComboText = "Állapot";
            klm_allapot.EgerTrartasSzin = Color.CornflowerBlue;
            klm_allapot.ForeColor = Color.White;
            klm_allapot.Ikon = (Image)resources.GetObject("klm_allapot.Ikon");
            klm_allapot.ItemHatterSzin = Color.White;
            klm_allapot.ItemPanelAlosSzin = Color.White;
            klm_allapot.ItemPanelFelsoSzin = Color.White;
            klm_allapot.KeretSzin = Color.MediumSlateBlue;
            klm_allapot.KeretVastagsag = 2F;
            klm_allapot.KivalasztottElemSzin = Color.BlueViolet;
            klm_allapot.LenyiloMagassag = 150;
            klm_allapot.Location = new Point(400, 44);
            klm_allapot.Margin = new Padding(2, 3, 2, 3);
            klm_allapot.MinimumSize = new Size(150, 0);
            klm_allapot.Name = "klm_allapot";
            klm_allapot.Radius = 10;
            klm_allapot.Size = new Size(251, 63);
            klm_allapot.TabIndex = 2;
            klm_allapot.TitleLabelSzin = Color.Black;
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
            kszm_lakcim.Location = new Point(39, 207);
            kszm_lakcim.Margin = new Padding(4, 3, 4, 3);
            kszm_lakcim.Name = "kszm_lakcim";
            kszm_lakcim.Padding = new Padding(9, 6, 9, 6);
            kszm_lakcim.Size = new Size(343, 31);
            kszm_lakcim.TabIndex = 3;
            kszm_lakcim.Texts = "";
            kszm_lakcim.TobbSor = false;
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
            kszm_telefon.Location = new Point(39, 153);
            kszm_telefon.Margin = new Padding(4, 3, 4, 3);
            kszm_telefon.Name = "kszm_telefon";
            kszm_telefon.Padding = new Padding(9, 6, 9, 6);
            kszm_telefon.Size = new Size(343, 31);
            kszm_telefon.TabIndex = 2;
            kszm_telefon.Texts = "";
            kszm_telefon.TobbSor = false;
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
            kszm_email.Location = new Point(39, 97);
            kszm_email.Margin = new Padding(4, 3, 4, 3);
            kszm_email.Name = "kszm_email";
            kszm_email.Padding = new Padding(9, 6, 9, 6);
            kszm_email.Size = new Size(343, 31);
            kszm_email.TabIndex = 1;
            kszm_email.Texts = "";
            kszm_email.TobbSor = false;
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
            // 
            // kg_pipa
            // 
            kg_pipa.BackColor = Color.WhiteSmoke;
            kg_pipa.BackgroundImageLayout = ImageLayout.Center;
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
            // pnl_vezerlopanel
            // 
            pnl_vezerlopanel.BackColor = Color.DarkViolet;
            pnl_vezerlopanel.Controls.Add(tlp_szerkesztes);
            pnl_vezerlopanel.Controls.Add(tlp_fomenu);
            pnl_vezerlopanel.Dock = DockStyle.Top;
            pnl_vezerlopanel.Location = new Point(0, 0);
            pnl_vezerlopanel.Name = "pnl_vezerlopanel";
            pnl_vezerlopanel.Size = new Size(1068, 169);
            pnl_vezerlopanel.TabIndex = 7;
            // 
            // tlp_szerkesztes
            // 
            tlp_szerkesztes.BackColor = Color.FromArgb(243, 244, 246);
            tlp_szerkesztes.ColumnCount = 5;
            tlp_szerkesztes.ColumnStyles.Add(new ColumnStyle());
            tlp_szerkesztes.ColumnStyles.Add(new ColumnStyle());
            tlp_szerkesztes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_szerkesztes.ColumnStyles.Add(new ColumnStyle());
            tlp_szerkesztes.ColumnStyles.Add(new ColumnStyle());
            tlp_szerkesztes.Controls.Add(kg_felvetelUtasnak, 2, 0);
            tlp_szerkesztes.Controls.Add(kg_mentes, 0, 0);
            tlp_szerkesztes.Controls.Add(pnl_segedPanel, 4, 0);
            tlp_szerkesztes.Controls.Add(lbl_allapotModositas, 3, 0);
            tlp_szerkesztes.Controls.Add(kg_torles, 1, 0);
            tlp_szerkesztes.Dock = DockStyle.Top;
            tlp_szerkesztes.Location = new Point(0, 70);
            tlp_szerkesztes.Name = "tlp_szerkesztes";
            tlp_szerkesztes.RowCount = 1;
            tlp_szerkesztes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_szerkesztes.Size = new Size(1068, 70);
            tlp_szerkesztes.TabIndex = 7;
            // 
            // kg_felvetelUtasnak
            // 
            kg_felvetelUtasnak.Anchor = AnchorStyles.Left;
            kg_felvetelUtasnak.BackColor = Color.MediumSlateBlue;
            kg_felvetelUtasnak.EgerTartasHatterSzine = Color.SlateBlue;
            kg_felvetelUtasnak.ErtesitesMutatasa = false;
            kg_felvetelUtasnak.ErtesitesSzam = 0;
            kg_felvetelUtasnak.ErtesitesSzin = Color.Red;
            kg_felvetelUtasnak.ErtesitesSzovegSzin = Color.White;
            kg_felvetelUtasnak.FlatAppearance.BorderSize = 0;
            kg_felvetelUtasnak.FlatStyle = FlatStyle.Flat;
            kg_felvetelUtasnak.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kg_felvetelUtasnak.ForeColor = Color.White;
            kg_felvetelUtasnak.HatterSzine = Color.MediumSlateBlue;
            kg_felvetelUtasnak.Image = (Image)resources.GetObject("kg_felvetelUtasnak.Image");
            kg_felvetelUtasnak.ImageAlign = ContentAlignment.MiddleRight;
            kg_felvetelUtasnak.KeretMeret = 0;
            kg_felvetelUtasnak.KeretSzine = Color.PaleVioletRed;
            kg_felvetelUtasnak.Location = new Point(309, 17);
            kg_felvetelUtasnak.Name = "kg_felvetelUtasnak";
            kg_felvetelUtasnak.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_felvetelUtasnak.SarokSugar = 8;
            kg_felvetelUtasnak.Size = new Size(184, 35);
            kg_felvetelUtasnak.SzovegSzine = Color.White;
            kg_felvetelUtasnak.TabIndex = 6;
            kg_felvetelUtasnak.Text = "Felvétel utasnak";
            kg_felvetelUtasnak.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_felvetelUtasnak.UseVisualStyleBackColor = false;
            kg_felvetelUtasnak.Click += kg_felvetelUtasnak_Click;
            // 
            // kg_mentes
            // 
            kg_mentes.Anchor = AnchorStyles.Left;
            kg_mentes.BackColor = Color.Green;
            kg_mentes.EgerTartasHatterSzine = Color.SlateBlue;
            kg_mentes.ErtesitesMutatasa = false;
            kg_mentes.ErtesitesSzam = 0;
            kg_mentes.ErtesitesSzin = Color.Red;
            kg_mentes.ErtesitesSzovegSzin = Color.White;
            kg_mentes.FlatAppearance.BorderSize = 0;
            kg_mentes.FlatStyle = FlatStyle.Flat;
            kg_mentes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kg_mentes.ForeColor = Color.White;
            kg_mentes.HatterSzine = Color.Green;
            kg_mentes.Image = (Image)resources.GetObject("kg_mentes.Image");
            kg_mentes.ImageAlign = ContentAlignment.MiddleRight;
            kg_mentes.KeretMeret = 0;
            kg_mentes.KeretSzine = Color.PaleVioletRed;
            kg_mentes.Location = new Point(3, 17);
            kg_mentes.Name = "kg_mentes";
            kg_mentes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_mentes.SarokSugar = 8;
            kg_mentes.Size = new Size(147, 35);
            kg_mentes.SzovegSzine = Color.White;
            kg_mentes.TabIndex = 0;
            kg_mentes.Text = "Mentés";
            kg_mentes.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_mentes.UseVisualStyleBackColor = false;
            kg_mentes.Click += Kg_mentes_Click;
            // 
            // pnl_segedPanel
            // 
            pnl_segedPanel.Location = new Point(823, 3);
            pnl_segedPanel.Name = "pnl_segedPanel";
            pnl_segedPanel.Size = new Size(242, 60);
            pnl_segedPanel.TabIndex = 4;
            // 
            // lbl_allapotModositas
            // 
            lbl_allapotModositas.Anchor = AnchorStyles.Right;
            lbl_allapotModositas.AutoSize = true;
            lbl_allapotModositas.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_allapotModositas.Location = new Point(632, 20);
            lbl_allapotModositas.Name = "lbl_allapotModositas";
            lbl_allapotModositas.Size = new Size(185, 30);
            lbl_allapotModositas.TabIndex = 5;
            lbl_allapotModositas.Text = "Állapot módosítás:";
            // 
            // kg_torles
            // 
            kg_torles.Anchor = AnchorStyles.Left;
            kg_torles.BackColor = Color.Crimson;
            kg_torles.EgerTartasHatterSzine = Color.SlateBlue;
            kg_torles.ErtesitesMutatasa = false;
            kg_torles.ErtesitesSzam = 0;
            kg_torles.ErtesitesSzin = Color.Red;
            kg_torles.ErtesitesSzovegSzin = Color.White;
            kg_torles.FlatAppearance.BorderSize = 0;
            kg_torles.FlatStyle = FlatStyle.Flat;
            kg_torles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kg_torles.ForeColor = Color.White;
            kg_torles.HatterSzine = Color.Crimson;
            kg_torles.Image = (Image)resources.GetObject("kg_torles.Image");
            kg_torles.ImageAlign = ContentAlignment.MiddleRight;
            kg_torles.KeretMeret = 0;
            kg_torles.KeretSzine = Color.PaleVioletRed;
            kg_torles.Location = new Point(156, 17);
            kg_torles.Name = "kg_torles";
            kg_torles.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_torles.SarokSugar = 8;
            kg_torles.Size = new Size(147, 35);
            kg_torles.SzovegSzine = Color.White;
            kg_torles.TabIndex = 3;
            kg_torles.Text = "Törlés";
            kg_torles.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_torles.UseVisualStyleBackColor = false;
            kg_torles.Click += Kg_torles_Click;
            // 
            // tlp_fomenu
            // 
            tlp_fomenu.ColumnCount = 5;
            tlp_fomenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_fomenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_fomenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_fomenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_fomenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_fomenu.Controls.Add(kszm_szerkesztes, 0, 0);
            tlp_fomenu.Controls.Add(kg_telefonszamMasolas, 4, 0);
            tlp_fomenu.Controls.Add(kg_szures, 2, 0);
            tlp_fomenu.Controls.Add(kg_email, 3, 0);
            tlp_fomenu.Controls.Add(nud_oldalszam, 1, 0);
            tlp_fomenu.Dock = DockStyle.Top;
            tlp_fomenu.Location = new Point(0, 0);
            tlp_fomenu.Name = "tlp_fomenu";
            tlp_fomenu.RowCount = 1;
            tlp_fomenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_fomenu.Size = new Size(1068, 70);
            tlp_fomenu.TabIndex = 6;
            // 
            // kszm_szerkesztes
            // 
            kszm_szerkesztes.Anchor = AnchorStyles.Left;
            kszm_szerkesztes.BackColor = Color.DarkGoldenrod;
            kszm_szerkesztes.EgerTartasHatterSzine = Color.SlateBlue;
            kszm_szerkesztes.ErtesitesMutatasa = false;
            kszm_szerkesztes.ErtesitesSzam = 0;
            kszm_szerkesztes.ErtesitesSzin = Color.Red;
            kszm_szerkesztes.ErtesitesSzovegSzin = Color.White;
            kszm_szerkesztes.FlatAppearance.BorderSize = 0;
            kszm_szerkesztes.FlatStyle = FlatStyle.Flat;
            kszm_szerkesztes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_szerkesztes.ForeColor = Color.White;
            kszm_szerkesztes.HatterSzine = Color.DarkGoldenrod;
            kszm_szerkesztes.Image = (Image)resources.GetObject("kszm_szerkesztes.Image");
            kszm_szerkesztes.ImageAlign = ContentAlignment.MiddleRight;
            kszm_szerkesztes.KeretMeret = 0;
            kszm_szerkesztes.KeretSzine = Color.PaleVioletRed;
            kszm_szerkesztes.Location = new Point(3, 17);
            kszm_szerkesztes.Name = "kszm_szerkesztes";
            kszm_szerkesztes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_szerkesztes.SarokSugar = 8;
            kszm_szerkesztes.Size = new Size(147, 35);
            kszm_szerkesztes.SzovegSzine = Color.White;
            kszm_szerkesztes.TabIndex = 0;
            kszm_szerkesztes.Text = "Szerkesztés";
            kszm_szerkesztes.TextImageRelation = TextImageRelation.ImageBeforeText;
            kszm_szerkesztes.UseVisualStyleBackColor = false;
            kszm_szerkesztes.Click += kszm_szerkesztes_Click;
            // 
            // kg_telefonszamMasolas
            // 
            kg_telefonszamMasolas.Anchor = AnchorStyles.Left;
            kg_telefonszamMasolas.BackColor = Color.MediumSlateBlue;
            kg_telefonszamMasolas.EgerTartasHatterSzine = Color.SlateBlue;
            kg_telefonszamMasolas.ErtesitesMutatasa = false;
            kg_telefonszamMasolas.ErtesitesSzam = 0;
            kg_telefonszamMasolas.ErtesitesSzin = Color.Red;
            kg_telefonszamMasolas.ErtesitesSzovegSzin = Color.White;
            kg_telefonszamMasolas.FlatAppearance.BorderSize = 0;
            kg_telefonszamMasolas.FlatStyle = FlatStyle.Flat;
            kg_telefonszamMasolas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kg_telefonszamMasolas.ForeColor = Color.White;
            kg_telefonszamMasolas.HatterSzine = Color.MediumSlateBlue;
            kg_telefonszamMasolas.Image = (Image)resources.GetObject("kg_telefonszamMasolas.Image");
            kg_telefonszamMasolas.ImageAlign = ContentAlignment.MiddleRight;
            kg_telefonszamMasolas.KeretMeret = 0;
            kg_telefonszamMasolas.KeretSzine = Color.PaleVioletRed;
            kg_telefonszamMasolas.Location = new Point(855, 17);
            kg_telefonszamMasolas.Name = "kg_telefonszamMasolas";
            kg_telefonszamMasolas.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_telefonszamMasolas.SarokSugar = 8;
            kg_telefonszamMasolas.Size = new Size(147, 35);
            kg_telefonszamMasolas.SzovegSzine = Color.White;
            kg_telefonszamMasolas.TabIndex = 5;
            kg_telefonszamMasolas.Text = "Telefon Szám";
            kg_telefonszamMasolas.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_telefonszamMasolas.UseVisualStyleBackColor = false;
            kg_telefonszamMasolas.Click += Kg_telefonszamMasolas_Click;
            // 
            // kg_szures
            // 
            kg_szures.Anchor = AnchorStyles.Left;
            kg_szures.BackColor = Color.MediumSlateBlue;
            kg_szures.EgerTartasHatterSzine = Color.SlateBlue;
            kg_szures.ErtesitesMutatasa = false;
            kg_szures.ErtesitesSzam = 0;
            kg_szures.ErtesitesSzin = Color.Red;
            kg_szures.ErtesitesSzovegSzin = Color.White;
            kg_szures.FlatAppearance.BorderSize = 0;
            kg_szures.FlatStyle = FlatStyle.Flat;
            kg_szures.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kg_szures.ForeColor = Color.White;
            kg_szures.HatterSzine = Color.MediumSlateBlue;
            kg_szures.Image = (Image)resources.GetObject("kg_szures.Image");
            kg_szures.ImageAlign = ContentAlignment.MiddleRight;
            kg_szures.KeretMeret = 0;
            kg_szures.KeretSzine = Color.PaleVioletRed;
            kg_szures.Location = new Point(429, 17);
            kg_szures.Name = "kg_szures";
            kg_szures.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_szures.SarokSugar = 8;
            kg_szures.Size = new Size(147, 35);
            kg_szures.SzovegSzine = Color.White;
            kg_szures.TabIndex = 3;
            kg_szures.Text = "Szűrés";
            kg_szures.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_szures.UseVisualStyleBackColor = false;
            kg_szures.Click += kg_szures_Click;
            // 
            // kg_email
            // 
            kg_email.Anchor = AnchorStyles.Left;
            kg_email.BackColor = Color.MediumSlateBlue;
            kg_email.EgerTartasHatterSzine = Color.SlateBlue;
            kg_email.ErtesitesMutatasa = false;
            kg_email.ErtesitesSzam = 0;
            kg_email.ErtesitesSzin = Color.Red;
            kg_email.ErtesitesSzovegSzin = Color.White;
            kg_email.FlatAppearance.BorderSize = 0;
            kg_email.FlatStyle = FlatStyle.Flat;
            kg_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kg_email.ForeColor = Color.White;
            kg_email.HatterSzine = Color.MediumSlateBlue;
            kg_email.Image = (Image)resources.GetObject("kg_email.Image");
            kg_email.ImageAlign = ContentAlignment.MiddleRight;
            kg_email.KeretMeret = 0;
            kg_email.KeretSzine = Color.PaleVioletRed;
            kg_email.Location = new Point(642, 17);
            kg_email.Name = "kg_email";
            kg_email.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_email.SarokSugar = 8;
            kg_email.Size = new Size(147, 35);
            kg_email.SzovegSzine = Color.White;
            kg_email.TabIndex = 4;
            kg_email.Text = "E-mail";
            kg_email.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_email.UseVisualStyleBackColor = false;
            kg_email.Click += Kg_email_Click;
            // 
            // klm_foglalasiAllapot
            // 
            klm_foglalasiAllapot.adatForras = new string[]
    {
    "érdeklődik",
    "foglalva",
    "lemondva"
    };
            klm_foglalasiAllapot.BackColor = Color.Transparent;
            klm_foglalasiAllapot.CimPanelAlsoSzin = Color.White;
            klm_foglalasiAllapot.CimPanelFelsoSzin = Color.White;
            klm_foglalasiAllapot.ComboText = "Álllapot";
            klm_foglalasiAllapot.EgerTrartasSzin = Color.Violet;
            klm_foglalasiAllapot.ForeColor = Color.Transparent;
            klm_foglalasiAllapot.Ikon = (Image)resources.GetObject("klm_foglalasiAllapot.Ikon");
            klm_foglalasiAllapot.ItemHatterSzin = Color.WhiteSmoke;
            klm_foglalasiAllapot.ItemPanelAlosSzin = Color.WhiteSmoke;
            klm_foglalasiAllapot.ItemPanelFelsoSzin = Color.WhiteSmoke;
            klm_foglalasiAllapot.KeretSzin = Color.RoyalBlue;
            klm_foglalasiAllapot.KeretVastagsag = 1F;
            klm_foglalasiAllapot.KivalasztottElemSzin = Color.BlueViolet;
            klm_foglalasiAllapot.LenyiloMagassag = 110;
            klm_foglalasiAllapot.Location = new Point(813, 4);
            klm_foglalasiAllapot.Margin = new Padding(2, 3, 2, 3);
            klm_foglalasiAllapot.MinimumSize = new Size(150, 0);
            klm_foglalasiAllapot.Name = "klm_foglalasiAllapot";
            klm_foglalasiAllapot.Radius = 8;
            klm_foglalasiAllapot.Size = new Size(242, 59);
            klm_foglalasiAllapot.TabIndex = 2;
            klm_foglalasiAllapot.TitleLabelSzin = Color.Black;
            klm_foglalasiAllapot.ElemKivalasztva += klm_foglalasiAllapot_ElemKivalasztva;
            // 
            // dgv_utasok
            // 
            dgv_utasok.AllowUserToAddRows = false;
            dgv_utasok.AllowUserToResizeRows = false;
            dgv_utasok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_utasok.BackgroundColor = SystemColors.ControlLightLight;
            dgv_utasok.BorderStyle = BorderStyle.None;
            dgv_utasok.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgv_utasok.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_utasok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_utasok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = Color.BlueViolet;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_utasok.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_utasok.Dock = DockStyle.Fill;
            dgv_utasok.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv_utasok.EnableHeadersVisualStyles = false;
            dgv_utasok.GridColor = SystemColors.InactiveBorder;
            dgv_utasok.Location = new Point(0, 169);
            dgv_utasok.MultiSelect = false;
            dgv_utasok.Name = "dgv_utasok";
            dgv_utasok.ReadOnly = true;
            dgv_utasok.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_utasok.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_utasok.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv_utasok.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_utasok.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgv_utasok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_utasok.ShowEditingIcon = false;
            dgv_utasok.ShowRowErrors = false;
            dgv_utasok.Size = new Size(1068, 404);
            dgv_utasok.TabIndex = 8;
            // 
            // ev_fomenu
            // 
            ev_fomenu.SarokSugar = 20;
            ev_fomenu.TargetControl = pnl_vezerlopanel;
            // 
            // nud_oldalszam
            // 
            nud_oldalszam.Anchor = AnchorStyles.Left;
            nud_oldalszam.BackColor = Color.Transparent;
            nud_oldalszam.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nud_oldalszam.KeretSzin = Color.Gray;
            nud_oldalszam.KeretVastagsag = 1.5F;
            nud_oldalszam.Location = new Point(216, 18);
            nud_oldalszam.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            nud_oldalszam.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nud_oldalszam.MinimumSize = new Size(80, 25);
            nud_oldalszam.Name = "nud_oldalszam";
            nud_oldalszam.Radius = 10;
            nud_oldalszam.Size = new Size(132, 33);
            nud_oldalszam.TabIndex = 6;
            nud_oldalszam.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // frm_Elofoglalasok
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 573);
            Controls.Add(szpn_szuroPanel);
            Controls.Add(klm_foglalasiAllapot);
            Controls.Add(dgv_utasok);
            Controls.Add(pnl_vezerlopanel);
            Name = "frm_Elofoglalasok";
            Text = "frm_Elofoglalasok";
            Resize += frm_Elofoglalasok_Resize;
            szpn_szuroPanel.ResumeLayout(false);
            szpn_szuroPanel.PerformLayout();
            pnl_vezerlopanel.ResumeLayout(false);
            tlp_szerkesztes.ResumeLayout(false);
            tlp_szerkesztes.PerformLayout();
            tlp_fomenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_utasok).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_vezerlopanel;
        private egyeni_vezerlok.KerekitettGomb kszm_szerkesztes;
        private egyeni_vezerlok.DoubleBufferedDataGridView dgv_utasok;
        private egyeni_vezerlok.kerekitettLenyilloMenu klm_foglalasiAllapot;
        private egyeni_vezerlok.KerekitettGomb kg_szures;
        private egyeni_vezerlok.KerekitettGomb kg_telefonszamMasolas;
        private egyeni_vezerlok.KerekitettGomb kg_email;
        private TableLayoutPanel tlp_fomenu;
        private TableLayoutPanel tlp_szerkesztes;
        private egyeni_vezerlok.KerekitettGomb kg_mentes;
        private egyeni_vezerlok.KerekitettGomb kg_torles;
        private Panel pnl_segedPanel;
        private Label lbl_allapotModositas;
        private Panel szpn_szuroPanel;
        private DateTimePicker dtp_relativDatum;
        private egyeni_vezerlok.kerekitettLenyilloMenu klm_allapot;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_lakcim;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_telefon;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_email;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_utasNeve;
        private egyeni_vezerlok.KerekitettGomb kg_pipa;
        private egyeni_vezerlok.BufferedLabel blbl_datum;
        private egyeni_vezerlok.ellipszisVezerlo ev_fomenu;
        private egyeni_vezerlok.KerekitettGomb kg_felvetelUtasnak;
        private egyeni_vezerlok.KerekitettNumericUpDown nud_oldalszam;
    }
}