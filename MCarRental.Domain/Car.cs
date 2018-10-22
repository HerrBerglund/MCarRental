using System;
using System.Collections.Generic;

namespace MCarRental.Domain
{
    public class Car
    {
        public Car()
        {
            Bookings = new List<Booking>();
        }

        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string Brand { get; set; }
        public string Mark { get; set; }
        public int Year { get; set; }
        public List<Booking> Bookings { get; set; }

        public bool IsReturned { get; set; }
    }
}