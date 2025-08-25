namespace Projekt_feladat.Formok
{
    partial class frm_ertesitesek
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
            flp_rendezoPanel = new FlowLayoutPanel();
            pl_terkezelo = new Panel();
            szp_utazasNeve = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            szp_utazasAdatok = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            flp_rendezoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flp_rendezoPanel
            // 
            flp_rendezoPanel.AutoScroll = true;
            flp_rendezoPanel.AutoSize = true;
            flp_rendezoPanel.BackColor = Color.FromArgb(50, 70, 90);
            flp_rendezoPanel.Controls.Add(pl_terkezelo);
            flp_rendezoPanel.Controls.Add(szp_utazasNeve);
            flp_rendezoPanel.Controls.Add(szp_utazasAdatok);
            flp_rendezoPanel.Dock = DockStyle.Fill;
            flp_rendezoPanel.FlowDirection = FlowDirection.TopDown;
            flp_rendezoPanel.Location = new Point(0, 0);
            flp_rendezoPanel.Margin = new Padding(0);
            flp_rendezoPanel.Name = "flp_rendezoPanel";
            flp_rendezoPanel.Size = new Size(991, 795);
            flp_rendezoPanel.TabIndex = 21;
            flp_rendezoPanel.WrapContents = false;
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
            // szp_utazasNeve
            // 
            szp_utazasNeve.BackColor = Color.Transparent;
            szp_utazasNeve.Dock = DockStyle.Fill;
            szp_utazasNeve.ForeColor = Color.Black;
            szp_utazasNeve.KeretSzin = Color.Black;
            szp_utazasNeve.KeretVastagsag = 0F;
            szp_utazasNeve.Location = new Point(20, 35);
            szp_utazasNeve.Margin = new Padding(20, 23, 60, 20);
            szp_utazasNeve.Name = "szp_utazasNeve";
            szp_utazasNeve.Padding = new Padding(9);
            szp_utazasNeve.SarkokLekerekitese = 20;
            szp_utazasNeve.Size = new Size(757, 500);
            szp_utazasNeve.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szp_utazasNeve.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szp_utazasNeve.SzinatmenetSzog = 90F;
            szp_utazasNeve.TabIndex = 7;
            // 
            // szp_utazasAdatok
            // 
            szp_utazasAdatok.BackColor = Color.Transparent;
            szp_utazasAdatok.Dock = DockStyle.Top;
            szp_utazasAdatok.ForeColor = Color.Black;
            szp_utazasAdatok.KeretSzin = Color.Black;
            szp_utazasAdatok.KeretVastagsag = 0F;
            szp_utazasAdatok.Location = new Point(20, 578);
            szp_utazasAdatok.Margin = new Padding(20, 23, 60, 34);
            szp_utazasAdatok.Name = "szp_utazasAdatok";
            szp_utazasAdatok.Padding = new Padding(9);
            szp_utazasAdatok.SarkokLekerekitese = 20;
            szp_utazasAdatok.Size = new Size(757, 500);
            szp_utazasAdatok.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szp_utazasAdatok.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szp_utazasAdatok.SzinatmenetSzog = 90F;
            szp_utazasAdatok.TabIndex = 9;
            // 
            // frm_ertesitesek
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 795);
            Controls.Add(flp_rendezoPanel);
            Name = "frm_ertesitesek";
            Text = "frm_ertesitesek";
            flp_rendezoPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp_rendezoPanel;
        private Panel pl_terkezelo;
        private egyeni_vezerlok.SzinatmenetPanel szp_utazasNeve;
        private egyeni_vezerlok.SzinatmenetPanel szp_utazasAdatok;
    }
}