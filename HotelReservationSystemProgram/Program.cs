﻿using System;
using System.Collections.Generic;

namespace HotelReservationSystemProgram
{
    class Program
    {
        private static string REGULAR = "Regular";
        private static string REWARD = "Reward";
        static void Main(string[] args)
        {
            Console.WriteLine("Hotel Reservation System Program!");
            HotelReservation reservation = new HotelReservation();
            reservation.AddHotel("Lakewood", 110, 90, REGULAR);
            reservation.AddHotel("Bridgewood", 160, 60, REGULAR);
            reservation.AddHotel("Ridgewood.", 220, 150, REGULAR);
            reservation.DisplayHotels();
        }
    }
}