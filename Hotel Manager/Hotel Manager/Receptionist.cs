using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager
{
    public class Receptionist : Person
    {
        public Receptionist(int id, string name, string username, string password)
             : base(id, name, username, password)
        {
        }
        //Method ( chekcin và checkout)

        public void HandleCheckIn()
        {
            Console.WriteLine("Handling check-in...");
        }

        public void HandleCheckOut()
        {
            Console.WriteLine("Handling check-out...");
        }
    }
}
