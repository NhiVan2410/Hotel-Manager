using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Manager
{
    public class Guest : Person
    {
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Guest(int id, string name, string username, string password, string gender, DateTime dateOfBirth, string phoneNumber, string address)
            : base(id, name, username, password)
        {
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Gender: {Gender}, Date of Birth: {DateOfBirth.ToShortDateString()}, Phone: {PhoneNumber}, Address: {Address}");
        }
    }
}