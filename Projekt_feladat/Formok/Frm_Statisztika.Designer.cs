namespace Projekt_feladat.Formok
{
    partial class Frm_Statisztika
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
            szpl_utasokSzama = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            lbl_osszUtas = new Label();
            szpn_utazasokSzama = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            lb_utazasokSzama = new Label();
            szpn_atlagosUtazasokSzama = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            lbl_atlagosUtazasokSzama = new Label();
            szp_tendencia = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            pnl_geopanel = new Panel();
            flp_rendezoPanel = new FlowLayoutPanel();
            szpn_penzugyiJelentes = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            sznp_egyebStatisztika = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            flp_egyebStatisztika = new FlowLayoutPanel();
            szpl_utasokSzama.SuspendLayout();
            szpn_utazasokSzama.SuspendLayout();
            szpn_atlagosUtazasokSzama.SuspendLayout();
            pnl_geopanel.SuspendLayout();
            flp_rendezoPanel.SuspendLayout();
            sznp_egyebStatisztika.SuspendLayout();
            SuspendLayout();
            // 
            // szpl_utasokSzama
            // 
            szpl_utasokSzama.BackColor = Color.Transparent;
            szpl_utasokSzama.Controls.Add(lbl_osszUtas);
            szpl_utasokSzama.ForeColor = Color.Black;
            szpl_utasokSzama.KeretSzin = Color.Black;
            szpl_utasokSzama.KeretVastagsag = 0F;
            szpl_utasokSzama.Location = new Point(38, 120);
            szpl_utasokSzama.Margin = new Padding(3, 2, 3, 2);
            szpl_utasokSzama.Name = "szpl_utasokSzama";
            szpl_utasokSzama.SarkokLekerekitese = 20;
            szpl_utasokSzama.Size = new Size(275, 26);
            szpl_utasokSzama.SzinatmenetAlsoSzine = Color.LightSlateGray;
            szpl_utasokSzama.SzinatmenetFelsoSzine = Color.LightSlateGray;
            szpl_utasokSzama.SzinatmenetSzog = 90F;
            szpl_utasokSzama.TabIndex = 0;
            // 
            // lbl_osszUtas
            // 
            lbl_osszUtas.AutoSize = true;
            lbl_osszUtas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_osszUtas.ForeColor = Color.White;
            lbl_osszUtas.Location = new Point(3, 0);
            lbl_osszUtas.Name = "lbl_osszUtas";
            lbl_osszUtas.Size = new Size(184, 21);
            lbl_osszUtas.TabIndex = 0;
            lbl_osszUtas.Text = "Regisztrált utasok száma:";
            // 
            // szpn_utazasokSzama
            // 
            szpn_utazasokSzama.BackColor = Color.Transparent;
            szpn_utazasokSzama.Controls.Add(lb_utazasokSzama);
            szpn_utazasokSzama.ForeColor = Color.Black;
            szpn_utazasokSzama.KeretSzin = Color.Black;
            szpn_utazasokSzama.KeretVastagsag = 0F;
            szpn_utazasokSzama.Location = new Point(671, 195);
            szpn_utazasokSzama.Margin = new Padding(3, 2, 3, 2);
            szpn_utazasokSzama.Name = "szpn_utazasokSzama";
            szpn_utazasokSzama.SarkokLekerekitese = 20;
            szpn_utazasokSzama.Size = new Size(226, 22);
            szpn_utazasokSzama.SzinatmenetAlsoSzine = Color.LightSlateGray;
            szpn_utazasokSzama.SzinatmenetFelsoSzine = Color.LightSlateGray;
            szpn_utazasokSzama.SzinatmenetSzog = 90F;
            szpn_utazasokSzama.TabIndex = 1;
            // 
            // lb_utazasokSzama
            // 
            lb_utazasokSzama.AutoSize = true;
            lb_utazasokSzama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lb_utazasokSzama.ForeColor = Color.White;
            lb_utazasokSzama.Location = new Point(3, -2);
            lb_utazasokSzama.Name = "lb_utazasokSzama";
            lb_utazasokSzama.Size = new Size(124, 21);
            lb_utazasokSzama.TabIndex = 0;
            lb_utazasokSzama.Text = "Utazások száma:";
            // 
            // szpn_atlagosUtazasokSzama
            // 
            szpn_atlagosUtazasokSzama.BackColor = Color.Transparent;
            szpn_atlagosUtazasokSzama.Controls.Add(lbl_atlagosUtazasokSzama);
            szpn_atlagosUtazasokSzama.ForeColor = Color.Black;
            szpn_atlagosUtazasokSzama.KeretSzin = Color.Black;
            szpn_atlagosUtazasokSzama.KeretVastagsag = 0F;
            szpn_atlagosUtazasokSzama.Location = new Point(809, 56);
            szpn_atlagosUtazasokSzama.Margin = new Padding(3, 2, 3, 2);
            szpn_atlagosUtazasokSzama.Name = "szpn_atlagosUtazasokSzama";
            szpn_atlagosUtazasokSzama.SarkokLekerekitese = 20;
            szpn_atlagosUtazasokSzama.Size = new Size(252, 22);
            szpn_atlagosUtazasokSzama.SzinatmenetAlsoSzine = Color.LightSlateGray;
            szpn_atlagosUtazasokSzama.SzinatmenetFelsoSzine = Color.LightSlateGray;
            szpn_atlagosUtazasokSzama.SzinatmenetSzog = 90F;
            szpn_atlagosUtazasokSzama.TabIndex = 2;
            // 
            // lbl_atlagosUtazasokSzama
            // 
            lbl_atlagosUtazasokSzama.AutoSize = true;
            lbl_atlagosUtazasokSzama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_atlagosUtazasokSzama.ForeColor = Color.White;
            lbl_atlagosUtazasokSzama.Location = new Point(0, -1);
            lbl_atlagosUtazasokSzama.Name = "lbl_atlagosUtazasokSzama";
            lbl_atlagosUtazasokSzama.Size = new Size(141, 21);
            lbl_atlagosUtazasokSzama.TabIndex = 0;
            lbl_atlagosUtazasokSzama.Text = "Idén utazók száma:";
            // 
            // szp_tendencia
            // 
            szp_tendencia.BackColor = Color.Transparent;
            szp_tendencia.Dock = DockStyle.Top;
            szp_tendencia.ForeColor = Color.Black;
            szp_tendencia.KeretSzin = Color.Black;
            szp_tendencia.KeretVastagsag = 0F;
            szp_tendencia.Location = new Point(35, 245);
            szp_tendencia.Margin = new Padding(35, 20, 35, 2);
            szp_tendencia.Name = "szp_tendencia";
            szp_tendencia.Padding = new Padding(9, 8, 9, 8);
            szp_tendencia.SarkokLekerekitese = 40;
            szp_tendencia.Size = new Size(1012, 248);
            szp_tendencia.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szp_tendencia.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szp_tendencia.SzinatmenetSzog = 90F;
            szp_tendencia.TabIndex = 5;
            // 
            // pnl_geopanel
            // 
            pnl_geopanel.Controls.Add(szpl_utasokSzama);
            pnl_geopanel.Controls.Add(szpn_utazasokSzama);
            pnl_geopanel.Controls.Add(szpn_atlagosUtazasokSzama);
            pnl_geopanel.Location = new Point(0, 0);
            pnl_geopanel.Margin = new Padding(0);
            pnl_geopanel.Name = "pnl_geopanel";
            pnl_geopanel.Size = new Size(1082, 225);
            pnl_geopanel.TabIndex = 4;
            // 
            // flp_rendezoPanel
            // 
            flp_rendezoPanel.AutoScroll = true;
            flp_rendezoPanel.AutoSize = true;
            flp_rendezoPanel.Controls.Add(pnl_geopanel);
            flp_rendezoPanel.Controls.Add(szp_tendencia);
            flp_rendezoPanel.Controls.Add(szpn_penzugyiJelentes);
            flp_rendezoPanel.Controls.Add(sznp_egyebStatisztika);
            flp_rendezoPanel.Dock = DockStyle.Fill;
            flp_rendezoPanel.FlowDirection = FlowDirection.TopDown;
            flp_rendezoPanel.Location = new Point(0, 0);
            flp_rendezoPanel.Margin = new Padding(3, 2, 3, 2);
            flp_rendezoPanel.Name = "flp_rendezoPanel";
            flp_rendezoPanel.Size = new Size(1082, 531);
            flp_rendezoPanel.TabIndex = 0;
            flp_rendezoPanel.WrapContents = false;
            flp_rendezoPanel.Resize += flp_rendezoPanel_Resize;
            // 
            // szpn_penzugyiJelentes
            // 
            szpn_penzugyiJelentes.BackColor = Color.Transparent;
            szpn_penzugyiJelentes.Dock = DockStyle.Top;
            szpn_penzugyiJelentes.ForeColor = Color.Black;
            szpn_penzugyiJelentes.KeretSzin = Color.Black;
            szpn_penzugyiJelentes.KeretVastagsag = 0F;
            szpn_penzugyiJelentes.Location = new Point(35, 515);
            szpn_penzugyiJelentes.Margin = new Padding(35, 20, 35, 2);
            szpn_penzugyiJelentes.Name = "szpn_penzugyiJelentes";
            szpn_penzugyiJelentes.Padding = new Padding(30, 30, 30, 65);
            szpn_penzugyiJelentes.SarkokLekerekitese = 40;
            szpn_penzugyiJelentes.Size = new Size(1012, 400);
            szpn_penzugyiJelentes.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szpn_penzugyiJelentes.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szpn_penzugyiJelentes.SzinatmenetSzog = 90F;
            szpn_penzugyiJelentes.TabIndex = 6;
            // 
            // sznp_egyebStatisztika
            // 
            sznp_egyebStatisztika.BackColor = Color.Transparent;
            sznp_egyebStatisztika.Controls.Add(flp_egyebStatisztika);
            sznp_egyebStatisztika.Dock = DockStyle.Top;
            sznp_egyebStatisztika.ForeColor = Color.Black;
            sznp_egyebStatisztika.KeretSzin = Color.Black;
            sznp_egyebStatisztika.KeretVastagsag = 0F;
            sznp_egyebStatisztika.Location = new Point(35, 947);
            sznp_egyebStatisztika.Margin = new Padding(35, 30, 35, 2);
            sznp_egyebStatisztika.Name = "sznp_egyebStatisztika";
            sznp_egyebStatisztika.Padding = new Padding(15);
            sznp_egyebStatisztika.SarkokLekerekitese = 40;
            sznp_egyebStatisztika.Size = new Size(1012, 300);
            sznp_egyebStatisztika.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            sznp_egyebStatisztika.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            sznp_egyebStatisztika.SzinatmenetSzog = 90F;
            sznp_egyebStatisztika.TabIndex = 7;
            // 
            // flp_egyebStatisztika
            // 
            flp_egyebStatisztika.BackColor = Color.WhiteSmoke;
            flp_egyebStatisztika.Dock = DockStyle.Fill;
            flp_egyebStatisztika.FlowDirection = FlowDirection.TopDown;
            flp_egyebStatisztika.Location = new Point(15, 15);
            flp_egyebStatisztika.Name = "flp_egyebStatisztika";
            flp_egyebStatisztika.Size = new Size(982, 270);
            flp_egyebStatisztika.TabIndex = 0;
            // 
            // Frm_Statisztika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(50, 70, 90);
            ClientSize = new Size(1082, 531);
            Controls.Add(flp_rendezoPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_Statisztika";
            Text = "Frm_Statisztika";
            Load += Frm_Statisztika_Load;
            Resize += Frm_Statisztika_Resize;
            szpl_utasokSzama.ResumeLayout(false);
            szpl_utasokSzama.PerformLayout();
            szpn_utazasokSzama.ResumeLayout(false);
            szpn_utazasokSzama.PerformLayout();
            szpn_atlagosUtazasokSzama.ResumeLayout(false);
            szpn_atlagosUtazasokSzama.PerformLayout();
            pnl_geopanel.ResumeLayout(false);
            flp_rendezoPanel.ResumeLayout(false);
            sznp_egyebStatisztika.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private egyeni_vezerlok.SzinatmenetPanel szpl_utasokSzama;
        private Label lbl_osszUtas;
        private egyeni_vezerlok.SzinatmenetPanel szpn_utazasokSzama;
        private Label lb_utazasokSzama;
        private egyeni_vezerlok.SzinatmenetPanel szpn_atlagosUtazasokSzama;
        private Label lbl_atlagosUtazasokSzama;
        private egyeni_vezerlok.SzinatmenetPanel szp_tendencia;
        private Panel pnl_geopanel;
       
        private FlowLayoutPanel flp_rendezoPanel;
        private egyeni_vezerlok.SzinatmenetPanel szpn_penzugyiJelentes;
        private egyeni_vezerlok.SzinatmenetPanel sznp_egyebStatisztika;
        private FlowLayoutPanel flp_egyebStatisztika;
    }
}