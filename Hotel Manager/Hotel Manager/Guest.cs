using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Manager
{
    public class Guest : Person
    {
        public int GuestID { get; set; }
        public new string Name { get; set; } // che khuất person tránh lập lại
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public new bool IsDeleted { get; protected set; }

        public Guest(int id, string name, string username, string password, string gender, DateTime dateOfBirth, string phoneNumber, string address)
      : base(id, name, username, password, contactInfo: "")
        {
            Gender = gender;
            Name = name;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Address = address;

        }
        // Method thực hiện đặt phòng.
        public void MakeReservation()
        {
            Console.WriteLine("Making a reservation...");
        }
        // Methof : Dịch vụ yêu cầu ổ sung

        public void RequestService()
        {
            Console.WriteLine("Requesting a service...");
        }
        public new void MarkAsDeleted()
        {
            IsDeleted = true;
            UpdatedAt = DateTime.Now;
        }
    }
}