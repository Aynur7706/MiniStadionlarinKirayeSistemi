namespace MiniStadionKiraye
{
    partial class StadiumScheduleForm
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
            this.cmbStadium = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 50);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Stadion Doluluq Cədvəli";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbStadium
            // 
            this.cmbStadium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStadium.Location = new System.Drawing.Point(20, 70);
            this.cmbStadium.Name = "cmbStadium";
            this.cmbStadium.Size = new System.Drawing.Size(250, 24);
            this.cmbStadium.TabIndex = 3;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(290, 70);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLoad.Location = new System.Drawing.Point(510, 65);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 35);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Yüklə";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvSchedule.ColumnHeadersHeight = 29;
            this.dgvSchedule.Location = new System.Drawing.Point(20, 120);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(640, 300);
            this.dgvSchedule.TabIndex = 0;
            // 
            // StadiumScheduleForm
            // 
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbStadium);
            this.Controls.Add(this.lblTitle);
            this.Name = "StadiumScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stadion Doluluq";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbStadium;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvSchedule;
    }
}
    