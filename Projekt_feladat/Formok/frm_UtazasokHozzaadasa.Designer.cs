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
            pnl_torles = new Panel();
            kg_nem = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kg_igen = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            lb_utazas = new Label();
            lb_torolni = new Label();
            kszm_desztinacio = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_utazasElnevezese = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            dt_datumvalaszto = new DateTimePicker();
            kszm_hozzaadas = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            rcb_desztinacio = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            rcb_utazasIdeje = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            rcb_utazasElnevezese = new Projekt_feladat.egyeni_vezerlok.kerekitettLenyilloMenu();
            kg_utazasTorlese = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            ev_torles = new Projekt_feladat.egyeni_vezerlok.ellipszisVezerlo();
            pnl_torles.SuspendLayout();
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
            pnl_torles.Location = new Point(79, 333);
            pnl_torles.Margin = new Padding(3, 2, 3, 2);
            pnl_torles.Name = "pnl_torles";
            pnl_torles.Size = new Size(454, 193);
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
            kg_nem.Location = new Point(239, 123);
            kg_nem.Margin = new Padding(3, 2, 3, 2);
            kg_nem.Name = "kg_nem";
            kg_nem.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_nem.SarokSugar = 8;
            kg_nem.Size = new Size(164, 38);
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
            kg_igen.Location = new Point(44, 123);
            kg_igen.Margin = new Padding(3, 2, 3, 2);
            kg_igen.Name = "kg_igen";
            kg_igen.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_igen.SarokSugar = 8;
            kg_igen.Size = new Size(164, 38);
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
            lb_utazas.Location = new Point(59, 59);
            lb_utazas.Name = "lb_utazas";
            lb_utazas.Size = new Size(0, 25);
            lb_utazas.TabIndex = 1;
            // 
            // lb_torolni
            // 
            lb_torolni.AutoSize = true;
            lb_torolni.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lb_torolni.Location = new Point(59, 25);
            lb_torolni.Name = "lb_torolni";
            lb_torolni.Size = new Size(328, 25);
            lb_torolni.TabIndex = 0;
            lb_torolni.Text = "Ön törölni készül a következő utazást:";
            // 
            // kszm_desztinacio
            // 
            kszm_desztinacio.AlahuzottStilus = false;
            kszm_desztinacio.BackColor = SystemColors.Window;
            kszm_desztinacio.FokuszKeretSzin = Color.HotPink;
            kszm_desztinacio.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_desztinacio.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_desztinacio.HelyorzoSzin = Color.DarkGray;
            kszm_desztinacio.HelyorzoSzoveg = "Densztináció";
            kszm_desztinacio.JelszoKarakter = false;
            kszm_desztinacio.KeretMeret = 2;
            kszm_desztinacio.KeretSugar = 8;
            kszm_desztinacio.KeretSzin = Color.MediumSlateBlue;
            kszm_desztinacio.Location = new Point(19, 17);
            kszm_desztinacio.Margin = new Padding(4, 3, 4, 3);
            kszm_desztinacio.Name = "kszm_desztinacio";
            kszm_desztinacio.Padding = new Padding(9, 5, 9, 5);
            kszm_desztinacio.Size = new Size(429, 35);
            kszm_desztinacio.TabIndex = 0;
            kszm_desztinacio.Texts = "";
            kszm_desztinacio.TobbSor = false;
            // 
            // kszm_utazasElnevezese
            // 
            kszm_utazasElnevezese.AlahuzottStilus = false;
            kszm_utazasElnevezese.BackColor = SystemColors.Window;
            kszm_utazasElnevezese.FokuszKeretSzin = Color.HotPink;
            kszm_utazasElnevezese.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_utazasElnevezese.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_utazasElnevezese.HelyorzoSzin = Color.DarkGray;
            kszm_utazasElnevezese.HelyorzoSzoveg = "Utazás Elnevezése";
            kszm_utazasElnevezese.JelszoKarakter = false;
            kszm_utazasElnevezese.KeretMeret = 2;
            kszm_utazasElnevezese.KeretSugar = 8;
            kszm_utazasElnevezese.KeretSzin = Color.MediumSlateBlue;
            kszm_utazasElnevezese.Location = new Point(19, 82);
            kszm_utazasElnevezese.Margin = new Padding(4, 3, 4, 3);
            kszm_utazasElnevezese.Name = "kszm_utazasElnevezese";
            kszm_utazasElnevezese.Padding = new Padding(9, 5, 9, 5);
            kszm_utazasElnevezese.Size = new Size(430, 35);
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
            dt_datumvalaszto.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dt_datumvalaszto.Location = new Point(18, 148);
            dt_datumvalaszto.Margin = new Padding(3, 2, 3, 2);
            dt_datumvalaszto.Name = "dt_datumvalaszto";
            dt_datumvalaszto.Size = new Size(430, 32);
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
            kszm_hozzaadas.Location = new Point(79, 232);
            kszm_hozzaadas.Margin = new Padding(3, 2, 3, 2);
            kszm_hozzaadas.Name = "kszm_hozzaadas";
            kszm_hozzaadas.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_hozzaadas.SarokSugar = 8;
            kszm_hozzaadas.Size = new Size(257, 53);
            kszm_hozzaadas.SzovegSzine = Color.White;
            kszm_hozzaadas.TabIndex = 3;
            kszm_hozzaadas.Text = "Új utazás hozzáadása";
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
            rcb_desztinacio.ForeColor = Color.White;
            rcb_desztinacio.Ikon = (Image)resources.GetObject("rcb_desztinacio.Ikon");
            rcb_desztinacio.ItemPanelAlosSzin = Color.WhiteSmoke;
            rcb_desztinacio.ItemPanelFelsoSzin = Color.WhiteSmoke;
            rcb_desztinacio.KeretSzin = Color.BlueViolet;
            rcb_desztinacio.KeretVastagsag = 1.8F;
            rcb_desztinacio.Location = new Point(508, 17);
            rcb_desztinacio.Margin = new Padding(0);
            rcb_desztinacio.MinimumSize = new Size(150, 0);
            rcb_desztinacio.Name = "rcb_desztinacio";
            rcb_desztinacio.Padding = new Padding(0, 0, 0, 10);
            rcb_desztinacio.Radius = 20;
            rcb_desztinacio.Size = new Size(302, 57);
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
            rcb_utazasIdeje.ForeColor = Color.White;
            rcb_utazasIdeje.Ikon = (Image)resources.GetObject("rcb_utazasIdeje.Ikon");
            rcb_utazasIdeje.ItemPanelAlosSzin = Color.WhiteSmoke;
            rcb_utazasIdeje.ItemPanelFelsoSzin = Color.WhiteSmoke;
            rcb_utazasIdeje.KeretSzin = Color.BlueViolet;
            rcb_utazasIdeje.KeretVastagsag = 1.8F;
            rcb_utazasIdeje.Location = new Point(508, 82);
            rcb_utazasIdeje.Margin = new Padding(0);
            rcb_utazasIdeje.MinimumSize = new Size(150, 0);
            rcb_utazasIdeje.Name = "rcb_utazasIdeje";
            rcb_utazasIdeje.Padding = new Padding(0, 0, 0, 10);
            rcb_utazasIdeje.Radius = 20;
            rcb_utazasIdeje.Size = new Size(302, 57);
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
            rcb_utazasElnevezese.ForeColor = Color.White;
            rcb_utazasElnevezese.Ikon = (Image)resources.GetObject("rcb_utazasElnevezese.Ikon");
            rcb_utazasElnevezese.ItemPanelAlosSzin = Color.WhiteSmoke;
            rcb_utazasElnevezese.ItemPanelFelsoSzin = Color.WhiteSmoke;
            rcb_utazasElnevezese.KeretSzin = Color.BlueViolet;
            rcb_utazasElnevezese.KeretVastagsag = 1.8F;
            rcb_utazasElnevezese.Location = new Point(508, 148);
            rcb_utazasElnevezese.Margin = new Padding(0);
            rcb_utazasElnevezese.MinimumSize = new Size(150, 0);
            rcb_utazasElnevezese.Name = "rcb_utazasElnevezese";
            rcb_utazasElnevezese.Padding = new Padding(0, 0, 0, 5);
            rcb_utazasElnevezese.Radius = 20;
            rcb_utazasElnevezese.Size = new Size(302, 57);
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
            kg_utazasTorlese.Location = new Point(508, 232);
            kg_utazasTorlese.Margin = new Padding(3, 2, 3, 2);
            kg_utazasTorlese.Name = "kg_utazasTorlese";
            kg_utazasTorlese.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_utazasTorlese.SarokSugar = 8;
            kg_utazasTorlese.Size = new Size(270, 53);
            kg_utazasTorlese.SzovegSzine = Color.White;
            kg_utazasTorlese.TabIndex = 10;
            kg_utazasTorlese.Text = "Utazás törlése";
            kg_utazasTorlese.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_utazasTorlese.UseVisualStyleBackColor = false;
            kg_utazasTorlese.Click += kg_utazasTorlese_Click;
            // 
            // frm_UtazasokHozzaadasa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1075, 518);
            Controls.Add(pnl_torles);
            Controls.Add(kg_utazasTorlese);
            Controls.Add(rcb_utazasElnevezese);
            Controls.Add(rcb_utazasIdeje);
            Controls.Add(kszm_hozzaadas);
            Controls.Add(dt_datumvalaszto);
            Controls.Add(kszm_utazasElnevezese);
            Controls.Add(rcb_desztinacio);
            Controls.Add(kszm_desztinacio);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_UtazasokHozzaadasa";
            Text = "frm_UtazasokHozzaadasa";
            Load += frm_UtazasokHozzaadasa_Load;
            pnl_torles.ResumeLayout(false);
            pnl_torles.PerformLayout();
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
    }
}