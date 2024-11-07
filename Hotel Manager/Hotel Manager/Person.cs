using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Manager
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public string ContactInfo { get; set; }

        public Person(int id, string name, string username, string password)
        {
            ID = id;
            Name = name;
            Username = username;
            Password = password;
        }

        public string GetPassword()
        {
            return Password;
        }

        public void SetPassword(string password)
        {
            Password = password;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Username: {Username}, Contact Info: {ContactInfo}");
        }

        public virtual void MakeReservation()
        {
            Console.WriteLine("Making a general reservation.");
        }

        public virtual void MakeReservation(int roomId)
        {
            Console.WriteLine($"Making a reservation for Room ID: {roomId}");
        }

        public virtual void MakeReservation(int roomId, DateTime date)
        {
            Console.WriteLine($"Making a reservation for Room ID: {roomId} on {date.ToShortDateString()}");
        }
    }
}

