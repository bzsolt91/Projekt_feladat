﻿namespace Projekt_feladat.Properties.Formok
{
    partial class Frm_Utasok
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
            kerekitettGomb1.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb1.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb1.SarokSugar = 10;
            kerekitettGomb1.KeretMeret = 0;
            kerekitettGomb1.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb1.EgerTartasHatterSzine = Color.SlateBlue;
            kerekitettGomb1.SzovegSzine = Color.White;
            kerekitettGomb1.FlatStyle = FlatStyle.Flat;
            kerekitettGomb1.Location = new Point(505, 72);
            kerekitettGomb1.Name = "kerekitettGomb1";
            kerekitettGomb1.Size = new Size(150, 40);
            kerekitettGomb1.TabIndex = 0;
            kerekitettGomb1.Text = "kerekitettGomb1";

            // kerekitettGomb2
            // 
            kerekitettGomb2.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb2.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb2.SarokSugar = 10;
            kerekitettGomb2.KeretMeret = 0;
            kerekitettGomb2.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb2.EgerTartasHatterSzine = Color.SlateBlue;
            kerekitettGomb2.SzovegSzine = Color.White;
            kerekitettGomb2.FlatStyle = FlatStyle.Flat;
            kerekitettGomb2.Location = new Point(505, 118);
            kerekitettGomb2.Name = "kerekitettGomb2";
            kerekitettGomb2.Size = new Size(150, 40);
            kerekitettGomb2.TabIndex = 1;
            kerekitettGomb2.Text = "kerekitettGomb2";

            // kerekitettGomb3
            // 
            kerekitettGomb3.HatterSzine = Color.MediumSlateBlue;
            kerekitettGomb3.KeretSzine = Color.PaleVioletRed;
            kerekitettGomb3.SarokSugar = 10;
            kerekitettGomb3.KeretMeret = 0;
            kerekitettGomb3.NyomottAllapotHatterSzine = Color.DarkSlateBlue;
            kerekitettGomb3.EgerTartasHatterSzine = Color.SlateBlue;
            kerekitettGomb3.SzovegSzine = Color.White;
            kerekitettGomb3.FlatStyle = FlatStyle.Flat;
            kerekitettGomb3.Location = new Point(505, 164);
            kerekitettGomb3.Name = "kerekitettGomb3";
            kerekitettGomb3.Size = new Size(150, 40);
            kerekitettGomb3.TabIndex = 2;
            kerekitettGomb3.Text = "kerekitettGomb3";
            // 
            // Frm_Utasok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kerekitettGomb3);
            Controls.Add(kerekitettGomb2);
            Controls.Add(kerekitettGomb1);
            Name = "Frm_Utasok";
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