namespace Projekt_feladat.Formok
{
    partial class Frm_UtasokMegtekintese
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
            egyeni_vezerlok.ellipszisVezerlo ev_vezerlo;
            pnl_vezerlo = new Panel();
            kg_mentes = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kg_szuro = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kszm_oldal = new Projekt_feladat.egyeni_vezerlok.kerekitettSzovegMezo();
            kerekitettGomb2 = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kerekitettGomb1 = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            dgv_utasok = new Projekt_feladat.egyeni_vezerlok.DoubleBufferedDataGridView();
            ev_vezerlo = new Projekt_feladat.egyeni_vezerlok.ellipszisVezerlo();
            pnl_vezerlo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_utasok).BeginInit();
            SuspendLayout();
            // 
            // ev_vezerlo
            // 
            ev_vezerlo.SarokSugar = 8;
            ev_vezerlo.TargetControl = pnl_vezerlo;
            // 
            // pnl_vezerlo
            // 
            pnl_vezerlo.BackColor = Color.DarkViolet;
            pnl_vezerlo.Controls.Add(kg_mentes);
            pnl_vezerlo.Controls.Add(kg_szuro);
            pnl_vezerlo.Controls.Add(kszm_oldal);
            pnl_vezerlo.Controls.Add(kerekitettGomb2);
            pnl_vezerlo.Controls.Add(kerekitettGomb1);
            pnl_vezerlo.Dock = DockStyle.Bottom;
            pnl_vezerlo.Location = new Point(0, 512);
            pnl_vezerlo.Name = "pnl_vezerlo";
            pnl_vezerlo.Size = new Size(914, 88);
            pnl_vezerlo.TabIndex = 0;
            // 
            // kg_mentes
            // 
            kg_mentes.BackColor = Color.MediumSlateBlue;
            kg_mentes.EgerTartasHatterSzine = Color.SlateBlue;
            kg_mentes.FlatAppearance.BorderSize = 0;
            kg_mentes.FlatStyle = FlatStyle.Flat;
            kg_mentes.ForeColor = Color.White;
            kg_mentes.HatterSzine = Color.MediumSlateBlue;
            kg_mentes.KeretMeret = 0;
            kg_mentes.KeretSzine = Color.PaleVioletRed;
            kg_mentes.Location = new Point(544, 17);
            kg_mentes.Name = "kg_mentes";
            kg_mentes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_mentes.SarokSugar = 8;
            kg_mentes.Size = new Size(188, 50);
            kg_mentes.SzovegSzine = Color.White;
            kg_mentes.TabIndex = 4;
            kg_mentes.Text = "Mentés";
            kg_mentes.UseVisualStyleBackColor = false;
            // 
            // kg_szuro
            // 
            kg_szuro.BackColor = Color.MediumSlateBlue;
            kg_szuro.EgerTartasHatterSzine = Color.SlateBlue;
            kg_szuro.FlatAppearance.BorderSize = 0;
            kg_szuro.FlatStyle = FlatStyle.Flat;
            kg_szuro.ForeColor = Color.White;
            kg_szuro.HatterSzine = Color.MediumSlateBlue;
            kg_szuro.KeretMeret = 0;
            kg_szuro.KeretSzine = Color.PaleVioletRed;
            kg_szuro.Location = new Point(341, 17);
            kg_szuro.Name = "kg_szuro";
            kg_szuro.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_szuro.SarokSugar = 8;
            kg_szuro.Size = new Size(188, 50);
            kg_szuro.SzovegSzine = Color.White;
            kg_szuro.TabIndex = 3;
            kg_szuro.Text = "Szűrő";
            kg_szuro.UseVisualStyleBackColor = false;
            // 
            // kszm_oldal
            // 
            kszm_oldal.AlahuzottStilus = false;
            kszm_oldal.BackColor = SystemColors.Window;
            kszm_oldal.FokuszKeretSzin = Color.HotPink;
            kszm_oldal.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kszm_oldal.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_oldal.HelyorzoSzin = Color.DarkGray;
            kszm_oldal.HelyorzoSzoveg = "Oldal";
            kszm_oldal.JelszoKarakter = false;
            kszm_oldal.KeretMeret = 2;
            kszm_oldal.KeretSugar = 8;
            kszm_oldal.KeretSzin = Color.MediumSlateBlue;
            kszm_oldal.Location = new Point(221, 21);
            kszm_oldal.Margin = new Padding(4);
            kszm_oldal.Name = "kszm_oldal";
            kszm_oldal.Padding = new Padding(10, 7, 10, 7);
            kszm_oldal.Size = new Size(77, 44);
            kszm_oldal.TabIndex = 2;
            kszm_oldal.Texts = "";
            kszm_oldal.TobbSor = false;
            // 
            // kerekitettGomb2
            // 
            kerekitettGomb2.BackColor = Color.MediumSlateBlue;
            kerekitettGomb2.EgerTartasHatterSzine = Color.SlateBlue;
            kerekitettGomb2.FlatAppearance.BorderSize = 0;
            kerekitettGomb2.FlatStyle = FlatStyle.Flat;
            kerekitettGomb2.ForeColor = Color.White;
            kerekitettGomb2.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb2.KeretMeret = 0;
            kerekitettGomb2.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb2.Location = new Point(112, 17);
            kerekitettGomb2.Name = "kerekitettGomb2";
            kerekitettGomb2.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb2.SarokSugar = 8;
            kerekitettGomb2.Size = new Size(86, 50);
            kerekitettGomb2.SzovegSzine = Color.White;
            kerekitettGomb2.TabIndex = 1;
            kerekitettGomb2.Text = "kerekitettGomb2";
            kerekitettGomb2.UseVisualStyleBackColor = false;
            // 
            // kerekitettGomb1
            // 
            kerekitettGomb1.BackColor = Color.MediumSlateBlue;
            kerekitettGomb1.EgerTartasHatterSzine = Color.SlateBlue;
            kerekitettGomb1.FlatAppearance.BorderSize = 0;
            kerekitettGomb1.FlatStyle = FlatStyle.Flat;
            kerekitettGomb1.ForeColor = Color.White;
            kerekitettGomb1.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb1.KeretMeret = 0;
            kerekitettGomb1.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb1.Location = new Point(12, 17);
            kerekitettGomb1.Name = "kerekitettGomb1";
            kerekitettGomb1.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb1.SarokSugar = 8;
            kerekitettGomb1.Size = new Size(86, 50);
            kerekitettGomb1.SzovegSzine = Color.White;
            kerekitettGomb1.TabIndex = 0;
            kerekitettGomb1.Text = "kerekitettGomb1";
            kerekitettGomb1.UseVisualStyleBackColor = false;
            // 
            // dgv_utasok
            // 
            dgv_utasok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_utasok.Dock = DockStyle.Fill;
            dgv_utasok.EnableHeadersVisualStyles = false;
            dgv_utasok.Location = new Point(0, 0);
            dgv_utasok.Name = "dgv_utasok";
            dgv_utasok.RowHeadersWidth = 51;
            dgv_utasok.Size = new Size(914, 512);
            dgv_utasok.TabIndex = 1;
            // 
            // Frm_UtasokMegtekintese
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgv_utasok);
            Controls.Add(pnl_vezerlo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_UtasokMegtekintese";
            Text = "Utasok";
            Load += Frm_Utasok_Load;
            pnl_vezerlo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_utasok).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_vezerlo;
        private egyeni_vezerlok.kerekitettSzovegMezo kszm_oldal;
        private egyeni_vezerlok.KerekitettGomb kerekitettGomb2;
        private egyeni_vezerlok.KerekitettGomb kerekitettGomb1;
        private egyeni_vezerlok.DoubleBufferedDataGridView dgv_utasok;
        private egyeni_vezerlok.KerekitettGomb kg_mentes;
        private egyeni_vezerlok.KerekitettGomb kg_szuro;
    }
}