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
    public partial class Booking_Room : UserControl
    {
        public Booking_Room()
        {
            InitializeComponent();
        }

        private void BtnConfirmBooking_Click(object sender, EventArgs e)
        {
            try
            {
                int BookingID = int.Parse(txtBookingID.Text);
                MessageBox.Show($"Booking ID: {BookingID}");
                string guestname = txtGuestName.Text;
                MessageBox.Show($"Guest: {guestname}");
                string RoomType = cmbRoomType.SelectedItem?.ToString();
                MessageBox.Show($"Room Type: {RoomType}");
                DateTime booking = dtpBooking.Value;
                MessageBox.Show($"Date booking: {booking}");
                DateTime Checkin = dtpCheckIn.Value;
                MessageBox.Show($" Check In: {Checkin}");
                DateTime Checkout = dtpCheckOut.Value;
                MessageBox.Show($" Check Out: {Checkout}");

                Guest guest = new Guest(
            id: 1,                  
            name: guestname,         
            username: "guestUsername",
            password: "12345",         
            gender: "Male",           
            dateOfBirth: DateTime.Parse("1990-01-01"), 
            phoneNumber: "0123456789", 
            address: "123 Main Street" 
        );

                Room room = new Room(
         roomId: 101,          
         roomType: RoomType, 
         price: 200.0,        
         isAvailable: true     
     );
                BookingRoom Booking = new BookingRoom(BookingID, guest, room,
                    booking, Checkin, Checkout);

                MessageBox.Show("Đặt phòng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            { 
          
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}








