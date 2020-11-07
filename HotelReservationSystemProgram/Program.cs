using System;
using System.Collections.Generic;
using System.Globalization;

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

            var startDate = CheckDateFormat("Check-in Date");
            var endDate = CheckDateFormat("Check-out Date");
            reservation.GetCheapestBestRatedHotel(REWARD, startDate, endDate);
        }

        static DateTime CheckDateFormat(string type)
        {
            bool valid = false;
            DateTime outDate;
            string dateFormat = "ddMMMyyyy";
            while (!valid)
            {
                Console.WriteLine("Enter " + type + " : (ddMMMyyyy)");
                string date = Console.ReadLine();
                if (DateTime.TryParseExact(date, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out outDate))
                {
                    valid = true;
                    return outDate;
                }
                else
                    Console.WriteLine("Invalid date format");
            }
            return default;
        }
    }
}
