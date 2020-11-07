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
            reservation.AddHotel(1, "Lakewood", 110, 90, REGULAR, 3);
            reservation.AddHotel(2, "Lakewood", 80, 80, REWARD, 3);
            reservation.AddHotel(3, "Bridgewood", 150, 50, REGULAR, 4);
            reservation.AddHotel(4, "Bridgewood", 110, 50, REWARD, 4);
            reservation.AddHotel(5, "Ridgewood", 220, 150, REGULAR, 5);
            reservation.AddHotel(6, "Ridgewood", 100, 40, REWARD, 5);
            reservation.DisplayHotels();
            reservation.GetCheapestBestRatedHotel(REWARD, DateTime.Parse("11Sep2020"), DateTime.Parse("12Sep2020"));
        }
    }
}
