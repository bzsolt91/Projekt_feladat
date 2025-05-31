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
            roundedComboBox2 = new kerekitettLenyilloMenu();
            roundedComboBox1 = new kerekitettLenyilloMenu();
            dataGridView1 = new DataGridView();
            roundedComboBox3 = new kerekitettLenyilloMenu();
            pnl_vezerlok = new SzinatmenetPanel();
            kerekitettGomb5 = new KerekitettGomb();
            kerekitettGomb4 = new KerekitettGomb();
            kerekitettGomb3 = new KerekitettGomb();
            btn_mentes = new KerekitettGomb();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnl_vezerlok.SuspendLayout();
            SuspendLayout();
            // 
            // roundedComboBox2
            // 
            roundedComboBox2.adatForras = null;
            roundedComboBox2.BackColor = Color.Transparent;
            roundedComboBox2.CimPanelAlsoSzin = Color.White;
            roundedComboBox2.CimPanelFelsoSzin = Color.White;
            roundedComboBox2.ComboText = "Desztináció";
            roundedComboBox2.ForeColor = Color.White;
            roundedComboBox2.Ikon = (Image)resources.GetObject("roundedComboBox2.Ikon");
            roundedComboBox2.ItemPanelAlosSzin = Color.WhiteSmoke;
            roundedComboBox2.ItemPanelFelsoSzin = Color.WhiteSmoke;
            roundedComboBox2.KeretSzin = Color.BlueViolet;
            roundedComboBox2.KeretVastagsag = 1.8F;
            roundedComboBox2.Location = new Point(284, 40);
            roundedComboBox2.Margin = new Padding(0);
            roundedComboBox2.MinimumSize = new Size(150, 0);
            roundedComboBox2.Name = "roundedComboBox2";
            roundedComboBox2.Padding = new Padding(0, 0, 0, 5);
            roundedComboBox2.Radius = 20;
            roundedComboBox2.Size = new Size(262, 57);
            roundedComboBox2.TabIndex = 7;
            roundedComboBox2.TitleLabelSzin = Color.Black;
            roundedComboBox2.Load += roundedComboBox2_Load;
            // 
            // roundedComboBox1
            // 
            roundedComboBox1.adatForras = null;
            roundedComboBox1.BackColor = Color.Transparent;
            roundedComboBox1.CimPanelAlsoSzin = Color.White;
            roundedComboBox1.CimPanelFelsoSzin = Color.White;
            roundedComboBox1.ComboText = "Időszak";
            roundedComboBox1.ForeColor = Color.Black;
            roundedComboBox1.Ikon = (Image)resources.GetObject("roundedComboBox1.Ikon");
            roundedComboBox1.ImeMode = ImeMode.Alpha;
            roundedComboBox1.ItemPanelAlosSzin = Color.WhiteSmoke;
            roundedComboBox1.ItemPanelFelsoSzin = Color.WhiteSmoke;
            roundedComboBox1.KeretSzin = Color.BlueViolet;
            roundedComboBox1.KeretVastagsag = 1.8F;
            roundedComboBox1.Location = new Point(19, 40);
            roundedComboBox1.Margin = new Padding(0);
            roundedComboBox1.MinimumSize = new Size(150, 0);
            roundedComboBox1.Name = "roundedComboBox1";
            roundedComboBox1.Padding = new Padding(0, 0, 0, 5);
            roundedComboBox1.Radius = 20;
            roundedComboBox1.Size = new Size(248, 55);
            roundedComboBox1.TabIndex = 6;
            roundedComboBox1.TitleLabelSzin = Color.Black;
            roundedComboBox1.Load += roundedComboBox1_Load;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = Color.BlueViolet;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(19, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(940, 479);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // roundedComboBox3
            // 
            roundedComboBox3.adatForras = null;
            roundedComboBox3.BackColor = Color.Transparent;
            roundedComboBox3.CimPanelAlsoSzin = Color.White;
            roundedComboBox3.CimPanelFelsoSzin = Color.White;
            roundedComboBox3.ComboText = "Utazás neve";
            roundedComboBox3.ForeColor = Color.White;
            roundedComboBox3.Ikon = (Image)resources.GetObject("roundedComboBox3.Ikon");
            roundedComboBox3.ItemPanelAlosSzin = Color.WhiteSmoke;
            roundedComboBox3.ItemPanelFelsoSzin = Color.WhiteSmoke;
            roundedComboBox3.KeretSzin = Color.BlueViolet;
            roundedComboBox3.KeretVastagsag = 1.8F;
            roundedComboBox3.Location = new Point(565, 40);
            roundedComboBox3.Margin = new Padding(0);
            roundedComboBox3.MinimumSize = new Size(150, 0);
            roundedComboBox3.Name = "roundedComboBox3";
            roundedComboBox3.Radius = 20;
            roundedComboBox3.Size = new Size(276, 54);
            roundedComboBox3.TabIndex = 8;
            roundedComboBox3.TitleLabelSzin = Color.Black;
            roundedComboBox3.Load += roundedComboBox3_Load;
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
            pnl_vezerlok.SarkokLekerekitese = 20;
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
            kerekitettGomb5.ForeColor = Color.White;
            kerekitettGomb5.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb5.KeretMeret = 0;
            kerekitettGomb5.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb5.Location = new Point(607, 8);
            kerekitettGomb5.Margin = new Padding(3, 2, 3, 2);
            kerekitettGomb5.Name = "kerekitettGomb5";
            kerekitettGomb5.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb5.SarokSugar = 0;
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
            kerekitettGomb4.ForeColor = Color.White;
            kerekitettGomb4.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb4.KeretMeret = 0;
            kerekitettGomb4.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb4.Location = new Point(417, 8);
            kerekitettGomb4.Margin = new Padding(3, 2, 3, 2);
            kerekitettGomb4.Name = "kerekitettGomb4";
            kerekitettGomb4.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb4.SarokSugar = 0;
            kerekitettGomb4.Size = new Size(164, 38);
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
            kerekitettGomb3.ForeColor = Color.White;
            kerekitettGomb3.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb3.KeretMeret = 0;
            kerekitettGomb3.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb3.Location = new Point(216, 8);
            kerekitettGomb3.Margin = new Padding(3, 2, 3, 2);
            kerekitettGomb3.Name = "kerekitettGomb3";
            kerekitettGomb3.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb3.SarokSugar = 0;
            kerekitettGomb3.Size = new Size(164, 38);
            kerekitettGomb3.SzovegSzine = Color.White;
            kerekitettGomb3.TabIndex = 1;
            kerekitettGomb3.Text = "Utaslista készítése";
            kerekitettGomb3.UseVisualStyleBackColor = false;
            // 
            // btn_mentes
            // 
            btn_mentes.BackColor = Color.DimGray;
            btn_mentes.EgerTartasHatterSzine = Color.SlateBlue;
            btn_mentes.FlatAppearance.BorderSize = 0;
            btn_mentes.FlatStyle = FlatStyle.Flat;
            btn_mentes.ForeColor = Color.Transparent;
            btn_mentes.HatterSzine = Color.DimGray;
            btn_mentes.KeretMeret = 0;
            btn_mentes.KeretSzine = Color.PaleVioletRed;
            btn_mentes.Location = new Point(19, 8);
            btn_mentes.Margin = new Padding(3, 2, 3, 2);
            btn_mentes.Name = "btn_mentes";
            btn_mentes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_mentes.SarokSugar = 15;
            btn_mentes.Size = new Size(164, 38);
            btn_mentes.SzovegSzine = Color.Transparent;
            btn_mentes.TabIndex = 0;
            btn_mentes.Text = "Mentés";
            btn_mentes.UseVisualStyleBackColor = false;
            // 
            // Frm_UtazasokMegtekintese
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(999, 729);
            Controls.Add(pnl_vezerlok);
            Controls.Add(roundedComboBox1);
            Controls.Add(roundedComboBox2);
            Controls.Add(dataGridView1);
            Controls.Add(roundedComboBox3);
            Name = "Frm_UtazasokMegtekintese";
            Text = "Utazasok";
            Load += Frm_UtazasokMegtekintese_Load_1;
            Resize += Frm_UtazasokMegtekintese_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnl_vezerlok.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Frm_UtazasokMegtekintese_Load_1(object sender, EventArgs e)
        {
            dataGridView1.SendToBack();
            vizualisrendezes();


        }

        #endregion

        private kerekitettLenyilloMenu roundedComboBox2;
        private kerekitettLenyilloMenu roundedComboBox1;
        private DataGridView dataGridView1;
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
        private kerekitettLenyilloMenu roundedComboBox3;
        private SzinatmenetPanel pnl_vezerlok;
        private KerekitettGomb kerekitettGomb5;
        private KerekitettGomb kerekitettGomb4;
        private KerekitettGomb kerekitettGomb3;
        private KerekitettGomb btn_mentes;
    }
}