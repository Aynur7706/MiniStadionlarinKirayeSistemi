using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniStadionKiraye
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT Role FROM Users WHERE Username=@u AND Password=@p",
                    conn);

                cmd.Parameters.AddWithValue("@u", txtUser.Text);
                cmd.Parameters.AddWithValue("@p", txtPass.Text);

                object role = cmd.ExecuteScalar();

                if (role != null)
                {
                    MessageBox.Show("Uğurlu giriş ✔️");

                    Form1 main = new Form1();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("İstifadəçi adı və ya şifrə səhvdir ❌");
                }
            }
        }
    }
}
