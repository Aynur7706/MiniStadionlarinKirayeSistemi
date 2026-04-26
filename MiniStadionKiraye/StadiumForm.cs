using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniStadionKiraye
{
    public partial class StadiumForm : Form
    {
        int selectedId = 0;

        public StadiumForm()
        {
            InitializeComponent();
        }

        private void StadiumForm_Load(object sender, EventArgs e)
        {
            LoadStadiums();
        }

        void LoadStadiums()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT Id, Name AS [Stadion], PricePerHour AS [Saatlıq Qiymət] FROM Stadiums",
                    conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStadiums.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Stadion adı boş ola bilməz");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Stadiums (Name, PricePerHour) VALUES (@n,@p)",
                    conn);

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@p", numPrice.Value);
                cmd.ExecuteNonQuery();
            }

            Clear();
            LoadStadiums();
            MessageBox.Show("Stadion əlavə olundu ✔️");
        }

        private void dgvStadiums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dgvStadiums.Rows[e.RowIndex].Cells["Id"].Value);
                txtName.Text = dgvStadiums.Rows[e.RowIndex].Cells["Stadion"].Value.ToString();
                numPrice.Value = Convert.ToDecimal(
                    dgvStadiums.Rows[e.RowIndex].Cells["Saatlıq Qiymət"].Value);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Yeniləmək üçün stadion seç");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Stadiums SET Name=@n, PricePerHour=@p WHERE Id=@id",
                    conn);

                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@p", numPrice.Value);
                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.ExecuteNonQuery();
            }

            Clear();
            LoadStadiums();
            MessageBox.Show("Stadion yeniləndi ✔️");
        }

        void Clear()
        {
            txtName.Clear();
            numPrice.Value = 0;
            selectedId = 0;
        }
    }
}
