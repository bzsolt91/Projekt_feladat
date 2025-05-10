namespace Projekt_feladat.egyeni_vezerlok
{
    partial class kerekitettSzovegMezo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_dizajn = new TextBox();
            SuspendLayout();
            // 
            // tb_dizajn
            // 
            tb_dizajn.BorderStyle = BorderStyle.None;
            tb_dizajn.Dock = DockStyle.Fill;
            tb_dizajn.Location = new Point(10, 7);
            tb_dizajn.Name = "tb_dizajn";
            tb_dizajn.Size = new Size(230, 15);
            tb_dizajn.TabIndex = 0;
            tb_dizajn.Click += textBox1_Click;
            tb_dizajn.TextChanged += textBox1_TextChanged;
            tb_dizajn.Enter += textBox1_Enter;
            tb_dizajn.KeyPress += textBox1_KeyPress;
            tb_dizajn.Leave += textBox1_Leave;
            tb_dizajn.MouseEnter += textBox1_MouseEnter;
            tb_dizajn.MouseLeave += textBox1_MouseLeave;
            // 
            // kerekitettSzovegMezo
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            Controls.Add(tb_dizajn);
            Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 64, 64);
            Margin = new Padding(4);
            Name = "kerekitettSzovegMezo";
            Padding = new Padding(10, 7, 10, 7);
            Size = new Size(250, 30);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_dizajn;
    }
}