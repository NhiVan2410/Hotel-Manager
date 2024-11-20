using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        private void HideMenu()
        {
            btnHome.Visible = false;
        }
        private void ShowMenu()
        {
            btnHome.Visible = true;
        }
        private void Room_Management_Load(object sender, EventArgs e)
        {

        }

        private void btnBookingRoon_Click(object sender, EventArgs e)
        {
            HideMenu();
            pnlContent.Controls.Clear();
            Booking_Room bookingRoomControl = new Booking_Room();
            bookingRoomControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(bookingRoomControl);
          
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "Where comfort meets excellence!\n Explore our services below or on the right to book your stay, manage reservations, or request personalized services. We’re here to make your experience unforgettable!";

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           
            

        }
    }
}
