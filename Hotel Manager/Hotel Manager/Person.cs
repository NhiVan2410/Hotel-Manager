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
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public  bool IsDeleted { get; private set; }

        // Constructor
        public Person(int id, string name, string username, string password, string contactInfo)
        {
            ID = id;
            Name = name;
            Username = username;
            Password = password;
            ContactInfo = contactInfo;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsDeleted = false;
        }
        // Getter, Setter
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
        public void MarkAsDeleted()
        {
            IsDeleted = true;
            UpdatedAt = DateTime.Now;
            this.MarkAsDeleted();
        }
    }
}

