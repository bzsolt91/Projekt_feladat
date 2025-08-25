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
            tableLayoutPanel1 = new DoubleBufferedTableLayoutPanel();
            blbl_ertesitesek = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            szp_utazasAdatok = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            szinatmenetPanel1 = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            btlp_okmanyLejaratok = new TableLayoutPanel();
            blbl_okmanyLejaratok = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            btlp_elofoglalasok = new TableLayoutPanel();
            blbl_elofoglalasok = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            flp_rendezoPanel.SuspendLayout();
            szp_utazasNeve.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            szp_utazasAdatok.SuspendLayout();
            szinatmenetPanel1.SuspendLayout();
            btlp_okmanyLejaratok.SuspendLayout();
            btlp_elofoglalasok.SuspendLayout();
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
            flp_rendezoPanel.Controls.Add(szinatmenetPanel1);
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
            szp_utazasNeve.Controls.Add(tableLayoutPanel1);
            szp_utazasNeve.Dock = DockStyle.Fill;
            szp_utazasNeve.ForeColor = Color.Black;
            szp_utazasNeve.KeretSzin = Color.Black;
            szp_utazasNeve.KeretVastagsag = 0F;
            szp_utazasNeve.Location = new Point(20, 32);
            szp_utazasNeve.Margin = new Padding(20, 20, 20, 40);
            szp_utazasNeve.Name = "szp_utazasNeve";
            szp_utazasNeve.Padding = new Padding(9);
            szp_utazasNeve.SarkokLekerekitese = 20;
            szp_utazasNeve.Size = new Size(797, 50);
            szp_utazasNeve.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szp_utazasNeve.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szp_utazasNeve.SzinatmenetSzog = 90F;
            szp_utazasNeve.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(blbl_ertesitesek, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(9, 9);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(779, 32);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // blbl_ertesitesek
            // 
            blbl_ertesitesek.AutoSize = true;
            blbl_ertesitesek.Dock = DockStyle.Fill;
            blbl_ertesitesek.Font = new Font("Segoe UI", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 238);
            blbl_ertesitesek.Location = new Point(3, 0);
            blbl_ertesitesek.Name = "blbl_ertesitesek";
            blbl_ertesitesek.Size = new Size(773, 32);
            blbl_ertesitesek.TabIndex = 3;
            blbl_ertesitesek.Text = "Értesítések";
            blbl_ertesitesek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // szp_utazasAdatok
            // 
            szp_utazasAdatok.BackColor = Color.Transparent;
            szp_utazasAdatok.Controls.Add(btlp_okmanyLejaratok);
            szp_utazasAdatok.Dock = DockStyle.Top;
            szp_utazasAdatok.ForeColor = Color.Black;
            szp_utazasAdatok.KeretSzin = Color.Black;
            szp_utazasAdatok.KeretVastagsag = 0F;
            szp_utazasAdatok.Location = new Point(20, 145);
            szp_utazasAdatok.Margin = new Padding(20, 23, 20, 34);
            szp_utazasAdatok.Name = "szp_utazasAdatok";
            szp_utazasAdatok.Padding = new Padding(9);
            szp_utazasAdatok.SarkokLekerekitese = 20;
            szp_utazasAdatok.Size = new Size(797, 500);
            szp_utazasAdatok.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szp_utazasAdatok.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szp_utazasAdatok.SzinatmenetSzog = 90F;
            szp_utazasAdatok.TabIndex = 9;
            // 
            // szinatmenetPanel1
            // 
            szinatmenetPanel1.BackColor = Color.Transparent;
            szinatmenetPanel1.Controls.Add(btlp_elofoglalasok);
            szinatmenetPanel1.Dock = DockStyle.Top;
            szinatmenetPanel1.ForeColor = Color.Black;
            szinatmenetPanel1.KeretSzin = Color.Black;
            szinatmenetPanel1.KeretVastagsag = 0F;
            szinatmenetPanel1.Location = new Point(20, 702);
            szinatmenetPanel1.Margin = new Padding(20, 23, 20, 34);
            szinatmenetPanel1.Name = "szinatmenetPanel1";
            szinatmenetPanel1.Padding = new Padding(9);
            szinatmenetPanel1.SarkokLekerekitese = 20;
            szinatmenetPanel1.Size = new Size(797, 500);
            szinatmenetPanel1.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szinatmenetPanel1.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szinatmenetPanel1.SzinatmenetSzog = 90F;
            szinatmenetPanel1.TabIndex = 10;
            // 
            // btlp_okmanyLejaratok
            // 
            btlp_okmanyLejaratok.ColumnCount = 1;
            btlp_okmanyLejaratok.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            btlp_okmanyLejaratok.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            btlp_okmanyLejaratok.Controls.Add(blbl_okmanyLejaratok, 0, 0);
            btlp_okmanyLejaratok.Dock = DockStyle.Top;
            btlp_okmanyLejaratok.Location = new Point(9, 9);
            btlp_okmanyLejaratok.Name = "btlp_okmanyLejaratok";
            btlp_okmanyLejaratok.RowCount = 1;
            btlp_okmanyLejaratok.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            btlp_okmanyLejaratok.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            btlp_okmanyLejaratok.Size = new Size(779, 32);
            btlp_okmanyLejaratok.TabIndex = 0;
            // 
            // blbl_okmanyLejaratok
            // 
            blbl_okmanyLejaratok.AutoSize = true;
            blbl_okmanyLejaratok.Dock = DockStyle.Left;
            blbl_okmanyLejaratok.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 238);
            blbl_okmanyLejaratok.ImageAlign = ContentAlignment.MiddleLeft;
            blbl_okmanyLejaratok.Location = new Point(3, 0);
            blbl_okmanyLejaratok.Name = "blbl_okmanyLejaratok";
            blbl_okmanyLejaratok.Size = new Size(125, 32);
            blbl_okmanyLejaratok.TabIndex = 4;
            blbl_okmanyLejaratok.Text = "Okmány lejáratok";
            blbl_okmanyLejaratok.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btlp_elofoglalasok
            // 
            btlp_elofoglalasok.ColumnCount = 1;
            btlp_elofoglalasok.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            btlp_elofoglalasok.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            btlp_elofoglalasok.Controls.Add(blbl_elofoglalasok, 0, 0);
            btlp_elofoglalasok.Dock = DockStyle.Top;
            btlp_elofoglalasok.Location = new Point(9, 9);
            btlp_elofoglalasok.Name = "btlp_elofoglalasok";
            btlp_elofoglalasok.RowCount = 1;
            btlp_elofoglalasok.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            btlp_elofoglalasok.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            btlp_elofoglalasok.Size = new Size(779, 32);
            btlp_elofoglalasok.TabIndex = 1;
            // 
            // blbl_elofoglalasok
            // 
            blbl_elofoglalasok.AutoSize = true;
            blbl_elofoglalasok.Dock = DockStyle.Left;
            blbl_elofoglalasok.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 238);
            blbl_elofoglalasok.ImageAlign = ContentAlignment.MiddleLeft;
            blbl_elofoglalasok.Location = new Point(3, 0);
            blbl_elofoglalasok.Name = "blbl_elofoglalasok";
            blbl_elofoglalasok.Size = new Size(99, 32);
            blbl_elofoglalasok.TabIndex = 4;
            blbl_elofoglalasok.Text = "Előfoglalások";
            blbl_elofoglalasok.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frm_ertesitesek
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 795);
            Controls.Add(flp_rendezoPanel);
            Name = "frm_ertesitesek";
            Text = "frm_ertesitesek";
            Load += frm_ertesitesek_Load;
            Resize += frm_ertesitesek_Resize;
            flp_rendezoPanel.ResumeLayout(false);
            szp_utazasNeve.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            szp_utazasAdatok.ResumeLayout(false);
            szinatmenetPanel1.ResumeLayout(false);
            btlp_okmanyLejaratok.ResumeLayout(false);
            btlp_okmanyLejaratok.PerformLayout();
            btlp_elofoglalasok.ResumeLayout(false);
            btlp_elofoglalasok.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp_rendezoPanel;
        private Panel pl_terkezelo;
        private egyeni_vezerlok.SzinatmenetPanel szp_utazasNeve;
        private egyeni_vezerlok.SzinatmenetPanel szp_utazasAdatok;
        private egyeni_vezerlok.SzinatmenetPanel szinatmenetPanel1;
        private DoubleBufferedTableLayoutPanel tableLayoutPanel1;
        private egyeni_vezerlok.BufferedLabel blbl_ertesitesek;
        private TableLayoutPanel btlp_okmanyLejaratok;
        private egyeni_vezerlok.BufferedLabel blbl_okmanyLejaratok;
        private TableLayoutPanel btlp_elofoglalasok;
        private egyeni_vezerlok.BufferedLabel blbl_elofoglalasok;
    }
}