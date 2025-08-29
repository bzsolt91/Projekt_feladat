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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            flp_rendezoPanel = new FlowLayoutPanel();
            pl_terkezelo = new Panel();
            szp_ertesitesek = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            tlp_ertesitesek = new DoubleBufferedTableLayoutPanel();
            blbl_ertesitesek = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            szp_okmanyLejaratok = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            dgv_okmanyLejaratok = new Projekt_feladat.egyeni_vezerlok.DoubleBufferedDataGridView();
            btlp_okmanyLejaratok = new DoubleBufferedTableLayoutPanel();
            blbl_okmanyLejaratok = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            szp_elofoglalasok = new Projekt_feladat.egyeni_vezerlok.SzinatmenetPanel();
            dgv_elofoglalasok = new Projekt_feladat.egyeni_vezerlok.DoubleBufferedDataGridView();
            btlp_elofoglalasok = new DoubleBufferedTableLayoutPanel();
            blbl_elofoglalasok = new Projekt_feladat.egyeni_vezerlok.BufferedLabel();
            flp_rendezoPanel.SuspendLayout();
            szp_ertesitesek.SuspendLayout();
            tlp_ertesitesek.SuspendLayout();
            szp_okmanyLejaratok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_okmanyLejaratok).BeginInit();
            btlp_okmanyLejaratok.SuspendLayout();
            szp_elofoglalasok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_elofoglalasok).BeginInit();
            btlp_elofoglalasok.SuspendLayout();
            SuspendLayout();
            // 
            // flp_rendezoPanel
            // 
            flp_rendezoPanel.AutoScroll = true;
            flp_rendezoPanel.AutoSize = true;
            flp_rendezoPanel.BackColor = Color.FromArgb(50, 70, 90);
            flp_rendezoPanel.Controls.Add(pl_terkezelo);
            flp_rendezoPanel.Controls.Add(szp_ertesitesek);
            flp_rendezoPanel.Controls.Add(szp_okmanyLejaratok);
            flp_rendezoPanel.Controls.Add(szp_elofoglalasok);
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
            // szp_ertesitesek
            // 
            szp_ertesitesek.BackColor = Color.Transparent;
            szp_ertesitesek.Controls.Add(tlp_ertesitesek);
            szp_ertesitesek.Dock = DockStyle.Fill;
            szp_ertesitesek.ForeColor = Color.Black;
            szp_ertesitesek.KeretSzin = Color.Black;
            szp_ertesitesek.KeretVastagsag = 0F;
            szp_ertesitesek.Location = new Point(40, 32);
            szp_ertesitesek.Margin = new Padding(40, 20, 40, 40);
            szp_ertesitesek.Name = "szp_ertesitesek";
            szp_ertesitesek.Padding = new Padding(9);
            szp_ertesitesek.SarkokLekerekitese = 20;
            szp_ertesitesek.Size = new Size(757, 50);
            szp_ertesitesek.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szp_ertesitesek.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szp_ertesitesek.SzinatmenetSzog = 90F;
            szp_ertesitesek.TabIndex = 7;
            // 
            // tlp_ertesitesek
            // 
            tlp_ertesitesek.ColumnCount = 1;
            tlp_ertesitesek.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_ertesitesek.Controls.Add(blbl_ertesitesek, 0, 0);
            tlp_ertesitesek.Dock = DockStyle.Fill;
            tlp_ertesitesek.Location = new Point(9, 9);
            tlp_ertesitesek.Name = "tlp_ertesitesek";
            tlp_ertesitesek.RowCount = 1;
            tlp_ertesitesek.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_ertesitesek.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_ertesitesek.Size = new Size(739, 32);
            tlp_ertesitesek.TabIndex = 0;
            // 
            // blbl_ertesitesek
            // 
            blbl_ertesitesek.AutoSize = true;
            blbl_ertesitesek.Dock = DockStyle.Fill;
            blbl_ertesitesek.Font = new Font("Segoe UI", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 238);
            blbl_ertesitesek.Location = new Point(3, 0);
            blbl_ertesitesek.Name = "blbl_ertesitesek";
            blbl_ertesitesek.Size = new Size(733, 32);
            blbl_ertesitesek.TabIndex = 3;
            blbl_ertesitesek.Text = "Értesítések";
            blbl_ertesitesek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // szp_okmanyLejaratok
            // 
            szp_okmanyLejaratok.BackColor = Color.Transparent;
            szp_okmanyLejaratok.Controls.Add(dgv_okmanyLejaratok);
            szp_okmanyLejaratok.Controls.Add(btlp_okmanyLejaratok);
            szp_okmanyLejaratok.Dock = DockStyle.Top;
            szp_okmanyLejaratok.ForeColor = Color.Black;
            szp_okmanyLejaratok.KeretSzin = Color.Black;
            szp_okmanyLejaratok.KeretVastagsag = 0F;
            szp_okmanyLejaratok.Location = new Point(40, 145);
            szp_okmanyLejaratok.Margin = new Padding(40, 23, 40, 34);
            szp_okmanyLejaratok.Name = "szp_okmanyLejaratok";
            szp_okmanyLejaratok.Padding = new Padding(9);
            szp_okmanyLejaratok.SarkokLekerekitese = 20;
            szp_okmanyLejaratok.Size = new Size(757, 500);
            szp_okmanyLejaratok.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szp_okmanyLejaratok.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szp_okmanyLejaratok.SzinatmenetSzog = 90F;
            szp_okmanyLejaratok.TabIndex = 9;
            // 
            // dgv_okmanyLejaratok
            // 
            dgv_okmanyLejaratok.AllowUserToAddRows = false;
            dgv_okmanyLejaratok.AllowUserToResizeRows = false;
            dgv_okmanyLejaratok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_okmanyLejaratok.BackgroundColor = Color.WhiteSmoke;
            dgv_okmanyLejaratok.BorderStyle = BorderStyle.None;
            dgv_okmanyLejaratok.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_okmanyLejaratok.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_okmanyLejaratok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_okmanyLejaratok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = Color.BlueViolet;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_okmanyLejaratok.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_okmanyLejaratok.Dock = DockStyle.Fill;
            dgv_okmanyLejaratok.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv_okmanyLejaratok.EnableHeadersVisualStyles = false;
            dgv_okmanyLejaratok.GridColor = Color.WhiteSmoke;
            dgv_okmanyLejaratok.Location = new Point(9, 41);
            dgv_okmanyLejaratok.MultiSelect = false;
            dgv_okmanyLejaratok.Name = "dgv_okmanyLejaratok";
            dgv_okmanyLejaratok.ReadOnly = true;
            dgv_okmanyLejaratok.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_okmanyLejaratok.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_okmanyLejaratok.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv_okmanyLejaratok.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_okmanyLejaratok.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_okmanyLejaratok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_okmanyLejaratok.ShowEditingIcon = false;
            dgv_okmanyLejaratok.ShowRowErrors = false;
            dgv_okmanyLejaratok.Size = new Size(739, 450);
            dgv_okmanyLejaratok.TabIndex = 9;
            dgv_okmanyLejaratok.CellMouseEnter += dgv_okmanyLejaratok_CellMouseEnter;
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
            btlp_okmanyLejaratok.Size = new Size(739, 32);
            btlp_okmanyLejaratok.TabIndex = 0;
            // 
            // blbl_okmanyLejaratok
            // 
            blbl_okmanyLejaratok.AutoSize = true;
            blbl_okmanyLejaratok.Dock = DockStyle.Left;
            blbl_okmanyLejaratok.Font = new Font("Segoe UI", 12.2264156F);
            blbl_okmanyLejaratok.ImageAlign = ContentAlignment.MiddleLeft;
            blbl_okmanyLejaratok.Location = new Point(3, 0);
            blbl_okmanyLejaratok.Name = "blbl_okmanyLejaratok";
            blbl_okmanyLejaratok.Size = new Size(151, 32);
            blbl_okmanyLejaratok.TabIndex = 4;
            blbl_okmanyLejaratok.Text = "Okmány lejáratok";
            blbl_okmanyLejaratok.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // szp_elofoglalasok
            // 
            szp_elofoglalasok.BackColor = Color.Transparent;
            szp_elofoglalasok.Controls.Add(dgv_elofoglalasok);
            szp_elofoglalasok.Controls.Add(btlp_elofoglalasok);
            szp_elofoglalasok.Dock = DockStyle.Top;
            szp_elofoglalasok.ForeColor = Color.Black;
            szp_elofoglalasok.KeretSzin = Color.Black;
            szp_elofoglalasok.KeretVastagsag = 0F;
            szp_elofoglalasok.Location = new Point(40, 702);
            szp_elofoglalasok.Margin = new Padding(40, 23, 40, 34);
            szp_elofoglalasok.Name = "szp_elofoglalasok";
            szp_elofoglalasok.Padding = new Padding(9);
            szp_elofoglalasok.SarkokLekerekitese = 20;
            szp_elofoglalasok.Size = new Size(757, 500);
            szp_elofoglalasok.SzinatmenetAlsoSzine = Color.WhiteSmoke;
            szp_elofoglalasok.SzinatmenetFelsoSzine = Color.WhiteSmoke;
            szp_elofoglalasok.SzinatmenetSzog = 90F;
            szp_elofoglalasok.TabIndex = 10;
            // 
            // dgv_elofoglalasok
            // 
            dgv_elofoglalasok.AllowUserToAddRows = false;
            dgv_elofoglalasok.AllowUserToResizeRows = false;
            dgv_elofoglalasok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_elofoglalasok.BackgroundColor = Color.WhiteSmoke;
            dgv_elofoglalasok.BorderStyle = BorderStyle.None;
            dgv_elofoglalasok.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_elofoglalasok.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_elofoglalasok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_elofoglalasok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.Padding = new Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle5.SelectionForeColor = Color.BlueViolet;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_elofoglalasok.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_elofoglalasok.Dock = DockStyle.Fill;
            dgv_elofoglalasok.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv_elofoglalasok.EnableHeadersVisualStyles = false;
            dgv_elofoglalasok.GridColor = SystemColors.InactiveBorder;
            dgv_elofoglalasok.Location = new Point(9, 41);
            dgv_elofoglalasok.MultiSelect = false;
            dgv_elofoglalasok.Name = "dgv_elofoglalasok";
            dgv_elofoglalasok.ReadOnly = true;
            dgv_elofoglalasok.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_elofoglalasok.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_elofoglalasok.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv_elofoglalasok.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv_elofoglalasok.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_elofoglalasok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_elofoglalasok.ShowEditingIcon = false;
            dgv_elofoglalasok.ShowRowErrors = false;
            dgv_elofoglalasok.Size = new Size(739, 450);
            dgv_elofoglalasok.TabIndex = 9;
            dgv_elofoglalasok.CellMouseEnter += dgv_okmanyLejaratok_CellMouseEnter;
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
            btlp_elofoglalasok.Size = new Size(739, 32);
            btlp_elofoglalasok.TabIndex = 1;
            // 
            // blbl_elofoglalasok
            // 
            blbl_elofoglalasok.AutoSize = true;
            blbl_elofoglalasok.Dock = DockStyle.Left;
            blbl_elofoglalasok.Font = new Font("Segoe UI", 12.2264156F);
            blbl_elofoglalasok.ImageAlign = ContentAlignment.MiddleLeft;
            blbl_elofoglalasok.Location = new Point(3, 0);
            blbl_elofoglalasok.Name = "blbl_elofoglalasok";
            blbl_elofoglalasok.Size = new Size(118, 32);
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
            szp_ertesitesek.ResumeLayout(false);
            tlp_ertesitesek.ResumeLayout(false);
            tlp_ertesitesek.PerformLayout();
            szp_okmanyLejaratok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_okmanyLejaratok).EndInit();
            btlp_okmanyLejaratok.ResumeLayout(false);
            btlp_okmanyLejaratok.PerformLayout();
            szp_elofoglalasok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_elofoglalasok).EndInit();
            btlp_elofoglalasok.ResumeLayout(false);
            btlp_elofoglalasok.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp_rendezoPanel;
        private Panel pl_terkezelo;
        private egyeni_vezerlok.SzinatmenetPanel szp_ertesitesek;
        private egyeni_vezerlok.SzinatmenetPanel szp_okmanyLejaratok;
        private egyeni_vezerlok.SzinatmenetPanel szp_elofoglalasok;
        private DoubleBufferedTableLayoutPanel tlp_ertesitesek;
        private egyeni_vezerlok.BufferedLabel blbl_ertesitesek;
        private DoubleBufferedTableLayoutPanel btlp_okmanyLejaratok;
        private egyeni_vezerlok.BufferedLabel blbl_okmanyLejaratok;
        private DoubleBufferedTableLayoutPanel btlp_elofoglalasok;
        private egyeni_vezerlok.BufferedLabel blbl_elofoglalasok;
        private egyeni_vezerlok.DoubleBufferedDataGridView dgv_okmanyLejaratok;
        private egyeni_vezerlok.DoubleBufferedDataGridView dgv_elofoglalasok;
    }
}