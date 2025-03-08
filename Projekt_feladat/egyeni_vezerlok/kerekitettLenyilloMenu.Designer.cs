namespace Projekt_feladat.egyeni_vezerlok
{
    partial class kerekitettLenyilloMenu
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
            components = new System.ComponentModel.Container();
            pnl_title = new SzinatmenetPanel();
            lb_diszcsik = new Label();
            picbtn_nyil = new PictureBox();
            lb_text = new Label();
            flp_items = new ModositottFLPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            pnl_item = new SzinatmenetPanel();
            pnl_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbtn_nyil).BeginInit();
            pnl_item.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_title
            // 
            pnl_title.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnl_title.BackColor = Color.Black;
            pnl_title.SarkokLekerekitese = 50;
            pnl_title.Controls.Add(lb_diszcsik);
            pnl_title.Controls.Add(picbtn_nyil);
            pnl_title.Controls.Add(lb_text);
            pnl_title.Dock = DockStyle.Top;
            pnl_title.ForeColor = Color.Black;
            pnl_title.SzinatmenetSzog = 90F;
            pnl_title.SzinatmenetAlsoSzine = Color.FromArgb(30, 32, 60);
            pnl_title.SzinatmenetFelsoSzine = Color.FromArgb(30, 32, 40);
            pnl_title.Location = new Point(0, 0);
            pnl_title.Margin = new Padding(0);
            pnl_title.Name = "pnl_title";
            pnl_title.Size = new Size(338, 50);
            pnl_title.TabIndex = 0;
            // 
            // lb_diszcsik
            // 
            lb_diszcsik.BackColor = Color.LightSkyBlue;
            lb_diszcsik.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lb_diszcsik.ForeColor = Color.LightSkyBlue;
            lb_diszcsik.Location = new Point(17, 36);
            lb_diszcsik.Margin = new Padding(0);
            lb_diszcsik.MaximumSize = new Size(150, 1);
            lb_diszcsik.MinimumSize = new Size(0, 1);
            lb_diszcsik.Name = "lb_diszcsik";
            lb_diszcsik.Size = new Size(150, 1);
            lb_diszcsik.TabIndex = 2;
            lb_diszcsik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picbtn_nyil
            // 
            picbtn_nyil.BackColor = Color.Transparent;
            picbtn_nyil.Dock = DockStyle.Right;
            picbtn_nyil.Image = Properties.Resources.arrow_down;
            picbtn_nyil.Location = new Point(296, 0);
            picbtn_nyil.Margin = new Padding(3, 3, 10, 3);
            picbtn_nyil.Name = "picbtn_nyil";
            picbtn_nyil.Size = new Size(42, 50);
            picbtn_nyil.SizeMode = PictureBoxSizeMode.StretchImage;
            picbtn_nyil.TabIndex = 1;
            picbtn_nyil.TabStop = false;
            picbtn_nyil.Click += picbtn_nyil_Click;
            // 
            // lb_text
            // 
            lb_text.AutoSize = true;
            lb_text.BackColor = Color.Transparent;
            lb_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lb_text.ForeColor = Color.LightSkyBlue;
            lb_text.Location = new Point(22, 11);
            lb_text.Name = "lb_text";
            lb_text.Size = new Size(39, 20);
            lb_text.TabIndex = 0;
            lb_text.Text = "Text";
            // 
            // flp_items
            // 
            flp_items.AutoSize = true;
            flp_items.BackColor = Color.Gray;
            flp_items.Dock = DockStyle.Fill;
            flp_items.ForeColor = Color.Black;
            flp_items.Location = new Point(0, 0);
            flp_items.Name = "flp_items";
            flp_items.Size = new Size(338, 0);
            flp_items.TabIndex = 0;
            //flp_items.WrapContents = false;
            flp_items.AutoScroll = true;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // pnl_item
            // 
            pnl_item.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnl_item.BackColor = Color.Black;
            pnl_item.SarkokLekerekitese = 30;
            pnl_item.Controls.Add(flp_items);
            pnl_item.Dock = DockStyle.Fill;
            pnl_item.ForeColor = Color.Black;
            pnl_item.SzinatmenetSzog = 90F;
            pnl_item.SzinatmenetAlsoSzine = Color.FromArgb(30, 32, 60);
            pnl_item.SzinatmenetFelsoSzine = Color.FromArgb(30, 32, 40);
            pnl_item.Location = new Point(0, 50);
            pnl_item.Margin = new Padding(0);
            pnl_item.Name = "pnl_item";
            pnl_item.Size = new Size(338, 0);
            pnl_item.TabIndex = 1;
            // 
            // kerekitettLenyilloMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(pnl_item);
            Controls.Add(pnl_title);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            Margin = new Padding(0);
            MinimumSize = new Size(300, 0);
            Name = "kerekitettLenyilloMenu";
            Size = new Size(338, 50);
            pnl_title.ResumeLayout(false);
            pnl_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbtn_nyil).EndInit();
            pnl_item.ResumeLayout(false);
            pnl_item.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SzinatmenetPanel pnl_title;
        private SzinatmenetPanel pnl_item;
        private PictureBox picbtn_nyil;
        private Label lb_text;
        private ModositottFLPanel flp_items;
        private Label lb_diszcsik;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
