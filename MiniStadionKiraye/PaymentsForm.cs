using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniStadionKiraye
{
    public partial class PaymentsForm : Form
    {
        public PaymentsForm()
        {
            InitializeComponent();
            LoadReservations();
            LoadPayments();
        }

        private void LoadReservations()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT r.Id AS ReservationId,
                       s.Name + ' | ' + c.FullName + ' | ' +
                       CAST(r.TotalPrice AS NVARCHAR) + ' AZN' AS Info
                FROM Reservations r
                JOIN Stadiums s ON r.StadiumId = s.Id
                JOIN Customers c ON r.CustomerId = c.Id", conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbReservation.DataSource = dt;
                    cmbReservation.DisplayMember = "Info";
                    cmbReservation.ValueMember = "ReservationId"; 
                    cmbReservation.SelectedIndex = -1; // default boş
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasiyaları yükləmək mümkün olmadı:\n" + ex.Message);
            }
        }


        private void LoadPayments()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"
                        SELECT p.Id,
                               s.Name AS Stadion,
                               c.FullName AS Müştəri,
                               p.Amount,
                               p.PaymentType,
                               p.PaymentDate
                        FROM Payments p
                        JOIN Reservations r ON p.ReservationId = r.Id
                        JOIN Stadiums s ON r.StadiumId = s.Id
                        JOIN Customers c ON r.CustomerId = c.Id", conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPayments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödənişləri yükləmək mümkün olmadı:\n" + ex.Message);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Seçimləri yoxla
            if (cmbReservation.SelectedIndex == -1)
            {
                MessageBox.Show("Rezervasiya seçilməyib!");
                return;
            }

            if (cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Ödəniş növü seçilməyib!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Ödəniş məbləğini daxil edin!");
                return;
            }

            // ReservationId
            int reservationId;
            try
            {
                reservationId = Convert.ToInt32(cmbReservation.SelectedValue);
            }
            catch
            {
                MessageBox.Show("Rezervasiya ID alınamadı!");
                return;
            }

            // Amount
            decimal amount;
            if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Ödəniş məbləği düzgün deyil!");
                return;
            }

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Payments (ReservationId, Amount, PaymentType) VALUES (@r,@a,@t)",
                        conn);

                    cmd.Parameters.Add("@r", SqlDbType.Int).Value = reservationId;
                    cmd.Parameters.Add("@a", SqlDbType.Decimal).Value = amount;
                    cmd.Parameters.Add("@t", SqlDbType.NVarChar).Value = cmbType.Text;

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Ödəniş uğurla qeydə alındı ✔️");

                // Formu təmizlə və cədvəli yenilə
                txtAmount.Clear();
                cmbType.SelectedIndex = -1;
                cmbReservation.SelectedIndex = -1;
                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödəniş zamanı xəta baş verdi:\n" + ex.Message);
            }
        }
    }
}
