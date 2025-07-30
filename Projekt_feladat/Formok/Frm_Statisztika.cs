using System;
using System.Collections.Generic;

using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Geo;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using MySqlConnector;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.Extensions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Projekt_feladat.Formok
{
    public partial class Frm_Statisztika : Form
    {
        string kapcsolatString = "server=localhost;database=utazast_kezelo;uid=utazast_kezelo;pwd=utazast_kezelo1234;";

        private GeoMap geoMap;
        //private  PieChart pieChart;
        //private CartesianChart oszlopDiagram;
        public Frm_Statisztika()
        {
            InitializeComponent();

        }



        private void geoAdatok() // adatbázis ország összefésülése
        {
            // országokhoz tartozó utaslétszámok tárolására
            Dictionary<string, int> orszagUtasokSzama = new Dictionary<string, int>();
            using var conn = new MySqlConnection(kapcsolatString);
            conn.Open();
            // Lekérdezzük a desztinációt és az utasok számát az utazásokból
            string sql = @"
                SELECT
                    utazas.desztinacio,
                    COUNT(DISTINCT utas_utazasai.utas_id) AS utasok_szama
                FROM utazas
                JOIN utas_utazasai ON utazas.utazas_id = utas_utazasai.utazas_id
                GROUP BY utazas.desztinacio;
            ";
            using var cmd = new MySqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string desztinacio = reader.GetString("desztinacio");
                int utasokSzama = reader.GetInt32("utasok_szama");

                // desztinációátalakítása országkódd
                string orszagKod = OrszagKodDesztinacio(desztinacio);

                if (!string.IsNullOrEmpty(orszagKod))
                {

                    if (orszagUtasokSzama.ContainsKey(orszagKod))
                    {
                        orszagUtasokSzama[orszagKod] += utasokSzama;
                    }
                    else
                    {
                        orszagUtasokSzama.Add(orszagKod, utasokSzama);
                    }
                }
            }

            List<HeatLand> lands = new List<HeatLand>();
            foreach (var entry in orszagUtasokSzama)
            {
                lands.Add(new HeatLand { Name = entry.Key, Value = entry.Value });

            }
            geoMap = new GeoMap
            {
                Series = new IGeoSeries[]
                 {
                    new HeatLandSeries
                    {
                        Lands = lands
                    }
                 },
                MapProjection = MapProjection.Default,
                Location = new Point(0, 10),
                Size = new Size(600, 250),
                Anchor = AnchorStyles.None
            };
            pnl_geopanel.Controls.Add(geoMap);


        }

        private void Frm_Statisztika_Load(object sender, EventArgs e)
        {
            // heat map adatok betöltése
            geoAdatok();
            //kisebb statisztika
            lbl_osszUtas.Text += " " + utasokSzama().ToString();
            lb_utazasokSzama.Text += " " + utazasokSzama().ToString();
            lbl_atlagosUtazasokSzama.Text += " " + idenUtzazokSzama().ToString();
            //utazási tendencia
            utazasiTendencia("yyyy.MM");
            penzugyiTendencia();
            korCsoport();
            utazasiMod();
            Topdesztinaciok();

            for (int i = 0; i < 3; i++)
                flp_egyebStatisztika.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.33F));
        }



        private void utazasiTendencia(string v)
        {
            try
            {
             
                var cim = new Label
                {
                    Text = "Éves utazási tendencia",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = Color.Black,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.TopLeft,
                    Height = 40,
                    Padding = new Padding(10,0,0,0)

                };
                szp_tendencia.Controls.Add(cim);

                List<DateTime> honapok = new();       // X tengely (pl. 2025.03)
                List<double> utasokSzama = new();   // Y tengely értékek

                using var kapcsolatObj = new MySqlConnection(kapcsolatString); // 'kapcsolat' a connection stringed
                kapcsolatObj.Open();

                string lekerdezes = @"SELECT
                 utazas.utazas_ideje,
                 COUNT(DISTINCT utas_utazasai.utas_id) AS utasok_szama 
             FROM
                 utazas
             JOIN
                 utas_utazasai ON utazas.utazas_id = utas_utazasai.utazas_id
             
             GROUP BY
                 utazas.utazas_ideje
             ORDER BY
                 utazas.utazas_ideje DESC limit 10;";

             

                using var parancs = new MySqlCommand(lekerdezes, kapcsolatObj);
                using var reader = parancs.ExecuteReader();


                while (reader.Read())
                {
                    honapok.Add(reader.GetDateTime("utazas_ideje"));
                    utasokSzama.Add(reader.GetInt32("utasok_szama"));
                }

                while (reader.Read())
                {
                    honapok.Add(reader.GetDateTime("utazas_ideje"));
                    utasokSzama.Add(reader.GetInt32("utasok_szama"));
                }

                var diagram = new CartesianChart
                {
                    Series = new ISeries[]
                    {
            new ColumnSeries<double>
            {
                Name = "Utasok száma",
                Rx = 8,
                Ry = 8,
                Values = utasokSzama
            }
                    },
                    XAxes = new Axis[]
                    {
            new Axis
            {
                Labels = honapok.Select(h => h.ToString("yyyy.MM", new CultureInfo("hu-HU"))).ToArray(),
                ForceStepToMin = true,
                MinStep = 1,
                LabelsRotation = 0,
                SeparatorsPaint = new SolidColorPaint(SKColors.Gray)
            }
                    },
                    Dock = DockStyle.Fill,
                    BackColor = Color.WhiteSmoke,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                    Location = new Point(10, cim.Bottom + 5), // 10px beljebb balról és fentről
                    Size = new Size(szp_tendencia.Width - 30, szp_tendencia.Height - cim.Height - 30), // 10px margó jobbra, alulra is
                    Padding = new Padding(5) // belső tartalom paddingje, ha kell
                };
               
                szp_tendencia.Controls.Add(diagram);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba az utazási tendencia betöltésekor: " + ex.Message);
            }
        }

        private void penzugyiTendencia()
        {
            try
            {
               
                szpn_penzugyiJelentes.Controls.Clear();


                var cim = new Label
                {
                    Text = "Utazásonkénti bevétel ",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    TextAlign = ContentAlignment.TopLeft,
                    Padding = new Padding(5, 0, 0, 0),
                    Location = new Point(10, 5)
                };
                szpn_penzugyiJelentes.Controls.Add(cim);


                // Adatok tárolása
                List<ObservablePoint> dataPoints = new();
                List<string> utazasLabels = new();

                using var kapcsolatObj = new MySqlConnection(kapcsolatString);
                kapcsolatObj.Open();

                string lekerdezes = @"
            SELECT u.utazas_id, u.utazas_elnevezese, u.utazas_ideje, u.desztinacio,
                   COALESCE(SUM(f.befizetett_osszeg), 0) AS osszes_befizetes
            FROM utazas u
            LEFT JOIN fizetes f ON f.utas_id IN (
                SELECT utas_id FROM utas_utazasai WHERE utazas_id = u.utazas_id
            )
            GROUP BY u.utazas_id, u.utazas_elnevezese, u.utazas_ideje, u.desztinacio
            ORDER BY u.utazas_ideje DESC
            LIMIT 10;
        ";

                using var parancs = new MySqlCommand(lekerdezes, kapcsolatObj);
                using var reader = parancs.ExecuteReader();

                int index = 0;
                while (reader.Read())
                {
                    string utazasNeve = reader.GetString("utazas_elnevezese");
                    double bevitel = reader.GetDouble("osszes_befizetes");

                    dataPoints.Add(new ObservablePoint(index, bevitel));
                    utazasLabels.Add(utazasNeve);
                    index++;
                }

                // Vonaldiagram létrehozása
                var diagram = new CartesianChart
                {
                    Series = new ISeries[]
                    {


                new LineSeries<ObservablePoint>
                {
                    Name = "Bevétel",
                    Values = dataPoints,
                    Fill = null, // nem kell háttérkitöltés
                    GeometrySize = 10,
                    Stroke = new SolidColorPaint(SKColors.DarkGreen, 3),
                    GeometryFill = new SolidColorPaint(SKColors.DarkGreen),
                    GeometryStroke = new SolidColorPaint(SKColors.White, 2),
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top
                }
                    },
                    XAxes = new Axis[]
                    {
                new Axis
                {
                    Labels = utazasLabels.ToArray(),
                    LabelsRotation = 45,
                    TextSize = 10,
                    SeparatorsPaint = null
                }
                    },
                    YAxes = new Axis[]
                    {
                new Axis
                {
                    Labeler = value => value.ToString("N0") + " Ft",
                    MinStep = 1,
                    SeparatorsPaint = null
                }
                    },
                  
                  



                    Location = new Point(10, cim.Bottom-10 ),
                   
                    Size = new Size(szpn_penzugyiJelentes.Width - 30, szpn_penzugyiJelentes.Height - cim.Height-15 ),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                    BackColor = Color.WhiteSmoke,
                   
                };

                szpn_penzugyiJelentes.Controls.Add(diagram);

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a pénzügyi tendencia betöltésekor: " + ex.Message,
                                "Adatbetöltési hiba",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public void korCsoport()
        {
            var ageGroupRawData = korcsoportLekerdezese();

            if (ageGroupRawData == null || ageGroupRawData.Count == 0)
            {
                MessageBox.Show("Nincs megjeleníthető adat a korcsoportokhoz. Ellenőrizze az adatbázis kapcsolatot és adatokat!",
                                "Adat hiány", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PieChart korDiagram = new PieChart
                {
                    Series = new List<ISeries>(),
                    Size = new Size(150, 150),
                    Dock = DockStyle.Left
                };
                flp_egyebStatisztika.Controls.Add(korDiagram);
                return;
            }
       

            double totalCount = ageGroupRawData.Sum(x => x.Item2);
            var gaugeItems = new List<GaugeItem>();
            Random random = new Random();

            foreach (var item in ageGroupRawData)
            {
                double percentage = (totalCount > 0) ? (item.Item2 / totalCount) * 100 : 0;

                Action<PieSeries<ObservableValue>> setStyleAction = (series) =>
                {
                    series.Name = item.Item1;
                    series.DataLabelsPosition = PolarLabelsPosition.Start;
                    series.DataLabelsFormatter =
                        point => $"{point.Coordinate.PrimaryValue:N1}% {point.Context.Series.Name}";
                    series.InnerRadius = 20;
                    series.RelativeOuterRadius = 1;
                    series.RelativeInnerRadius = 1;
                    series.Fill = new SolidColorPaint(GetRandomColor());
                    series.DataLabelsPaint = new SolidColorPaint(SKColors.Black)
                    {
                        SKTypeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyle.Bold)
                    };
                };

                gaugeItems.Add(new GaugeItem(percentage, setStyleAction));
            }

        
            Label korCimke = new Label
            {
                Text = "Korcsoport Eloszlás (Utasok)",
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                TextAlign = ContentAlignment.TopLeft,
                AutoSize = true,
                Location = new Point(10, 10),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };
            flp_egyebStatisztika.Controls.Add(korCimke);
            korCimke.BringToFront();

            // Diagram hozzáadása a címke alá
            PieChart pieChart = new PieChart
            {
                Series = GaugeGenerator.BuildSolidGauge(gaugeItems.ToArray()),
                InitialRotation = 90,
                MaxAngle = 270,
                MinValue = 0,
                MaxValue = 100,
                Dock = DockStyle.None,
                BackColor = Color.WhiteSmoke,
                Size = new Size(250, 250),
                Location = new Point(10, korCimke.Bottom + 5)
            };

            Panel diagramKeret = new Panel
            {
                //Width = 260,
                //Height = 300,
                Dock = DockStyle.Fill,
                Margin = new Padding(1),
                BackColor = Color.WhiteSmoke
            };
            diagramKeret.Controls.Add(pieChart);
            diagramKeret.Controls.Add(korCimke);
            flp_egyebStatisztika.Controls.Add(diagramKeret);
        }
        private SKColor GetRandomColor()
        {
            Random random = new Random();
            return new SKColor((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256), (byte)200);
        }

       public void utazasiMod()
{


    var travelModeData = utazasiModLekerdezes(); 

    if (travelModeData == null || travelModeData.Count == 0)
    {
        MessageBox.Show("Nincs megjeleníthető adat az utazási módokhoz. Ellenőrizze az adatokat!", "Adat hiány", MessageBoxButtons.OK, MessageBoxIcon.Information);

        PieChart utazasimodDiagramAlap = new PieChart
        {
            Series = new List<ISeries>(),
            Size = new Size(250, 250),
            Dock = DockStyle.Left
        };
                flp_egyebStatisztika.Controls.Add(utazasimodDiagramAlap);
        return;
    }

            Label utazasModCimke = new Label
            {
                Text = "Utazási mód eloszlás",
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                Height = 30,
                Location = new Point(1, 1),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };

        
            List<ISeries> seriesCollection = new();
    int outerOffset = 0;
    Random random = new();

    foreach (var (modNev, darab) in travelModeData)
    {
        var series = new PieSeries<double>
        {
            Values = new[] { (double)darab },
            Name = modNev,
            OuterRadiusOffset = outerOffset,
            DataLabelsPaint = new SolidColorPaint(SKColors.Black)
            {
                SKTypeface = SKTypeface.FromFamilyName("Segoe UI", SKFontStyle.Normal)
            },
            DataLabelsFormatter = point =>
            {
                var modeName = point.Context.Series.Name;
                var pv = point.Coordinate.PrimaryValue;
                var sv = point.StackedValue!;
                return $"{modeName}: {pv} ({sv.Share:P2})";
            },
            ToolTipLabelFormatter = point =>
            {
                var modeName = point.Context.Series.Name;
                var pv = point.Coordinate.PrimaryValue;
                var sv = point.StackedValue!;
                return $" {pv} fő ({sv.Share:P2})";
            },
            Fill = new SolidColorPaint(GetRandomColor())
        };

        seriesCollection.Add(series);
        outerOffset += 10;
    }

   
    PieChart utazasimodDiagram = new PieChart
    {
        Series = seriesCollection,
        InitialRotation = -90,
        Dock = DockStyle.Left,
        Location = new Point(10, utazasModCimke.Bottom + 5),
        BackColor = Color.WhiteSmoke,
       
        Size = new Size(250, 250)
    };


 
            Panel diagramKeret = new Panel
            {
         
                Dock = DockStyle.Fill,
                Margin = new Padding(1),
                BackColor = Color.WhiteSmoke
            };
            diagramKeret.Controls.Add(utazasModCimke);
            diagramKeret.Controls.Add(utazasimodDiagram);           
            flp_egyebStatisztika.Controls.Add(diagramKeret);   
}
        private List<Tuple<string, int>> korcsoportLekerdezese()
        {
            List<Tuple<string, int>> data = new List<Tuple<string, int>>();
            string connectionString = kapcsolatString;

            string query = @"
            SELECT
                CASE
                    WHEN TIMESTAMPDIFF(YEAR, T.szuletesi_datum, CURDATE()) BETWEEN 0 AND 29 THEN '0-29'
                    WHEN TIMESTAMPDIFF(YEAR, T.szuletesi_datum, CURDATE()) BETWEEN 30 AND 45 THEN '30-45'
                    WHEN TIMESTAMPDIFF(YEAR, T.szuletesi_datum, CURDATE()) BETWEEN 46 AND 65 THEN '46-65'
                    WHEN TIMESTAMPDIFF(YEAR, T.szuletesi_datum, CURDATE()) > 65 THEN '65+'
                END AS korcsoport,
                COUNT(*) AS letszam
            FROM
                utas AS T
            WHERE
                T.szuletesi_datum IS NOT NULL
            GROUP BY
                korcsoport
            ORDER BY
                MIN(TIMESTAMPDIFF(YEAR, T.szuletesi_datum, CURDATE()));";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                              
                                data.Add(new Tuple<string, int>(
                                    reader["korcsoport"].ToString(),
                                    Convert.ToInt32(reader["letszam"])
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Adatbázis hiba: {ex.Message}");
                return new List<Tuple<string, int>>();
            }

            return data;
        }
        private List<Tuple<string, int>> utazasiModLekerdezes()
        {
            List<Tuple<string, int>> data = new List<Tuple<string, int>>();
            string connectionString = kapcsolatString;

            string query = @"SELECT utazas.utazas_modja, COUNT(*) AS darabszam
                            FROM utazas
                            GROUP BY utazas_modja
                            ORDER BY darabszam DESC";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                data.Add(new Tuple<string, int>(
                                    reader["utazas_modja"].ToString().Trim(),
                                    Convert.ToInt32(reader["darabszam"])
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Adatbázis hiba: {ex.Message}");
                return new List<Tuple<string, int>>();
            }

            return data;
        }
        private string OrszagKodDesztinacio(string desztinacio)
        {

            string tisztaDesztinacio = desztinacio.Trim().ToLower();

            switch (tisztaDesztinacio)
            {

                case "tokió": return "jpn"; // Japán
                case "london": return "gbr"; // Nagy-Britannia
                case "párizs": return "fra"; // Franciaország
                case "new york": return "usa"; // Egyesült Államok
                case "róma": return "ita"; // Olaszország


                // Európa (1-100)
                case "berlin": return "deu";
                case "madrid": return "esp";
                case "prága": return "cze";
                case "bécs": return "aut";
                case "amsterdam": return "nld";
                case "brüsszel": return "bel";
                case "stockholm": return "swe";
                case "osló": return "nor";
                case "koppenhága": return "dnk";
                case "helsinki": return "fin";
                case "varsó": return "pol";
                case "budapest": return "hun";
                case "lisszabon": return "prt";
                case "dublin": return "irl";
                case "athén": return "grc";
                case "isztambul": return "tur";
                case "moszkva": return "rus";
                case "szentpétervár": return "rus";
                case "dubrovnik": return "hrv";
                case "szarajevó": return "bih";
                case "belgrád": return "srb";
                case "szófia": return "bgr";
                case "kijev": return "ukr";
                case "genf": return "che";
                case "zürich": return "che";
                case "milánó": return "ita";
                case "velence": return "ita";
                case "barcelona": return "esp";
                case "porto": return "prt";
                case "bruges": return "bel";
                case "strasbourg": return "fra";
                case "lyon": return "fra";
                case "marseille": return "fra";
                case "edinburg": return "gbr";
                case "manchester": return "gbr";
                case "liverpool": return "gbr";
                case "frankfurt": return "deu";
                case "münchen": return "deu";
                case "hamburg": return "deu";
                case "drezda": return "deu";
                case "köln": return "deu";
                case "split": return "hrv";
                case "rig": return "lva"; // Lettország
                case "vilnius": return "ltu"; // Litvánia
                case "tallinn": return "est"; // Észtország
                case "minsk": return "blr"; // Fehéroroszország
                case "krakkó": return "pol";
                case "gdansk": return "pol";
                case "wroclaw": return "pol";
                case "bratislava": return "svk"; // Szlovákia
                case "ljubljana": return "svn"; // Szlovénia
                case "odessza": return "ukr";
                case "lvov": return "ukr";
                case "chișinău": return "mda"; // Moldova
                case "tirana": return "alb"; // Albánia
                case "skopje": return "mkd"; // Észak-Macedónia
                case "podgorica": return "mne"; // Montenegró
                case "priština": return "kos"; // Koszovó
                case "valletta": return "mlt"; // Málta
                case "nicosia": return "cyp"; // Ciprus
                case "reykjavík": return "isl"; // Izland
                case "feröer szigetek": return "fro"; // Feröer-szigetek
                case "számos": return "grc";
                case "kréta": return "grc";
                case "rodosz": return "grc";
                case "santorini": return "grc";
                case "mykonos": return "grc";
                case "nápoly": return "ita";
                case "firenze": return "ita";
                case "torinó": return "ita";
                case "genova": return "ita";
                case "bologna": return "ita";
                case "seville": return "esp";
                case "valencia": return "esp";
                case "malaga": return "esp";
                case "granada": return "esp";
                case "bilbao": return "esp";
                case "nantes": return "fra";
                case "bordeaux": return "fra";
                case "nice": return "fra";
                case "cannes": return "fra";
                case "monaco": return "mco"; // Monaco
                case "luxembourg város": return "lux"; // Luxemburg
                case "vaticánváros": return "vat"; // Vatikán
                case "anderlecht": return "bel";
                case "rotterdam": return "nld";
                case "haga": return "nld";
                case "antwerpen": return "bel";
                case "ghent": return "bel";
                case "salzburg": return "aut";
                case "graz": return "aut";
                case "innsbruck": return "aut";
                case "linz": return "aut";
                case "poznan": return "pol";
                case "lodz": return "pol";
                case "szczecin": return "pol";
                case "debarkáló": return "hun";
                case "szeged": return "hun";
                case "pécs": return "hun";

                // Észak-Amerika (101-200)
                case "toronto": return "can";
                case "vancouver": return "can";
                case "montreal": return "can";
                case "ottawa": return "can";
                case "calgary": return "can";
                case "edmonton": return "can";
                case "halifax": return "can";
                case "quebec város": return "can";
                case "winnipeg": return "can";
                case "mexikóváros": return "mex";
                case "guadalajara": return "mex";
                case "monterrey": return "mex";
                case "cancun": return "mex";
                case "san francisco": return "usa";
                case "los angeles": return "usa";
                case "chicago": return "usa";
                case "miami": return "usa";
                case "orlando": return "usa";
                case "boston": return "usa";
                case "philadelphia": return "usa";
                case "seattle": return "usa";
                case "denver": return "usa";
                case "las vegas": return "usa";
                case "houston": return "usa";
                case "dallas": return "usa";
                case "atlanta": return "usa";
                case "washington": return "usa";
                case "new orleans": return "usa";
                case "san diego": return "usa";
                case "phoenix": return "usa";
                case "austin": return "usa";
                case "nashville": return "usa";
                case "detroit": return "usa";
                case "cleveland": return "usa";
                case "minneapolis": return "usa";
                case "st. louis": return "usa";
                case "charlotte": return "usa";
                case "salt lake city": return "usa";
                case "portland": return "usa";
                case "honolulu": return "usa";
                case "anchorage": return "usa";
                case "sydney, nova scotia": return "can";
                case "victoria": return "can";
                case "regina": return "can";
                case "saskatoon": return "can";
                case "santiago de cuba": return "cub"; // Kuba
                case "havanna": return "cub";
                case "santo domingo": return "dom"; // Dominikai Köztársaság
                case "san juan": return "pri"; // Puerto Rico
                case "kingston": return "jam"; // Jamaica
                case "port-au-prince": return "hti"; // Haiti
                case "nassau": return "bhs"; // Bahamák
                case "castries": return "lca"; // Saint Lucia
                case "bridgetown": return "brb"; // Barbados
                case "st. george's": return "grd"; // Grenada
                case "port of spain": return "tto"; // Trinidad és Tobago
                case "panamaváros": return "pan"; // Panama
                case "san josé": return "cri"; // Costa Rica
                case "managua": return "nic"; // Nicaragua
                case "san salvador": return "slv"; // El Salvador
                case "tegucigalpa": return "hnd"; // Honduras
                case "guatemalaváros": return "gtm"; // Guatemala
                case "belize city": return "blz"; // Belize
                case "puebla": return "mex";
                case "tijuana": return "mex";
                case "juárez": return "mex";
                case "acapulco": return "mex";
                case "veracruz": return "mex";
                case "cuernavaca": return "mex";
                case "charleston": return "usa";
                case "savannah": return "usa";
                case "key west": return "usa";
                case "sarasota": return "usa";
                case "tampa": return "usa";
                case "newport": return "usa";
                case "providence": return "usa";
                case "albany": return "usa";
                case "buffalo": return "usa";
                case "rochester": return "usa";
                case "pittsburgh": return "usa";
                case "baltimore": return "usa";
                case "richmond": return "usa";
                case "virginia beach": return "usa";
                case "columbus": return "usa";
                case "indianapolis": return "usa";
                case "kansas city": return "usa";
                case "omaha": return "usa";
                case "albuquerque": return "usa";
                case "reno": return "usa";
                case "boise": return "usa";
                case "juneau": return "usa";
                case "hilo": return "usa";
                case "maui": return "usa";

                // Dél-Amerika (201-250)
                case "rio de janeiró": return "bra";
                case "buenos aires": return "arg";
                case "lima": return "per";
                case "bogotá": return "col";
                case "santiago": return "chl";
                case "caracas": return "ven";
                case "quito": return "ecu"; // Ecuador
                case "la paz": return "bol"; // Bolívia
                case "montevideó": return "ury"; // Uruguay
                case "aszunción": return "pry"; // Paraguay
                case "brazíliaváros": return "bra";
                case "são paulo": return "bra";
                case "salvador": return "bra";
                case "recife": return "bra";
                case "fortaleza": return "bra";
                case "cordoba": return "arg";
                case "rosario": return "arg";
                case "cuscó": return "per";
                case "medellín": return "col";
                case "cartagena": return "col";
                case "valparaíso": return "chl";
                case "arequipa": return "per";
                case "barranquilla": return "col";
                case "guayaquil": return "ecu";
                case "cali": return "col";
                case "santa cruz": return "bol";
                case "sucre": return "bol";
                case "colonia del sacramento": return "ury";
                case "iguazu falls": return "arg"; // Vagy bra
                case "ushuaia": return "arg";
                case "punta arenas": return "chl";
                case "falkland-szigetek": return "flk"; // Falkland-szigetek
                case "galapagos szigetek": return "ecu";
                case "georgetown": return "guy"; // Guyana
                case "paramaribo": return "sur"; // Suriname
                case "cayenne": return "guf"; // Francia Guyana
                case "manaos": return "bra";
                case "belém": return "bra";
                case "natal": return "bra";
                case "maceió": return "bra";
                case "cuzco": return "per";
                case "trujillo": return "per";
                case "chiclayo": return "per";
                case "cajamarca": return "per";
                case "iquitos": return "per";
                case "pastó": return "col";
                case "bucaramanga": return "col";
                case "cúcuta": return "col";
                case "villavicencio": return "col";
                case "barquisimeto": return "ven";

                // Ázsia, Afrika, Ausztrália (251-300+)
                case "peking": return "chn";
                case "sanghaj": return "chn";
                case "dubaj": return "are";
                case "szingapúr": return "sgp";
                case "bangkok": return "tha";
                case "szöul": return "kor";
                case "hong kong": return "hkg";
                case "new delhi": return "ind";
                case "mumbai": return "ind";
                case "tel-aviv": return "isr";
                case "kuala lumpur": return "mys";
                case "jakarta": return "idn";
                case "manila": return "phl";
                case "hanói": return "vnm";
                case "ho chi minh város": return "vnm";
                case "sydney": return "aus";
                case "melbourne": return "aus";
                case "auckland": return "nzl";
                case "wellington": return "nzl";
                case "kairó": return "egy";
                case "fokváros": return "zaf";
                case "johannesburg": return "zaf";
                case "nairobi": return "ken";
                case "addisz-abeba": return "eth";
                case "casablanca": return "mar";
                case "tunisz": return "tun";
                case "algír": return "dza";
                case "lagos": return "nga";
                case "doha": return "qat";
                case "rijád": return "sau";
                case "bejrút": return "lbn";
                case "abu dhabi": return "are";
                case "amman": return "jor"; // Jordánia
                case "kuwait city": return "kwt"; // Kuvait
                case "dámszkusz": return "syr"; // Szíria (ha használod)
                case "teherán": return "irn";
                case "bagdad": return "irq";
                case "jeruzsálem": return "isr";
                case "tokyo": return "jpn"; // Ismétlés, ha más írásmód is előfordulhat
                case "osaka": return "jpn";
                case "kyoto": return "jpn";
                case "nagoya": return "jpn";
                case "fukuoka": return "jpn";
                case "daegu": return "kor";
                case "busan": return "kor";
                case "phuket": return "tha";
                case "chiang mai": return "tha";
                case "bali": return "idn";
                case "kolombo": return "lka"; // Srí Lanka
                case "male": return "mdv"; // Maldív-szigetek
                case "seychelles": return "syc"; // Seychelle-szigetek
                case "mauritius": return "mus"; // Mauritius
                case "dar es salaam": return "tza"; // Tanzánia
                case "kampala": return "uga"; // Uganda
                case "kigali": return "rwa"; // Ruanda
                case "lusaka": return "zmb"; // Zambia
                case "harare": return "zwe"; // Zimbabwe
                case "maputó": return "moz"; // Mozambik
                case "antalya": return "tur";
                case "izmir": return "tur";
                case "ankara": return "tur";
                case "dammam": return "sau";
                case "jeddah": return "sau";
                case "medina": return "sau";
                case "maskat": return "omn"; // Omán
                case "baku": return "aze"; // Azerbajdzsán
                case "tbiliszi": return "geo"; // Grúzia
                case "ereván": return "arm"; // Örményország
                case "taskent": return "uzb"; // Üzbegisztán
                case "asztana": return "kaz"; // Kazahsztán
                case "ulaanbaatar": return "mng"; // Mongólia
                case "vladivostok": return "rus";
                case "novoszibirszk": return "rus";
                case "irkutszk": return "rus";
                case "adelaide": return "aus";
                case "brisbane": return "aus";
                case "perth": return "aus";
                case "christchurch": return "nzl";
                case "queenstown": return "nzl";
                case "fiji": return "fji"; // Fidzsi-szigetek
                case "tahiti": return "pyf"; // Francia Polinézia
                case "papeete": return "pyf"; // Francia Polinézia
                case "noumea": return "ncl"; // Új-Kaledónia
                case "port moresby": return "png"; // Pápua Új-Guinea
                case "manado": return "idn";
                case "surabaya": return "idn";
                case "yogyakarta": return "idn";
                case "makassar": return "idn";
                case "bandung": return "idn";
                case "penang": return "mys";
                case "kota kinabalu": return "mys";
                case "ho chi minh city": return "vnm"; // Esetleges angol írásmód
                case "hanoi": return "vnm"; // Esetleges angol írásmód
                case "da nang": return "vnm";
                case "hue": return "vnm";
                case "nha trang": return "vnm";
                case "cebu": return "phl";
                case "davao": return "phl";
                case "boracay": return "phl";
                case "siem reap": return "khm"; // Kambodzsa
                case "phnom penh": return "khm";
                case "vientiane": return "lao"; // Laosz
                case "yangon": return "mmr"; // Mianmar
                case "mandala": return "mmr";

                default:

                    return null;
            }
        }

        private void Frm_Statisztika_Resize(object sender, EventArgs e)
        {

            ablakUjraRendezes();
        }
        private void ablakUjraRendezes()
        {
         
            if (geoMap == null) return;

            int geoMapX;

            if (this.ClientSize.Width > 1200)
            {

                geoMapX = (this.ClientSize.Width - geoMap.Width) / 2;
            }
            else
            {


                geoMap.Dock = DockStyle.Top;


                geoMapX = this.ClientSize.Width - geoMap.Width;
            }

            int geoMapY = 30; // felül maradjon

            geoMap.Location = new Point(geoMapX, geoMapY);

            // További vezérlők igazítása (példák)
            szpn_atlagosUtazasokSzama.Location = new Point(
                this.ClientSize.Width - szpn_atlagosUtazasokSzama.Width - 10,
                geoMapY + 10
            );

            szpn_utazasokSzama.Location = new Point((this.ClientRectangle.Width / 2) + szpn_utazasokSzama.Width ,  geoMap.Height -50);
            flp_egyebStatisztika.ColumnStyles.Clear();
            for (int i = 0; i < 3; i++)
                flp_egyebStatisztika.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));


        }

        private int utasokSzama()
        {
            int utasokSzama = 0;

            try
            {
                using var kapcsolatObj = new MySqlConnection(kapcsolatString); // "kapcsolat" = connection stringed
                kapcsolatObj.Open();

                string lekerdezes = @"SELECT COUNT( utas.utas_id) AS utasok_szama FROM utas;";

                using var parancs = new MySqlCommand(lekerdezes, kapcsolatObj);
                object eredmeny = parancs.ExecuteScalar();

                if (eredmeny != null && int.TryParse(eredmeny.ToString(), out int szam))
                {
                    utasokSzama = szam;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a lekérdezés során: {ex.Message}");
            }

            return utasokSzama;

        }
        private int utazasokSzama()
        {
            int utazasokSzama = 0;

            try
            {
                using var kapcsolatObj = new MySqlConnection(kapcsolatString); // "kapcsolat" = connection stringed
                kapcsolatObj.Open();

                string lekerdezes = @"
        SELECT COUNT( utazas.utazas_id) AS utazasok_szama FROM utazas;
    ";

                using var parancs = new MySqlCommand(lekerdezes, kapcsolatObj);
                object eredmeny = parancs.ExecuteScalar();

                if (eredmeny != null && int.TryParse(eredmeny.ToString(), out int szam))
                {
                    utazasokSzama = szam;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a lekérdezés során: {ex.Message}");
            }

            return utazasokSzama;

        }
        private int idenUtzazokSzama()
        {
            int utazasokSzama = 0;

            try
            {
                using var kapcsolatObj = new MySqlConnection(kapcsolatString ); // "kapcsolat" = connection stringed
                kapcsolatObj.Open();

                string lekerdezes = @"SELECT 
                                        COUNT(DISTINCT uu.utas_id) AS iden_utazok_szama
                                    FROM utas_utazasai uu
                                    JOIN utazas u ON uu.utazas_id = u.utazas_id
                                    WHERE YEAR(u.utazas_ideje) = YEAR(NOW());
                                    ";

                using var parancs = new MySqlCommand(lekerdezes, kapcsolatObj);
                object eredmeny = parancs.ExecuteScalar();

                if (eredmeny != null && int.TryParse(eredmeny.ToString(), out int szam))
                {
                    utazasokSzama = szam;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a lekérdezés során: {ex.Message}");
            }

            return utazasokSzama;

        }

        public void Topdesztinaciok()
        {
            var lista = new List<(string desztinacio, int utasokSzama)>();


            Label desztinacioCimke = new Label
            {
                Text = "Legkeresettebb desztinációk",
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                  AutoSize = true,
                Height = 30,
                Dock = DockStyle.Top,
             
                ForeColor = Color.Black,
          
                BackColor = Color.Transparent
            };

            // --- Lekérdezés az adatbázisból ---
            using (var kapcsolat = new MySqlConnection(kapcsolatString))
            {
                kapcsolat.Open();
                var parancs = new MySqlCommand(@"
            SELECT u.desztinacio, COUNT(uu.utas_id) AS utasszam
            FROM utazas u
            LEFT JOIN utas_utazasai uu ON u.utazas_id = uu.utazas_id
            GROUP BY u.desztinacio
            ORDER BY utasszam DESC
            LIMIT 8;
        ", kapcsolat);

                using var reader = parancs.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add((
                        reader.GetString("desztinacio"),
                        reader.GetInt32("utasszam")
                    ));
                }
            }

            // --- PieSeries generálása ---
            var series = new List<ISeries>();
            foreach (var (desztinacio, utasszam) in lista)
            {
                series.Add(new PieSeries<int>
                {
                    Values = new[] { utasszam },
                    Name = desztinacio,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.End,
                    DataLabelsSize = 0,
           
                    DataLabelsPaint = new SolidColorPaint(SKColors.Red),


                    DataLabelsFormatter = point => "",


                    ToolTipLabelFormatter = point => $"{point.StackedValue!.Share:P0}"
                });
            }

            // --- PieChart létrehozása ---
            var pieChart = new PieChart
            {
                Series = series,
                IsClockwise = true,
                InitialRotation = 0,
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
                LegendPosition = LiveChartsCore.Measure.LegendPosition.Right,
              Size = new Size(350,300),
              
                BackColor = System.Drawing.Color.WhiteSmoke
            };
            Panel diagramKeret = new Panel
            {
                
                Dock = DockStyle.Fill,
                Margin = new Padding(1),
                BackColor = Color.WhiteSmoke
            };
            diagramKeret.Controls.Add(desztinacioCimke);
            diagramKeret.Controls.Add(pieChart);
           
            desztinacioCimke.BringToFront();
            flp_egyebStatisztika.Controls.Add(diagramKeret);   

          
        }

        private void flp_rendezoPanel_Resize(object sender, EventArgs e)
        {
                foreach (Control ctrl in flp_rendezoPanel.Controls)// a flow panel tartalmát át kell méretezni mert maguktól nem akarnak
                {
                    ctrl.Width = flp_rendezoPanel.ClientSize.Width - flp_rendezoPanel.Padding.Horizontal;
                }
            
        }
    }

}
