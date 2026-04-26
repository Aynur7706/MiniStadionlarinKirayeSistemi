namespace MiniStadionKiraye
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStadiums = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(150, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mini Stadion Kirayə Sistemi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStadiums
            // 
            this.btnStadiums.BackColor = System.Drawing.Color.Silver;
            this.btnStadiums.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStadiums.Location = new System.Drawing.Point(50, 100);
            this.btnStadiums.Name = "btnStadiums";
            this.btnStadiums.Size = new System.Drawing.Size(220, 45);
            this.btnStadiums.TabIndex = 1;
            this.btnStadiums.Text = "🏟 Stadionlar";
            this.btnStadiums.UseVisualStyleBackColor = false;
            this.btnStadiums.Click += new System.EventHandler(this.btnStadiums_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomers.Location = new System.Drawing.Point(290, 100);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(220, 45);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "👤 Müştərilər";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnReservations.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReservations.Location = new System.Drawing.Point(530, 100);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(220, 45);
            this.btnReservations.TabIndex = 3;
            this.btnReservations.Text = "📅 Rezervasiyalar";
            this.btnReservations.UseVisualStyleBackColor = false;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPayments.Location = new System.Drawing.Point(50, 170);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(220, 45);
            this.btnPayments.TabIndex = 4;
            this.btnPayments.Text = "💰 Ödənişlər";
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSchedule.Location = new System.Drawing.Point(290, 170);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(220, 45);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Text = "⏱ Stadion Doluluğu";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnExit.Location = new System.Drawing.Point(530, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "❌ Çıxış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStadiums);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Əsas Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStadiums;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnExit;
    }
}
