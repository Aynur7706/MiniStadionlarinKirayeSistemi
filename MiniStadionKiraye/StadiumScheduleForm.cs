using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniStadionKiraye
{
    public partial class StadiumScheduleForm : Form
    {
        public StadiumScheduleForm()
        {
            InitializeComponent();
            LoadStadiums();
        }

        private void LoadStadiums()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    // IsActive yoxdursa, sadəcə bütün stadionları gətir
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT Id, Name FROM Stadiums", conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbStadium.DataSource = dt;
                    cmbStadium.DisplayMember = "Name";
                    cmbStadium.ValueMember = "Id";
                    cmbStadium.SelectedIndex = -1; // default boş
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stadionları yükləmək mümkün olmadı:\n" + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbStadium.SelectedIndex == -1)
            {
                MessageBox.Show("Stadion seçilməyib!");
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("Saat");
            table.Columns.Add("Status");

            int stadiumId;
            try
            {
                stadiumId = Convert.ToInt32(cmbStadium.SelectedValue);
            }
            catch
            {
                MessageBox.Show("Stadion ID alınamadı!");
                return;
            }

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    for (int hour = 8; hour < 24; hour++)
                    {
                        TimeSpan start = new TimeSpan(hour, 0, 0);

                        // hour + 1 == 24 olarsa, end = 23:59:59
                        TimeSpan end = (hour + 1 < 24) ? new TimeSpan(hour + 1, 0, 0) : new TimeSpan(23, 59, 59);

                        // Saatın dolu olub olmadığını yoxla
                        SqlCommand cmd = new SqlCommand(@"
         SELECT COUNT(*) FROM Reservations
         WHERE StadiumId=@sid AND CAST(Date AS DATE) = @d
         AND NOT (CAST(EndTime AS TIME) <= @s OR CAST(StartTime AS TIME) >= @e)",
                            conn);

                        cmd.Parameters.Add("@sid", SqlDbType.Int).Value = stadiumId;
                        cmd.Parameters.Add("@d", SqlDbType.Date).Value = dtpDate.Value.Date;
                        cmd.Parameters.Add("@s", SqlDbType.Time).Value = start;
                        cmd.Parameters.Add("@e", SqlDbType.Time).Value = end;

                        int count = (int)cmd.ExecuteScalar();

                        string status = count > 0 ? "DOLU ❌" : "BOŞ ✅";
                        table.Rows.Add($"{hour}:00 - {Math.Min(hour + 1, 23)}:59", status);
                    }

                }

                dgvSchedule.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cədvəli yükləmək mümkün olmadı:\n" + ex.Message);
            }
        }
    }
}
