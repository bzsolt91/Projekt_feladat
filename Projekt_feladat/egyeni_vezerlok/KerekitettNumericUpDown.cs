using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Projekt_feladat.egyeni_vezerlok
{
    public class KerekitettNumericUpDown : UserControl
    {
        private TextBox textBox;
        private Button btnUp;
        private Button btnDown;

        private int radius = 10;
        private Color keretSzin = Color.Gray;
        private float keretVastagsag = 1.5f;
        private decimal minimum = 0;
        private decimal maximum = 100;
        private decimal increment = 1;
        private decimal value = 0;

        public KerekitettNumericUpDown()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            this.BackColor = Color.Transparent;

            btnUp = new Button();
            btnDown = new Button();
            textBox = new TextBox();

            btnUp.FlatStyle = FlatStyle.Flat;
            btnUp.FlatAppearance.BorderSize = 0;
            btnUp.BackColor = Color.LightGray;
            btnUp.ForeColor = Color.Black;
            btnUp.Click += BtnUp_Click;
            btnUp.Cursor = Cursors.Hand;
            btnUp.Paint += BtnUp_Paint;

            btnDown.FlatStyle = FlatStyle.Flat;
            btnDown.FlatAppearance.BorderSize = 0;
            btnDown.BackColor = Color.LightGray;
            btnDown.ForeColor = Color.Black;
            btnDown.Click += BtnDown_Click;
            btnDown.Cursor = Cursors.Hand;
            btnDown.Paint += BtnDown_Paint;

            textBox.BorderStyle = BorderStyle.None;
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.Font = new Font("Segoe UI", 10);
            textBox.Text = value.ToString();
            textBox.TextChanged += TextBox_TextChanged;
            textBox.KeyPress += TextBox_KeyPress;
            textBox.BackColor = Color.White;

            this.Controls.Add(textBox);
            this.Controls.Add(btnUp);
            this.Controls.Add(btnDown);

            this.Size = new Size(120, 30);
            this.MinimumSize = new Size(80, 25);

            KerekitettNumericUpDown_Resize(this, EventArgs.Empty);
            this.Resize += KerekitettNumericUpDown_Resize;
        }

        // --- Gombok Paint eseménykezelői ---
        private void BtnUp_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Növelt belső margó a nyíl és a gomb széle között
            int arrowInnerMargin = 4; // Ezt az értéket növelheted, ha több hely kell

            int availableWidth = btn.Width - 2 * arrowInnerMargin;
            int availableHeight = btn.Height - 2 * arrowInnerMargin;

            // Biztosítsuk, hogy a rendelkezésre álló terület pozitív legyen
            if (availableWidth <= 0 || availableHeight <= 0) return;

            int arrowHeight = (int)(availableHeight * 0.5f); // Nyíl magassága (pl. a rendelkezésre álló magasság fele)
            int arrowWidth = (int)(arrowHeight * 1.5f);     // Nyíl szélessége (pl. magasságának 1.5-szerese)

            // Ne legyen nagyobb a nyíl, mint a rendelkezésre álló hely
            if (arrowWidth > availableWidth) arrowWidth = availableWidth;
            if (arrowHeight > availableHeight) arrowHeight = availableHeight;

            // Középre igazítás a gomb területén belül a margóval
            int startX = arrowInnerMargin + (availableWidth - arrowWidth) / 2;
            int startY = arrowInnerMargin + (availableHeight - arrowHeight) / 2;

            // Felfelé mutató nyíl pontjai
            Point[] triangle = new Point[3];
            triangle[0] = new Point(startX, startY + arrowHeight); // Bal alsó
            triangle[1] = new Point(startX + arrowWidth, startY + arrowHeight); // Jobb alsó
            triangle[2] = new Point(startX + arrowWidth / 2, startY); // Felső csúcs (középen)

            using (SolidBrush brush = new SolidBrush(btn.ForeColor))
            {
                e.Graphics.FillPolygon(brush, triangle);
            }
        }

        private void BtnDown_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int arrowInnerMargin = 4; // Ezt az értéket növelheted, ha több hely kell

            int availableWidth = btn.Width - 2 * arrowInnerMargin;
            int availableHeight = btn.Height - 2 * arrowInnerMargin;

            if (availableWidth <= 0 || availableHeight <= 0) return;

            int arrowHeight = (int)(availableHeight * 0.5f);
            int arrowWidth = (int)(arrowHeight * 1.5f);

            if (arrowWidth > availableWidth) arrowWidth = availableWidth;
            if (arrowHeight > availableHeight) arrowHeight = availableHeight;

            int startX = arrowInnerMargin + (availableWidth - arrowWidth) / 2;
            int startY = arrowInnerMargin + (availableHeight - arrowHeight) / 2;

            // Lefelé mutató nyíl pontjai
            Point[] triangle = new Point[3];
            triangle[0] = new Point(startX, startY); // Bal felső
            triangle[1] = new Point(startX + arrowWidth, startY); // Jobb felső
            triangle[2] = new Point(startX + arrowWidth / 2, startY + arrowHeight); // Alsó csúcs (középen)

            using (SolidBrush brush = new SolidBrush(btn.ForeColor))
            {
                e.Graphics.FillPolygon(brush, triangle);
            }
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            SetValue(value + increment);
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            SetValue(value - increment);
        }

        private void KerekitettNumericUpDown_Resize(object sender, EventArgs e)
        {
            int controlHeight = this.Height;
            int controlWidth = this.Width;

            // Számoljuk ki a keret vastagságát és a belső paddinget pontosabban
            int actualBorderThickness = (int)Math.Ceiling(keretVastagsag);
            int outerPadding = actualBorderThickness + 1; // Egy pici extra hely a kereten kívülről

            int buttonWidth = 28;
            if (controlWidth < buttonWidth + 50)
            {
                buttonWidth = Math.Max(15, controlWidth / 4);
            }

            // Gombok magassága: az összes rendelkezésre álló hely fele, figyelembe véve a külső paddinget és a két gomb közötti rést
            int verticalSpaceForButtons = controlHeight - 2 * outerPadding;
            int buttonHeight = (verticalSpaceForButtons / 2) - 1; // -1 a kis rés miatt a gombok között
            buttonHeight = Math.Max(10, buttonHeight); // Minimum magasság

            // Felfelé gomb elhelyezése
            btnUp.Size = new Size(buttonWidth, buttonHeight);
            btnUp.Location = new Point(controlWidth - buttonWidth - outerPadding, outerPadding);

            // Lefelé gomb elhelyezése
            btnDown.Size = new Size(buttonWidth, buttonHeight);
            btnDown.Location = new Point(controlWidth - buttonWidth - outerPadding, btnUp.Bottom + 2); // +2 pixel rés a két gomb között

            // TextBox méretének és pozíciójának beállítása
            textBox.Location = new Point(outerPadding + 2, (controlHeight - textBox.Height) / 2); // Kicsi extra padding a szövegnek
            textBox.Width = controlWidth - buttonWidth - 2 * outerPadding - 4; // 4 pixel a TextBox belső paddingjének
            textBox.Height = (int)textBox.Font.GetHeight() + 8; // Biztosítsuk, hogy a TextBox magassága elegendő legyen

            btnUp.Invalidate();
            btnDown.Invalidate();
            Invalidate();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',' || e.KeyChar == '.') && (textBox.Text.Contains(",") || textBox.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox.Text.Replace('.', ','), out decimal newVal))
            {
                SetValue(newVal, false);
            }
        }

        private void SetValue(decimal newVal, bool updateTextBox = true)
        {
            if (newVal < minimum) newVal = minimum;
            if (newVal > maximum) newVal = maximum;
            value = newVal;
            if (updateTextBox)
                textBox.Text = value.ToString();

            ValueChanged?.Invoke(this, EventArgs.Empty);
        }

        // --- Tulajdonságok (változatlanul hagytam őket) ---
        [Browsable(true)]
        [Category("Megjelenés")]
        public int Radius
        {
            get => radius;
            set { radius = Math.Max(0, value); Invalidate(); }
        }

        [Browsable(true)]
        [Category("Megjelenés")]
        public Color KeretSzin
        {
            get => keretSzin;
            set { keretSzin = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Megjelenés")]
        public float KeretVastagsag
        {
            get => keretVastagsag;
            set { keretVastagsag = Math.Max(0, value); Invalidate(); }
        }

        [Browsable(true)]
        [Category("Adatok")]
        public decimal Minimum
        {
            get => minimum;
            set
            {
                minimum = value;
                if (this.value < minimum) SetValue(minimum);
            }
        }

        [Browsable(true)]
        [Category("Adatok")]
        public decimal Maximum
        {
            get => maximum;
            set
            {
                maximum = value;
                if (this.value > maximum) SetValue(maximum);
            }
        }

        [Browsable(true)]
        [Category("Adatok")]
        public decimal Increment
        {
            get => increment;
            set { increment = value > 0 ? value : 1; }
        }

        [Browsable(true)]
        [Category("Adatok")]
        public decimal Value
        {
            get => value;
            set { SetValue(value); }
        }

        public event EventHandler ValueChanged;

        // --- Rajzolás (változatlanul hagytam őket) ---
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float halfPen = keretVastagsag / 2f;
            RectangleF rect = new RectangleF(
                halfPen,
                halfPen,
                this.Width - keretVastagsag,
                this.Height - keretVastagsag);

            float r = Math.Min(radius, Math.Min(rect.Width / 2, rect.Height / 2));

            using (GraphicsPath path = CreateRoundedPath(rect, r))
            using (Brush brush = new SolidBrush(this.BackColor == Color.Transparent ? Color.White : this.BackColor))
            using (Pen pen = new Pen(keretSzin, keretVastagsag))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath CreateRoundedPath(RectangleF rect, float radius)
        {
            float d = radius * 2f;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}