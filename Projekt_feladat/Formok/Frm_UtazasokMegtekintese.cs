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

        private void roundedComboBox1_Load(object sender, EventArgs e)
        {
            roundedComboBox1.ElemKivalasztva += (s, e) =>
            {
                using (var mc_mysqlcon = new MySqlConnection(constr))
                {
                    var dt = new DataTable();
                    String sql = "SELECT sorszam as Sorszám, nev as Név, szuletesi_ev as 'Születési éve', halalanak_eve as 'Halálának éve', nemzetseg as 'Nemzetiség' From szerzok"; // A lekérdezés vége hiányzik a képről
                   // var cmd = new MySqlCommand(sql, mc_mysqlcon);
                    var cmd = new MySqlCommand("SELECT * FROM szerzok", mc_mysqlcon); // Kikommentelt sor
                    var da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                   dataGridView1.DataSource = dt;
                }
            };
        }
    }
}
