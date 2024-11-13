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

        public Room(int roomId, string roomType, double price, bool isAvailable)
        {
            RoomID = roomId;
            RoomType = roomType;
            Price = price;
            IsAvailable = isAvailable;
        }
        public void DisplayRoomDetails()
        {
            Console.WriteLine($"Room Id: {RoomID}, Type: {RoomType}, Price: {Price}, Available: {IsAvailable}");
        }
    }
}