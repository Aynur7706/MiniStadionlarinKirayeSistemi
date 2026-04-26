using System;
using System.Windows.Forms;

namespace MiniStadionKiraye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStadiums_Click(object sender, EventArgs e)
        {
            new StadiumForm().ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new CustomerForm().ShowDialog();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            new ReservationForm().ShowDialog();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            new PaymentsForm().ShowDialog();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            new StadiumScheduleForm().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
