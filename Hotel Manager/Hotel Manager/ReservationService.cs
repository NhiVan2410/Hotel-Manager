using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager
{
    public  class ReservationService
    {
        public int ReservationServiceID { get; set; }
        public int ReservationID { get; set; }
        public int ServiceID { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; private set; }

        public ReservationService(int reservationID, int serviceID, int quantity)
        {
            ReservationID = reservationID;
            ServiceID = serviceID;
            Quantity = quantity;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsDeleted = false;
        }

        public void MarkAsDeleted()
        {
            IsDeleted = true;
        }
    }
}
