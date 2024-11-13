using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager
{
    public  class Reservation
    {
        public int ReservationID { get; set; }
        public int GuestID { get; set; }
        public int RoomID { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Feedback { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; private set; }

        public Reservation(int guestID, int roomID, DateTime checkInDate, DateTime checkOutDate)
        {
            GuestID = guestID;
            RoomID = roomID;
            BookingDate = DateTime.Now;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsDeleted = false;
        }
        public void MarkAsDeleted()
        {
            IsDeleted = true;

        }
        public void AddFeedback(string feedback)
        {
            Feedback = feedback;
        }
    }

}
