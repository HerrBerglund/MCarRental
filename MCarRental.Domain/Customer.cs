﻿using System.Collections.Generic;

namespace MCarRental.Domain
{
    public class Customer
    {
        public Customer()
        {
            Bookings = new List<Booking>();
        }

        //comments added
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelephoneNumeber { get; set; }
        public string Email { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}