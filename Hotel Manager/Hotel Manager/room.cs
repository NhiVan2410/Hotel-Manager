using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Manager
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomType { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
  
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; private set; }


        public Room(int roomId, string roomType, double price, bool isAvailable)
        {
            RoomID = roomId;
            RoomType = roomType;
            Price = price;
            IsAvailable = isAvailable;
            CreatedAt = DateTime.Now; 
            UpdatedAt = DateTime.Now; 
            IsDeleted = false;
        }
        // hiện thị chi tiết phòng
        public void DisplayRoomDetails()
        {
            Console.WriteLine($"Room Id: {RoomID}, Type: {RoomType}, Price: {Price}, Available: {IsAvailable}");
        }
        // Đánh dấu phòng khách hủy 
        public void MarkAsDeleted()
        {
            IsDeleted = true;
            UpdatedAt = DateTime.Now;
        }
    }
}