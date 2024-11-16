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
            id: 1,                   // ID khách hàng (thay đổi nếu cần)
            name: guestname,         // Tên khách hàng
            username: "guestUsername",  // Username (cố định hoặc nhập từ giao diện)
            password: "12345",          // Mật khẩu (cố định hoặc nhập từ giao diện)
            gender: "Male",             // Giới tính (tùy chỉnh)
            dateOfBirth: DateTime.Parse("1990-01-01"), // Ngày sinh (cố định hoặc nhập từ giao diện)
            phoneNumber: "0123456789",  // Số điện thoại (tùy chỉnh)
            address: "123 Main Street"  // Địa chỉ (tùy chỉnh)
        );

                Room room = new Room(
         roomId: 101,           // ID phòng (tùy chỉnh)
         roomType: RoomType,    // Loại phòng từ ComboBox
         price: 200.0,          // Giá phòng (cố định hoặc nhập từ giao diện)
         isAvailable: true      // Tình trạng phòng (tùy chỉnh)
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








