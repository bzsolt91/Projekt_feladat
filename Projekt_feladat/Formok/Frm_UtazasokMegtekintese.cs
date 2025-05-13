using MySqlConnector;
using Projekt_feladat.egyeni_vezerlok;
using System.Data;

namespace Projekt_feladat.Formok
{
    public partial class Frm_UtazasokMegtekintese : Form
    {
        string constr;
        public Frm_UtazasokMegtekintese()
        {
            InitializeComponent();
            constr = String.Format("Server={0};User ID={1};Password={2};Database={3}", "127.0.0.1", "root", "", "oktav");

        }
        private void vizualisrendezes()
        {


            int spacing = 100;

            int formWidth = this.Width;
            int totalWidth = 3 * roundedComboBox1.Width + 2 * spacing;
            int startX = (formWidth - totalWidth) / 2;
            int y = 10;

            roundedComboBox1.SetBounds(startX, y, roundedComboBox1.Width, roundedComboBox1.Height);
            roundedComboBox2.SetBounds(startX + roundedComboBox2.Width + spacing, y, roundedComboBox2.Width, roundedComboBox2.Height);
            roundedComboBox3.SetBounds(startX + 2 * (roundedComboBox3.Width + spacing), y, roundedComboBox3.Width, roundedComboBox3.Height);

            this.Controls.Add(roundedComboBox1);
            this.Controls.Add(roundedComboBox2);
            this.Controls.Add(roundedComboBox3);

            // === DataGridView pozicionálása alá ===
            dataGridView1.Location = new Point(10, y + roundedComboBox1.Height + 15);
            dataGridView1.Size = new Size(this.Width - 20, this.Height - (y + roundedComboBox1.Height + 25));
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(dataGridView1);
        }

        private void MeretezdCellakAlapjan(DataGridView dgv)

        {
            
            using (Graphics g = dgv.CreateGraphics())
            {
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    int maxWidth = 0;

                    // Mérjük meg a cellák szövegét
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow && row.Cells[col.Index].Value != null)
                        {
                            string cellaSzoveg = row.Cells[col.Index].Value.ToString();
                            SizeF cellaMeret = g.MeasureString(cellaSzoveg, dgv.DefaultCellStyle.Font);
                            int cellaSzelesseg = (int)Math.Ceiling(cellaMeret.Width);
                            if (cellaSzelesseg > maxWidth)
                                maxWidth = cellaSzelesseg;
                        }
                    }

                    // Mérjük meg a fejléc szövegét a fejléc fontjával
                    string fejlecSzoveg = col.HeaderText;
                    Font fejlecFont = col.HeaderCell.Style.Font ?? dgv.ColumnHeadersDefaultCellStyle.Font ?? dgv.Font;
                    SizeF fejlecMeret = g.MeasureString(fejlecSzoveg, fejlecFont);
                    int fejlecSzelesseg = (int)Math.Ceiling(fejlecMeret.Width);

                    // A kettő közül a nagyobb, + némi margó
                    col.Width = Math.Max(maxWidth, fejlecSzelesseg) + 20;
                }
            }
        }
        private void roundedComboBox1_Load(object sender, EventArgs e)
        {
            roundedComboBox1.ElemKivalasztva += (s, e) =>
            {
                using (var mc_mysqlcon = new MySqlConnection(constr))
                {
                    var dt = new DataTable();
                    String sql = "SELECT sorszam as Sorszám, nev as Név, szuletesi_ev as 'Születési éve', halalanak_eve as 'Halálának éve', nemzetseg as 'Nemzetiség' From szerzok"; // A lekérdezés vége hiányzik a képről
                    var cmd = new MySqlCommand(sql, mc_mysqlcon);
                    //23-36var cmd = new MySqlCommand("SELECT * FROM szerzok", mc_mysqlcon); // Kikommentelt sor
                    var da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            };
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
                col.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            }
            MeretezdCellakAlapjan(dataGridView1);
        }
    }
}
