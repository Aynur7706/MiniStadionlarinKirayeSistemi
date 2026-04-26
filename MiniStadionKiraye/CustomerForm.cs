using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniStadionKiraye
{
    public partial class CustomerForm : Form
    {
        int selectedId = 0;

        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomers(); // Load burada çağırılır (xətasız yol)
        }

        void LoadCustomers()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT Id, FullName AS [Ad Soyad], Phone AS [Telefon] FROM Customers",
                    conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("Ad Soyad boş ola bilməz");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Customers (FullName, Phone) VALUES (@n,@p)",
                    conn);

                cmd.Parameters.AddWithValue("@n", txtFullName.Text);
                cmd.Parameters.AddWithValue("@p", txtPhone.Text);
                cmd.ExecuteNonQuery();
            }

            Clear();
            LoadCustomers();
            MessageBox.Show("Müştəri əlavə olundu ✔️");
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells["Id"].Value);
                txtFullName.Text = dgvCustomers.Rows[e.RowIndex].Cells["Ad Soyad"].Value.ToString();
                txtPhone.Text = dgvCustomers.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Yeniləmək üçün müştəri seç");
                return;
            }

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Customers SET FullName=@n, Phone=@p WHERE Id=@id",
                    conn);

                cmd.Parameters.AddWithValue("@n", txtFullName.Text);
                cmd.Parameters.AddWithValue("@p", txtPhone.Text);
                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.ExecuteNonQuery();
            }

            Clear();
            LoadCustomers();
            MessageBox.Show("Müştəri yeniləndi ✔️");
        }

        void Clear()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            selectedId = 0;
        }
    }
}
