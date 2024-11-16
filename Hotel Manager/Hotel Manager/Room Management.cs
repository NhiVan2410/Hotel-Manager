using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Manager
{
    public partial class Room_Management : Form
    {
        public Room_Management()
        {
            InitializeComponent();
        }

        private void Room_Management_Load(object sender, EventArgs e)
        {

        }

        private void btnBookingRoon_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            Booking_Room bookingRoomControl = new Booking_Room();
            bookingRoomControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(bookingRoomControl);

        }
    }
}
