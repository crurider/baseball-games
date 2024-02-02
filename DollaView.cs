using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballGames
{
    public partial class DollaView : Form
    {
        public double NORMAL_PER_PITCH { get; set; }
        public double PRO_PER_PITCH { get; set; }

        public DollaView()
        {
            InitializeComponent();
            LoadConfig();
            SelectData();
        }

        private void LoadConfig()
        {
            var jsonConfig = File.ReadAllText("appsettings.json");
            var configObject = JsonSerializer.Deserialize<Configuration>(jsonConfig);

            NORMAL_PER_PITCH = configObject.configuration.NORMAL_PER_PITCH;
            PRO_PER_PITCH = configObject.configuration.PRO_PER_PITCH;
        }

        private void SelectData()
        {
            using (var connection = new SQLiteConnection("Data Source=BaseballGames.db"))
            {
                connection.Open();

                using (var command = new SQLiteCommand("SELECT count(*) \r\nFROM BaseballGames \r\nWHERE strftime('%Y-%m', Datum) = strftime('%Y-%m', 'now');", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int brojTekmi = reader.GetInt32(0);
                            lblBrojUtakmica.Text += brojTekmi.ToString();
                        }
                    }
                }

                double totalCollege = 0;
                double totalPro = 0;
                double totalSoft = 0;
                double totalDolla = 0;

                using (var command = new SQLiteCommand("SELECT pitches, pro, soft FROM BaseballGames WHERE strftime('%Y-%m', Datum) = strftime('%Y-%m', 'now');", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int pitches = reader.GetInt32(0);
                            bool pro = reader.GetBoolean(1);
                            bool soft = reader.GetBoolean(2);

                            if (pro && !soft) { totalPro += pitches * PRO_PER_PITCH; }
                            else if (soft && !pro) { totalSoft += pitches * NORMAL_PER_PITCH; }
                            else totalCollege += pitches * NORMAL_PER_PITCH;

                            totalDolla = (totalPro + totalSoft + totalCollege);
                        }
                    }
                }

                lblCollege.Text += totalCollege.ToString("0.00") + " $";
                lblPro.Text += totalPro.ToString("0.00") + " $";
                lblSoft.Text += totalSoft.ToString("0.00") + " $";
                lblTotal.Text += totalDolla.ToString("0.00") + " $";
            }
        }
    }
}
