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

namespace BaseballGames {
    public partial class DollaView : Form {
        public DollaView() {
            InitializeComponent();
            SelectData();
        }

        private void SelectData() {
            using (var connection = new SQLiteConnection("Data Source=BaseballGames.db")) {
                connection.Open();

                using (var command = new SQLiteCommand("SELECT count(*) FROM BaseballGames WHERE strftime('%Y-%m', Datum) = strftime('%Y-%m', 'now');", connection)) {
                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            int brojTekmi = reader.GetInt32(0);
                            lblBrojUtakmicaValue.Text = brojTekmi.ToString();
                        }
                    }
                }

                double totalCollege = 0;
                double totalPro = 0;
                double totalSoft = 0;
                double totalDolla = 0;

                using (var command = new SQLiteCommand("SELECT pitches, pro, soft, amount FROM BaseballGames WHERE strftime('%Y-%m', Datum) = strftime('%Y-%m', 'now');", connection)) {
                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            int pitches = reader.GetInt32(0);
                            bool pro = reader.GetBoolean(1);
                            bool soft = reader.GetBoolean(2);
                            double amount = reader.GetDouble(3);

                            if (pro && !soft) totalPro += amount;
                            else if (soft && !pro) totalSoft += amount;
                            else totalCollege += amount;

                            totalDolla = (totalPro + totalSoft + totalCollege);
                        }
                    }
                }

                lblCollegeValue.Text = totalCollege.ToString("0.00") + " $";
                lblProValue.Text = totalPro.ToString("0.00") + " $";
                lblSoftValue.Text = totalSoft.ToString("0.00") + " $";
                lblTotalValue.Text = totalDolla.ToString("0.00") + " $";

                string last3query = @"
                    SELECT
                            CASE
                                WHEN strftime('%m', Datum) = '01' THEN 'Januar'
                                WHEN strftime('%m', Datum) = '02' THEN 'Februar'
                                WHEN strftime('%m', Datum) = '03' THEN 'Mart'
                                WHEN strftime('%m', Datum) = '04' THEN 'April'
                                WHEN strftime('%m', Datum) = '05' THEN 'Maj'
                                WHEN strftime('%m', Datum) = '06' THEN 'Jun'
                                WHEN strftime('%m', Datum) = '07' THEN 'Jul'
                                WHEN strftime('%m', Datum) = '08' THEN 'Avgust'
                                WHEN strftime('%m', Datum) = '09' THEN 'Septembar'
                                WHEN strftime('%m', Datum) = '10' THEN 'Oktobar'
                                WHEN strftime('%m', Datum) = '11' THEN 'Novembar'
                                ELSE 'Decembar'
                            END AS Mesec,
                            CAST(SUM(amount) AS TEXT) || ' $' AS Zarada
                    FROM BaseballGames
                    WHERE Datum < date('now', '-1 month')
                            AND Datum >= date('now', '-4 month')
                    GROUP BY strftime('%Y', Datum), strftime('%m', Datum)
                    ORDER BY strftime('%Y', Datum) DESC, strftime('%m', Datum) DESC;";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(last3query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
        }

        // clear selection hack
        private void DollaView_Load(object sender, EventArgs e) {
            dataGridView.ClearSelection();
        }
    }
}
