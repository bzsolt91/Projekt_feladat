using System.Resources;
using Projekt_feladat.egyeni_vezerlok;
namespace Projekt_feladat
{
    partial class frm_foForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ellipszisVezerlo ev_bejelentkezes;
            ellipszisVezerlo ev_bejelentkezve;
            ellipszisVezerlo ev_regisztacio;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_foForm));
            pnl_bejelentkezes = new Panel();
            label3 = new Label();
            kszm_regisztralas = new KerekitettGomb();
            kg_bejelentkezvemarad = new KapcsoloGomb();
            lbl_bejelentkezvemarad = new Label();
            lbl_belepes = new Label();
            kg_belepes = new KerekitettGomb();
            kszm_jelszo = new kerekitettSzovegMezo();
            kszm_felhasznalo = new kerekitettSzovegMezo();
            pnl_bejelentkezve = new Panel();
            lbl_hozzaferes = new Label();
            lbl_diszcsik = new Label();
            lbl_pkeszenall = new Label();
            lbl_udvozlet = new Label();
            lbl_nev = new Label();
            lbl_bejelentkezve = new Label();
            kg_kilepes = new KerekitettGomb();
            pnl_regisztacio = new Panel();
            kszm_vissza = new KerekitettGomb();
            label2 = new Label();
            kszm_regjelszoujra = new kerekitettSzovegMezo();
            lbl_regisztacio = new Label();
            kg_regisztacio = new KerekitettGomb();
            kszm_regjelszo = new kerekitettSzovegMezo();
            kszm_regnev = new kerekitettSzovegMezo();
            pnl_fejlec = new SzinatmenetPanel();
            btn_minimalizalas = new KerekitettGomb();
            btn_ablakmeret_valto = new KerekitettGomb();
            btn_kilepes = new KerekitettGomb();
            pnl_fopanel = new Panel();
            pnl_fomenu_disz = new Panel();
            lbl_utazas_kezelo = new Label();
            lbl_disz = new Label();
            btn_utazasok = new KerekitettGomb();
            button6 = new KerekitettGomb();
            lbl_disz2 = new Label();
            button1 = new KerekitettGomb();
            pnl_fomenu = new Panel();
            kg_segitseg = new KerekitettGomb();
            button5 = new KerekitettGomb();
            button4 = new KerekitettGomb();
            btn_statisztika = new KerekitettGomb();
            pnl_UtasokAlmenu = new Panel();
            btn_utasokHozzadasa = new KerekitettGomb();
            btn_utasokMegtekintese = new KerekitettGomb();
            btn_utasok = new KerekitettGomb();
            pnl_UtazasokAlmenu = new Panel();
            btn_utazasokHozzaadasa = new KerekitettGomb();
            btn_utazasokmegtekintese = new KerekitettGomb();
            tmr_almenuAnimacio = new System.Windows.Forms.Timer(components);
            ev_foForm = new ellipszisVezerlo();
            ev_bejelentkezes = new ellipszisVezerlo();
            ev_bejelentkezve = new ellipszisVezerlo();
            ev_regisztacio = new ellipszisVezerlo();
            pnl_bejelentkezes.SuspendLayout();
            pnl_bejelentkezve.SuspendLayout();
            pnl_regisztacio.SuspendLayout();
            pnl_fejlec.SuspendLayout();
            pnl_fopanel.SuspendLayout();
            pnl_fomenu_disz.SuspendLayout();
            pnl_fomenu.SuspendLayout();
            pnl_UtasokAlmenu.SuspendLayout();
            pnl_UtazasokAlmenu.SuspendLayout();
            SuspendLayout();
            // 
            // ev_bejelentkezes
            // 
            ev_bejelentkezes.SarokSugar = 75;
            ev_bejelentkezes.TargetControl = pnl_bejelentkezes;
            // 
            // pnl_bejelentkezes
            // 
            pnl_bejelentkezes.BackColor = Color.WhiteSmoke;
            pnl_bejelentkezes.Controls.Add(label3);
            pnl_bejelentkezes.Controls.Add(kszm_regisztralas);
            pnl_bejelentkezes.Controls.Add(kg_bejelentkezvemarad);
            pnl_bejelentkezes.Controls.Add(lbl_bejelentkezvemarad);
            pnl_bejelentkezes.Controls.Add(lbl_belepes);
            pnl_bejelentkezes.Controls.Add(kg_belepes);
            pnl_bejelentkezes.Controls.Add(kszm_jelszo);
            pnl_bejelentkezes.Controls.Add(kszm_felhasznalo);
            pnl_bejelentkezes.Location = new Point(56, 61);
            pnl_bejelentkezes.Name = "pnl_bejelentkezes";
            pnl_bejelentkezes.Size = new Size(463, 390);
            pnl_bejelentkezes.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.BackColor = Color.FromArgb(209, 213, 219);
            label3.ForeColor = Color.FromArgb(209, 213, 219);
            label3.Location = new Point(39, 66);
            label3.Name = "label3";
            label3.Size = new Size(385, 1);
            label3.TabIndex = 8;
            // 
            // kszm_regisztralas
            // 
            kszm_regisztralas.BackColor = Color.MediumSlateBlue;
            kszm_regisztralas.EgerTartasHatterSzine = Color.SlateBlue;
            kszm_regisztralas.FlatAppearance.BorderSize = 0;
            kszm_regisztralas.FlatStyle = FlatStyle.Flat;
            kszm_regisztralas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_regisztralas.ForeColor = Color.White;
            kszm_regisztralas.HatterSzine = Color.MediumSlateBlue;
            kszm_regisztralas.KeretMeret = 0;
            kszm_regisztralas.KeretSzine = Color.PaleVioletRed;
            kszm_regisztralas.Location = new Point(240, 314);
            kszm_regisztralas.Name = "kszm_regisztralas";
            kszm_regisztralas.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_regisztralas.SarokSugar = 8;
            kszm_regisztralas.Size = new Size(188, 50);
            kszm_regisztralas.SzovegSzine = Color.White;
            kszm_regisztralas.TabIndex = 6;
            kszm_regisztralas.Text = "Regisztráció";
            kszm_regisztralas.UseVisualStyleBackColor = false;
            kszm_regisztralas.Click += kszm_regisztralas_Click;
            // 
            // kg_bejelentkezvemarad
            // 
            kg_bejelentkezvemarad.AktualisAllas = KapcsoloGomb.KapcsoloAllas.Ki;
            kg_bejelentkezvemarad.KetAllasuModAktiv = true;
            kg_bejelentkezvemarad.Location = new Point(295, 242);
            kg_bejelentkezvemarad.MinimumSize = new Size(70, 22);
            kg_bejelentkezvemarad.Name = "kg_bejelentkezvemarad";
            kg_bejelentkezvemarad.Size = new Size(87, 36);
            kg_bejelentkezvemarad.TabIndex = 5;
            // 
            // lbl_bejelentkezvemarad
            // 
            lbl_bejelentkezvemarad.AutoSize = true;
            lbl_bejelentkezvemarad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_bejelentkezvemarad.Location = new Point(70, 242);
            lbl_bejelentkezvemarad.Name = "lbl_bejelentkezvemarad";
            lbl_bejelentkezvemarad.Size = new Size(191, 28);
            lbl_bejelentkezvemarad.TabIndex = 4;
            lbl_bejelentkezvemarad.Text = "Bejelentkezve marad";
            // 
            // lbl_belepes
            // 
            lbl_belepes.AutoSize = true;
            lbl_belepes.Font = new Font("Segoe UI", 12F);
            lbl_belepes.Location = new Point(123, 20);
            lbl_belepes.Name = "lbl_belepes";
            lbl_belepes.Size = new Size(212, 28);
            lbl_belepes.TabIndex = 3;
            lbl_belepes.Text = "Belépés az adatbázisba";
            // 
            // kg_belepes
            // 
            kg_belepes.BackColor = Color.MediumSlateBlue;
            kg_belepes.EgerTartasHatterSzine = Color.SlateBlue;
            kg_belepes.FlatAppearance.BorderSize = 0;
            kg_belepes.FlatStyle = FlatStyle.Flat;
            kg_belepes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kg_belepes.ForeColor = Color.White;
            kg_belepes.HatterSzine = Color.MediumSlateBlue;
            kg_belepes.KeretMeret = 0;
            kg_belepes.KeretSzine = Color.PaleVioletRed;
            kg_belepes.Location = new Point(37, 314);
            kg_belepes.Name = "kg_belepes";
            kg_belepes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_belepes.SarokSugar = 8;
            kg_belepes.Size = new Size(188, 50);
            kg_belepes.SzovegSzine = Color.White;
            kg_belepes.TabIndex = 2;
            kg_belepes.Text = "Belépés";
            kg_belepes.UseVisualStyleBackColor = false;
            kg_belepes.Click += kg_belepes_Click;
            // 
            // kszm_jelszo
            // 
            kszm_jelszo.AlahuzottStilus = false;
            kszm_jelszo.BackColor = SystemColors.Window;
            kszm_jelszo.FokuszKeretSzin = Color.HotPink;
            kszm_jelszo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_jelszo.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_jelszo.HelyorzoSzin = Color.DarkGray;
            kszm_jelszo.HelyorzoSzoveg = "Jelszó";
            kszm_jelszo.JelszoKarakter = true;
            kszm_jelszo.KeretMeret = 2;
            kszm_jelszo.KeretSugar = 8;
            kszm_jelszo.KeretSzin = Color.MediumSlateBlue;
            kszm_jelszo.Location = new Point(70, 169);
            kszm_jelszo.Margin = new Padding(4);
            kszm_jelszo.Name = "kszm_jelszo";
            kszm_jelszo.Padding = new Padding(10, 7, 10, 7);
            kszm_jelszo.Size = new Size(312, 40);
            kszm_jelszo.TabIndex = 1;
            kszm_jelszo.Texts = "";
            kszm_jelszo.TobbSor = false;
            // 
            // kszm_felhasznalo
            // 
            kszm_felhasznalo.AlahuzottStilus = false;
            kszm_felhasznalo.BackColor = SystemColors.Window;
            kszm_felhasznalo.FokuszKeretSzin = Color.HotPink;
            kszm_felhasznalo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_felhasznalo.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_felhasznalo.HelyorzoSzin = Color.DarkGray;
            kszm_felhasznalo.HelyorzoSzoveg = "Felhasználó név";
            kszm_felhasznalo.JelszoKarakter = false;
            kszm_felhasznalo.KeretMeret = 2;
            kszm_felhasznalo.KeretSugar = 8;
            kszm_felhasznalo.KeretSzin = Color.MediumSlateBlue;
            kszm_felhasznalo.Location = new Point(70, 84);
            kszm_felhasznalo.Margin = new Padding(4);
            kszm_felhasznalo.Name = "kszm_felhasznalo";
            kszm_felhasznalo.Padding = new Padding(10, 7, 10, 7);
            kszm_felhasznalo.Size = new Size(312, 40);
            kszm_felhasznalo.TabIndex = 0;
            kszm_felhasznalo.Texts = "";
            kszm_felhasznalo.TobbSor = false;
            // 
            // ev_bejelentkezve
            // 
            ev_bejelentkezve.SarokSugar = 80;
            ev_bejelentkezve.TargetControl = pnl_bejelentkezve;
            // 
            // pnl_bejelentkezve
            // 
            pnl_bejelentkezve.BackColor = Color.WhiteSmoke;
            pnl_bejelentkezve.Controls.Add(lbl_hozzaferes);
            pnl_bejelentkezve.Controls.Add(lbl_diszcsik);
            pnl_bejelentkezve.Controls.Add(lbl_pkeszenall);
            pnl_bejelentkezve.Controls.Add(lbl_udvozlet);
            pnl_bejelentkezve.Controls.Add(lbl_nev);
            pnl_bejelentkezve.Controls.Add(lbl_bejelentkezve);
            pnl_bejelentkezve.Controls.Add(kg_kilepes);
            pnl_bejelentkezve.Location = new Point(525, 61);
            pnl_bejelentkezve.Name = "pnl_bejelentkezve";
            pnl_bejelentkezve.Size = new Size(463, 390);
            pnl_bejelentkezve.TabIndex = 1;
            pnl_bejelentkezve.Visible = false;
            // 
            // lbl_hozzaferes
            // 
            lbl_hozzaferes.AutoSize = true;
            lbl_hozzaferes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_hozzaferes.ForeColor = Color.FromArgb(55, 65, 81);
            lbl_hozzaferes.Location = new Point(91, 201);
            lbl_hozzaferes.Name = "lbl_hozzaferes";
            lbl_hozzaferes.Size = new Size(0, 23);
            lbl_hozzaferes.TabIndex = 8;
            // 
            // lbl_diszcsik
            // 
            lbl_diszcsik.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_diszcsik.BackColor = Color.FromArgb(209, 213, 219);
            lbl_diszcsik.ForeColor = Color.FromArgb(209, 213, 219);
            lbl_diszcsik.Location = new Point(41, 67);
            lbl_diszcsik.Name = "lbl_diszcsik";
            lbl_diszcsik.Size = new Size(385, 1);
            lbl_diszcsik.TabIndex = 7;
            // 
            // lbl_pkeszenall
            // 
            lbl_pkeszenall.AutoSize = true;
            lbl_pkeszenall.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_pkeszenall.Location = new Point(88, 255);
            lbl_pkeszenall.Name = "lbl_pkeszenall";
            lbl_pkeszenall.Size = new Size(290, 25);
            lbl_pkeszenall.TabIndex = 6;
            lbl_pkeszenall.Text = "A program készen áll a használatra.";
            // 
            // lbl_udvozlet
            // 
            lbl_udvozlet.AutoSize = true;
            lbl_udvozlet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_udvozlet.Location = new Point(168, 96);
            lbl_udvozlet.Name = "lbl_udvozlet";
            lbl_udvozlet.Size = new Size(0, 28);
            lbl_udvozlet.TabIndex = 5;
            // 
            // lbl_nev
            // 
            lbl_nev.AutoSize = true;
            lbl_nev.Font = new Font("Segoe UI", 14F);
            lbl_nev.ForeColor = Color.DarkViolet;
            lbl_nev.Location = new Point(196, 135);
            lbl_nev.Name = "lbl_nev";
            lbl_nev.Size = new Size(53, 32);
            lbl_nev.TabIndex = 4;
            lbl_nev.Text = "nev";
            // 
            // lbl_bejelentkezve
            // 
            lbl_bejelentkezve.AutoSize = true;
            lbl_bejelentkezve.Font = new Font("Segoe UI", 12F);
            lbl_bejelentkezve.Location = new Point(123, 20);
            lbl_bejelentkezve.Name = "lbl_bejelentkezve";
            lbl_bejelentkezve.Size = new Size(214, 28);
            lbl_bejelentkezve.TabIndex = 3;
            lbl_bejelentkezve.Text = "Belépve az adatbázisba";
            // 
            // kg_kilepes
            // 
            kg_kilepes.BackColor = Color.MediumSlateBlue;
            kg_kilepes.EgerTartasHatterSzine = Color.Crimson;
            kg_kilepes.FlatAppearance.BorderSize = 0;
            kg_kilepes.FlatStyle = FlatStyle.Flat;
            kg_kilepes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kg_kilepes.ForeColor = Color.White;
            kg_kilepes.HatterSzine = Color.MediumSlateBlue;
            kg_kilepes.KeretMeret = 0;
            kg_kilepes.KeretSzine = Color.PaleVioletRed;
            kg_kilepes.Location = new Point(133, 302);
            kg_kilepes.Name = "kg_kilepes";
            kg_kilepes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_kilepes.SarokSugar = 8;
            kg_kilepes.Size = new Size(188, 50);
            kg_kilepes.SzovegSzine = Color.White;
            kg_kilepes.TabIndex = 2;
            kg_kilepes.Text = "Kilépés";
            kg_kilepes.UseVisualStyleBackColor = false;
            kg_kilepes.Click += kg_kilepes_Click;
            // 
            // ev_regisztacio
            // 
            ev_regisztacio.SarokSugar = 75;
            ev_regisztacio.TargetControl = pnl_regisztacio;
            // 
            // pnl_regisztacio
            // 
            pnl_regisztacio.BackColor = Color.WhiteSmoke;
            pnl_regisztacio.Controls.Add(kszm_vissza);
            pnl_regisztacio.Controls.Add(label2);
            pnl_regisztacio.Controls.Add(kszm_regjelszoujra);
            pnl_regisztacio.Controls.Add(lbl_regisztacio);
            pnl_regisztacio.Controls.Add(kg_regisztacio);
            pnl_regisztacio.Controls.Add(kszm_regjelszo);
            pnl_regisztacio.Controls.Add(kszm_regnev);
            pnl_regisztacio.Location = new Point(425, 467);
            pnl_regisztacio.Name = "pnl_regisztacio";
            pnl_regisztacio.Size = new Size(463, 390);
            pnl_regisztacio.TabIndex = 2;
            pnl_regisztacio.Visible = false;
            // 
            // kszm_vissza
            // 
            kszm_vissza.BackColor = Color.MediumSlateBlue;
            kszm_vissza.EgerTartasHatterSzine = Color.SlateBlue;
            kszm_vissza.FlatAppearance.BorderSize = 0;
            kszm_vissza.FlatStyle = FlatStyle.Flat;
            kszm_vissza.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_vissza.ForeColor = Color.White;
            kszm_vissza.HatterSzine = Color.MediumSlateBlue;
            kszm_vissza.Image = (Image)resources.GetObject("kszm_vissza.Image");
            kszm_vissza.KeretMeret = 0;
            kszm_vissza.KeretSzine = Color.PaleVioletRed;
            kszm_vissza.Location = new Point(70, 319);
            kszm_vissza.Name = "kszm_vissza";
            kszm_vissza.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_vissza.SarokSugar = 8;
            kszm_vissza.Size = new Size(94, 50);
            kszm_vissza.SzovegSzine = Color.White;
            kszm_vissza.TabIndex = 9;
            kszm_vissza.UseVisualStyleBackColor = false;
            kszm_vissza.Click += kszm_vissza_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.BackColor = Color.FromArgb(209, 213, 219);
            label2.ForeColor = Color.FromArgb(209, 213, 219);
            label2.Location = new Point(39, 61);
            label2.Name = "label2";
            label2.Size = new Size(385, 1);
            label2.TabIndex = 8;
            // 
            // kszm_regjelszoujra
            // 
            kszm_regjelszoujra.AlahuzottStilus = false;
            kszm_regjelszoujra.BackColor = SystemColors.Window;
            kszm_regjelszoujra.FokuszKeretSzin = Color.HotPink;
            kszm_regjelszoujra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_regjelszoujra.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_regjelszoujra.HelyorzoSzin = Color.DarkGray;
            kszm_regjelszoujra.HelyorzoSzoveg = "Jelszó újra";
            kszm_regjelszoujra.JelszoKarakter = true;
            kszm_regjelszoujra.KeretMeret = 2;
            kszm_regjelszoujra.KeretSugar = 8;
            kszm_regjelszoujra.KeretSzin = Color.MediumSlateBlue;
            kszm_regjelszoujra.Location = new Point(70, 198);
            kszm_regjelszoujra.Margin = new Padding(4);
            kszm_regjelszoujra.Name = "kszm_regjelszoujra";
            kszm_regjelszoujra.Padding = new Padding(10, 7, 10, 7);
            kszm_regjelszoujra.Size = new Size(312, 40);
            kszm_regjelszoujra.TabIndex = 6;
            kszm_regjelszoujra.Texts = "";
            kszm_regjelszoujra.TobbSor = false;
            // 
            // lbl_regisztacio
            // 
            lbl_regisztacio.AutoSize = true;
            lbl_regisztacio.Font = new Font("Segoe UI", 12F);
            lbl_regisztacio.Location = new Point(169, 17);
            lbl_regisztacio.Name = "lbl_regisztacio";
            lbl_regisztacio.Size = new Size(117, 28);
            lbl_regisztacio.TabIndex = 3;
            lbl_regisztacio.Text = "Regisztráció";
            // 
            // kg_regisztacio
            // 
            kg_regisztacio.BackColor = Color.MediumSlateBlue;
            kg_regisztacio.EgerTartasHatterSzine = Color.SlateBlue;
            kg_regisztacio.FlatAppearance.BorderSize = 0;
            kg_regisztacio.FlatStyle = FlatStyle.Flat;
            kg_regisztacio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kg_regisztacio.ForeColor = Color.White;
            kg_regisztacio.HatterSzine = Color.MediumSlateBlue;
            kg_regisztacio.KeretMeret = 0;
            kg_regisztacio.KeretSzine = Color.PaleVioletRed;
            kg_regisztacio.Location = new Point(194, 319);
            kg_regisztacio.Name = "kg_regisztacio";
            kg_regisztacio.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_regisztacio.SarokSugar = 8;
            kg_regisztacio.Size = new Size(188, 50);
            kg_regisztacio.SzovegSzine = Color.White;
            kg_regisztacio.TabIndex = 2;
            kg_regisztacio.Text = "Regisztáció";
            kg_regisztacio.UseVisualStyleBackColor = false;
            kg_regisztacio.Click += kg_regisztacio_Click;
            // 
            // kszm_regjelszo
            // 
            kszm_regjelszo.AlahuzottStilus = false;
            kszm_regjelszo.BackColor = SystemColors.Window;
            kszm_regjelszo.FokuszKeretSzin = Color.HotPink;
            kszm_regjelszo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_regjelszo.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_regjelszo.HelyorzoSzin = Color.DarkGray;
            kszm_regjelszo.HelyorzoSzoveg = "Jelszó";
            kszm_regjelszo.JelszoKarakter = true;
            kszm_regjelszo.KeretMeret = 2;
            kszm_regjelszo.KeretSugar = 8;
            kszm_regjelszo.KeretSzin = Color.MediumSlateBlue;
            kszm_regjelszo.Location = new Point(70, 141);
            kszm_regjelszo.Margin = new Padding(4);
            kszm_regjelszo.Name = "kszm_regjelszo";
            kszm_regjelszo.Padding = new Padding(10, 7, 10, 7);
            kszm_regjelszo.Size = new Size(312, 40);
            kszm_regjelszo.TabIndex = 1;
            kszm_regjelszo.Texts = "";
            kszm_regjelszo.TobbSor = false;
            // 
            // kszm_regnev
            // 
            kszm_regnev.AlahuzottStilus = false;
            kszm_regnev.BackColor = SystemColors.Window;
            kszm_regnev.FokuszKeretSzin = Color.HotPink;
            kszm_regnev.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_regnev.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_regnev.HelyorzoSzin = Color.DarkGray;
            kszm_regnev.HelyorzoSzoveg = "Felhasználó név";
            kszm_regnev.JelszoKarakter = false;
            kszm_regnev.KeretMeret = 2;
            kszm_regnev.KeretSugar = 8;
            kszm_regnev.KeretSzin = Color.MediumSlateBlue;
            kszm_regnev.Location = new Point(70, 84);
            kszm_regnev.Margin = new Padding(4);
            kszm_regnev.Name = "kszm_regnev";
            kszm_regnev.Padding = new Padding(10, 7, 10, 7);
            kszm_regnev.Size = new Size(312, 40);
            kszm_regnev.TabIndex = 0;
            kszm_regnev.Texts = "";
            kszm_regnev.TobbSor = false;
            // 
            // pnl_fejlec
            // 
            pnl_fejlec.BackColor = Color.SlateGray;
            pnl_fejlec.Controls.Add(btn_minimalizalas);
            pnl_fejlec.Controls.Add(btn_ablakmeret_valto);
            pnl_fejlec.Controls.Add(btn_kilepes);
            pnl_fejlec.Dock = DockStyle.Top;
            pnl_fejlec.ForeColor = Color.Black;
            pnl_fejlec.KeretSzin = Color.Black;
            pnl_fejlec.KeretVastagsag = 0F;
            pnl_fejlec.Location = new Point(0, 0);
            pnl_fejlec.Margin = new Padding(3, 4, 3, 4);
            pnl_fejlec.Name = "pnl_fejlec";
            pnl_fejlec.SarkokLekerekitese = 0;
            pnl_fejlec.Size = new Size(1403, 37);
            pnl_fejlec.SzinatmenetAlsoSzine = Color.Silver;
            pnl_fejlec.SzinatmenetFelsoSzine = Color.DimGray;
            pnl_fejlec.SzinatmenetSzog = 100F;
            pnl_fejlec.TabIndex = 0;
            pnl_fejlec.MouseDown += pnl_fejlec_MouseDown;
            pnl_fejlec.MouseMove += pnl_fejlec_MouseMove;
            pnl_fejlec.MouseUp += pnl_fejlec_MouseUp;
            // 
            // btn_minimalizalas
            // 
            btn_minimalizalas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_minimalizalas.BackColor = Color.Transparent;
            btn_minimalizalas.EgerTartasHatterSzine = Color.Yellow;
            btn_minimalizalas.FlatStyle = FlatStyle.Flat;
            btn_minimalizalas.Font = new Font("Segoe Fluent Icons", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_minimalizalas.ForeColor = Color.White;
            btn_minimalizalas.HatterSzine = Color.Transparent;
            btn_minimalizalas.KeretMeret = 0;
            btn_minimalizalas.KeretSzine = Color.PaleVioletRed;
            btn_minimalizalas.Location = new Point(1212, 3);
            btn_minimalizalas.Margin = new Padding(3, 4, 3, 4);
            btn_minimalizalas.Name = "btn_minimalizalas";
            btn_minimalizalas.NyomottAllapotHatterSzine = Color.Yellow;
            btn_minimalizalas.SarokSugar = 0;
            btn_minimalizalas.Size = new Size(61, 31);
            btn_minimalizalas.SzovegSzine = Color.White;
            btn_minimalizalas.TabIndex = 3;
            btn_minimalizalas.Text = "➖";
            btn_minimalizalas.UseVisualStyleBackColor = false;
            btn_minimalizalas.Click += btn_minimalizalas_Click;
            // 
            // btn_ablakmeret_valto
            // 
            btn_ablakmeret_valto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ablakmeret_valto.BackColor = Color.Transparent;
            btn_ablakmeret_valto.EgerTartasHatterSzine = Color.Aqua;
            btn_ablakmeret_valto.FlatStyle = FlatStyle.Flat;
            btn_ablakmeret_valto.Font = new Font("Segoe Fluent Icons", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ablakmeret_valto.ForeColor = Color.White;
            btn_ablakmeret_valto.HatterSzine = Color.Transparent;
            btn_ablakmeret_valto.KeretMeret = 0;
            btn_ablakmeret_valto.KeretSzine = Color.PaleVioletRed;
            btn_ablakmeret_valto.Location = new Point(1275, 3);
            btn_ablakmeret_valto.Margin = new Padding(3, 4, 3, 4);
            btn_ablakmeret_valto.Name = "btn_ablakmeret_valto";
            btn_ablakmeret_valto.NyomottAllapotHatterSzine = Color.Aqua;
            btn_ablakmeret_valto.SarokSugar = 0;
            btn_ablakmeret_valto.Size = new Size(61, 31);
            btn_ablakmeret_valto.SzovegSzine = Color.White;
            btn_ablakmeret_valto.TabIndex = 2;
            btn_ablakmeret_valto.Text = "🔲";
            btn_ablakmeret_valto.UseVisualStyleBackColor = false;
            btn_ablakmeret_valto.Click += btn_ablakmeret_valto_Click;
            // 
            // btn_kilepes
            // 
            btn_kilepes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_kilepes.BackColor = Color.Transparent;
            btn_kilepes.EgerTartasHatterSzine = Color.Red;
            btn_kilepes.FlatStyle = FlatStyle.Flat;
            btn_kilepes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_kilepes.ForeColor = Color.White;
            btn_kilepes.HatterSzine = Color.Transparent;
            btn_kilepes.KeretMeret = 0;
            btn_kilepes.KeretSzine = Color.PaleVioletRed;
            btn_kilepes.Location = new Point(1335, 3);
            btn_kilepes.Margin = new Padding(3, 4, 3, 4);
            btn_kilepes.Name = "btn_kilepes";
            btn_kilepes.NyomottAllapotHatterSzine = Color.Red;
            btn_kilepes.SarokSugar = 0;
            btn_kilepes.Size = new Size(61, 31);
            btn_kilepes.SzovegSzine = Color.White;
            btn_kilepes.TabIndex = 1;
            btn_kilepes.Text = "❌";
            btn_kilepes.UseVisualStyleBackColor = false;
            btn_kilepes.Click += btn_kilepes_Click;
            // 
            // pnl_fopanel
            // 
            pnl_fopanel.BackColor = Color.FromArgb(50, 70, 90);
            pnl_fopanel.Controls.Add(pnl_regisztacio);
            pnl_fopanel.Controls.Add(pnl_bejelentkezve);
            pnl_fopanel.Controls.Add(pnl_bejelentkezes);
            pnl_fopanel.Dock = DockStyle.Fill;
            pnl_fopanel.ForeColor = Color.Black;
            pnl_fopanel.Location = new Point(277, 37);
            pnl_fopanel.Margin = new Padding(3, 4, 3, 4);
            pnl_fopanel.Name = "pnl_fopanel";
            pnl_fopanel.Size = new Size(1126, 698);
            pnl_fopanel.TabIndex = 2;
            pnl_fopanel.ControlAdded += pnl_fopanel_ControlAdded;
            pnl_fopanel.ControlRemoved += pnl_fopanel_ControlRemoved;
            pnl_fopanel.Resize += pnl_fopanel_Resize;
            // 
            // pnl_fomenu_disz
            // 
            pnl_fomenu_disz.Controls.Add(lbl_utazas_kezelo);
            pnl_fomenu_disz.Controls.Add(lbl_disz);
            pnl_fomenu_disz.Dock = DockStyle.Top;
            pnl_fomenu_disz.Location = new Point(0, 0);
            pnl_fomenu_disz.Margin = new Padding(3, 4, 3, 4);
            pnl_fomenu_disz.Name = "pnl_fomenu_disz";
            pnl_fomenu_disz.Size = new Size(256, 61);
            pnl_fomenu_disz.TabIndex = 2;
            // 
            // lbl_utazas_kezelo
            // 
            lbl_utazas_kezelo.BackColor = Color.Transparent;
            lbl_utazas_kezelo.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 150);
            lbl_utazas_kezelo.Location = new Point(3, 4);
            lbl_utazas_kezelo.Name = "lbl_utazas_kezelo";
            lbl_utazas_kezelo.Size = new Size(246, 40);
            lbl_utazas_kezelo.TabIndex = 4;
            lbl_utazas_kezelo.Text = "Utazást kezelő";
            lbl_utazas_kezelo.TextAlign = ContentAlignment.MiddleCenter;
            lbl_utazas_kezelo.Click += lbl_utazas_kezelo_Click;
            // 
            // lbl_disz
            // 
            lbl_disz.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_disz.BackColor = Color.FromArgb(209, 213, 219);
            lbl_disz.ForeColor = Color.FromArgb(209, 213, 219);
            lbl_disz.Location = new Point(34, 53);
            lbl_disz.Name = "lbl_disz";
            lbl_disz.Size = new Size(177, 3);
            lbl_disz.TabIndex = 0;
            // 
            // btn_utazasok
            // 
            btn_utazasok.BackColor = Color.FromArgb(243, 244, 246);
            btn_utazasok.Dock = DockStyle.Top;
            btn_utazasok.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            btn_utazasok.FlatStyle = FlatStyle.Flat;
            btn_utazasok.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Bold);
            btn_utazasok.ForeColor = Color.FromArgb(55, 65, 81);
            btn_utazasok.HatterSzine = Color.FromArgb(243, 244, 246);
            btn_utazasok.KeretMeret = 0;
            btn_utazasok.KeretSzine = Color.PaleVioletRed;
            btn_utazasok.Location = new Point(0, 61);
            btn_utazasok.Margin = new Padding(3, 4, 3, 4);
            btn_utazasok.Name = "btn_utazasok";
            btn_utazasok.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_utazasok.SarokSugar = 10;
            btn_utazasok.Size = new Size(256, 67);
            btn_utazasok.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_utazasok.TabIndex = 3;
            btn_utazasok.Text = "✈️  Utazások";
            btn_utazasok.TextAlign = ContentAlignment.MiddleLeft;
            btn_utazasok.UseVisualStyleBackColor = false;
            btn_utazasok.Click += btn_utazasok_Click;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.BackColor = Color.FromArgb(243, 244, 246);
            button6.Dock = DockStyle.Bottom;
            button6.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(55, 65, 81);
            button6.HatterSzine = Color.FromArgb(243, 244, 246);
            button6.KeretMeret = 0;
            button6.KeretSzine = Color.PaleVioletRed;
            button6.Location = new Point(0, 763);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.MaximumSize = new Size(73, 85);
            button6.Name = "button6";
            button6.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            button6.SarokSugar = 10;
            button6.Size = new Size(73, 85);
            button6.SzovegSzine = Color.FromArgb(55, 65, 81);
            button6.TabIndex = 8;
            button6.Text = "🔔";
            button6.UseVisualStyleBackColor = false;
            // 
            // lbl_disz2
            // 
            lbl_disz2.BackColor = Color.FromArgb(209, 213, 219);
            lbl_disz2.Dock = DockStyle.Bottom;
            lbl_disz2.ForeColor = Color.FromArgb(209, 213, 219);
            lbl_disz2.Location = new Point(0, 760);
            lbl_disz2.Margin = new Padding(0, 67, 0, 0);
            lbl_disz2.Name = "lbl_disz2";
            lbl_disz2.Padding = new Padding(0, 13, 0, 0);
            lbl_disz2.Size = new Size(256, 3);
            lbl_disz2.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(243, 244, 246);
            button1.Dock = DockStyle.Bottom;
            button1.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(55, 65, 81);
            button1.HatterSzine = Color.FromArgb(243, 244, 246);
            button1.KeretMeret = 0;
            button1.KeretSzine = Color.PaleVioletRed;
            button1.Location = new Point(0, 693);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            button1.SarokSugar = 10;
            button1.Size = new Size(256, 67);
            button1.SzovegSzine = Color.FromArgb(55, 65, 81);
            button1.TabIndex = 10;
            button1.Text = "⚙️ Beállítások";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // pnl_fomenu
            // 
            pnl_fomenu.AutoScroll = true;
            pnl_fomenu.BackColor = Color.FromArgb(243, 244, 246);
            pnl_fomenu.Controls.Add(kg_segitseg);
            pnl_fomenu.Controls.Add(button5);
            pnl_fomenu.Controls.Add(button4);
            pnl_fomenu.Controls.Add(btn_statisztika);
            pnl_fomenu.Controls.Add(pnl_UtasokAlmenu);
            pnl_fomenu.Controls.Add(btn_utasok);
            pnl_fomenu.Controls.Add(pnl_UtazasokAlmenu);
            pnl_fomenu.Controls.Add(button1);
            pnl_fomenu.Controls.Add(lbl_disz2);
            pnl_fomenu.Controls.Add(button6);
            pnl_fomenu.Controls.Add(btn_utazasok);
            pnl_fomenu.Controls.Add(pnl_fomenu_disz);
            pnl_fomenu.Dock = DockStyle.Left;
            pnl_fomenu.Location = new Point(0, 37);
            pnl_fomenu.Margin = new Padding(3, 4, 3, 4);
            pnl_fomenu.Name = "pnl_fomenu";
            pnl_fomenu.Size = new Size(277, 698);
            pnl_fomenu.TabIndex = 1;
            // 
            // kg_segitseg
            // 
            kg_segitseg.BackColor = Color.FromArgb(243, 244, 246);
            kg_segitseg.Dock = DockStyle.Bottom;
            kg_segitseg.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            kg_segitseg.FlatStyle = FlatStyle.Flat;
            kg_segitseg.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kg_segitseg.ForeColor = Color.FromArgb(55, 65, 81);
            kg_segitseg.HatterSzine = Color.FromArgb(243, 244, 246);
            kg_segitseg.KeretMeret = 0;
            kg_segitseg.KeretSzine = Color.PaleVioletRed;
            kg_segitseg.Location = new Point(0, 626);
            kg_segitseg.Margin = new Padding(3, 4, 3, 4);
            kg_segitseg.Name = "kg_segitseg";
            kg_segitseg.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_segitseg.SarokSugar = 10;
            kg_segitseg.Size = new Size(256, 67);
            kg_segitseg.SzovegSzine = Color.FromArgb(55, 65, 81);
            kg_segitseg.TabIndex = 18;
            kg_segitseg.Text = "\U0001f9fe Útmutató";
            kg_segitseg.TextAlign = ContentAlignment.MiddleLeft;
            kg_segitseg.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(243, 244, 246);
            button5.Dock = DockStyle.Top;
            button5.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(55, 65, 81);
            button5.HatterSzine = Color.FromArgb(243, 244, 246);
            button5.KeretMeret = 0;
            button5.KeretSzine = Color.PaleVioletRed;
            button5.Location = new Point(0, 559);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            button5.SarokSugar = 10;
            button5.Size = new Size(256, 67);
            button5.SzovegSzine = Color.FromArgb(55, 65, 81);
            button5.TabIndex = 17;
            button5.Text = "📤 Exportálás";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(243, 244, 246);
            button4.Dock = DockStyle.Top;
            button4.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(55, 65, 81);
            button4.HatterSzine = Color.FromArgb(243, 244, 246);
            button4.KeretMeret = 0;
            button4.KeretSzine = Color.PaleVioletRed;
            button4.Location = new Point(0, 492);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            button4.SarokSugar = 10;
            button4.Size = new Size(256, 67);
            button4.SzovegSzine = Color.FromArgb(55, 65, 81);
            button4.TabIndex = 16;
            button4.Text = "💾 Biztonsági mentés";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // btn_statisztika
            // 
            btn_statisztika.BackColor = Color.FromArgb(243, 244, 246);
            btn_statisztika.Dock = DockStyle.Top;
            btn_statisztika.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            btn_statisztika.FlatStyle = FlatStyle.Flat;
            btn_statisztika.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Bold);
            btn_statisztika.ForeColor = Color.FromArgb(55, 65, 81);
            btn_statisztika.HatterSzine = Color.FromArgb(243, 244, 246);
            btn_statisztika.KeretMeret = 0;
            btn_statisztika.KeretSzine = Color.PaleVioletRed;
            btn_statisztika.Location = new Point(0, 425);
            btn_statisztika.Margin = new Padding(3, 4, 3, 4);
            btn_statisztika.Name = "btn_statisztika";
            btn_statisztika.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_statisztika.SarokSugar = 10;
            btn_statisztika.Size = new Size(256, 67);
            btn_statisztika.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_statisztika.TabIndex = 15;
            btn_statisztika.Text = "📈 Statisztika";
            btn_statisztika.TextAlign = ContentAlignment.MiddleLeft;
            btn_statisztika.UseVisualStyleBackColor = false;
            btn_statisztika.Click += btn_statisztika_Click;
            // 
            // pnl_UtasokAlmenu
            // 
            pnl_UtasokAlmenu.BackColor = Color.FromArgb(209, 213, 219);
            pnl_UtasokAlmenu.Controls.Add(btn_utasokHozzadasa);
            pnl_UtasokAlmenu.Controls.Add(btn_utasokMegtekintese);
            pnl_UtasokAlmenu.Dock = DockStyle.Top;
            pnl_UtasokAlmenu.Location = new Point(0, 310);
            pnl_UtasokAlmenu.Margin = new Padding(3, 4, 3, 4);
            pnl_UtasokAlmenu.Name = "pnl_UtasokAlmenu";
            pnl_UtasokAlmenu.Size = new Size(256, 115);
            pnl_UtasokAlmenu.TabIndex = 12;
            // 
            // btn_utasokHozzadasa
            // 
            btn_utasokHozzadasa.BackColor = Color.FromArgb(209, 213, 219);
            btn_utasokHozzadasa.Dock = DockStyle.Top;
            btn_utasokHozzadasa.EgerTartasHatterSzine = SystemColors.ButtonShadow;
            btn_utasokHozzadasa.FlatStyle = FlatStyle.Flat;
            btn_utasokHozzadasa.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Bold);
            btn_utasokHozzadasa.ForeColor = Color.FromArgb(55, 65, 81);
            btn_utasokHozzadasa.HatterSzine = Color.FromArgb(209, 213, 219);
            btn_utasokHozzadasa.KeretMeret = 0;
            btn_utasokHozzadasa.KeretSzine = Color.PaleVioletRed;
            btn_utasokHozzadasa.Location = new Point(0, 53);
            btn_utasokHozzadasa.Margin = new Padding(3, 4, 3, 4);
            btn_utasokHozzadasa.Name = "btn_utasokHozzadasa";
            btn_utasokHozzadasa.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_utasokHozzadasa.SarokSugar = 10;
            btn_utasokHozzadasa.Size = new Size(256, 53);
            btn_utasokHozzadasa.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_utasokHozzadasa.TabIndex = 2;
            btn_utasokHozzadasa.Text = "🖆 Hozzáadás";
            btn_utasokHozzadasa.TextAlign = ContentAlignment.MiddleLeft;
            btn_utasokHozzadasa.UseVisualStyleBackColor = false;
            btn_utasokHozzadasa.Click += btn_utasokHozzadasa_Click;
            // 
            // btn_utasokMegtekintese
            // 
            btn_utasokMegtekintese.BackColor = Color.FromArgb(209, 213, 219);
            btn_utasokMegtekintese.Dock = DockStyle.Top;
            btn_utasokMegtekintese.EgerTartasHatterSzine = SystemColors.ButtonShadow;
            btn_utasokMegtekintese.FlatStyle = FlatStyle.Flat;
            btn_utasokMegtekintese.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Bold);
            btn_utasokMegtekintese.ForeColor = Color.FromArgb(55, 65, 81);
            btn_utasokMegtekintese.HatterSzine = Color.FromArgb(209, 213, 219);
            btn_utasokMegtekintese.KeretMeret = 0;
            btn_utasokMegtekintese.KeretSzine = Color.PaleVioletRed;
            btn_utasokMegtekintese.Location = new Point(0, 0);
            btn_utasokMegtekintese.Margin = new Padding(0);
            btn_utasokMegtekintese.Name = "btn_utasokMegtekintese";
            btn_utasokMegtekintese.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_utasokMegtekintese.SarokSugar = 10;
            btn_utasokMegtekintese.Size = new Size(256, 53);
            btn_utasokMegtekintese.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_utasokMegtekintese.TabIndex = 0;
            btn_utasokMegtekintese.Text = "📖 Megtekintés";
            btn_utasokMegtekintese.TextAlign = ContentAlignment.MiddleLeft;
            btn_utasokMegtekintese.UseVisualStyleBackColor = false;
            btn_utasokMegtekintese.Click += btn_utasokMegtekintese_Click;
            // 
            // btn_utasok
            // 
            btn_utasok.BackColor = Color.FromArgb(243, 244, 246);
            btn_utasok.Dock = DockStyle.Top;
            btn_utasok.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            btn_utasok.FlatStyle = FlatStyle.Flat;
            btn_utasok.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Bold);
            btn_utasok.ForeColor = Color.FromArgb(55, 65, 81);
            btn_utasok.HatterSzine = Color.FromArgb(243, 244, 246);
            btn_utasok.ImageAlign = ContentAlignment.MiddleLeft;
            btn_utasok.KeretMeret = 0;
            btn_utasok.KeretSzine = Color.PaleVioletRed;
            btn_utasok.Location = new Point(0, 243);
            btn_utasok.Margin = new Padding(3, 4, 3, 4);
            btn_utasok.Name = "btn_utasok";
            btn_utasok.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_utasok.SarokSugar = 10;
            btn_utasok.Size = new Size(256, 67);
            btn_utasok.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_utasok.TabIndex = 11;
            btn_utasok.Text = "👩‍👩‍👦 Utasok";
            btn_utasok.TextAlign = ContentAlignment.MiddleLeft;
            btn_utasok.UseVisualStyleBackColor = false;
            btn_utasok.Click += btn_utasok_Click;
            // 
            // pnl_UtazasokAlmenu
            // 
            pnl_UtazasokAlmenu.BackColor = Color.FromArgb(209, 213, 219);
            pnl_UtazasokAlmenu.Controls.Add(btn_utazasokHozzaadasa);
            pnl_UtazasokAlmenu.Controls.Add(btn_utazasokmegtekintese);
            pnl_UtazasokAlmenu.Dock = DockStyle.Top;
            pnl_UtazasokAlmenu.Location = new Point(0, 128);
            pnl_UtazasokAlmenu.Margin = new Padding(3, 4, 3, 4);
            pnl_UtazasokAlmenu.Name = "pnl_UtazasokAlmenu";
            pnl_UtazasokAlmenu.Size = new Size(256, 115);
            pnl_UtazasokAlmenu.TabIndex = 0;
            // 
            // btn_utazasokHozzaadasa
            // 
            btn_utazasokHozzaadasa.BackColor = Color.FromArgb(209, 213, 219);
            btn_utazasokHozzaadasa.Dock = DockStyle.Top;
            btn_utazasokHozzaadasa.EgerTartasHatterSzine = SystemColors.ButtonShadow;
            btn_utazasokHozzaadasa.FlatStyle = FlatStyle.Flat;
            btn_utazasokHozzaadasa.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Bold);
            btn_utazasokHozzaadasa.ForeColor = Color.FromArgb(55, 65, 81);
            btn_utazasokHozzaadasa.HatterSzine = Color.FromArgb(209, 213, 219);
            btn_utazasokHozzaadasa.KeretMeret = 0;
            btn_utazasokHozzaadasa.KeretSzine = Color.PaleVioletRed;
            btn_utazasokHozzaadasa.Location = new Point(0, 53);
            btn_utazasokHozzaadasa.Margin = new Padding(0);
            btn_utazasokHozzaadasa.Name = "btn_utazasokHozzaadasa";
            btn_utazasokHozzaadasa.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_utazasokHozzaadasa.SarokSugar = 10;
            btn_utazasokHozzaadasa.Size = new Size(256, 53);
            btn_utazasokHozzaadasa.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_utazasokHozzaadasa.TabIndex = 1;
            btn_utazasokHozzaadasa.Text = "🖆 Szerkesztés";
            btn_utazasokHozzaadasa.TextAlign = ContentAlignment.MiddleLeft;
            btn_utazasokHozzaadasa.UseVisualStyleBackColor = false;
            btn_utazasokHozzaadasa.Click += btn_utazasokHozzaadasa_Click;
            // 
            // btn_utazasokmegtekintese
            // 
            btn_utazasokmegtekintese.BackColor = Color.FromArgb(209, 213, 219);
            btn_utazasokmegtekintese.Dock = DockStyle.Top;
            btn_utazasokmegtekintese.EgerTartasHatterSzine = SystemColors.ButtonShadow;
            btn_utazasokmegtekintese.FlatStyle = FlatStyle.Flat;
            btn_utazasokmegtekintese.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Bold);
            btn_utazasokmegtekintese.ForeColor = Color.FromArgb(55, 65, 81);
            btn_utazasokmegtekintese.HatterSzine = Color.FromArgb(209, 213, 219);
            btn_utazasokmegtekintese.KeretMeret = 0;
            btn_utazasokmegtekintese.KeretSzine = Color.PaleVioletRed;
            btn_utazasokmegtekintese.Location = new Point(0, 0);
            btn_utazasokmegtekintese.Margin = new Padding(0);
            btn_utazasokmegtekintese.Name = "btn_utazasokmegtekintese";
            btn_utazasokmegtekintese.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_utazasokmegtekintese.SarokSugar = 10;
            btn_utazasokmegtekintese.Size = new Size(256, 53);
            btn_utazasokmegtekintese.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_utazasokmegtekintese.TabIndex = 0;
            btn_utazasokmegtekintese.Text = "📖 Megtekintés";
            btn_utazasokmegtekintese.TextAlign = ContentAlignment.MiddleLeft;
            btn_utazasokmegtekintese.UseVisualStyleBackColor = false;
            btn_utazasokmegtekintese.Click += btn_utazasokmegtekintese_Click;
            // 
            // tmr_almenuAnimacio
            // 
            tmr_almenuAnimacio.Interval = 1;
            tmr_almenuAnimacio.Tick += tmr_almenuAnimacio_Tick;
            // 
            // ev_foForm
            // 
            ev_foForm.SarokSugar = 25;
            ev_foForm.TargetControl = this;
            // 
            // frm_foForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 735);
            ControlBox = false;
            Controls.Add(pnl_fopanel);
            Controls.Add(pnl_fomenu);
            Controls.Add(pnl_fejlec);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_foForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Utas kezelő";
            Load += frm_foForm_Load;
            pnl_bejelentkezes.ResumeLayout(false);
            pnl_bejelentkezes.PerformLayout();
            pnl_bejelentkezve.ResumeLayout(false);
            pnl_bejelentkezve.PerformLayout();
            pnl_regisztacio.ResumeLayout(false);
            pnl_regisztacio.PerformLayout();
            pnl_fejlec.ResumeLayout(false);
            pnl_fopanel.ResumeLayout(false);
            pnl_fomenu_disz.ResumeLayout(false);
            pnl_fomenu.ResumeLayout(false);
            pnl_fomenu.PerformLayout();
            pnl_UtasokAlmenu.ResumeLayout(false);
            pnl_UtazasokAlmenu.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private SzinatmenetPanel pnl_fejlec;
        private KerekitettGomb btn_kilepes;
        private KerekitettGomb btn_ablakmeret_valto;
        private Panel pnl_fopanel;
       private KerekitettGomb btn_minimalizalas;
        private Panel pnl_fomenu_disz;
        private Label lbl_utazas_kezelo;
        private Label lbl_disz;
        private KerekitettGomb btn_utazasok;
        private KerekitettGomb button6;
        private Label lbl_disz2;
        private KerekitettGomb button1;
        private Panel pnl_fomenu;
        private KerekitettGomb button5;
        private KerekitettGomb button4;
        private KerekitettGomb btn_statisztika;
        private Panel pnl_UtasokAlmenu;
        private KerekitettGomb btn_utasok;
        private Panel pnl_UtazasokAlmenu;
        private KerekitettGomb btn_utazasokHozzaadasa;
        private KerekitettGomb btn_utazasokmegtekintese;
        private KerekitettGomb btn_utasokHozzadasa;
        private KerekitettGomb btn_utasokMegtekintese;
        private System.Windows.Forms.Timer tmr_almenuAnimacio;
        private ellipszisVezerlo ev_foForm;
        private Panel pnl_bejelentkezve;
        private Label lbl_nev;
        private Label lbl_bejelentkezve;
        private KerekitettGomb kg_kilepes;
        private ellipszisVezerlo ev_bejelentkezve;
        private Panel pnl_regisztacio;
        private Label lbl_regisztacio;
        private KerekitettGomb kg_regisztacio;
        private kerekitettSzovegMezo kszm_regjelszo;
        private kerekitettSzovegMezo kszm_regnev;
        private kerekitettSzovegMezo kszm_regjelszoujra;
        private Panel pnl_bejelentkezes;
        private KerekitettGomb kszm_regisztralas;
        private KapcsoloGomb kg_bejelentkezvemarad;
        private Label lbl_bejelentkezvemarad;
        private Label lbl_belepes;
        private KerekitettGomb kg_belepes;
        private kerekitettSzovegMezo kszm_jelszo;
        private kerekitettSzovegMezo kszm_felhasznalo;
        private Label lbl_udvozlet;
        private Label lbl_pkeszenall;
        private Label lbl_diszcsik;
        private Label label3;
        private Label label2;
        private KerekitettGomb kszm_vissza;
        private Label lbl_hozzaferes;
        private KerekitettGomb kg_segitseg;
    }
}

