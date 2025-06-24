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
            kszm_desztinacio = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kszm_utazasElnevezese = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            dt_datumvalaszto = new DateTimePicker();
            kszm_hozzaadas = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            SuspendLayout();
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
            kszm_desztinacio.Location = new Point(109, 58);
            kszm_desztinacio.Margin = new Padding(4);
            kszm_desztinacio.Name = "kszm_desztinacio";
            kszm_desztinacio.Padding = new Padding(10, 7, 10, 7);
            kszm_desztinacio.Size = new Size(490, 44);
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
            kszm_utazasElnevezese.Location = new Point(109, 144);
            kszm_utazasElnevezese.Margin = new Padding(4);
            kszm_utazasElnevezese.Name = "kszm_utazasElnevezese";
            kszm_utazasElnevezese.Padding = new Padding(10, 7, 10, 7);
            kszm_utazasElnevezese.Size = new Size(483, 44);
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
            dt_datumvalaszto.Location = new Point(109, 238);
            dt_datumvalaszto.Name = "dt_datumvalaszto";
            dt_datumvalaszto.Size = new Size(483, 38);
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
            kszm_hozzaadas.KeretMeret = 0;
            kszm_hozzaadas.KeretSzine = Color.PaleVioletRed;
            kszm_hozzaadas.Location = new Point(109, 425);
            kszm_hozzaadas.Name = "kszm_hozzaadas";
            kszm_hozzaadas.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kszm_hozzaadas.SarokSugar = 8;
            kszm_hozzaadas.Size = new Size(294, 71);
            kszm_hozzaadas.SzovegSzine = Color.White;
            kszm_hozzaadas.TabIndex = 3;
            kszm_hozzaadas.Text = "Új utazás hozzáadása";
            kszm_hozzaadas.UseVisualStyleBackColor = false;
            kszm_hozzaadas.Click += kszm_hozzaadas_Click;
            // 
            // frm_UtazasokHozzaadasa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(970, 662);
            Controls.Add(kszm_hozzaadas);
            Controls.Add(dt_datumvalaszto);
            Controls.Add(kszm_utazasElnevezese);
            Controls.Add(kszm_desztinacio);
            Name = "frm_UtazasokHozzaadasa";
            Text = "frm_UtazasokHozzaadasa";
            ResumeLayout(false);
        }

        #endregion

        private egyeni_vezerlok.kerekitettSzovegMezo kszm_desztinacio;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_utazasElnevezese;
        private DateTimePicker dt_datumvalaszto;
        private egyeni_vezerlok.KerekitettGomb kszm_hozzaadas;
    }
}