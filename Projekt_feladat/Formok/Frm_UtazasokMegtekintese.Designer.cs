using Projekt_feladat.egyeni_vezerlok;

namespace Projekt_feladat.Formok
{
    partial class Frm_UtazasokMegtekintese
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UtazasokMegtekintese));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            rcb_desztinacio = new kerekitettLenyilloMenu();
            rcb_idoszak = new kerekitettLenyilloMenu();
            dgv_utazasok = new DataGridView();
            rcb_utazasNeve = new kerekitettLenyilloMenu();
            pnl_vezerlok = new SzinatmenetPanel();
            kerekitettGomb5 = new KerekitettGomb();
            kerekitettGomb4 = new KerekitettGomb();
            kerekitettGomb3 = new KerekitettGomb();
            btn_mentes = new KerekitettGomb();
            ((System.ComponentModel.ISupportInitialize)dgv_utazasok).BeginInit();
            pnl_vezerlok.SuspendLayout();
            SuspendLayout();
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
            rcb_desztinacio.Location = new Point(9, 9);
            rcb_desztinacio.Margin = new Padding(0);
            rcb_desztinacio.MinimumSize = new Size(150, 0);
            rcb_desztinacio.Name = "rcb_desztinacio";
            rcb_desztinacio.Padding = new Padding(0, 0, 0, 5);
            rcb_desztinacio.Radius = 20;
            rcb_desztinacio.Size = new Size(262, 57);
            rcb_desztinacio.TabIndex = 7;
            rcb_desztinacio.TitleLabelSzin = Color.Black;
            rcb_desztinacio.Load += roundedComboBox2_Load;
            // 
            // rcb_idoszak
            // 
            rcb_idoszak.BackColor = Color.Transparent;
            rcb_idoszak.CimPanelAlsoSzin = Color.White;
            rcb_idoszak.CimPanelFelsoSzin = Color.White;
            rcb_idoszak.ComboText = "Időszak";
            rcb_idoszak.ForeColor = Color.Black;
            rcb_idoszak.Ikon = (Image)resources.GetObject("rcb_idoszak.Ikon");
            rcb_idoszak.ImeMode = ImeMode.Alpha;
            rcb_idoszak.ItemPanelAlosSzin = Color.WhiteSmoke;
            rcb_idoszak.ItemPanelFelsoSzin = Color.WhiteSmoke;
            rcb_idoszak.KeretSzin = Color.BlueViolet;
            rcb_idoszak.KeretVastagsag = 1.8F;
            rcb_idoszak.Location = new Point(293, 9);
            rcb_idoszak.Margin = new Padding(0);
            rcb_idoszak.MinimumSize = new Size(150, 0);
            rcb_idoszak.Name = "rcb_idoszak";
            rcb_idoszak.Padding = new Padding(0, 0, 0, 5);
            rcb_idoszak.Radius = 20;
            rcb_idoszak.Size = new Size(288, 55);
            rcb_idoszak.TabIndex = 6;
            rcb_idoszak.TitleLabelSzin = Color.Black;
            rcb_idoszak.Load += roundedComboBox1_Load;
            // 
            // dgv_utazasok
            // 
            dgv_utazasok.AllowUserToAddRows = false;
            dgv_utazasok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_utazasok.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_utazasok.BackgroundColor = SystemColors.ControlLightLight;
            dgv_utazasok.BorderStyle = BorderStyle.None;
            dgv_utazasok.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgv_utazasok.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_utazasok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_utazasok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = Color.BlueViolet;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_utazasok.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_utazasok.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv_utazasok.EnableHeadersVisualStyles = false;
            dgv_utazasok.GridColor = SystemColors.InactiveBorder;
            dgv_utazasok.Location = new Point(9, 69);
            dgv_utazasok.Name = "dgv_utazasok";
            dgv_utazasok.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_utazasok.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_utazasok.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv_utazasok.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_utazasok.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgv_utazasok.ShowEditingIcon = false;
            dgv_utazasok.ShowRowErrors = false;
            dgv_utazasok.Size = new Size(940, 479);
            dgv_utazasok.TabIndex = 9;
            dgv_utazasok.CellMouseEnter += dataGridView1_CellMouseEnter;
            dgv_utazasok.CellValueChanged += dgv_utazasok_CellValueChanged;
            dgv_utazasok.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // rcb_utazasNeve
            // 
            rcb_utazasNeve.BackColor = Color.Transparent;
            rcb_utazasNeve.CimPanelAlsoSzin = Color.White;
            rcb_utazasNeve.CimPanelFelsoSzin = Color.White;
            rcb_utazasNeve.ComboText = "Utazás neve";
            rcb_utazasNeve.ForeColor = Color.White;
            rcb_utazasNeve.Ikon = (Image)resources.GetObject("rcb_utazasNeve.Ikon");
            rcb_utazasNeve.ItemPanelAlosSzin = Color.WhiteSmoke;
            rcb_utazasNeve.ItemPanelFelsoSzin = Color.WhiteSmoke;
            rcb_utazasNeve.KeretSzin = Color.BlueViolet;
            rcb_utazasNeve.KeretVastagsag = 1.8F;
            rcb_utazasNeve.Location = new Point(595, 7);
            rcb_utazasNeve.Margin = new Padding(0);
            rcb_utazasNeve.MinimumSize = new Size(150, 0);
            rcb_utazasNeve.Name = "rcb_utazasNeve";
            rcb_utazasNeve.Radius = 20;
            rcb_utazasNeve.Size = new Size(286, 57);
            rcb_utazasNeve.TabIndex = 8;
            rcb_utazasNeve.TitleLabelSzin = Color.Black;
            rcb_utazasNeve.Load += roundedComboBox3_Load;
            // 
            // pnl_vezerlok
            // 
            pnl_vezerlok.BackColor = Color.Transparent;
            pnl_vezerlok.Controls.Add(kerekitettGomb5);
            pnl_vezerlok.Controls.Add(kerekitettGomb4);
            pnl_vezerlok.Controls.Add(kerekitettGomb3);
            pnl_vezerlok.Controls.Add(btn_mentes);
            pnl_vezerlok.Dock = DockStyle.Bottom;
            pnl_vezerlok.ForeColor = Color.CadetBlue;
            pnl_vezerlok.KeretSzin = Color.Black;
            pnl_vezerlok.KeretVastagsag = 0F;
            pnl_vezerlok.Location = new Point(0, 677);
            pnl_vezerlok.Margin = new Padding(3, 2, 3, 2);
            pnl_vezerlok.Name = "pnl_vezerlok";
            pnl_vezerlok.SarkokLekerekitese = 15;
            pnl_vezerlok.Size = new Size(999, 52);
            pnl_vezerlok.SzinatmenetAlsoSzine = Color.DarkViolet;
            pnl_vezerlok.SzinatmenetFelsoSzine = Color.DarkViolet;
            pnl_vezerlok.SzinatmenetSzog = 90F;
            pnl_vezerlok.TabIndex = 10;
            // 
            // kerekitettGomb5
            // 
            kerekitettGomb5.BackColor = Color.MediumSlateBlue;
            kerekitettGomb5.EgerTartasHatterSzine = Color.SlateBlue;
            kerekitettGomb5.FlatAppearance.BorderSize = 0;
            kerekitettGomb5.FlatStyle = FlatStyle.Flat;
            kerekitettGomb5.Font = new Font("Segoe UI", 12F);
            kerekitettGomb5.ForeColor = Color.White;
            kerekitettGomb5.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb5.Image = (Image)resources.GetObject("kerekitettGomb5.Image");
            kerekitettGomb5.ImageAlign = ContentAlignment.MiddleLeft;
            kerekitettGomb5.KeretMeret = 0;
            kerekitettGomb5.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb5.Location = new Point(631, 8);
            kerekitettGomb5.Margin = new Padding(3, 2, 3, 2);
            kerekitettGomb5.Name = "kerekitettGomb5";
            kerekitettGomb5.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb5.SarokSugar = 10;
            kerekitettGomb5.Size = new Size(164, 38);
            kerekitettGomb5.SzovegSzine = Color.White;
            kerekitettGomb5.TabIndex = 3;
            kerekitettGomb5.Text = "Nyomtatás";
            kerekitettGomb5.UseVisualStyleBackColor = false;
            // 
            // kerekitettGomb4
            // 
            kerekitettGomb4.BackColor = Color.MediumSlateBlue;
            kerekitettGomb4.EgerTartasHatterSzine = Color.SlateBlue;
            kerekitettGomb4.FlatAppearance.BorderSize = 0;
            kerekitettGomb4.FlatStyle = FlatStyle.Flat;
            kerekitettGomb4.Font = new Font("Segoe UI", 12F);
            kerekitettGomb4.ForeColor = Color.White;
            kerekitettGomb4.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb4.Image = (Image)resources.GetObject("kerekitettGomb4.Image");
            kerekitettGomb4.ImageAlign = ContentAlignment.MiddleLeft;
            kerekitettGomb4.KeretMeret = 0;
            kerekitettGomb4.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb4.Location = new Point(410, 8);
            kerekitettGomb4.Margin = new Padding(3, 2, 3, 2);
            kerekitettGomb4.Name = "kerekitettGomb4";
            kerekitettGomb4.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb4.SarokSugar = 10;
            kerekitettGomb4.Size = new Size(201, 38);
            kerekitettGomb4.SzovegSzine = Color.White;
            kerekitettGomb4.TabIndex = 2;
            kerekitettGomb4.Text = "Exportálás Excelbe";
            kerekitettGomb4.UseVisualStyleBackColor = false;
            // 
            // kerekitettGomb3
            // 
            kerekitettGomb3.BackColor = Color.MediumSlateBlue;
            kerekitettGomb3.EgerTartasHatterSzine = Color.SlateBlue;
            kerekitettGomb3.FlatAppearance.BorderSize = 0;
            kerekitettGomb3.FlatStyle = FlatStyle.Flat;
            kerekitettGomb3.Font = new Font("Segoe UI", 12F);
            kerekitettGomb3.ForeColor = Color.White;
            kerekitettGomb3.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb3.Image = (Image)resources.GetObject("kerekitettGomb3.Image");
            kerekitettGomb3.ImageAlign = ContentAlignment.MiddleLeft;
            kerekitettGomb3.KeretMeret = 0;
            kerekitettGomb3.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb3.Location = new Point(202, 8);
            kerekitettGomb3.Margin = new Padding(3, 2, 3, 2);
            kerekitettGomb3.Name = "kerekitettGomb3";
            kerekitettGomb3.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb3.SarokSugar = 10;
            kerekitettGomb3.Size = new Size(189, 38);
            kerekitettGomb3.SzovegSzine = Color.White;
            kerekitettGomb3.TabIndex = 1;
            kerekitettGomb3.Text = "Utaslista készítése";
            kerekitettGomb3.UseVisualStyleBackColor = false;
            // 
            // btn_mentes
            // 
            btn_mentes.BackColor = Color.MediumSlateBlue;
            btn_mentes.EgerTartasHatterSzine = Color.SlateBlue;
            btn_mentes.FlatAppearance.BorderSize = 0;
            btn_mentes.FlatStyle = FlatStyle.Flat;
            btn_mentes.Font = new Font("Segoe UI", 12F);
            btn_mentes.ForeColor = Color.White;
            btn_mentes.HatterSzine = Color.MediumSlateBlue;
            btn_mentes.Image = (Image)resources.GetObject("btn_mentes.Image");
            btn_mentes.ImageAlign = ContentAlignment.MiddleRight;
            btn_mentes.KeretMeret = 0;
            btn_mentes.KeretSzine = Color.MediumVioletRed;
            btn_mentes.Location = new Point(19, 8);
            btn_mentes.Margin = new Padding(3, 2, 3, 2);
            btn_mentes.Name = "btn_mentes";
            btn_mentes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_mentes.RightToLeft = RightToLeft.No;
            btn_mentes.SarokSugar = 10;
            btn_mentes.Size = new Size(164, 38);
            btn_mentes.SzovegSzine = Color.White;
            btn_mentes.TabIndex = 0;
            btn_mentes.Text = "Mentés";
            btn_mentes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_mentes.UseVisualStyleBackColor = false;
            // 
            // Frm_UtazasokMegtekintese
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(999, 729);
            Controls.Add(pnl_vezerlok);
            Controls.Add(rcb_idoszak);
            Controls.Add(rcb_desztinacio);
            Controls.Add(dgv_utazasok);
            Controls.Add(rcb_utazasNeve);
            Name = "Frm_UtazasokMegtekintese";
            Text = "Utazasok";
            Load += Frm_UtazasokMegtekintese_Load_1;
            Resize += Frm_UtazasokMegtekintese_Resize;
            ((System.ComponentModel.ISupportInitialize)dgv_utazasok).EndInit();
            pnl_vezerlok.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Frm_UtazasokMegtekintese_Load_1(object sender, EventArgs e)
        {
            dgv_utazasok.SendToBack();
            vizualisrendezes();


        }

        #endregion

        private kerekitettLenyilloMenu rcb_desztinacio;
        private kerekitettLenyilloMenu rcb_idoszak;
        private DataGridView dgv_utazasok;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private KerekitettGomb kerekitettGomb1;
        private kerekitettLenyilloMenu rcb_utazasNeve;
        private SzinatmenetPanel pnl_vezerlok;
        private KerekitettGomb kerekitettGomb5;
        private KerekitettGomb kerekitettGomb4;
        private KerekitettGomb kerekitettGomb3;
        private KerekitettGomb btn_mentes;
    }
}