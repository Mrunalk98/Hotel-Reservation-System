using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSystemProgram
{
    public class HotelReservation
    {
        Dictionary<int, Hotel> hotelRecords = new Dictionary<int, Hotel>();
        List<Hotel> MinRateHotels = new List<Hotel>();
        public void AddHotel(int hotelId, string hotelName, double weekdayRate, double weekendRate, string customerType, double rating)
        {
            Hotel hotel = new Hotel();
            hotel.HotelID = hotelId;
            hotel.HotelName = hotelName;
            hotel.WeekdayRate = weekdayRate;
            hotel.WeekendRate = weekendRate;
            hotel.CustomerType = customerType;
            hotel.Rating = rating;
            hotelRecords.Add(hotelId, hotel);
            Console.WriteLine("Hotel added successfully");
        }

        public void DisplayHotels()
        {
            foreach(KeyValuePair<int, Hotel> hotels in hotelRecords)
            {
                Console.WriteLine("Key : " + hotels.Key + "     Value : " + hotels.Value.HotelName + ", " + hotels.Value.WeekdayRate + ", " + hotels.Value.WeekendRate + ", " + hotels.Value.CustomerType);
            }
        }

        public int[] getDaysCount(DateTime startDate, DateTime endDate)
        {
            int[] weekDays = new int[2];
            double numberOfDays = (endDate - startDate).TotalDays + 1;
            for (int i = 0; i < numberOfDays; i++)
            {
                var nextDate = startDate.AddDays(i);
                if (nextDate.DayOfWeek == DayOfWeek.Saturday || nextDate.DayOfWeek == DayOfWeek.Sunday)
                    weekDays[0]++;
                else
                    weekDays[1]++;
            }
            return weekDays;
        }
        public void GetCheapestHotel(DateTime startDate, DateTime endDate)
        {
            double minRate = 0;
            double hotelRate;
            Hotel MinRateHotel = null;

            int[] Days = new int[2];
            Days = getDaysCount(startDate, endDate);
            foreach (Hotel hotel in hotelRecords.Values)
            {
                hotelRate = (Days[0] * hotel.WeekendRate) + (Days[1] * hotel.WeekdayRate);
                if (hotelRecords.Values.ToList().IndexOf(hotel) == 0 || hotelRate <= minRate)
                {
                    minRate = hotelRate;
                    MinRateHotel = hotel;
                    MinRateHotels.Add(MinRateHotel);
                }
            }
            Console.WriteLine("\nCheapest Hotel :- ");
            var ratedHotel = MinRateHotels.Select(x => (x.Rating, x)).Max();
            Console.WriteLine("Hotel Name: " + ratedHotel.x.HotelName + "\t Rating: " + ratedHotel.Rating + "\t Total Rate: $" + minRate);
        }

        public void GetBestRatedHotel(DateTime startDate, DateTime endDate)
        {
            double hotelRate;
            int[] Days = new int[2];
            Days = getDaysCount(startDate, endDate);
            var bestRateHotel = hotelRecords.Values.Select(x => (x.Rating, x)).Max();
            hotelRate = (Days[0] * bestRateHotel.x.WeekendRate) + (Days[1] * bestRateHotel.x.WeekdayRate);
            Console.WriteLine("\nBest Rated Hotel :- ");
            Console.WriteLine("Hotel Name: " + bestRateHotel.x.HotelName + "\t Rating: " + bestRateHotel.Rating + "\t Total Rate: $" + hotelRate);
        }

    }
}
