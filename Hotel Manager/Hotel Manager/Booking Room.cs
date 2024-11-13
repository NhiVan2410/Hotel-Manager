using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager
{
    public class Booking_Room
    {
        public int BookingId { get; set; }
        public Guest Guest { get; set; }
        public Room Room { get; set; }
        public DateTime BookingDate { get; set; } // ngày book phòng
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Booking_Room(int bookingId, Guest guest, Room room,
            DateTime bookingDate, DateTime checkInDate, DateTime checkOutDate)
        {
            BookingId = bookingId;
            Guest = guest;
            Room = room;
            BookingDate = bookingDate;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
        //method

        public void DisplayBookingDetails()
        {
            Console.WriteLine($"Booking ID: {BookingId}");
            Console.WriteLine($"Guest: {Guest.Name}, Room ID: {Room.RoomID}");
            Console.WriteLine($"Booking Date: {BookingDate.ToShortDateString()}, Check-In: {CheckInDate.ToShortDateString()}, Check-Out: {CheckOutDate.ToShortDateString()}");
        }
    }
}
