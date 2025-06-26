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
            kerekitettGomb1 = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kerekitettGomb2 = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            kerekitettGomb3 = new Projekt_feladat.egyeni_vezerlok.KerekitettGomb();
            SuspendLayout();
            // 
            // kerekitettGomb1
            // 
            kerekitettGomb1.BackColor = Color.MediumSlateBlue;
            kerekitettGomb1.EgerTartasHatterSzine = Color.SlateBlue;
            kerekitettGomb1.FlatStyle = FlatStyle.Flat;
            kerekitettGomb1.ForeColor = Color.White;
            kerekitettGomb1.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb1.KeretMeret = 0;
            kerekitettGomb1.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb1.Location = new Point(577, 96);
            kerekitettGomb1.Margin = new Padding(3, 4, 3, 4);
            kerekitettGomb1.Name = "kerekitettGomb1";
            kerekitettGomb1.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb1.SarokSugar = 10;
            kerekitettGomb1.Size = new Size(171, 53);
            kerekitettGomb1.SzovegSzine = Color.White;
            kerekitettGomb1.TabIndex = 0;
            kerekitettGomb1.Text = "kerekitettGomb1";
            kerekitettGomb1.UseVisualStyleBackColor = false;
            // 
            // kerekitettGomb2
            // 
            kerekitettGomb2.BackColor = Color.MediumSlateBlue;
            kerekitettGomb2.EgerTartasHatterSzine = Color.SlateBlue;
            kerekitettGomb2.FlatStyle = FlatStyle.Flat;
            kerekitettGomb2.ForeColor = Color.White;
            kerekitettGomb2.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb2.KeretMeret = 0;
            kerekitettGomb2.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb2.Location = new Point(577, 157);
            kerekitettGomb2.Margin = new Padding(3, 4, 3, 4);
            kerekitettGomb2.Name = "kerekitettGomb2";
            kerekitettGomb2.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb2.SarokSugar = 10;
            kerekitettGomb2.Size = new Size(171, 53);
            kerekitettGomb2.SzovegSzine = Color.White;
            kerekitettGomb2.TabIndex = 1;
            kerekitettGomb2.Text = "kerekitettGomb2";
            kerekitettGomb2.UseVisualStyleBackColor = false;
            // 
            // kerekitettGomb3
            // 
            kerekitettGomb3.BackColor = Color.MediumSlateBlue;
            kerekitettGomb3.EgerTartasHatterSzine = Color.SlateBlue;
            kerekitettGomb3.FlatStyle = FlatStyle.Flat;
            kerekitettGomb3.ForeColor = Color.White;
            kerekitettGomb3.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb3.KeretMeret = 0;
            kerekitettGomb3.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb3.Location = new Point(577, 219);
            kerekitettGomb3.Margin = new Padding(3, 4, 3, 4);
            kerekitettGomb3.Name = "kerekitettGomb3";
            kerekitettGomb3.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb3.SarokSugar = 10;
            kerekitettGomb3.Size = new Size(171, 53);
            kerekitettGomb3.SzovegSzine = Color.White;
            kerekitettGomb3.TabIndex = 2;
            kerekitettGomb3.Text = "kerekitettGomb3";
            kerekitettGomb3.UseVisualStyleBackColor = false;
            // 
            // Frm_UtasokMegtekintese
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(kerekitettGomb3);
            Controls.Add(kerekitettGomb2);
            Controls.Add(kerekitettGomb1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_UtasokMegtekintese";
            Text = "Utasok";
            Load += Frm_Utasok_Load;
            ResumeLayout(false);
        }

        #endregion

        private egyeni_vezerlok.KerekitettGomb kerekitettGomb1;
        private egyeni_vezerlok.KerekitettGomb kerekitettGomb2;
        private egyeni_vezerlok.KerekitettGomb kerekitettGomb3;
    }
}