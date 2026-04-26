using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniStadionKiraye
{
    public partial class ReservationForm : Form
    {
        decimal pricePerHour = 0;

        public ReservationForm()
        {
            InitializeComponent();
            LoadStadiums();
            LoadCustomers();
            LoadReservations();
        }

        void LoadStadiums()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT Id, Name, PricePerHour FROM Stadiums", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbStadium.DataSource = dt;
                cmbStadium.DisplayMember = "Name";
                cmbStadium.ValueMember = "Id";
                cmbStadium.SelectedIndex = -1; // default boş
            }
        }

        void LoadCustomers()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT Id, FullName FROM Customers", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCustomer.DataSource = dt;
                cmbCustomer.DisplayMember = "FullName";
                cmbCustomer.ValueMember = "Id";
                cmbCustomer.SelectedIndex = -1; // default boş
            }
        }

        void LoadReservations()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT r.Id, s.Name AS Stadion, c.FullName AS Müştəri,
                           r.Date, r.StartTime, r.EndTime, r.TotalPrice
                    FROM Reservations r
                    JOIN Stadiums s ON r.StadiumId = s.Id
                    JOIN Customers c ON r.CustomerId = c.Id", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReservations.DataSource = dt;
            }
        }

        private void CalculateTotal(object sender, EventArgs e)
        {
            if (cmbStadium.SelectedValue == null) return;

            int stadiumId = Convert.ToInt32(cmbStadium.SelectedValue);

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT PricePerHour FROM Stadiums WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", stadiumId);
                pricePerHour = Convert.ToDecimal(cmd.ExecuteScalar());
            }

            TimeSpan diff = dtpEnd.Value - dtpStart.Value;
            if (diff.TotalHours <= 0)
            {
                lblTotal.Text = "Toplam: 0 AZN";
                return;
            }

            decimal total = Math.Round((decimal)diff.TotalHours * pricePerHour, 2);
            lblTotal.Text = "Toplam: " + total + " AZN";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpEnd.Value <= dtpStart.Value)
            {
                MessageBox.Show("Saat düzgün deyil");
                return;
            }

            if (cmbStadium.SelectedValue == null || cmbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Stadion və ya Müştəri seçilməyib!");
                return;
            }

            int stadiumId = Convert.ToInt32(cmbStadium.SelectedValue);
            int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                // Boşluq yoxlama
                SqlCommand check = new SqlCommand(@"
                    SELECT COUNT(*) FROM Reservations
                    WHERE StadiumId=@sid AND Date=@d
                    AND (@s < EndTime AND @e > StartTime)", conn);

                check.Parameters.AddWithValue("@sid", stadiumId);
                check.Parameters.AddWithValue("@d", dtpDate.Value.Date);
                check.Parameters.AddWithValue("@s", dtpStart.Value.TimeOfDay);
                // EndTime 24:00-ı keçməsin deyə 23:59:59 ilə məhdudlaşdırırıq
                TimeSpan endTime = dtpEnd.Value.TimeOfDay;
                if (endTime.TotalHours >= 24) endTime = new TimeSpan(23, 59, 59);
                check.Parameters.AddWithValue("@e", endTime);

                int exists = (int)check.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Bu saatda stadion doludur ❌");
                    return;
                }

                // Ümumi qiymət hesabı
                TimeSpan diff = dtpEnd.Value - dtpStart.Value;
                decimal total = (decimal)diff.TotalHours * pricePerHour;

                SqlCommand insert = new SqlCommand(@"
                    INSERT INTO Reservations
                    (StadiumId, CustomerId, Date, StartTime, EndTime, TotalPrice)
                    VALUES (@sid,@cid,@d,@s,@e,@t)", conn);

                insert.Parameters.AddWithValue("@sid", stadiumId);
                insert.Parameters.AddWithValue("@cid", customerId);
                insert.Parameters.AddWithValue("@d", dtpDate.Value.Date);
                insert.Parameters.AddWithValue("@s", dtpStart.Value.TimeOfDay);
                insert.Parameters.AddWithValue("@e", endTime);
                insert.Parameters.AddWithValue("@t", total);

                insert.ExecuteNonQuery();
            }

            LoadReservations();
            MessageBox.Show("Rezervasiya uğurla edildi ✔️");
        }
    }
}
