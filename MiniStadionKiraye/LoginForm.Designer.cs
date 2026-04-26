namespace MiniStadionKiraye
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Text = "İstifadəçi adı:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(160, 38);
            this.txtUser.Size = new System.Drawing.Size(200, 22);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Text = "Şifrə:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(160, 78);
            this.txtPass.Size = new System.Drawing.Size(200, 22);
            this.txtPass.PasswordChar = '*';
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(160, 120);
            this.btnLogin.Size = new System.Drawing.Size(120, 35);
            this.btnLogin.Text = "Daxil ol";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(420, 200);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
    }
}
