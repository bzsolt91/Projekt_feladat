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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kerekitettLenyilloMenu));
            pnl_title = new SzinatmenetPanel();
            pcb_nyil = new PictureBox();
            lb_text = new Label();
            picbtn_nyil = new PictureBox();
            flp_items = new ModositottFLPanel();
            pnl_item = new SzinatmenetPanel();
            pnl_helykoz = new Panel();
            ellipszisVezerlo1 = new ellipszisVezerlo();
            pnl_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_nyil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbtn_nyil).BeginInit();
            pnl_item.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_title
            // 
            pnl_title.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnl_title.BackColor = Color.Transparent;
            pnl_title.Controls.Add(pcb_nyil);
            pnl_title.Controls.Add(lb_text);
            pnl_title.Controls.Add(picbtn_nyil);
            pnl_title.Dock = DockStyle.Top;
            pnl_title.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            pnl_title.ForeColor = Color.Transparent;
            pnl_title.KeretSzin = Color.Black;
            pnl_title.KeretVastagsag = 0F;
            pnl_title.Location = new Point(0, 0);
            pnl_title.Margin = new Padding(5);
            pnl_title.Name = "pnl_title";
            pnl_title.Padding = new Padding(5);
            pnl_title.SarkokLekerekitese = 30;
            pnl_title.Size = new Size(338, 49);
            pnl_title.SzinatmenetAlsoSzine = Color.FromArgb(30, 32, 60);
            pnl_title.SzinatmenetFelsoSzine = Color.FromArgb(30, 32, 40);
            pnl_title.SzinatmenetSzog = 50F;
            pnl_title.TabIndex = 0;
            pnl_title.Click += Click;
            // 
            // pcb_nyil
            // 
            pcb_nyil.BackgroundImageLayout = ImageLayout.None;
            pcb_nyil.Dock = DockStyle.Right;
            pcb_nyil.Image = (Image)resources.GetObject("pcb_nyil.Image");
            pcb_nyil.InitialImage = (Image)resources.GetObject("pcb_nyil.InitialImage");
            pcb_nyil.Location = new Point(276, 5);
            pcb_nyil.Margin = new Padding(10, 10, 10, 5);
            pcb_nyil.Name = "pcb_nyil";
            pcb_nyil.Padding = new Padding(10, 10, 10, 5);
            pcb_nyil.Size = new Size(57, 39);
            pcb_nyil.SizeMode = PictureBoxSizeMode.CenterImage;
            pcb_nyil.TabIndex = 7;
            pcb_nyil.TabStop = false;
            pcb_nyil.Click += Click;
            // 
            // lb_text
            // 
            lb_text.AutoSize = true;
            lb_text.BackColor = Color.Transparent;
            lb_text.Dock = DockStyle.Left;
            lb_text.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lb_text.ForeColor = Color.White;
            lb_text.Location = new Point(51, 5);
            lb_text.Name = "lb_text";
            lb_text.Padding = new Padding(0, 6, 0, 0);
            lb_text.Size = new Size(45, 31);
            lb_text.TabIndex = 6;
            lb_text.Text = "Text";
            lb_text.Click += Click;
            // 
            // picbtn_nyil
            // 
            picbtn_nyil.BackColor = Color.Transparent;
            picbtn_nyil.BackgroundImageLayout = ImageLayout.Center;
            picbtn_nyil.Dock = DockStyle.Left;
            picbtn_nyil.Location = new Point(5, 5);
            picbtn_nyil.Margin = new Padding(3, 3, 10, 3);
            picbtn_nyil.Name = "picbtn_nyil";
            picbtn_nyil.Padding = new Padding(5);
            picbtn_nyil.Size = new Size(46, 39);
            picbtn_nyil.SizeMode = PictureBoxSizeMode.CenterImage;
            picbtn_nyil.TabIndex = 1;
            picbtn_nyil.TabStop = false;
            picbtn_nyil.Click += Click;
            // 
            // flp_items
            // 
            flp_items.AutoScroll = true;
            flp_items.AutoSize = true;
            flp_items.BackColor = Color.WhiteSmoke;
            flp_items.Dock = DockStyle.Fill;
            flp_items.ForeColor = Color.Black;
            flp_items.Location = new Point(10, 10);
            flp_items.Name = "flp_items";
            flp_items.Padding = new Padding(10);
            flp_items.Size = new Size(318, 132);
            flp_items.TabIndex = 0;
            // 
            // pnl_item
            // 
            pnl_item.BackColor = Color.Transparent;
            pnl_item.Controls.Add(flp_items);
            pnl_item.Dock = DockStyle.Fill;
            pnl_item.ForeColor = Color.Transparent;
            pnl_item.KeretSzin = Color.Black;
            pnl_item.KeretVastagsag = 0F;
            pnl_item.Location = new Point(0, 54);
            pnl_item.Margin = new Padding(10);
            pnl_item.Name = "pnl_item";
            pnl_item.Padding = new Padding(10);
            pnl_item.SarkokLekerekitese = 15;
            pnl_item.Size = new Size(338, 152);
            pnl_item.SzinatmenetAlsoSzine = Color.FromArgb(0, 0, 0);
            pnl_item.SzinatmenetFelsoSzine = Color.FromArgb(0, 0, 0);
            pnl_item.SzinatmenetSzog = 90F;
            pnl_item.TabIndex = 1;
            // 
            // pnl_helykoz
            // 
            pnl_helykoz.Dock = DockStyle.Top;
            pnl_helykoz.Location = new Point(0, 49);
            pnl_helykoz.Name = "pnl_helykoz";
            pnl_helykoz.Size = new Size(338, 5);
            pnl_helykoz.TabIndex = 2;
            // 
            // ellipszisVezerlo1
            // 
            ellipszisVezerlo1.SarokSugar = 25;
            ellipszisVezerlo1.TargetControl = pnl_item;
            // 
            // kerekitettLenyilloMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnl_item);
            Controls.Add(pnl_helykoz);
            Controls.Add(pnl_title);
            DoubleBuffered = true;
            ForeColor = Color.White;
            Margin = new Padding(2);
            MinimumSize = new Size(300, 0);
            Name = "kerekitettLenyilloMenu";
            Size = new Size(338, 206);
            pnl_title.ResumeLayout(false);
            pnl_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_nyil).EndInit();
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
        private Panel pnl_helykoz;
        private ellipszisVezerlo ellipszisVezerlo1;
        private PictureBox pcb_nyil;
    }
}