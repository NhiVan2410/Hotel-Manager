using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Manager
{
    public class Manager : Person
    {
        public Manager(int id, string name, string username, string password)
            : base(id, name, username, password)
        {
        }
        // Method QLIKS
        public void ManageHotel()
        {
            Console.WriteLine("Managing the hotel...");
        }
    }
}