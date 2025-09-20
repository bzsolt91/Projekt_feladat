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
            pnl_fejlec = new SzinatmenetPanel();
            btn_minimalizalas = new KerekitettGomb();
            btn_ablakmeret_valto = new KerekitettGomb();
            btn_kilepes = new KerekitettGomb();
            pnl_fopanel = new Panel();
            pnl_fomenu_disz = new Panel();
            lbl_utazas_kezelo = new Label();
            lbl_disz = new Label();
            btn_utazasok = new KerekitettGomb();
            btn_ertesitesek = new KerekitettGomb();
            lbl_disz2 = new Label();
            pnl_fomenu = new Panel();
            btn_statisztika = new KerekitettGomb();
            kg_segitseg = new KerekitettGomb();
            btn_elofoglalasok = new KerekitettGomb();
            btn_biztonsagiMentes = new KerekitettGomb();
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
            pnl_bejelentkezes.SuspendLayout();
            pnl_bejelentkezve.SuspendLayout();
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
            pnl_bejelentkezes.Location = new Point(49, 52);
            pnl_bejelentkezes.Margin = new Padding(3, 2, 3, 2);
            pnl_bejelentkezes.Name = "pnl_bejelentkezes";
            pnl_bejelentkezes.Size = new Size(405, 331);
            pnl_bejelentkezes.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.BackColor = Color.FromArgb(209, 213, 219);
            label3.ForeColor = Color.FromArgb(209, 213, 219);
            label3.Location = new Point(34, 57);
            label3.Name = "label3";
            label3.Size = new Size(337, 1);
            label3.TabIndex = 8;
            // 
            // kszm_regisztralas
            // 
            kszm_regisztralas.BackColor = Color.MediumSlateBlue;
            kszm_regisztralas.BadgeMeret = 40;
            kszm_regisztralas.EgerTartasHatterSzine = Color.SlateBlue;
            kszm_regisztralas.ErtesitesMutatasa = false;
            kszm_regisztralas.ErtesitesSzam = 0;
            kszm_regisztralas.ErtesitesSzin = Color.Red;
            kszm_regisztralas.ErtesitesSzovegSzin = Color.White;
            kszm_regisztralas.FlatAppearance.BorderSize = 0;
            kszm_regisztralas.FlatStyle = FlatStyle.Flat;
            kszm_regisztralas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_regisztralas.ForeColor = Color.White;
            kszm_regisztralas.HatterSzine = Color.MediumSlateBlue;
            kszm_regisztralas.KeretMeret = 0;
            kszm_regisztralas.KeretSzine = Color.PaleVioletRed;
            kszm_regisztralas.Location = new Point(210, 267);
            kszm_regisztralas.Margin = new Padding(3, 2, 3, 2);
            kszm_regisztralas.Name = "kszm_regisztralas";
            kszm_regisztralas.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_regisztralas.SarokSugar = 8;
            kszm_regisztralas.Size = new Size(164, 43);
            kszm_regisztralas.SzovegSzine = Color.White;
            kszm_regisztralas.TabIndex = 6;
            kszm_regisztralas.Text = "Regisztráció";
            kszm_regisztralas.UseVisualStyleBackColor = false;
            // 
            // kg_bejelentkezvemarad
            // 
            kg_bejelentkezvemarad.AktualisAllas = KapcsoloGomb.KapcsoloAllas.Ki;
            kg_bejelentkezvemarad.BackColor = Color.Transparent;
            kg_bejelentkezvemarad.HatterKitoltoSzin = null;
            kg_bejelentkezvemarad.KetAllasuModAktiv = true;
            kg_bejelentkezvemarad.Location = new Point(258, 206);
            kg_bejelentkezvemarad.Margin = new Padding(3, 2, 3, 2);
            kg_bejelentkezvemarad.MinimumSize = new Size(61, 18);
            kg_bejelentkezvemarad.Name = "kg_bejelentkezvemarad";
            kg_bejelentkezvemarad.Size = new Size(76, 31);
            kg_bejelentkezvemarad.TabIndex = 5;
            // 
            // lbl_bejelentkezvemarad
            // 
            lbl_bejelentkezvemarad.AutoSize = true;
            lbl_bejelentkezvemarad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_bejelentkezvemarad.Location = new Point(61, 206);
            lbl_bejelentkezvemarad.Name = "lbl_bejelentkezvemarad";
            lbl_bejelentkezvemarad.Size = new Size(173, 25);
            lbl_bejelentkezvemarad.TabIndex = 4;
            lbl_bejelentkezvemarad.Text = "Bejelentkezve marad";
            // 
            // lbl_belepes
            // 
            lbl_belepes.AutoSize = true;
            lbl_belepes.Font = new Font("Segoe UI", 12F);
            lbl_belepes.Location = new Point(108, 17);
            lbl_belepes.Name = "lbl_belepes";
            lbl_belepes.Size = new Size(194, 25);
            lbl_belepes.TabIndex = 3;
            lbl_belepes.Text = "Belépés az adatbázisba";
            // 
            // kg_belepes
            // 
            kg_belepes.BackColor = Color.MediumSlateBlue;
            kg_belepes.BadgeMeret = 40;
            kg_belepes.EgerTartasHatterSzine = Color.SlateBlue;
            kg_belepes.ErtesitesMutatasa = false;
            kg_belepes.ErtesitesSzam = 0;
            kg_belepes.ErtesitesSzin = Color.Red;
            kg_belepes.ErtesitesSzovegSzin = Color.White;
            kg_belepes.FlatAppearance.BorderSize = 0;
            kg_belepes.FlatStyle = FlatStyle.Flat;
            kg_belepes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kg_belepes.ForeColor = Color.White;
            kg_belepes.HatterSzine = Color.MediumSlateBlue;
            kg_belepes.KeretMeret = 0;
            kg_belepes.KeretSzine = Color.PaleVioletRed;
            kg_belepes.Location = new Point(32, 267);
            kg_belepes.Margin = new Padding(3, 2, 3, 2);
            kg_belepes.Name = "kg_belepes";
            kg_belepes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_belepes.SarokSugar = 8;
            kg_belepes.Size = new Size(164, 43);
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
            kszm_jelszo.Location = new Point(61, 144);
            kszm_jelszo.Margin = new Padding(4, 3, 4, 3);
            kszm_jelszo.Name = "kszm_jelszo";
            kszm_jelszo.Padding = new Padding(9, 6, 9, 6);
            kszm_jelszo.Size = new Size(273, 35);
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
            kszm_felhasznalo.Location = new Point(61, 71);
            kszm_felhasznalo.Margin = new Padding(4, 3, 4, 3);
            kszm_felhasznalo.Name = "kszm_felhasznalo";
            kszm_felhasznalo.Padding = new Padding(9, 6, 9, 6);
            kszm_felhasznalo.Size = new Size(273, 35);
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
            pnl_bejelentkezve.Location = new Point(459, 52);
            pnl_bejelentkezve.Margin = new Padding(3, 2, 3, 2);
            pnl_bejelentkezve.Name = "pnl_bejelentkezve";
            pnl_bejelentkezve.Size = new Size(405, 331);
            pnl_bejelentkezve.TabIndex = 1;
            pnl_bejelentkezve.Visible = false;
            // 
            // lbl_hozzaferes
            // 
            lbl_hozzaferes.AutoSize = true;
            lbl_hozzaferes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_hozzaferes.ForeColor = Color.FromArgb(55, 65, 81);
            lbl_hozzaferes.Location = new Point(80, 171);
            lbl_hozzaferes.Name = "lbl_hozzaferes";
            lbl_hozzaferes.Size = new Size(0, 21);
            lbl_hozzaferes.TabIndex = 8;
            // 
            // lbl_diszcsik
            // 
            lbl_diszcsik.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_diszcsik.BackColor = Color.FromArgb(209, 213, 219);
            lbl_diszcsik.ForeColor = Color.FromArgb(209, 213, 219);
            lbl_diszcsik.Location = new Point(36, 57);
            lbl_diszcsik.Name = "lbl_diszcsik";
            lbl_diszcsik.Size = new Size(337, 1);
            lbl_diszcsik.TabIndex = 7;
            // 
            // lbl_pkeszenall
            // 
            lbl_pkeszenall.AutoSize = true;
            lbl_pkeszenall.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_pkeszenall.Location = new Point(77, 216);
            lbl_pkeszenall.Name = "lbl_pkeszenall";
            lbl_pkeszenall.Size = new Size(254, 21);
            lbl_pkeszenall.TabIndex = 6;
            lbl_pkeszenall.Text = "A program készen áll a használatra.";
            // 
            // lbl_udvozlet
            // 
            lbl_udvozlet.AutoSize = true;
            lbl_udvozlet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_udvozlet.Location = new Point(147, 82);
            lbl_udvozlet.Name = "lbl_udvozlet";
            lbl_udvozlet.Size = new Size(0, 25);
            lbl_udvozlet.TabIndex = 5;
            // 
            // lbl_nev
            // 
            lbl_nev.AutoSize = true;
            lbl_nev.Font = new Font("Segoe UI", 14F);
            lbl_nev.ForeColor = Color.DarkViolet;
            lbl_nev.Location = new Point(172, 114);
            lbl_nev.Name = "lbl_nev";
            lbl_nev.Size = new Size(46, 30);
            lbl_nev.TabIndex = 4;
            lbl_nev.Text = "nev";
            // 
            // lbl_bejelentkezve
            // 
            lbl_bejelentkezve.AutoSize = true;
            lbl_bejelentkezve.Font = new Font("Segoe UI", 12F);
            lbl_bejelentkezve.Location = new Point(108, 17);
            lbl_bejelentkezve.Name = "lbl_bejelentkezve";
            lbl_bejelentkezve.Size = new Size(195, 25);
            lbl_bejelentkezve.TabIndex = 3;
            lbl_bejelentkezve.Text = "Belépve az adatbázisba";
            // 
            // kg_kilepes
            // 
            kg_kilepes.BackColor = Color.MediumSlateBlue;
            kg_kilepes.BadgeMeret = 40;
            kg_kilepes.EgerTartasHatterSzine = Color.Crimson;
            kg_kilepes.ErtesitesMutatasa = false;
            kg_kilepes.ErtesitesSzam = 0;
            kg_kilepes.ErtesitesSzin = Color.Red;
            kg_kilepes.ErtesitesSzovegSzin = Color.White;
            kg_kilepes.FlatAppearance.BorderSize = 0;
            kg_kilepes.FlatStyle = FlatStyle.Flat;
            kg_kilepes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kg_kilepes.ForeColor = Color.White;
            kg_kilepes.HatterSzine = Color.MediumSlateBlue;
            kg_kilepes.KeretMeret = 0;
            kg_kilepes.KeretSzine = Color.PaleVioletRed;
            kg_kilepes.Location = new Point(116, 256);
            kg_kilepes.Margin = new Padding(3, 2, 3, 2);
            kg_kilepes.Name = "kg_kilepes";
            kg_kilepes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_kilepes.SarokSugar = 8;
            kg_kilepes.Size = new Size(164, 43);
            kg_kilepes.SzovegSzine = Color.White;
            kg_kilepes.TabIndex = 2;
            kg_kilepes.Text = "Kilépés";
            kg_kilepes.UseVisualStyleBackColor = false;
            kg_kilepes.Click += kg_kilepes_Click;
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
            pnl_fejlec.Name = "pnl_fejlec";
            pnl_fejlec.SarkokLekerekitese = 0;
            pnl_fejlec.Size = new Size(1228, 32);
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
            btn_minimalizalas.BadgeMeret = 40;
            btn_minimalizalas.EgerTartasHatterSzine = Color.Yellow;
            btn_minimalizalas.ErtesitesMutatasa = false;
            btn_minimalizalas.ErtesitesSzam = 0;
            btn_minimalizalas.ErtesitesSzin = Color.Red;
            btn_minimalizalas.ErtesitesSzovegSzin = Color.White;
            btn_minimalizalas.FlatStyle = FlatStyle.Flat;
            btn_minimalizalas.Font = new Font("Segoe Fluent Icons", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_minimalizalas.ForeColor = Color.White;
            btn_minimalizalas.HatterSzine = Color.Transparent;
            btn_minimalizalas.KeretMeret = 0;
            btn_minimalizalas.KeretSzine = Color.PaleVioletRed;
            btn_minimalizalas.Location = new Point(1060, 2);
            btn_minimalizalas.Name = "btn_minimalizalas";
            btn_minimalizalas.NyomottAllapotHatterSzine = Color.Yellow;
            btn_minimalizalas.SarokSugar = 0;
            btn_minimalizalas.Size = new Size(53, 26);
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
            btn_ablakmeret_valto.BadgeMeret = 40;
            btn_ablakmeret_valto.EgerTartasHatterSzine = Color.Aqua;
            btn_ablakmeret_valto.ErtesitesMutatasa = false;
            btn_ablakmeret_valto.ErtesitesSzam = 0;
            btn_ablakmeret_valto.ErtesitesSzin = Color.Red;
            btn_ablakmeret_valto.ErtesitesSzovegSzin = Color.White;
            btn_ablakmeret_valto.FlatStyle = FlatStyle.Flat;
            btn_ablakmeret_valto.Font = new Font("Segoe Fluent Icons", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ablakmeret_valto.ForeColor = Color.White;
            btn_ablakmeret_valto.HatterSzine = Color.Transparent;
            btn_ablakmeret_valto.KeretMeret = 0;
            btn_ablakmeret_valto.KeretSzine = Color.PaleVioletRed;
            btn_ablakmeret_valto.Location = new Point(1116, 2);
            btn_ablakmeret_valto.Name = "btn_ablakmeret_valto";
            btn_ablakmeret_valto.NyomottAllapotHatterSzine = Color.Aqua;
            btn_ablakmeret_valto.SarokSugar = 0;
            btn_ablakmeret_valto.Size = new Size(53, 26);
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
            btn_kilepes.BadgeMeret = 40;
            btn_kilepes.EgerTartasHatterSzine = Color.Red;
            btn_kilepes.ErtesitesMutatasa = false;
            btn_kilepes.ErtesitesSzam = 0;
            btn_kilepes.ErtesitesSzin = Color.Red;
            btn_kilepes.ErtesitesSzovegSzin = Color.White;
            btn_kilepes.FlatStyle = FlatStyle.Flat;
            btn_kilepes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_kilepes.ForeColor = Color.White;
            btn_kilepes.HatterSzine = Color.Transparent;
            btn_kilepes.KeretMeret = 0;
            btn_kilepes.KeretSzine = Color.PaleVioletRed;
            btn_kilepes.Location = new Point(1168, 2);
            btn_kilepes.Name = "btn_kilepes";
            btn_kilepes.NyomottAllapotHatterSzine = Color.Red;
            btn_kilepes.SarokSugar = 0;
            btn_kilepes.Size = new Size(53, 26);
            btn_kilepes.SzovegSzine = Color.White;
            btn_kilepes.TabIndex = 1;
            btn_kilepes.Text = "❌";
            btn_kilepes.UseVisualStyleBackColor = false;
            btn_kilepes.Click += btn_kilepes_Click;
            // 
            // pnl_fopanel
            // 
            pnl_fopanel.BackColor = Color.FromArgb(50, 70, 90);
            pnl_fopanel.Controls.Add(pnl_bejelentkezve);
            pnl_fopanel.Controls.Add(pnl_bejelentkezes);
            pnl_fopanel.Dock = DockStyle.Fill;
            pnl_fopanel.ForeColor = Color.Black;
            pnl_fopanel.Location = new Point(242, 32);
            pnl_fopanel.Name = "pnl_fopanel";
            pnl_fopanel.Size = new Size(986, 592);
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
            pnl_fomenu_disz.Name = "pnl_fomenu_disz";
            pnl_fomenu_disz.Size = new Size(223, 52);
            pnl_fomenu_disz.TabIndex = 2;
            // 
            // lbl_utazas_kezelo
            // 
            lbl_utazas_kezelo.BackColor = Color.Transparent;
            lbl_utazas_kezelo.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_utazas_kezelo.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_utazas_kezelo.Location = new Point(3, 3);
            lbl_utazas_kezelo.Name = "lbl_utazas_kezelo";
            lbl_utazas_kezelo.Size = new Size(215, 34);
            lbl_utazas_kezelo.TabIndex = 4;
            lbl_utazas_kezelo.Text = "Utazáskezelő";
            lbl_utazas_kezelo.TextAlign = ContentAlignment.MiddleCenter;
            lbl_utazas_kezelo.Click += lbl_utazas_kezelo_Click;
            lbl_utazas_kezelo.MouseEnter += lbl_utazas_kezelo_MouseEnter;
            lbl_utazas_kezelo.MouseLeave += lbl_utazas_kezelo_MouseLeave;
            // 
            // lbl_disz
            // 
            lbl_disz.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_disz.BackColor = Color.FromArgb(209, 213, 219);
            lbl_disz.ForeColor = Color.FromArgb(209, 213, 219);
            lbl_disz.Location = new Point(38, 45);
            lbl_disz.Name = "lbl_disz";
            lbl_disz.Size = new Size(155, 1);
            lbl_disz.TabIndex = 0;
            // 
            // btn_utazasok
            // 
            btn_utazasok.BackColor = Color.FromArgb(243, 244, 246);
            btn_utazasok.BadgeMeret = 40;
            btn_utazasok.Dock = DockStyle.Top;
            btn_utazasok.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            btn_utazasok.ErtesitesMutatasa = false;
            btn_utazasok.ErtesitesSzam = 0;
            btn_utazasok.ErtesitesSzin = Color.Red;
            btn_utazasok.ErtesitesSzovegSzin = Color.White;
            btn_utazasok.FlatStyle = FlatStyle.Flat;
            btn_utazasok.Font = new Font("Segoe UI Semibold", 14.2641506F, FontStyle.Bold);
            btn_utazasok.ForeColor = Color.FromArgb(55, 65, 81);
            btn_utazasok.HatterSzine = Color.FromArgb(243, 244, 246);
            btn_utazasok.Image = (Image)resources.GetObject("btn_utazasok.Image");
            btn_utazasok.ImageAlign = ContentAlignment.MiddleLeft;
            btn_utazasok.KeretMeret = 0;
            btn_utazasok.KeretSzine = Color.PaleVioletRed;
            btn_utazasok.Location = new Point(0, 52);
            btn_utazasok.Name = "btn_utazasok";
            btn_utazasok.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_utazasok.RightToLeft = RightToLeft.No;
            btn_utazasok.SarokSugar = 10;
            btn_utazasok.Size = new Size(223, 57);
            btn_utazasok.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_utazasok.TabIndex = 3;
            btn_utazasok.Text = " Utazások";
            btn_utazasok.TextAlign = ContentAlignment.MiddleLeft;
            btn_utazasok.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_utazasok.UseVisualStyleBackColor = false;
            btn_utazasok.Click += btn_utazasok_Click;
            // 
            // btn_ertesitesek
            // 
            btn_ertesitesek.BackColor = Color.FromArgb(243, 244, 246);
            btn_ertesitesek.BadgeMeret = 40;
            btn_ertesitesek.Dock = DockStyle.Bottom;
            btn_ertesitesek.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            btn_ertesitesek.ErtesitesMutatasa = true;
            btn_ertesitesek.ErtesitesSzam = 0;
            btn_ertesitesek.ErtesitesSzin = Color.Firebrick;
            btn_ertesitesek.ErtesitesSzovegSzin = Color.White;
            btn_ertesitesek.FlatStyle = FlatStyle.Flat;
            btn_ertesitesek.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Bold);
            btn_ertesitesek.ForeColor = Color.FromArgb(55, 65, 81);
            btn_ertesitesek.HatterSzine = Color.FromArgb(243, 244, 246);
            btn_ertesitesek.Image = (Image)resources.GetObject("btn_ertesitesek.Image");
            btn_ertesitesek.KeretMeret = 0;
            btn_ertesitesek.KeretSzine = Color.PaleVioletRed;
            btn_ertesitesek.Location = new Point(0, 589);
            btn_ertesitesek.Name = "btn_ertesitesek";
            btn_ertesitesek.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_ertesitesek.SarokSugar = 0;
            btn_ertesitesek.Size = new Size(223, 67);
            btn_ertesitesek.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_ertesitesek.TabIndex = 8;
            btn_ertesitesek.UseVisualStyleBackColor = false;
            btn_ertesitesek.Click += btn_ertesitesek_Click;
            // 
            // lbl_disz2
            // 
            lbl_disz2.BackColor = Color.FromArgb(209, 213, 219);
            lbl_disz2.Dock = DockStyle.Bottom;
            lbl_disz2.ForeColor = Color.FromArgb(209, 213, 219);
            lbl_disz2.Location = new Point(0, 588);
            lbl_disz2.Margin = new Padding(0, 57, 0, 0);
            lbl_disz2.Name = "lbl_disz2";
            lbl_disz2.Padding = new Padding(0, 11, 0, 0);
            lbl_disz2.Size = new Size(223, 1);
            lbl_disz2.TabIndex = 9;
            // 
            // pnl_fomenu
            // 
            pnl_fomenu.AutoScroll = true;
            pnl_fomenu.BackColor = Color.FromArgb(243, 244, 246);
            pnl_fomenu.Controls.Add(btn_statisztika);
            pnl_fomenu.Controls.Add(kg_segitseg);
            pnl_fomenu.Controls.Add(btn_elofoglalasok);
            pnl_fomenu.Controls.Add(btn_biztonsagiMentes);
            pnl_fomenu.Controls.Add(pnl_UtasokAlmenu);
            pnl_fomenu.Controls.Add(btn_utasok);
            pnl_fomenu.Controls.Add(pnl_UtazasokAlmenu);
            pnl_fomenu.Controls.Add(lbl_disz2);
            pnl_fomenu.Controls.Add(btn_ertesitesek);
            pnl_fomenu.Controls.Add(btn_utazasok);
            pnl_fomenu.Controls.Add(pnl_fomenu_disz);
            pnl_fomenu.Dock = DockStyle.Left;
            pnl_fomenu.Location = new Point(0, 32);
            pnl_fomenu.Name = "pnl_fomenu";
            pnl_fomenu.Size = new Size(242, 592);
            pnl_fomenu.TabIndex = 1;
            // 
            // btn_statisztika
            // 
            btn_statisztika.BackColor = Color.FromArgb(243, 244, 246);
            btn_statisztika.BadgeMeret = 40;
            btn_statisztika.Dock = DockStyle.Top;
            btn_statisztika.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            btn_statisztika.ErtesitesMutatasa = false;
            btn_statisztika.ErtesitesSzam = 0;
            btn_statisztika.ErtesitesSzin = Color.Red;
            btn_statisztika.ErtesitesSzovegSzin = Color.White;
            btn_statisztika.FlatStyle = FlatStyle.Flat;
            btn_statisztika.Font = new Font("Segoe UI Semibold", 14.2641506F, FontStyle.Bold);
            btn_statisztika.ForeColor = Color.FromArgb(55, 65, 81);
            btn_statisztika.HatterSzine = Color.FromArgb(243, 244, 246);
            btn_statisztika.Image = (Image)resources.GetObject("btn_statisztika.Image");
            btn_statisztika.ImageAlign = ContentAlignment.TopLeft;
            btn_statisztika.KeretMeret = 0;
            btn_statisztika.KeretSzine = Color.PaleVioletRed;
            btn_statisztika.Location = new Point(0, 417);
            btn_statisztika.Name = "btn_statisztika";
            btn_statisztika.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_statisztika.SarokSugar = 10;
            btn_statisztika.Size = new Size(223, 57);
            btn_statisztika.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_statisztika.TabIndex = 15;
            btn_statisztika.Text = " Statisztika";
            btn_statisztika.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_statisztika.UseVisualStyleBackColor = false;
            btn_statisztika.Click += btn_statisztika_Click;
            // 
            // kg_segitseg
            // 
            kg_segitseg.BackColor = Color.FromArgb(243, 244, 246);
            kg_segitseg.BadgeMeret = 40;
            kg_segitseg.Dock = DockStyle.Bottom;
            kg_segitseg.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            kg_segitseg.ErtesitesMutatasa = false;
            kg_segitseg.ErtesitesSzam = 0;
            kg_segitseg.ErtesitesSzin = Color.Red;
            kg_segitseg.ErtesitesSzovegSzin = Color.White;
            kg_segitseg.FlatStyle = FlatStyle.Flat;
            kg_segitseg.Font = new Font("Segoe UI Semibold", 14.2641506F, FontStyle.Bold);
            kg_segitseg.ForeColor = Color.FromArgb(55, 65, 81);
            kg_segitseg.HatterSzine = Color.FromArgb(243, 244, 246);
            kg_segitseg.Image = (Image)resources.GetObject("kg_segitseg.Image");
            kg_segitseg.ImageAlign = ContentAlignment.TopLeft;
            kg_segitseg.KeretMeret = 0;
            kg_segitseg.KeretSzine = Color.PaleVioletRed;
            kg_segitseg.Location = new Point(0, 474);
            kg_segitseg.Name = "kg_segitseg";
            kg_segitseg.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_segitseg.SarokSugar = 10;
            kg_segitseg.Size = new Size(223, 57);
            kg_segitseg.SzovegSzine = Color.FromArgb(55, 65, 81);
            kg_segitseg.TabIndex = 18;
            kg_segitseg.Text = " Útmutató";
            kg_segitseg.TextAlign = ContentAlignment.TopLeft;
            kg_segitseg.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_segitseg.UseVisualStyleBackColor = false;
            kg_segitseg.Click += kg_segitseg_Click;
            // 
            // btn_elofoglalasok
            // 
            btn_elofoglalasok.BackColor = Color.FromArgb(243, 244, 246);
            btn_elofoglalasok.BadgeMeret = 40;
            btn_elofoglalasok.Dock = DockStyle.Top;
            btn_elofoglalasok.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            btn_elofoglalasok.ErtesitesMutatasa = false;
            btn_elofoglalasok.ErtesitesSzam = 0;
            btn_elofoglalasok.ErtesitesSzin = Color.Red;
            btn_elofoglalasok.ErtesitesSzovegSzin = Color.White;
            btn_elofoglalasok.FlatStyle = FlatStyle.Flat;
            btn_elofoglalasok.Font = new Font("Segoe UI Semibold", 14.2641506F, FontStyle.Bold);
            btn_elofoglalasok.ForeColor = Color.FromArgb(55, 65, 81);
            btn_elofoglalasok.HatterSzine = Color.FromArgb(243, 244, 246);
            btn_elofoglalasok.Image = (Image)resources.GetObject("btn_elofoglalasok.Image");
            btn_elofoglalasok.ImageAlign = ContentAlignment.TopLeft;
            btn_elofoglalasok.KeretMeret = 0;
            btn_elofoglalasok.KeretSzine = Color.PaleVioletRed;
            btn_elofoglalasok.Location = new Point(0, 360);
            btn_elofoglalasok.Name = "btn_elofoglalasok";
            btn_elofoglalasok.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_elofoglalasok.SarokSugar = 10;
            btn_elofoglalasok.Size = new Size(223, 57);
            btn_elofoglalasok.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_elofoglalasok.TabIndex = 17;
            btn_elofoglalasok.Text = " Előfoglalások";
            btn_elofoglalasok.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_elofoglalasok.UseVisualStyleBackColor = false;
            btn_elofoglalasok.Click += btn_elofoglalasok_Click;
            // 
            // btn_biztonsagiMentes
            // 
            btn_biztonsagiMentes.BackColor = Color.FromArgb(243, 244, 246);
            btn_biztonsagiMentes.BadgeMeret = 40;
            btn_biztonsagiMentes.Dock = DockStyle.Bottom;
            btn_biztonsagiMentes.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            btn_biztonsagiMentes.ErtesitesMutatasa = false;
            btn_biztonsagiMentes.ErtesitesSzam = 0;
            btn_biztonsagiMentes.ErtesitesSzin = Color.Red;
            btn_biztonsagiMentes.ErtesitesSzovegSzin = Color.White;
            btn_biztonsagiMentes.FlatStyle = FlatStyle.Flat;
            btn_biztonsagiMentes.Font = new Font("Segoe UI Semibold", 14.2641506F, FontStyle.Bold);
            btn_biztonsagiMentes.ForeColor = Color.FromArgb(55, 65, 81);
            btn_biztonsagiMentes.HatterSzine = Color.FromArgb(243, 244, 246);
            btn_biztonsagiMentes.Image = (Image)resources.GetObject("btn_biztonsagiMentes.Image");
            btn_biztonsagiMentes.ImageAlign = ContentAlignment.TopLeft;
            btn_biztonsagiMentes.KeretMeret = 0;
            btn_biztonsagiMentes.KeretSzine = Color.PaleVioletRed;
            btn_biztonsagiMentes.Location = new Point(0, 531);
            btn_biztonsagiMentes.Name = "btn_biztonsagiMentes";
            btn_biztonsagiMentes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_biztonsagiMentes.SarokSugar = 10;
            btn_biztonsagiMentes.Size = new Size(223, 57);
            btn_biztonsagiMentes.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_biztonsagiMentes.TabIndex = 16;
            btn_biztonsagiMentes.Text = " Mentés";
            btn_biztonsagiMentes.TextAlign = ContentAlignment.TopLeft;
            btn_biztonsagiMentes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_biztonsagiMentes.UseMnemonic = false;
            btn_biztonsagiMentes.UseVisualStyleBackColor = false;
            btn_biztonsagiMentes.Click += btn_biztonsagiMentes_Click;
            // 
            // pnl_UtasokAlmenu
            // 
            pnl_UtasokAlmenu.BackColor = Color.FromArgb(209, 213, 219);
            pnl_UtasokAlmenu.Controls.Add(btn_utasokHozzadasa);
            pnl_UtasokAlmenu.Controls.Add(btn_utasokMegtekintese);
            pnl_UtasokAlmenu.Dock = DockStyle.Top;
            pnl_UtasokAlmenu.Location = new Point(0, 263);
            pnl_UtasokAlmenu.Name = "pnl_UtasokAlmenu";
            pnl_UtasokAlmenu.Size = new Size(223, 97);
            pnl_UtasokAlmenu.TabIndex = 12;
            // 
            // btn_utasokHozzadasa
            // 
            btn_utasokHozzadasa.BackColor = Color.FromArgb(209, 213, 219);
            btn_utasokHozzadasa.BadgeMeret = 40;
            btn_utasokHozzadasa.Dock = DockStyle.Top;
            btn_utasokHozzadasa.EgerTartasHatterSzine = SystemColors.ButtonShadow;
            btn_utasokHozzadasa.ErtesitesMutatasa = false;
            btn_utasokHozzadasa.ErtesitesSzam = 0;
            btn_utasokHozzadasa.ErtesitesSzin = Color.Red;
            btn_utasokHozzadasa.ErtesitesSzovegSzin = Color.White;
            btn_utasokHozzadasa.FlatStyle = FlatStyle.Flat;
            btn_utasokHozzadasa.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            btn_utasokHozzadasa.ForeColor = Color.FromArgb(55, 65, 81);
            btn_utasokHozzadasa.HatterSzine = Color.FromArgb(209, 213, 219);
            btn_utasokHozzadasa.Image = (Image)resources.GetObject("btn_utasokHozzadasa.Image");
            btn_utasokHozzadasa.ImageAlign = ContentAlignment.TopCenter;
            btn_utasokHozzadasa.KeretMeret = 0;
            btn_utasokHozzadasa.KeretSzine = Color.PaleVioletRed;
            btn_utasokHozzadasa.Location = new Point(0, 45);
            btn_utasokHozzadasa.Margin = new Padding(0);
            btn_utasokHozzadasa.Name = "btn_utasokHozzadasa";
            btn_utasokHozzadasa.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_utasokHozzadasa.SarokSugar = 10;
            btn_utasokHozzadasa.Size = new Size(223, 45);
            btn_utasokHozzadasa.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_utasokHozzadasa.TabIndex = 2;
            btn_utasokHozzadasa.Text = "Hozzáadás";
            btn_utasokHozzadasa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_utasokHozzadasa.UseVisualStyleBackColor = false;
            btn_utasokHozzadasa.Click += btn_utasokHozzadasa_Click;
            // 
            // btn_utasokMegtekintese
            // 
            btn_utasokMegtekintese.BackColor = Color.FromArgb(209, 213, 219);
            btn_utasokMegtekintese.BadgeMeret = 40;
            btn_utasokMegtekintese.Dock = DockStyle.Top;
            btn_utasokMegtekintese.EgerTartasHatterSzine = SystemColors.ButtonShadow;
            btn_utasokMegtekintese.ErtesitesMutatasa = false;
            btn_utasokMegtekintese.ErtesitesSzam = 0;
            btn_utasokMegtekintese.ErtesitesSzin = Color.Red;
            btn_utasokMegtekintese.ErtesitesSzovegSzin = Color.White;
            btn_utasokMegtekintese.FlatStyle = FlatStyle.Flat;
            btn_utasokMegtekintese.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            btn_utasokMegtekintese.ForeColor = Color.FromArgb(55, 65, 81);
            btn_utasokMegtekintese.HatterSzine = Color.FromArgb(209, 213, 219);
            btn_utasokMegtekintese.Image = (Image)resources.GetObject("btn_utasokMegtekintese.Image");
            btn_utasokMegtekintese.ImageAlign = ContentAlignment.TopCenter;
            btn_utasokMegtekintese.KeretMeret = 0;
            btn_utasokMegtekintese.KeretSzine = Color.PaleVioletRed;
            btn_utasokMegtekintese.Location = new Point(0, 0);
            btn_utasokMegtekintese.Margin = new Padding(0);
            btn_utasokMegtekintese.Name = "btn_utasokMegtekintese";
            btn_utasokMegtekintese.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_utasokMegtekintese.SarokSugar = 10;
            btn_utasokMegtekintese.Size = new Size(223, 45);
            btn_utasokMegtekintese.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_utasokMegtekintese.TabIndex = 0;
            btn_utasokMegtekintese.Text = " Megtekintés";
            btn_utasokMegtekintese.TextAlign = ContentAlignment.MiddleLeft;
            btn_utasokMegtekintese.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_utasokMegtekintese.UseVisualStyleBackColor = false;
            btn_utasokMegtekintese.Click += btn_utasokMegtekintese_Click;
            // 
            // btn_utasok
            // 
            btn_utasok.BackColor = Color.FromArgb(243, 244, 246);
            btn_utasok.BadgeMeret = 40;
            btn_utasok.Dock = DockStyle.Top;
            btn_utasok.EgerTartasHatterSzine = Color.FromArgb(209, 213, 219);
            btn_utasok.ErtesitesMutatasa = false;
            btn_utasok.ErtesitesSzam = 0;
            btn_utasok.ErtesitesSzin = Color.Red;
            btn_utasok.ErtesitesSzovegSzin = Color.White;
            btn_utasok.FlatStyle = FlatStyle.Flat;
            btn_utasok.Font = new Font("Segoe UI Semibold", 14.2641506F, FontStyle.Bold);
            btn_utasok.ForeColor = Color.FromArgb(55, 65, 81);
            btn_utasok.HatterSzine = Color.FromArgb(243, 244, 246);
            btn_utasok.Image = (Image)resources.GetObject("btn_utasok.Image");
            btn_utasok.ImageAlign = ContentAlignment.MiddleLeft;
            btn_utasok.KeretMeret = 0;
            btn_utasok.KeretSzine = Color.PaleVioletRed;
            btn_utasok.Location = new Point(0, 206);
            btn_utasok.Name = "btn_utasok";
            btn_utasok.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_utasok.SarokSugar = 10;
            btn_utasok.Size = new Size(223, 57);
            btn_utasok.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_utasok.TabIndex = 11;
            btn_utasok.Text = "‍ Utasok";
            btn_utasok.TextAlign = ContentAlignment.MiddleLeft;
            btn_utasok.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_utasok.UseVisualStyleBackColor = false;
            btn_utasok.Click += btn_utasok_Click;
            // 
            // pnl_UtazasokAlmenu
            // 
            pnl_UtazasokAlmenu.BackColor = Color.FromArgb(209, 213, 219);
            pnl_UtazasokAlmenu.Controls.Add(btn_utazasokHozzaadasa);
            pnl_UtazasokAlmenu.Controls.Add(btn_utazasokmegtekintese);
            pnl_UtazasokAlmenu.Dock = DockStyle.Top;
            pnl_UtazasokAlmenu.Location = new Point(0, 109);
            pnl_UtazasokAlmenu.Name = "pnl_UtazasokAlmenu";
            pnl_UtazasokAlmenu.Size = new Size(223, 97);
            pnl_UtazasokAlmenu.TabIndex = 0;
            // 
            // btn_utazasokHozzaadasa
            // 
            btn_utazasokHozzaadasa.BackColor = Color.FromArgb(209, 213, 219);
            btn_utazasokHozzaadasa.BadgeMeret = 40;
            btn_utazasokHozzaadasa.Dock = DockStyle.Top;
            btn_utazasokHozzaadasa.EgerTartasHatterSzine = SystemColors.ButtonShadow;
            btn_utazasokHozzaadasa.ErtesitesMutatasa = false;
            btn_utazasokHozzaadasa.ErtesitesSzam = 0;
            btn_utazasokHozzaadasa.ErtesitesSzin = Color.Red;
            btn_utazasokHozzaadasa.ErtesitesSzovegSzin = Color.White;
            btn_utazasokHozzaadasa.FlatStyle = FlatStyle.Flat;
            btn_utazasokHozzaadasa.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            btn_utazasokHozzaadasa.ForeColor = Color.FromArgb(55, 65, 81);
            btn_utazasokHozzaadasa.HatterSzine = Color.FromArgb(209, 213, 219);
            btn_utazasokHozzaadasa.Image = (Image)resources.GetObject("btn_utazasokHozzaadasa.Image");
            btn_utazasokHozzaadasa.KeretMeret = 0;
            btn_utazasokHozzaadasa.KeretSzine = Color.PaleVioletRed;
            btn_utazasokHozzaadasa.Location = new Point(0, 45);
            btn_utazasokHozzaadasa.Margin = new Padding(0);
            btn_utazasokHozzaadasa.Name = "btn_utazasokHozzaadasa";
            btn_utazasokHozzaadasa.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_utazasokHozzaadasa.SarokSugar = 10;
            btn_utazasokHozzaadasa.Size = new Size(223, 45);
            btn_utazasokHozzaadasa.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_utazasokHozzaadasa.TabIndex = 1;
            btn_utazasokHozzaadasa.Text = " Szerkesztés";
            btn_utazasokHozzaadasa.TextAlign = ContentAlignment.MiddleLeft;
            btn_utazasokHozzaadasa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_utazasokHozzaadasa.UseVisualStyleBackColor = false;
            btn_utazasokHozzaadasa.Click += btn_utazasokHozzaadasa_Click;
            // 
            // btn_utazasokmegtekintese
            // 
            btn_utazasokmegtekintese.BackColor = Color.FromArgb(209, 213, 219);
            btn_utazasokmegtekintese.BadgeMeret = 40;
            btn_utazasokmegtekintese.Dock = DockStyle.Top;
            btn_utazasokmegtekintese.EgerTartasHatterSzine = SystemColors.ButtonShadow;
            btn_utazasokmegtekintese.ErtesitesMutatasa = false;
            btn_utazasokmegtekintese.ErtesitesSzam = 0;
            btn_utazasokmegtekintese.ErtesitesSzin = Color.Red;
            btn_utazasokmegtekintese.ErtesitesSzovegSzin = Color.White;
            btn_utazasokmegtekintese.FlatStyle = FlatStyle.Flat;
            btn_utazasokmegtekintese.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            btn_utazasokmegtekintese.ForeColor = Color.FromArgb(55, 65, 81);
            btn_utazasokmegtekintese.HatterSzine = Color.FromArgb(209, 213, 219);
            btn_utazasokmegtekintese.Image = (Image)resources.GetObject("btn_utazasokmegtekintese.Image");
            btn_utazasokmegtekintese.KeretMeret = 0;
            btn_utazasokmegtekintese.KeretSzine = Color.PaleVioletRed;
            btn_utazasokmegtekintese.Location = new Point(0, 0);
            btn_utazasokmegtekintese.Margin = new Padding(0);
            btn_utazasokmegtekintese.Name = "btn_utazasokmegtekintese";
            btn_utazasokmegtekintese.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_utazasokmegtekintese.SarokSugar = 10;
            btn_utazasokmegtekintese.Size = new Size(223, 45);
            btn_utazasokmegtekintese.SzovegSzine = Color.FromArgb(55, 65, 81);
            btn_utazasokmegtekintese.TabIndex = 0;
            btn_utazasokmegtekintese.Text = " Megtekintés";
            btn_utazasokmegtekintese.TextAlign = ContentAlignment.MiddleLeft;
            btn_utazasokmegtekintese.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 624);
            ControlBox = false;
            Controls.Add(pnl_fopanel);
            Controls.Add(pnl_fomenu);
            Controls.Add(pnl_fejlec);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_foForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Utazás kezelő";
            Load += frm_foForm_Load;
            pnl_bejelentkezes.ResumeLayout(false);
            pnl_bejelentkezes.PerformLayout();
            pnl_bejelentkezve.ResumeLayout(false);
            pnl_bejelentkezve.PerformLayout();
            pnl_fejlec.ResumeLayout(false);
            pnl_fopanel.ResumeLayout(false);
            pnl_fomenu_disz.ResumeLayout(false);
            pnl_fomenu.ResumeLayout(false);
            pnl_UtasokAlmenu.ResumeLayout(false);
            pnl_UtazasokAlmenu.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private SzinatmenetPanel pnl_fejlec;
        private KerekitettGomb btn_kilepes;
        private KerekitettGomb btn_ablakmeret_valto;
       private KerekitettGomb btn_minimalizalas;
        private Panel pnl_fomenu_disz;
        private Label lbl_utazas_kezelo;
        private Label lbl_disz;
        private KerekitettGomb btn_utazasok;
        private KerekitettGomb btn_ertesitesek;
        private Label lbl_disz2;
        private Panel pnl_fomenu;
        private KerekitettGomb btn_elofoglalasok;
        private KerekitettGomb btn_biztonsagiMentes;
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
        private Label lbl_hozzaferes;
        private KerekitettGomb kg_segitseg;
        public Panel pnl_fopanel;
    }
}

