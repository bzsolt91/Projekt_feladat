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
            pnl_fejlec = new SzinatmenetPanel();
            btn_minimalizalas = new KerekitettGomb();
            btn_ablakmeret_valto = new KerekitettGomb();
            btn_kilepes = new KerekitettGomb();
            pnl_fopanel = new SzinatmenetPanel();
            pnl_fomenu_disz = new Panel();
            lbl_utazas_kezelo = new Label();
            lbl_disz = new Label();
            btn_utazasok = new KerekitettGomb();
            button6 = new KerekitettGomb();
            lbl_disz2 = new Label();
            button1 = new KerekitettGomb();
            pnl_fomenu = new Panel();
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
            pnl_fejlec.SuspendLayout();
            pnl_fomenu_disz.SuspendLayout();
            pnl_fomenu.SuspendLayout();
            pnl_UtasokAlmenu.SuspendLayout();
            pnl_UtazasokAlmenu.SuspendLayout();
            SuspendLayout();
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
            pnl_fejlec.Size = new Size(1295, 37);
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
            btn_minimalizalas.Location = new Point(1104, 3);
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
            btn_ablakmeret_valto.Location = new Point(1167, 3);
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
            btn_kilepes.Location = new Point(1227, 3);
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
            pnl_fopanel.BackColor = Color.White;
            pnl_fopanel.Dock = DockStyle.Fill;
            pnl_fopanel.ForeColor = Color.Black;
            pnl_fopanel.KeretSzin = Color.Black;
            pnl_fopanel.KeretVastagsag = 0F;
            pnl_fopanel.Location = new Point(277, 37);
            pnl_fopanel.Margin = new Padding(3, 4, 3, 4);
            pnl_fopanel.Name = "pnl_fopanel";
            pnl_fopanel.SarkokLekerekitese = 0;
            pnl_fopanel.Size = new Size(1018, 698);
            pnl_fopanel.SzinatmenetAlsoSzine = Color.FromArgb(40, 50, 60);
            pnl_fopanel.SzinatmenetFelsoSzine = Color.FromArgb(72, 85, 99);
            pnl_fopanel.SzinatmenetSzog = 90F;
            pnl_fopanel.TabIndex = 2;
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
            button6.Location = new Point(0, 696);
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
            lbl_disz2.Location = new Point(0, 693);
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
            button1.Location = new Point(0, 626);
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
            btn_utasokHozzadasa.Text = "🖆 Szerkesztés";
            btn_utasokHozzadasa.TextAlign = ContentAlignment.MiddleLeft;
            btn_utasokHozzadasa.UseVisualStyleBackColor = false;
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
            ClientSize = new Size(1295, 735);
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
            pnl_fejlec.ResumeLayout(false);
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
        private SzinatmenetPanel pnl_fopanel;
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
    }
}

