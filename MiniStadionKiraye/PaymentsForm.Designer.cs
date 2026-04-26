namespace MiniStadionKiraye
{
    partial class PaymentsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbReservation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(900, 50);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Ödəniş Sistemi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rezervasiya:";
            // 
            // cmbReservation
            // 
            this.cmbReservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReservation.Location = new System.Drawing.Point(130, 78);
            this.cmbReservation.Name = "cmbReservation";
            this.cmbReservation.Size = new System.Drawing.Size(250, 24);
            this.cmbReservation.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Məbləğ:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(130, 118);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(250, 22);
            this.txtAmount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ödəniş növü:";
            // 
            // cmbType
            // 
            this.cmbType.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cmbType.Location = new System.Drawing.Point(130, 158);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(250, 24);
            this.cmbType.TabIndex = 2;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPay.Location = new System.Drawing.Point(130, 200);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 40);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Ödəniş et";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPayments.ColumnHeadersHeight = 29;
            this.dgvPayments.Location = new System.Drawing.Point(420, 70);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(450, 320);
            this.dgvPayments.TabIndex = 0;
            // 
            // PaymentsForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 420);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "PaymentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödənişlər";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbReservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dgvPayments;
    }
}
