using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace BaseballGames
{
    public partial class BaseballGames : Form
    {
        bool inputValid;

        public BaseballGames()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection("Data Source=BaseballGames.db"))
            {
                connection.Open();

                using (var command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS BaseballGames (Id INTEGER PRIMARY KEY AUTOINCREMENT, Datum TEXT, GameId INTEGER, Pitches INTEGER, Pro INTEGER, Soft INTEGER);", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InsertData()
        {
            try
            {
                inputValid = true;

                using (var connection = new SQLiteConnection("Data Source=BaseballGames.db"))
                {
                    connection.Open();

                    var model = new BaseballGameModel
                    {
                        Datum = DateTime.Now
                    };

                    if (!IsValidPositiveInteger(txtGameid.Text))
                    {
                        MessageBox.Show("Polje 'GAMEID' mora biti validan pozitivan broj!", "Greška prilikom unosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        inputValid = false;
                    }

                    if (!IsValidPositiveInteger(txtPitches.Text))
                    {
                        MessageBox.Show("Polje 'PITCHES' mora biti validan pozitivan broj!", "Greška prilikom unosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        inputValid = false;
                    }

                    model.GameId = int.Parse(txtGameid.Text);
                    model.Pitches = int.Parse(txtPitches.Text);
                    model.Pro = checkBoxPro.Checked;
                    model.Soft = checkBoxSoft.Checked;

                    if (inputValid)
                    {
                        using (var transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                using (var command = new SQLiteCommand("INSERT INTO BaseballGames (Datum, GameId, Pitches, Pro, Soft) VALUES (@Datum, @GameId, @Pitches, @Pro, @Soft);", connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@Datum", model.Datum);
                                    command.Parameters.AddWithValue("@GameId", model.GameId);
                                    command.Parameters.AddWithValue("@Pitches", model.Pitches);
                                    command.Parameters.AddWithValue("@Pro", model.Pro);
                                    command.Parameters.AddWithValue("@Soft", model.Soft);

                                    command.ExecuteNonQuery();
                                }

                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"Greška prilikom unosa podataka: {ex.Message}", "Greška prilikom unosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom otvaranja veze s bazom podataka: {ex.Message}");
            }
        }

        private bool IsValidPositiveInteger(string input)
        {
            return !string.IsNullOrEmpty(input) && Regex.IsMatch(input, @"^[1-9]\d*$");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                InsertData();

                if (inputValid)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom unosa podataka: {ex.Message}");
            }
        }

        private void buttonDolla_Click(object sender, EventArgs e)
        {
            buttonDolla.Enabled = false;

            DollaView dv = new DollaView();

            dv.StartPosition = FormStartPosition.CenterScreen;
            dv.FormClosed += (s, args) => buttonDolla.Enabled = true;

            dv.Show(this);
        }
    }
}
