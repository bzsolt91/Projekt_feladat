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
            ellipszisVezerlo ev_szuroPanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UtazasokMegtekintese));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            szpn_szuroPanel = new Panel();
            kb_biztositas = new KapcsoloGomb();
            kb_befizetes = new KapcsoloGomb();
            kb_okmanyErvenyes = new KapcsoloGomb();
            kg_pipa = new KerekitettGomb();
            lbl_befizetes = new Label();
            lbl_okmanyErvenyes = new Label();
            lbl_biztositas = new Label();
            kszm_megjegyzes = new kerekitettSzovegMezo();
            kszm_okmanySzam = new kerekitettSzovegMezo();
            kszm_lakcim = new kerekitettSzovegMezo();
            kszm_telefon = new kerekitettSzovegMezo();
            kszm_email = new kerekitettSzovegMezo();
            kszm_utasNeve = new kerekitettSzovegMezo();
            rcb_desztinacio = new kerekitettLenyilloMenu();
            rcb_idoszak = new kerekitettLenyilloMenu();
            dgv_utazasok = new DataGridView();
            rcb_utazasNeve = new kerekitettLenyilloMenu();
            pnl_vezerlok = new Panel();
            kg_szures = new KerekitettGomb();
            kerekitettGomb5 = new KerekitettGomb();
            kerekitettGomb3 = new KerekitettGomb();
            btn_mentes = new KerekitettGomb();
            ev_vezerloPanel = new ellipszisVezerlo();
            ev_szuroPanel = new ellipszisVezerlo();
            szpn_szuroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_utazasok).BeginInit();
            pnl_vezerlok.SuspendLayout();
            SuspendLayout();
            // 
            // ev_szuroPanel
            // 
            ev_szuroPanel.SarokSugar = 80;
            ev_szuroPanel.TargetControl = szpn_szuroPanel;
            // 
            // szpn_szuroPanel
            // 
            szpn_szuroPanel.BackColor = Color.FromArgb(243, 244, 246);
            szpn_szuroPanel.Controls.Add(kb_biztositas);
            szpn_szuroPanel.Controls.Add(kb_befizetes);
            szpn_szuroPanel.Controls.Add(kb_okmanyErvenyes);
            szpn_szuroPanel.Controls.Add(kg_pipa);
            szpn_szuroPanel.Controls.Add(lbl_befizetes);
            szpn_szuroPanel.Controls.Add(lbl_okmanyErvenyes);
            szpn_szuroPanel.Controls.Add(lbl_biztositas);
            szpn_szuroPanel.Controls.Add(kszm_megjegyzes);
            szpn_szuroPanel.Controls.Add(kszm_okmanySzam);
            szpn_szuroPanel.Controls.Add(kszm_lakcim);
            szpn_szuroPanel.Controls.Add(kszm_telefon);
            szpn_szuroPanel.Controls.Add(kszm_email);
            szpn_szuroPanel.Controls.Add(kszm_utasNeve);
            szpn_szuroPanel.ForeColor = Color.Black;
            szpn_szuroPanel.Location = new Point(12, 12);
            szpn_szuroPanel.Name = "szpn_szuroPanel";
            szpn_szuroPanel.Size = new Size(818, 559);
            szpn_szuroPanel.TabIndex = 11;
            szpn_szuroPanel.Visible = false;
            // 
            // kb_biztositas
            // 
            kb_biztositas.AktualisAllas = KapcsoloGomb.KapcsoloAllas.Ki;
            kb_biztositas.Location = new Point(623, 52);
            kb_biztositas.MinimumSize = new Size(70, 22);
            kb_biztositas.Name = "kb_biztositas";
            kb_biztositas.Size = new Size(90, 35);
            kb_biztositas.TabIndex = 0;
            // 
            // kb_befizetes
            // 
            kb_befizetes.AktualisAllas = KapcsoloGomb.KapcsoloAllas.Ki;
            kb_befizetes.Location = new Point(623, 165);
            kb_befizetes.MinimumSize = new Size(70, 22);
            kb_befizetes.Name = "kb_befizetes";
            kb_befizetes.Size = new Size(90, 35);
            kb_befizetes.TabIndex = 1;
            // 
            // kb_okmanyErvenyes
            // 
            kb_okmanyErvenyes.AktualisAllas = KapcsoloGomb.KapcsoloAllas.Ki;
            kb_okmanyErvenyes.Location = new Point(623, 105);
            kb_okmanyErvenyes.MinimumSize = new Size(70, 22);
            kb_okmanyErvenyes.Name = "kb_okmanyErvenyes";
            kb_okmanyErvenyes.Size = new Size(90, 35);
            kb_okmanyErvenyes.TabIndex = 2;
            // 
            // kg_pipa
            // 
            kg_pipa.BackColor = Color.WhiteSmoke;
            kg_pipa.BackgroundImage = (Image)resources.GetObject("kg_pipa.BackgroundImage");
            kg_pipa.BackgroundImageLayout = ImageLayout.Stretch;
            kg_pipa.EgerTartasHatterSzine = Color.DarkViolet;
            kg_pipa.FlatAppearance.BorderSize = 0;
            kg_pipa.FlatStyle = FlatStyle.Flat;
            kg_pipa.ForeColor = Color.White;
            kg_pipa.HatterSzine = Color.WhiteSmoke;
            kg_pipa.KeretMeret = 0;
            kg_pipa.KeretSzine = Color.PaleVioletRed;
            kg_pipa.Location = new Point(608, 413);
            kg_pipa.Name = "kg_pipa";
            kg_pipa.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_pipa.SarokSugar = 20;
            kg_pipa.Size = new Size(105, 94);
            kg_pipa.SzovegSzine = Color.White;
            kg_pipa.TabIndex = 13;
            kg_pipa.UseVisualStyleBackColor = false;
            kg_pipa.Click += kg_pipa_Click;
            // 
            // lbl_befizetes
            // 
            lbl_befizetes.AutoSize = true;
            lbl_befizetes.Location = new Point(473, 180);
            lbl_befizetes.Name = "lbl_befizetes";
            lbl_befizetes.Size = new Size(108, 20);
            lbl_befizetes.TabIndex = 11;
            lbl_befizetes.Text = "Van befizetése:";
            // 
            // lbl_okmanyErvenyes
            // 
            lbl_okmanyErvenyes.AutoSize = true;
            lbl_okmanyErvenyes.Location = new Point(473, 120);
            lbl_okmanyErvenyes.Name = "lbl_okmanyErvenyes";
            lbl_okmanyErvenyes.Size = new Size(144, 20);
            lbl_okmanyErvenyes.TabIndex = 10;
            lbl_okmanyErvenyes.Text = "Érvényes az okmány:";
            // 
            // lbl_biztositas
            // 
            lbl_biztositas.AutoSize = true;
            lbl_biztositas.Location = new Point(473, 56);
            lbl_biztositas.Name = "lbl_biztositas";
            lbl_biztositas.Size = new Size(102, 20);
            lbl_biztositas.TabIndex = 9;
            lbl_biztositas.Text = "Biztosítás van:";
            // 
            // kszm_megjegyzes
            // 
            kszm_megjegyzes.AlahuzottStilus = false;
            kszm_megjegyzes.BackColor = SystemColors.Window;
            kszm_megjegyzes.FokuszKeretSzin = Color.HotPink;
            kszm_megjegyzes.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_megjegyzes.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_megjegyzes.HelyorzoSzin = Color.DarkGray;
            kszm_megjegyzes.HelyorzoSzoveg = "Megjegyzés";
            kszm_megjegyzes.JelszoKarakter = false;
            kszm_megjegyzes.KeretMeret = 2;
            kszm_megjegyzes.KeretSugar = 8;
            kszm_megjegyzes.KeretSzin = Color.MediumSlateBlue;
            kszm_megjegyzes.Location = new Point(45, 370);
            kszm_megjegyzes.Margin = new Padding(4);
            kszm_megjegyzes.Name = "kszm_megjegyzes";
            kszm_megjegyzes.Padding = new Padding(10, 7, 10, 7);
            kszm_megjegyzes.Size = new Size(392, 35);
            kszm_megjegyzes.TabIndex = 6;
            kszm_megjegyzes.Texts = "";
            kszm_megjegyzes.TobbSor = false;
            // 
            // kszm_okmanySzam
            // 
            kszm_okmanySzam.AlahuzottStilus = false;
            kszm_okmanySzam.BackColor = SystemColors.Window;
            kszm_okmanySzam.FokuszKeretSzin = Color.HotPink;
            kszm_okmanySzam.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_okmanySzam.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_okmanySzam.HelyorzoSzin = Color.DarkGray;
            kszm_okmanySzam.HelyorzoSzoveg = "Okmány szám";
            kszm_okmanySzam.JelszoKarakter = false;
            kszm_okmanySzam.KeretMeret = 2;
            kszm_okmanySzam.KeretSugar = 8;
            kszm_okmanySzam.KeretSzin = Color.MediumSlateBlue;
            kszm_okmanySzam.Location = new Point(45, 303);
            kszm_okmanySzam.Margin = new Padding(4);
            kszm_okmanySzam.Name = "kszm_okmanySzam";
            kszm_okmanySzam.Padding = new Padding(10, 7, 10, 7);
            kszm_okmanySzam.Size = new Size(392, 35);
            kszm_okmanySzam.TabIndex = 4;
            kszm_okmanySzam.Texts = "";
            kszm_okmanySzam.TobbSor = false;
            // 
            // kszm_lakcim
            // 
            kszm_lakcim.AlahuzottStilus = false;
            kszm_lakcim.BackColor = SystemColors.Window;
            kszm_lakcim.FokuszKeretSzin = Color.HotPink;
            kszm_lakcim.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_lakcim.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_lakcim.HelyorzoSzin = Color.DarkGray;
            kszm_lakcim.HelyorzoSzoveg = "Lakcím";
            kszm_lakcim.JelszoKarakter = false;
            kszm_lakcim.KeretMeret = 2;
            kszm_lakcim.KeretSugar = 8;
            kszm_lakcim.KeretSzin = Color.MediumSlateBlue;
            kszm_lakcim.Location = new Point(45, 244);
            kszm_lakcim.Margin = new Padding(4);
            kszm_lakcim.Name = "kszm_lakcim";
            kszm_lakcim.Padding = new Padding(10, 7, 10, 7);
            kszm_lakcim.Size = new Size(392, 35);
            kszm_lakcim.TabIndex = 3;
            kszm_lakcim.Texts = "";
            kszm_lakcim.TobbSor = false;
            // 
            // kszm_telefon
            // 
            kszm_telefon.AlahuzottStilus = false;
            kszm_telefon.BackColor = SystemColors.Window;
            kszm_telefon.FokuszKeretSzin = Color.HotPink;
            kszm_telefon.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_telefon.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_telefon.HelyorzoSzin = Color.DarkGray;
            kszm_telefon.HelyorzoSzoveg = "Telefon";
            kszm_telefon.JelszoKarakter = false;
            kszm_telefon.KeretMeret = 2;
            kszm_telefon.KeretSugar = 8;
            kszm_telefon.KeretSzin = Color.MediumSlateBlue;
            kszm_telefon.Location = new Point(45, 180);
            kszm_telefon.Margin = new Padding(4);
            kszm_telefon.Name = "kszm_telefon";
            kszm_telefon.Padding = new Padding(10, 7, 10, 7);
            kszm_telefon.Size = new Size(392, 35);
            kszm_telefon.TabIndex = 2;
            kszm_telefon.Texts = "";
            kszm_telefon.TobbSor = false;
            // 
            // kszm_email
            // 
            kszm_email.AlahuzottStilus = false;
            kszm_email.BackColor = SystemColors.Window;
            kszm_email.FokuszKeretSzin = Color.HotPink;
            kszm_email.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_email.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_email.HelyorzoSzin = Color.DarkGray;
            kszm_email.HelyorzoSzoveg = "Email";
            kszm_email.JelszoKarakter = false;
            kszm_email.KeretMeret = 2;
            kszm_email.KeretSugar = 8;
            kszm_email.KeretSzin = Color.MediumSlateBlue;
            kszm_email.Location = new Point(45, 115);
            kszm_email.Margin = new Padding(4);
            kszm_email.Name = "kszm_email";
            kszm_email.Padding = new Padding(10, 7, 10, 7);
            kszm_email.Size = new Size(392, 35);
            kszm_email.TabIndex = 1;
            kszm_email.Texts = "";
            kszm_email.TobbSor = false;
            // 
            // kszm_utasNeve
            // 
            kszm_utasNeve.AlahuzottStilus = false;
            kszm_utasNeve.BackColor = SystemColors.Window;
            kszm_utasNeve.FokuszKeretSzin = Color.HotPink;
            kszm_utasNeve.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kszm_utasNeve.ForeColor = Color.FromArgb(64, 64, 64);
            kszm_utasNeve.HelyorzoSzin = Color.DarkGray;
            kszm_utasNeve.HelyorzoSzoveg = "Utas Neve";
            kszm_utasNeve.JelszoKarakter = false;
            kszm_utasNeve.KeretMeret = 2;
            kszm_utasNeve.KeretSugar = 8;
            kszm_utasNeve.KeretSzin = Color.MediumSlateBlue;
            kszm_utasNeve.Location = new Point(45, 52);
            kszm_utasNeve.Margin = new Padding(4);
            kszm_utasNeve.Name = "kszm_utasNeve";
            kszm_utasNeve.Padding = new Padding(10, 7, 10, 7);
            kszm_utasNeve.Size = new Size(392, 35);
            kszm_utasNeve.TabIndex = 0;
            kszm_utasNeve.Texts = "";
            kszm_utasNeve.TobbSor = false;
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
            rcb_desztinacio.Location = new Point(10, 12);
            rcb_desztinacio.Margin = new Padding(0);
            rcb_desztinacio.MinimumSize = new Size(171, 0);
            rcb_desztinacio.Name = "rcb_desztinacio";
            rcb_desztinacio.Padding = new Padding(0, 0, 0, 7);
            rcb_desztinacio.Radius = 20;
            rcb_desztinacio.Size = new Size(299, 76);
            rcb_desztinacio.TabIndex = 7;
            rcb_desztinacio.TitleLabelSzin = Color.Black;
            rcb_desztinacio.ElemKivalasztva += rcb_desztinacio_ElemKivalasztva;
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
            rcb_idoszak.Location = new Point(335, 12);
            rcb_idoszak.Margin = new Padding(0);
            rcb_idoszak.MinimumSize = new Size(171, 0);
            rcb_idoszak.Name = "rcb_idoszak";
            rcb_idoszak.Padding = new Padding(0, 0, 0, 7);
            rcb_idoszak.Radius = 20;
            rcb_idoszak.Size = new Size(329, 73);
            rcb_idoszak.TabIndex = 6;
            rcb_idoszak.TitleLabelSzin = Color.Black;
            rcb_idoszak.ElemKivalasztva += rcb_idoszak_ElemKivalasztva;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_utazasok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_utazasok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle5.SelectionForeColor = Color.BlueViolet;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_utazasok.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_utazasok.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv_utazasok.EnableHeadersVisualStyles = false;
            dgv_utazasok.GridColor = SystemColors.InactiveBorder;
            dgv_utazasok.Location = new Point(10, 92);
            dgv_utazasok.Margin = new Padding(3, 4, 3, 4);
            dgv_utazasok.Name = "dgv_utazasok";
            dgv_utazasok.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_utazasok.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_utazasok.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv_utazasok.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv_utazasok.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgv_utazasok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_utazasok.ShowEditingIcon = false;
            dgv_utazasok.ShowRowErrors = false;
            dgv_utazasok.Size = new Size(1074, 639);
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
            rcb_utazasNeve.Location = new Point(680, 9);
            rcb_utazasNeve.Margin = new Padding(0);
            rcb_utazasNeve.MinimumSize = new Size(171, 0);
            rcb_utazasNeve.Name = "rcb_utazasNeve";
            rcb_utazasNeve.Radius = 20;
            rcb_utazasNeve.Size = new Size(327, 76);
            rcb_utazasNeve.TabIndex = 8;
            rcb_utazasNeve.TitleLabelSzin = Color.Black;
            rcb_utazasNeve.ElemKivalasztva += rcb_utazasNeve_ElemKivalasztva;
            // 
            // pnl_vezerlok
            // 
            pnl_vezerlok.BackColor = Color.DarkViolet;
            pnl_vezerlok.Controls.Add(kg_szures);
            pnl_vezerlok.Controls.Add(kerekitettGomb5);
            pnl_vezerlok.Controls.Add(kerekitettGomb3);
            pnl_vezerlok.Controls.Add(btn_mentes);
            pnl_vezerlok.Dock = DockStyle.Bottom;
            pnl_vezerlok.ForeColor = Color.CadetBlue;
            pnl_vezerlok.Location = new Point(0, 903);
            pnl_vezerlok.Name = "pnl_vezerlok";
            pnl_vezerlok.Size = new Size(1142, 69);
            pnl_vezerlok.TabIndex = 10;
            pnl_vezerlok.Paint += pnl_vezerlok_Paint;
            // 
            // kg_szures
            // 
            kg_szures.BackColor = Color.MediumSlateBlue;
            kg_szures.EgerTartasHatterSzine = Color.SlateBlue;
            kg_szures.FlatAppearance.BorderSize = 0;
            kg_szures.FlatStyle = FlatStyle.Flat;
            kg_szures.Font = new Font("Segoe UI", 12F);
            kg_szures.ForeColor = Color.White;
            kg_szures.HatterSzine = Color.MediumSlateBlue;
            kg_szures.Image = (Image)resources.GetObject("kg_szures.Image");
            kg_szures.ImageAlign = ContentAlignment.MiddleRight;
            kg_szures.KeretMeret = 0;
            kg_szures.KeretSzine = Color.PaleVioletRed;
            kg_szures.Location = new Point(216, 8);
            kg_szures.Name = "kg_szures";
            kg_szures.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kg_szures.SarokSugar = 10;
            kg_szures.Size = new Size(187, 51);
            kg_szures.SzovegSzine = Color.White;
            kg_szures.TabIndex = 4;
            kg_szures.Text = "Szűrés";
            kg_szures.TextImageRelation = TextImageRelation.ImageBeforeText;
            kg_szures.UseVisualStyleBackColor = false;
            kg_szures.Click += kerekitettGomb2_Click;
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
            kerekitettGomb5.Location = new Point(654, 8);
            kerekitettGomb5.Name = "kerekitettGomb5";
            kerekitettGomb5.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb5.SarokSugar = 10;
            kerekitettGomb5.Size = new Size(187, 51);
            kerekitettGomb5.SzovegSzine = Color.White;
            kerekitettGomb5.TabIndex = 3;
            kerekitettGomb5.Text = "Nyomtatás";
            kerekitettGomb5.UseVisualStyleBackColor = false;
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
            kerekitettGomb3.Location = new Point(421, 8);
            kerekitettGomb3.Name = "kerekitettGomb3";
            kerekitettGomb3.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb3.SarokSugar = 10;
            kerekitettGomb3.Size = new Size(216, 51);
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
            btn_mentes.Location = new Point(12, 8);
            btn_mentes.Name = "btn_mentes";
            btn_mentes.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            btn_mentes.RightToLeft = RightToLeft.No;
            btn_mentes.SarokSugar = 10;
            btn_mentes.Size = new Size(187, 51);
            btn_mentes.SzovegSzine = Color.White;
            btn_mentes.TabIndex = 0;
            btn_mentes.Text = "Mentés";
            btn_mentes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_mentes.UseVisualStyleBackColor = false;
            // 
            // ev_vezerloPanel
            // 
            ev_vezerloPanel.SarokSugar = 20;
            ev_vezerloPanel.TargetControl = pnl_vezerlok;
            // 
            // Frm_UtazasokMegtekintese
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1142, 972);
            Controls.Add(szpn_szuroPanel);
            Controls.Add(pnl_vezerlok);
            Controls.Add(rcb_idoszak);
            Controls.Add(rcb_desztinacio);
            Controls.Add(dgv_utazasok);
            Controls.Add(rcb_utazasNeve);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_UtazasokMegtekintese";
            Text = "Utazasok";
            Load += Frm_UtazasokMegtekintese_Load_1;
            Resize += Frm_UtazasokMegtekintese_Resize;
            szpn_szuroPanel.ResumeLayout(false);
            szpn_szuroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_utazasok).EndInit();
            pnl_vezerlok.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Frm_UtazasokMegtekintese_Load_1(object sender, EventArgs e)
        {
            szpn_szuroPanel.Visible = false;
            dgv_utazasok.SendToBack();
            vizualisrendezes();
            utazasok_betoltes();


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
        private Panel pnl_vezerlok;
        private KerekitettGomb kerekitettGomb5;
        private KerekitettGomb kerekitettGomb3;
        private KerekitettGomb btn_mentes;
        private KerekitettGomb kg_szures;
        private kerekitettSzovegMezo kszm_utasNeve;
        private kerekitettSzovegMezo kszm_email;
        private kerekitettSzovegMezo kszm_telefon;
        private kerekitettSzovegMezo kszm_lakcim;
        private kerekitettSzovegMezo kszm_okmanySzam;
        private Panel szpn_szuroPanel;
        private kerekitettSzovegMezo kszm_megjegyzes;
        private Label lbl_okmanyErvenyes;
        private Label lbl_biztositas;
     
  
        private Label lbl_befizetes;
        private KerekitettGomb kg_pipa;
        
        public ellipszisVezerlo ev_szuroPanel;
        private ellipszisVezerlo ev_vezerloPanel;
        private KapcsoloGomb kb_okmanyErvenyes;
        private KapcsoloGomb kb_biztositas;
        private KapcsoloGomb kb_befizetes;
    }
}