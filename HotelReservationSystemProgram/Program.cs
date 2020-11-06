using System;
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
            reservation.AddHotel("Lakewood", 110, 90, REGULAR, 3);
            reservation.AddHotel("Bridgewood", 150, 50, REGULAR, 4);
            reservation.AddHotel("Ridgewood.", 220, 150, REGULAR, 5);
            reservation.GetCheapestHotel(DateTime.Parse("11Sep2020"), DateTime.Parse("12Sep2020"));
        }
    }
}
