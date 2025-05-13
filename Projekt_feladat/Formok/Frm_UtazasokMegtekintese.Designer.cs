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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // roundedComboBox2
            // 
            roundedComboBox2.adatForras = new string[]
    {
    "Cancún (Mexikó)",
    "Miami (USA)",
    "Dubaj (Egyesült Arab Emírségek)",
    "Phuket (Thaiföld)",
    "Nizza (Franciaország)",
    "Bali (Indonézia)",
    "Maldív-szigetek",
    "Goa (India)",
    "Barcelona (Spanyolország)",
    "Rio de Janeiro (Brazília)",
    "Santorini (Görögország)",
    "Hawaii (USA)",
    "Sydney (Ausztrália)",
    "Sharm el-Sheikh (Egyiptom)",
    "Antalya (Törökország)",
    "Malaga (Spanyolország)",
    "Monte Carlo (Monaco)",
    "Los Angeles (USA)",
    "Bahama-szigetek",
    "Kréta (Görögország)"
    };
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
            roundedComboBox2.Location = new Point(305, 54);
            roundedComboBox2.Margin = new Padding(0);
            roundedComboBox2.MinimumSize = new Size(171, 0);
            roundedComboBox2.Name = "roundedComboBox2";
            roundedComboBox2.Padding = new Padding(0, 0, 0, 7);
            roundedComboBox2.Radius = 20;
            roundedComboBox2.Size = new Size(271, 76);
            roundedComboBox2.TabIndex = 7;
            roundedComboBox2.TitleLabelSzin = Color.Black;
            // 
            // roundedComboBox1
            // 
            roundedComboBox1.adatForras = new string[]
    {
    "1902-08-03",
    "1902-10-05",
    "1903-05-03",
    "1904-02-19",
    "1904-11-09",
    "1910-06-07",
    "1914-09-21",
    "1916-07-18",
    "1919-09-24",
    "1919-12-14",
    "1922-01-05",
    "1929-08-17",
    "1931-04-10",
    "1931-06-03",
    "1931-11-02",
    "1933-03-15",
    "1937-04-22",
    "1939-05-16",
    "1945-02-12",
    "1946-06-12",
    "1954-09-13",
    "1955-03-12",
    "1959-01-14",
    "1960-03-19",
    "1961-04-27",
    "1961-08-17",
    "1966-02-09",
    "1968-06-28",
    "1974-11-11",
    "1974-11-14",
    "1975-12-16",
    "1976-06-22",
    "1976-12-20",
    "1977-06-15",
    "1983-07-13",
    "1983-08-09",
    "1984-07-06",
    "1985-01-10",
    "1990-03-09",
    "1990-10-05",
    "1991-12-09",
    "1992-09-18",
    "1993-06-14",
    "1993-07-18",
    "1994-04-28",
    "1995-02-27",
    "1997-04-04",
    "1997-07-09",
    "1999-01-09",
    "1999-10-05",
    "2003-06-16",
    "2004-12-13",
    "2008-10-21",
    "2010-03-27",
    "2017-02-03",
    "2017-06-07",
    "2018-06-08",
    "2019-02-17",
    "2019-11-20",
    "2020-10-03",
    "2021-02-17",
    "2021-03-02",
    "2022-11-06",
    "2025-09-05",
    "2026-07-07",
    "2028-10-14",
    "2028-10-18",
    "2028-11-17",
    "2029-09-23",
    "2031-11-23",
    "2033-10-11",
    "2034-06-02",
    "2035-12-21",
    "2036-04-28",
    "2045-05-23",
    "2047-11-03",
    "2052-08-15",
    "2054-11-01",
    "2057-07-10",
    "2058-01-03",
    "2060-05-05",
    "2062-02-15",
    "2066-07-10",
    "2067-05-23",
    "2070-08-14",
    "2070-11-12",
    "2074-06-18",
    "2078-12-25",
    "2081-04-10",
    "2081-04-19",
    "2087-06-07",
    "2089-12-16",
    "2090-06-26",
    "2092-09-10",
    "2093-05-23",
    "2094-01-16",
    "2095-12-26",
    "2098-05-19",
    "2098-11-01",
    "2099-06-05"
    };
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
            roundedComboBox1.Location = new Point(22, 54);
            roundedComboBox1.Margin = new Padding(0);
            roundedComboBox1.MinimumSize = new Size(171, 0);
            roundedComboBox1.Name = "roundedComboBox1";
            roundedComboBox1.Padding = new Padding(0, 0, 0, 7);
            roundedComboBox1.Radius = 20;
            roundedComboBox1.Size = new Size(251, 73);
            roundedComboBox1.TabIndex = 6;
            roundedComboBox1.TitleLabelSzin = Color.Black;
            roundedComboBox1.Load += roundedComboBox1_Load;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
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
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(22, 157);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
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
            dataGridView1.Size = new Size(1074, 639);
            dataGridView1.TabIndex = 9;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // roundedComboBox3
            // 
            roundedComboBox3.adatForras = new string[]
    {
    "nhjhjééééééééééééééééééééééééééééééééééé",
    "jghjhgj",
    "hgjghj",
    "hjgj",
    "jhgj",
    "hgjgh",
    "ghj",
    "ghjj",
    "ghj",
    "g",
    "ghj",
    "ghj",
    "ghj",
    "ghj",
    "gh",
    "jgh",
    "jgh",
    "j",
    "ghjgh",
    "jg",
    "jhg",
    "j",
    "ghj",
    "ghj",
    "g",
    "hj",
    "gh",
    "jg",
    "hj",
    "gh",
    "j",
    "h",
    "hjg",
    "j",
    "hg",
    "",
    "",
    "j"
    };
            roundedComboBox3.BackColor = Color.Transparent;
            roundedComboBox3.CimPanelAlsoSzin = Color.White;
            roundedComboBox3.CimPanelFelsoSzin = Color.White;
            roundedComboBox3.ComboText = "Utazás neve";
            roundedComboBox3.ForeColor = Color.Transparent;
            roundedComboBox3.Ikon = (Image)resources.GetObject("roundedComboBox3.Ikon");
            roundedComboBox3.ItemPanelAlosSzin = Color.White;
            roundedComboBox3.ItemPanelFelsoSzin = Color.White;
            roundedComboBox3.KeretSzin = Color.BlueViolet;
            roundedComboBox3.KeretVastagsag = 1.8F;
            roundedComboBox3.Location = new Point(804, 51);
            roundedComboBox3.Margin = new Padding(0);
            roundedComboBox3.MinimumSize = new Size(171, 0);
            roundedComboBox3.Name = "roundedComboBox3";
            roundedComboBox3.Radius = 40;
            roundedComboBox3.Size = new Size(280, 72);
            roundedComboBox3.TabIndex = 8;
            roundedComboBox3.TitleLabelSzin = Color.Black;
            // 
            // Frm_UtazasokMegtekintese
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1142, 972);
            Controls.Add(roundedComboBox1);
            Controls.Add(roundedComboBox2);
            Controls.Add(dataGridView1);
            Controls.Add(roundedComboBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_UtazasokMegtekintese";
            Text = "Utazasok";
            Load += Frm_UtazasokMegtekintese_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}