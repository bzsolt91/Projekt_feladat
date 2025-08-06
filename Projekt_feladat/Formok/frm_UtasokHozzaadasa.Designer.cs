using System.Windows.Forms;

namespace Projekt_feladat.Formok
{
    partial class frm_UtasokHozzaadasa
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
            egyeni_vezerlok.ellipszisVezerlo ev_vezerlopanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UtasokHozzaadasa));
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            pnl_vezerlopanel = new Panel();
            kszm_ujRegiFelhasznalo = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kszm_mentes = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kszm_titulus = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_vezeteknev = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_keresztnev1 = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_keresztnev2 = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            dtp_szulido = new DateTimePicker();
            kszm_lakcim = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            lbl_szulido = new Label();
            kszm_email = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_okmanySzam = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            dtp_okmany = new DateTimePicker();
            lbl_okmanyLejarat = new Label();
            kszm_telefon = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_befizetettOsszeg = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            lbl_biztositas = new Label();
            kg_biztositas = new Projekt_feladat.egyeni_vezerlok.KapcsoloGomb();
            kszm_megjegyzes = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            rcb_desztinacio = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            rcb_utazasIdeje = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            rcb_utazasElnevezese = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            lb_utazasok = new ListBox();
            kszm_utazasTorlese = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            pnl_ujhozzaadas = new Panel();
            pnl_meglevoutasokhozAdas = new Panel();
            label1 = new Label();
            lbl_regiszulido = new Label();
            dtp_regiSzulido = new DateTimePicker();
            kszm_regiokmanyszam = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_reginev = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            dgv_meglevoUtasok = new Projekt_feladat.egyeni_vezerlok.DoubleBufferedDataGridView();
            pnl_eszkozok = new Panel();
            ev_vezerlopanel = new Projekt_feladat.egyeni_vezerlok.ellipszisVezerlo();
            pnl_vezerlopanel.SuspendLayout();
            pnl_ujhozzaadas.SuspendLayout();
            pnl_meglevoutasokhozAdas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_meglevoUtasok).BeginInit();
            pnl_eszkozok.SuspendLayout();
            SuspendLayout();
            // 
            // ev_vezerlopanel
            // 
            ev_vezerlopanel.SarokSugar = 9;
            ev_vezerlopanel.TargetControl = pnl_vezerlopanel;
            // 
            // pnl_vezerlopanel
            // 
            pnl_vezerlopanel.BackColor = Color.DarkViolet;
            pnl_vezerlopanel.Controls.Add(kszm_ujRegiFelhasznalo);
            pnl_vezerlopanel.Controls.Add(kszm_mentes);
            pnl_vezerlopanel.Dock = DockStyle.Bottom;
            pnl_vezerlopanel.Location = new Point(0, 484);
            pnl_vezerlopanel.Name = "pnl_vezerlopanel";
            pnl_vezerlopanel.Size = new Size(994, 52);
            pnl_vezerlopanel.TabIndex = 6;
            // 
            // kszm_ujRegiFelhasznalo
            // 
            kszm_ujRegiFelhasznalo.BackColor = Color.Chocolate;
            kszm_ujRegiFelhasznalo.EgerTartasHatterSzine = Color.SlateBlue;
            kszm_ujRegiFelhasznalo.FlatAppearance.BorderSize = 0;
            kszm_ujRegiFelhasznalo.FlatStyle = FlatStyle.Flat;
            kszm_ujRegiFelhasznalo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_ujRegiFelhasznalo.ForeColor = Color.White;
            kszm_ujRegiFelhasznalo.HatterSzine = Color.Chocolate;
            kszm_ujRegiFelhasznalo.Image = (Image)resources.GetObject("kszm_ujRegiFelhasznalo.Image");
            kszm_ujRegiFelhasznalo.ImageAlign = ContentAlignment.TopCenter;
            kszm_ujRegiFelhasznalo.KeretMeret = 0;
            kszm_ujRegiFelhasznalo.KeretSzine = Color.PaleVioletRed;
            kszm_ujRegiFelhasznalo.Location = new Point(201, 7);
            kszm_ujRegiFelhasznalo.Name = "kszm_ujRegiFelhasznalo";
            kszm_ujRegiFelhasznalo.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_ujRegiFelhasznalo.SarokSugar = 8;
            kszm_ujRegiFelhasznalo.Size = new Size(315, 35);
            kszm_ujRegiFelhasznalo.SzovegSzine = Color.White;
            kszm_ujRegiFelhasznalo.TabIndex = 1;
            kszm_ujRegiFelhasznalo.Text = "Meglévő felhasználóhoz adás";
            kszm_ujRegiFelhasznalo.TextImageRelation = TextImageRelation.ImageBeforeText;
            kszm_ujRegiFelhasznalo.UseVisualStyleBackColor = false;
            kszm_ujRegiFelhasznalo.Click += kszm_ujRegiFelhasznalo_Click;
            // 
            // kszm_mentes
            // 
            kszm_mentes.BackColor = Color.MediumSlateBlue;
            kszm_mentes.EgerTartasHatterSzine = Color.SlateBlue;
            kszm_mentes.FlatAppearance.BorderSize = 0;
            kszm_mentes.FlatStyle = FlatStyle.Flat;
            kszm_mentes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_mentes.ForeColor = Color.White;
            kszm_mentes.HatterSzine = Color.MediumSlateBlue;
            kszm_mentes.Image = (Image)resources.GetObject("kszm_mentes.Image");
            kszm_mentes.ImageAlign = ContentAlignment.MiddleRight;
            kszm_mentes.KeretMeret = 0;
            kszm_mentes.KeretSzine = Color.PaleVioletRed;
            kszm_mentes.Location = new Point(24, 7);
            kszm_mentes.Name = "kszm_mentes";
            kszm_mentes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_mentes.SarokSugar = 8;
            kszm_mentes.Size = new Size(147, 35);
            kszm_mentes.SzovegSzine = Color.White;
            kszm_mentes.TabIndex = 0;
            kszm_mentes.Text = "Mentés";
            kszm_mentes.TextImageRelation = TextImageRelation.ImageBeforeText;
            kszm_mentes.UseVisualStyleBackColor = false;
            kszm_mentes.Click += kszm_mentes_Click;
            // 
            // kszm_titulus
            // 
            kszm_titulus.AlahuzottStilus = false;
            kszm_titulus.BackColor = SystemColors.Window;
            kszm_titulus.FokuszKeretSzin = Color.HotPink;
            kszm_titulus.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_titulus.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_titulus.HelyorzoSzin = Color.DarkGray;
            kszm_titulus.HelyorzoSzoveg = "Titulus";
            kszm_titulus.JelszoKarakter = false;
            kszm_titulus.KeretMeret = 2;
            kszm_titulus.KeretSugar = 8;
            kszm_titulus.KeretSzin = Color.MediumSlateBlue;
            kszm_titulus.Location = new Point(11, 11);
            kszm_titulus.Margin = new Padding(4, 3, 4, 3);
            kszm_titulus.Name = "kszm_titulus";
            kszm_titulus.Padding = new Padding(9, 6, 9, 6);
            kszm_titulus.Size = new Size(109, 30);
            kszm_titulus.TabIndex = 0;
            kszm_titulus.Texts = "";
            kszm_titulus.TobbSor = false;
            kszm_titulus._SzovegValtoztatva += kszm_AutoComplete;
            kszm_titulus.KeyDown += SzovegMezo_KeyDown;
            kszm_titulus.Leave += kszm_Leave;
            // 
            // kszm_vezeteknev
            // 
            kszm_vezeteknev.AlahuzottStilus = false;
            kszm_vezeteknev.BackColor = SystemColors.Window;
            kszm_vezeteknev.FokuszKeretSzin = Color.HotPink;
            kszm_vezeteknev.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_vezeteknev.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_vezeteknev.HelyorzoSzin = Color.DarkGray;
            kszm_vezeteknev.HelyorzoSzoveg = "Vezetéknév";
            kszm_vezeteknev.JelszoKarakter = false;
            kszm_vezeteknev.KeretMeret = 2;
            kszm_vezeteknev.KeretSugar = 8;
            kszm_vezeteknev.KeretSzin = Color.MediumSlateBlue;
            kszm_vezeteknev.Location = new Point(128, 11);
            kszm_vezeteknev.Margin = new Padding(4, 3, 4, 3);
            kszm_vezeteknev.Name = "kszm_vezeteknev";
            kszm_vezeteknev.Padding = new Padding(9, 6, 9, 6);
            kszm_vezeteknev.Size = new Size(220, 30);
            kszm_vezeteknev.TabIndex = 1;
            kszm_vezeteknev.Texts = "";
            kszm_vezeteknev.TobbSor = false;
            kszm_vezeteknev._SzovegValtoztatva += kszm_AutoComplete;
            kszm_vezeteknev.KeyDown += SzovegMezo_KeyDown;
            kszm_vezeteknev.Leave += kszm_Leave;
            // 
            // kszm_keresztnev1
            // 
            kszm_keresztnev1.AlahuzottStilus = false;
            kszm_keresztnev1.BackColor = SystemColors.Window;
            kszm_keresztnev1.FokuszKeretSzin = Color.HotPink;
            kszm_keresztnev1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_keresztnev1.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_keresztnev1.HelyorzoSzin = Color.DarkGray;
            kszm_keresztnev1.HelyorzoSzoveg = "Keresztnév";
            kszm_keresztnev1.JelszoKarakter = false;
            kszm_keresztnev1.KeretMeret = 2;
            kszm_keresztnev1.KeretSugar = 8;
            kszm_keresztnev1.KeretSzin = Color.MediumSlateBlue;
            kszm_keresztnev1.Location = new Point(355, 11);
            kszm_keresztnev1.Margin = new Padding(4, 3, 4, 3);
            kszm_keresztnev1.Name = "kszm_keresztnev1";
            kszm_keresztnev1.Padding = new Padding(9, 6, 9, 6);
            kszm_keresztnev1.Size = new Size(212, 30);
            kszm_keresztnev1.TabIndex = 2;
            kszm_keresztnev1.Texts = "";
            kszm_keresztnev1.TobbSor = false;
            kszm_keresztnev1._SzovegValtoztatva += kszm_AutoComplete;
            kszm_keresztnev1.KeyDown += SzovegMezo_KeyDown;
            kszm_keresztnev1.Leave += kszm_Leave;
            // 
            // kszm_keresztnev2
            // 
            kszm_keresztnev2.AlahuzottStilus = false;
            kszm_keresztnev2.BackColor = SystemColors.Window;
            kszm_keresztnev2.FokuszKeretSzin = Color.HotPink;
            kszm_keresztnev2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_keresztnev2.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_keresztnev2.HelyorzoSzin = Color.DarkGray;
            kszm_keresztnev2.HelyorzoSzoveg = "Keresztnév 2";
            kszm_keresztnev2.JelszoKarakter = false;
            kszm_keresztnev2.KeretMeret = 2;
            kszm_keresztnev2.KeretSugar = 8;
            kszm_keresztnev2.KeretSzin = Color.MediumSlateBlue;
            kszm_keresztnev2.Location = new Point(574, 11);
            kszm_keresztnev2.Margin = new Padding(4, 3, 4, 3);
            kszm_keresztnev2.Name = "kszm_keresztnev2";
            kszm_keresztnev2.Padding = new Padding(9, 6, 9, 6);
            kszm_keresztnev2.Size = new Size(238, 30);
            kszm_keresztnev2.TabIndex = 3;
            kszm_keresztnev2.Texts = "";
            kszm_keresztnev2.TobbSor = false;
            kszm_keresztnev2._SzovegValtoztatva += kszm_AutoComplete;
            kszm_keresztnev2.KeyDown += SzovegMezo_KeyDown;
            kszm_keresztnev2.Leave += kszm_Leave;
            // 
            // dtp_szulido
            // 
            dtp_szulido.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_szulido.CalendarTitleBackColor = Color.DarkViolet;
            dtp_szulido.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_szulido.Location = new Point(593, 52);
            dtp_szulido.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtp_szulido.Name = "dtp_szulido";
            dtp_szulido.Size = new Size(219, 35);
            dtp_szulido.TabIndex = 4;
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
            kszm_lakcim.Location = new Point(10, 57);
            kszm_lakcim.Margin = new Padding(4, 3, 4, 3);
            kszm_lakcim.Name = "kszm_lakcim";
            kszm_lakcim.Padding = new Padding(9, 6, 9, 6);
            kszm_lakcim.Size = new Size(382, 30);
            kszm_lakcim.TabIndex = 5;
            kszm_lakcim.Texts = "";
            kszm_lakcim.TobbSor = false;
            kszm_lakcim._SzovegValtoztatva += kszm_AutoComplete;
            kszm_lakcim.KeyDown += SzovegMezo_KeyDown;
            kszm_lakcim.Leave += kszm_Leave;
            // 
            // lbl_szulido
            // 
            lbl_szulido.AutoSize = true;
            lbl_szulido.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_szulido.Location = new Point(410, 57);
            lbl_szulido.Name = "lbl_szulido";
            lbl_szulido.Size = new Size(164, 30);
            lbl_szulido.TabIndex = 7;
            lbl_szulido.Text = "Születési dátum:";
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
            kszm_email.Location = new Point(10, 94);
            kszm_email.Margin = new Padding(4, 3, 4, 3);
            kszm_email.Name = "kszm_email";
            kszm_email.Padding = new Padding(9, 6, 9, 6);
            kszm_email.Size = new Size(273, 30);
            kszm_email.TabIndex = 8;
            kszm_email.Texts = "";
            kszm_email.TobbSor = false;
            kszm_email._SzovegValtoztatva += kszm_AutoComplete;
            kszm_email.KeyDown += SzovegMezo_KeyDown;
            kszm_email.Leave += kszm_Leave;
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
            kszm_okmanySzam.Location = new Point(10, 130);
            kszm_okmanySzam.Margin = new Padding(4, 3, 4, 3);
            kszm_okmanySzam.Name = "kszm_okmanySzam";
            kszm_okmanySzam.Padding = new Padding(9, 6, 9, 6);
            kszm_okmanySzam.Size = new Size(273, 30);
            kszm_okmanySzam.TabIndex = 9;
            kszm_okmanySzam.Texts = "";
            kszm_okmanySzam.TobbSor = false;
            kszm_okmanySzam._SzovegValtoztatva += kszm_AutoComplete;
            kszm_okmanySzam.KeyDown += SzovegMezo_KeyDown;
            kszm_okmanySzam.Leave += kszm_Leave;
            // 
            // dtp_okmany
            // 
            dtp_okmany.CalendarTitleBackColor = Color.DarkViolet;
            dtp_okmany.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_okmany.Location = new Point(593, 130);
            dtp_okmany.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtp_okmany.Name = "dtp_okmany";
            dtp_okmany.Size = new Size(219, 35);
            dtp_okmany.TabIndex = 10;
            // 
            // lbl_okmanyLejarat
            // 
            lbl_okmanyLejarat.AutoSize = true;
            lbl_okmanyLejarat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_okmanyLejarat.Location = new Point(410, 130);
            lbl_okmanyLejarat.Name = "lbl_okmanyLejarat";
            lbl_okmanyLejarat.Size = new Size(158, 30);
            lbl_okmanyLejarat.TabIndex = 11;
            lbl_okmanyLejarat.Text = "Okmány lejárat:";
            // 
            // kszm_telefon
            // 
            kszm_telefon.AlahuzottStilus = false;
            kszm_telefon.BackColor = SystemColors.Window;
            kszm_telefon.FokuszKeretSzin = Color.HotPink;
            kszm_telefon.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_telefon.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_telefon.HelyorzoSzin = Color.DarkGray;
            kszm_telefon.HelyorzoSzoveg = "Telefonszám";
            kszm_telefon.JelszoKarakter = false;
            kszm_telefon.KeretMeret = 2;
            kszm_telefon.KeretSugar = 8;
            kszm_telefon.KeretSzin = Color.MediumSlateBlue;
            kszm_telefon.Location = new Point(11, 178);
            kszm_telefon.Margin = new Padding(4, 3, 4, 3);
            kszm_telefon.Name = "kszm_telefon";
            kszm_telefon.Padding = new Padding(9, 6, 9, 6);
            kszm_telefon.Size = new Size(273, 30);
            kszm_telefon.TabIndex = 12;
            kszm_telefon.Texts = "";
            kszm_telefon.TobbSor = false;
            kszm_telefon._SzovegValtoztatva += kszm_AutoComplete;
            kszm_telefon.KeyDown += SzovegMezo_KeyDown;
            kszm_telefon.Leave += kszm_Leave;
            // 
            // kszm_befizetettOsszeg
            // 
            kszm_befizetettOsszeg.AlahuzottStilus = false;
            kszm_befizetettOsszeg.BackColor = SystemColors.Window;
            kszm_befizetettOsszeg.FokuszKeretSzin = Color.HotPink;
            kszm_befizetettOsszeg.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_befizetettOsszeg.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_befizetettOsszeg.HelyorzoSzin = Color.DarkGray;
            kszm_befizetettOsszeg.HelyorzoSzoveg = "Befizetett összeg";
            kszm_befizetettOsszeg.JelszoKarakter = false;
            kszm_befizetettOsszeg.KeretMeret = 2;
            kszm_befizetettOsszeg.KeretSugar = 8;
            kszm_befizetettOsszeg.KeretSzin = Color.MediumSlateBlue;
            kszm_befizetettOsszeg.Location = new Point(11, 224);
            kszm_befizetettOsszeg.Margin = new Padding(4, 3, 4, 3);
            kszm_befizetettOsszeg.Name = "kszm_befizetettOsszeg";
            kszm_befizetettOsszeg.Padding = new Padding(9, 6, 9, 6);
            kszm_befizetettOsszeg.Size = new Size(273, 30);
            kszm_befizetettOsszeg.TabIndex = 13;
            kszm_befizetettOsszeg.Texts = "";
            kszm_befizetettOsszeg.TobbSor = false;
            kszm_befizetettOsszeg.Leave += kszm_Leave;
            // 
            // lbl_biztositas
            // 
            lbl_biztositas.AutoSize = true;
            lbl_biztositas.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_biztositas.Location = new Point(410, 195);
            lbl_biztositas.Name = "lbl_biztositas";
            lbl_biztositas.Size = new Size(155, 30);
            lbl_biztositas.TabIndex = 14;
            lbl_biztositas.Text = "Biztosítása van:";
            // 
            // kg_biztositas
            // 
            kg_biztositas.AktualisAllas = egyeni_vezerlok.KapcsoloGomb.KapcsoloAllas.Ki;
            kg_biztositas.KetAllasuModAktiv = true;
            kg_biztositas.Location = new Point(593, 195);
            kg_biztositas.MinimumSize = new Size(61, 19);
            kg_biztositas.Name = "kg_biztositas";
            kg_biztositas.Size = new Size(96, 32);
            kg_biztositas.TabIndex = 15;
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
            kszm_megjegyzes.Location = new Point(11, 269);
            kszm_megjegyzes.Margin = new Padding(4, 3, 4, 3);
            kszm_megjegyzes.Name = "kszm_megjegyzes";
            kszm_megjegyzes.Padding = new Padding(9, 6, 9, 6);
            kszm_megjegyzes.Size = new Size(801, 30);
            kszm_megjegyzes.TabIndex = 16;
            kszm_megjegyzes.Texts = "";
            kszm_megjegyzes.TobbSor = true;
            kszm_megjegyzes._SzovegValtoztatva += kszm_AutoComplete;
            kszm_megjegyzes.KeyDown += SzovegMezo_KeyDown;
            kszm_megjegyzes.Leave += kszm_Leave;
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
            rcb_desztinacio.LenyiloMagassag = 100;
            rcb_desztinacio.Location = new Point(19, 15);
            rcb_desztinacio.Margin = new Padding(0);
            rcb_desztinacio.MinimumSize = new Size(150, 0);
            rcb_desztinacio.Name = "rcb_desztinacio";
            rcb_desztinacio.Padding = new Padding(0, 0, 0, 6);
            rcb_desztinacio.Radius = 20;
            rcb_desztinacio.Size = new Size(273, 65);
            rcb_desztinacio.TabIndex = 12;
            rcb_desztinacio.TitleLabelSzin = Color.Black;
            rcb_desztinacio.ElemKivalasztva += rcb_desztinacio_ElemKivalasztva;
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
            rcb_utazasIdeje.LenyiloMagassag = 100;
            rcb_utazasIdeje.Location = new Point(300, 15);
            rcb_utazasIdeje.Margin = new Padding(0);
            rcb_utazasIdeje.MinimumSize = new Size(150, 0);
            rcb_utazasIdeje.Name = "rcb_utazasIdeje";
            rcb_utazasIdeje.Padding = new Padding(0, 0, 0, 6);
            rcb_utazasIdeje.Radius = 20;
            rcb_utazasIdeje.Size = new Size(275, 65);
            rcb_utazasIdeje.TabIndex = 13;
            rcb_utazasIdeje.TitleLabelSzin = Color.Black;
            rcb_utazasIdeje.ElemKivalasztva += rcb_idoszak_ElemKivalasztva;
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
            rcb_utazasElnevezese.LenyiloMagassag = 100;
            rcb_utazasElnevezese.Location = new Point(587, 15);
            rcb_utazasElnevezese.Margin = new Padding(0);
            rcb_utazasElnevezese.MinimumSize = new Size(150, 0);
            rcb_utazasElnevezese.Name = "rcb_utazasElnevezese";
            rcb_utazasElnevezese.Padding = new Padding(0, 0, 0, 6);
            rcb_utazasElnevezese.Radius = 20;
            rcb_utazasElnevezese.Size = new Size(302, 65);
            rcb_utazasElnevezese.TabIndex = 14;
            rcb_utazasElnevezese.TitleLabelSzin = Color.Black;
            rcb_utazasElnevezese.ElemKivalasztva += rcb_utazasNeve_ElemKivalasztva;
            // 
            // lb_utazasok
            // 
            lb_utazasok.BorderStyle = BorderStyle.None;
            lb_utazasok.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lb_utazasok.FormattingEnabled = true;
            lb_utazasok.ItemHeight = 28;
            lb_utazasok.Location = new Point(28, 82);
            lb_utazasok.Name = "lb_utazasok";
            lb_utazasok.Size = new Size(690, 56);
            lb_utazasok.TabIndex = 17;
            lb_utazasok.DrawItem += lst_talalatok_DrawItem;
            // 
            // kszm_utazasTorlese
            // 
            kszm_utazasTorlese.BackColor = Color.MediumSlateBlue;
            kszm_utazasTorlese.EgerTartasHatterSzine = Color.SlateBlue;
            kszm_utazasTorlese.FlatAppearance.BorderSize = 0;
            kszm_utazasTorlese.FlatStyle = FlatStyle.Flat;
            kszm_utazasTorlese.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_utazasTorlese.ForeColor = Color.White;
            kszm_utazasTorlese.HatterSzine = Color.MediumSlateBlue;
            kszm_utazasTorlese.Image = (Image)resources.GetObject("kszm_utazasTorlese.Image");
            kszm_utazasTorlese.ImageAlign = ContentAlignment.MiddleRight;
            kszm_utazasTorlese.KeretMeret = 0;
            kszm_utazasTorlese.KeretSzine = Color.PaleVioletRed;
            kszm_utazasTorlese.Location = new Point(724, 95);
            kszm_utazasTorlese.Name = "kszm_utazasTorlese";
            kszm_utazasTorlese.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_utazasTorlese.SarokSugar = 8;
            kszm_utazasTorlese.Size = new Size(240, 42);
            kszm_utazasTorlese.SzovegSzine = Color.White;
            kszm_utazasTorlese.TabIndex = 18;
            kszm_utazasTorlese.Text = "Kiválasztott eltávolítása";
            kszm_utazasTorlese.TextImageRelation = TextImageRelation.ImageBeforeText;
            kszm_utazasTorlese.UseVisualStyleBackColor = false;
            kszm_utazasTorlese.Click += kszm_utazasTorlese_Click;
            // 
            // pnl_ujhozzaadas
            // 
            pnl_ujhozzaadas.AutoScroll = true;
            pnl_ujhozzaadas.AutoSize = true;
            pnl_ujhozzaadas.Controls.Add(kszm_titulus);
            pnl_ujhozzaadas.Controls.Add(kszm_vezeteknev);
            pnl_ujhozzaadas.Controls.Add(kszm_megjegyzes);
            pnl_ujhozzaadas.Controls.Add(kszm_keresztnev1);
            pnl_ujhozzaadas.Controls.Add(kg_biztositas);
            pnl_ujhozzaadas.Controls.Add(kszm_keresztnev2);
            pnl_ujhozzaadas.Controls.Add(lbl_biztositas);
            pnl_ujhozzaadas.Controls.Add(dtp_szulido);
            pnl_ujhozzaadas.Controls.Add(kszm_befizetettOsszeg);
            pnl_ujhozzaadas.Controls.Add(kszm_lakcim);
            pnl_ujhozzaadas.Controls.Add(kszm_telefon);
            pnl_ujhozzaadas.Controls.Add(lbl_szulido);
            pnl_ujhozzaadas.Controls.Add(lbl_okmanyLejarat);
            pnl_ujhozzaadas.Controls.Add(kszm_email);
            pnl_ujhozzaadas.Controls.Add(dtp_okmany);
            pnl_ujhozzaadas.Controls.Add(kszm_okmanySzam);
            pnl_ujhozzaadas.Dock = DockStyle.Fill;
            pnl_ujhozzaadas.Location = new Point(0, 189);
            pnl_ujhozzaadas.Name = "pnl_ujhozzaadas";
            pnl_ujhozzaadas.Size = new Size(994, 295);
            pnl_ujhozzaadas.TabIndex = 20;
            pnl_ujhozzaadas.Visible = false;
            pnl_ujhozzaadas.Click += kszm_Leave;
            // 
            // pnl_meglevoutasokhozAdas
            // 
            pnl_meglevoutasokhozAdas.Controls.Add(label1);
            pnl_meglevoutasokhozAdas.Controls.Add(lbl_regiszulido);
            pnl_meglevoutasokhozAdas.Controls.Add(dtp_regiSzulido);
            pnl_meglevoutasokhozAdas.Controls.Add(kszm_regiokmanyszam);
            pnl_meglevoutasokhozAdas.Controls.Add(kszm_reginev);
            pnl_meglevoutasokhozAdas.Controls.Add(dgv_meglevoUtasok);
            pnl_meglevoutasokhozAdas.Dock = DockStyle.Fill;
            pnl_meglevoutasokhozAdas.Location = new Point(0, 0);
            pnl_meglevoutasokhozAdas.Name = "pnl_meglevoutasokhozAdas";
            pnl_meglevoutasokhozAdas.Size = new Size(994, 536);
            pnl_meglevoutasokhozAdas.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 59);
            label1.Name = "label1";
            label1.Size = new Size(645, 25);
            label1.TabIndex = 6;
            label1.Text = "Válassza ki a listában amelyhez, hozzá kíván adni új utazásokat ⤵";
            // 
            // lbl_regiszulido
            // 
            lbl_regiszulido.AutoSize = true;
            lbl_regiszulido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_regiszulido.Location = new Point(568, 12);
            lbl_regiszulido.Name = "lbl_regiszulido";
            lbl_regiszulido.Size = new Size(114, 25);
            lbl_regiszulido.TabIndex = 4;
            lbl_regiszulido.Text = "Születési idő:";
            // 
            // dtp_regiSzulido
            // 
            dtp_regiSzulido.CalendarFont = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dtp_regiSzulido.CalendarTitleBackColor = Color.DarkViolet;
            dtp_regiSzulido.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dtp_regiSzulido.Location = new Point(705, 12);
            dtp_regiSzulido.Name = "dtp_regiSzulido";
            dtp_regiSzulido.Size = new Size(219, 35);
            dtp_regiSzulido.TabIndex = 2;
            dtp_regiSzulido.ValueChanged += KeresesiSzuroValtozott;
            // 
            // kszm_regiokmanyszam
            // 
            kszm_regiokmanyszam.AlahuzottStilus = false;
            kszm_regiokmanyszam.BackColor = SystemColors.Window;
            kszm_regiokmanyszam.FokuszKeretSzin = Color.HotPink;
            kszm_regiokmanyszam.Font = new Font("Microsoft Sans Serif", 10.8679247F);
            kszm_regiokmanyszam.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_regiokmanyszam.HelyorzoSzin = Color.DarkGray;
            kszm_regiokmanyszam.HelyorzoSzoveg = "Okmány szám";
            kszm_regiokmanyszam.JelszoKarakter = false;
            kszm_regiokmanyszam.KeretMeret = 2;
            kszm_regiokmanyszam.KeretSugar = 8;
            kszm_regiokmanyszam.KeretSzin = Color.MediumSlateBlue;
            kszm_regiokmanyszam.Location = new Point(347, 8);
            kszm_regiokmanyszam.Margin = new Padding(4, 3, 4, 3);
            kszm_regiokmanyszam.Name = "kszm_regiokmanyszam";
            kszm_regiokmanyszam.Padding = new Padding(9, 6, 9, 6);
            kszm_regiokmanyszam.Size = new Size(199, 33);
            kszm_regiokmanyszam.TabIndex = 1;
            kszm_regiokmanyszam.Texts = "";
            kszm_regiokmanyszam.TobbSor = false;
            kszm_regiokmanyszam._SzovegValtoztatva += KeresesiSzuroValtozott;
            // 
            // kszm_reginev
            // 
            kszm_reginev.AlahuzottStilus = false;
            kszm_reginev.BackColor = SystemColors.Window;
            kszm_reginev.FokuszKeretSzin = Color.HotPink;
            kszm_reginev.Font = new Font("Microsoft Sans Serif", 10.8679247F);
            kszm_reginev.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_reginev.HelyorzoSzin = Color.DarkGray;
            kszm_reginev.HelyorzoSzoveg = "Kezdje begépelni a nevet a kereséshez";
            kszm_reginev.JelszoKarakter = false;
            kszm_reginev.KeretMeret = 2;
            kszm_reginev.KeretSugar = 8;
            kszm_reginev.KeretSzin = Color.MediumSlateBlue;
            kszm_reginev.Location = new Point(4, 8);
            kszm_reginev.Margin = new Padding(4, 3, 4, 3);
            kszm_reginev.Name = "kszm_reginev";
            kszm_reginev.Padding = new Padding(9, 6, 9, 6);
            kszm_reginev.Size = new Size(324, 33);
            kszm_reginev.TabIndex = 0;
            kszm_reginev.Texts = "";
            kszm_reginev.TobbSor = false;
            kszm_reginev._SzovegValtoztatva += KeresesiSzuroValtozott;
            // 
            // dgv_meglevoUtasok
            // 
            dgv_meglevoUtasok.AllowUserToAddRows = false;
            dgv_meglevoUtasok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_meglevoUtasok.BackgroundColor = SystemColors.ControlLightLight;
            dgv_meglevoUtasok.BorderStyle = BorderStyle.None;
            dgv_meglevoUtasok.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgv_meglevoUtasok.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgv_meglevoUtasok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgv_meglevoUtasok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle17.Padding = new Padding(3);
            dataGridViewCellStyle17.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle17.SelectionForeColor = Color.BlueViolet;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dgv_meglevoUtasok.DefaultCellStyle = dataGridViewCellStyle17;
            dgv_meglevoUtasok.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv_meglevoUtasok.EnableHeadersVisualStyles = false;
            dgv_meglevoUtasok.GridColor = SystemColors.InactiveBorder;
            dgv_meglevoUtasok.Location = new Point(14, 91);
            dgv_meglevoUtasok.MultiSelect = false;
            dgv_meglevoUtasok.Name = "dgv_meglevoUtasok";
            dgv_meglevoUtasok.ReadOnly = true;
            dgv_meglevoUtasok.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.White;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dgv_meglevoUtasok.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            dgv_meglevoUtasok.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv_meglevoUtasok.RowsDefaultCellStyle = dataGridViewCellStyle18;
            dgv_meglevoUtasok.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgv_meglevoUtasok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_meglevoUtasok.ShowEditingIcon = false;
            dgv_meglevoUtasok.ShowRowErrors = false;
            dgv_meglevoUtasok.Size = new Size(818, 252);
            dgv_meglevoUtasok.TabIndex = 1;
            // 
            // pnl_eszkozok
            // 
            pnl_eszkozok.Controls.Add(rcb_utazasElnevezese);
            pnl_eszkozok.Controls.Add(rcb_utazasIdeje);
            pnl_eszkozok.Controls.Add(rcb_desztinacio);
            pnl_eszkozok.Controls.Add(lb_utazasok);
            pnl_eszkozok.Controls.Add(kszm_utazasTorlese);
            pnl_eszkozok.Dock = DockStyle.Top;
            pnl_eszkozok.Location = new Point(0, 0);
            pnl_eszkozok.Name = "pnl_eszkozok";
            pnl_eszkozok.Size = new Size(994, 189);
            pnl_eszkozok.TabIndex = 21;
            // 
            // frm_UtasokHozzaadasa
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(994, 536);
            Controls.Add(pnl_meglevoutasokhozAdas);
            Controls.Add(pnl_ujhozzaadas);
            Controls.Add(pnl_eszkozok);
            Controls.Add(pnl_vezerlopanel);
          
            Name = "frm_UtasokHozzaadasa";
            Text = "frm_UtasokHozzaadasa";
            Click += frm_UtasokHozzaadasa_Click;
            pnl_vezerlopanel.ResumeLayout(false);
            pnl_ujhozzaadas.ResumeLayout(false);
            pnl_ujhozzaadas.PerformLayout();
            pnl_meglevoutasokhozAdas.ResumeLayout(false);
            pnl_meglevoutasokhozAdas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_meglevoUtasok).EndInit();
            pnl_eszkozok.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private egyeni_vezerlok.kerekitettSzovegMezo kszm_titulus;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_vezeteknev;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_keresztnev1;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_keresztnev2;
        private DateTimePicker dtp_szulido;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_lakcim;
        private Panel pnl_vezerlopanel;
        private Label lbl_szulido;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_email;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_okmanySzam;
        private DateTimePicker dtp_okmany;
        private Label lbl_okmanyLejarat;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_telefon;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_befizetettOsszeg;
        private Label lbl_biztositas;
        private egyeni_vezerlok.KapcsoloGomb kg_biztositas;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_megjegyzes;
        private egyeni_vezerlok.kerekitettLenyilloMenu rcb_desztinacio;
        private egyeni_vezerlok.kerekitettLenyilloMenu rcb_utazasIdeje;
        private egyeni_vezerlok.kerekitettLenyilloMenu rcb_utazasElnevezese;
        private ListBox lb_utazasok;
        private egyeni_vezerlok.KerekitettGomb kszm_utazasTorlese;
        private egyeni_vezerlok.KerekitettGomb kszm_mentes;
        private egyeni_vezerlok.KerekitettGomb kszm_ujRegiFelhasznalo;
        private Panel pnl_ujhozzaadas;
        private Panel pnl_meglevoutasokhozAdas;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_regiokmanyszam;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_reginev;
        private Label lbl_regiszulido;
        private DateTimePicker dtp_regiSzulido;
        private Label label1;
        private egyeni_vezerlok.DoubleBufferedDataGridView dgv_meglevoUtasok;
        private Panel pnl_eszkozok;
    }
}