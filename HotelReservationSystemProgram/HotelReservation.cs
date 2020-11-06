using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSystemProgram
{
    public class HotelReservation
    {
        Dictionary<string, Hotel> hotelRecords = new Dictionary<string, Hotel>();
        List<Hotel> MinRateHotels = new List<Hotel>();
        public void AddHotel(string hotelName, double weekdayRate, double weekendRate, string customerType, double rating)
        {
            Hotel hotel = new Hotel();
            hotel.HotelName = hotelName;
            hotel.WeekdayRate = weekdayRate;
            hotel.WeekendRate = weekendRate;
            hotel.CustomerType = customerType;
            hotel.Rating = rating;
            hotelRecords.Add(hotelName, hotel);
            Console.WriteLine("Hotel added successfully");
        }

        public void DisplayHotels()
        {
            foreach(KeyValuePair<string, Hotel> hotels in hotelRecords)
            {
                Console.WriteLine("Key : " + hotels.Key + "     Value : " + hotels.Value.HotelName + ", " + hotels.Value.WeekdayRate + ", " + hotels.Value.WeekendRate + ", " + hotels.Value.CustomerType);
            }
        }

        public void GetCheapestHotel(DateTime startDate, DateTime endDate)
        {
            double minRate = 0;
            double hotelRate;
            Hotel MinRateHotel = null;
            int weekdayCount = 0;
            int weekendCount = 0;

            double numberOfDays = (endDate - startDate).TotalDays + 1;
            for (int i=0; i<numberOfDays; i++)
            {
                var nextDate = startDate.AddDays(i);
                if (nextDate.DayOfWeek == DayOfWeek.Saturday || nextDate.DayOfWeek == DayOfWeek.Sunday)
                    weekendCount++;
                else
                    weekdayCount++;
            }
            foreach (Hotel hotel in hotelRecords.Values)
            {
                hotelRate = (weekdayCount * hotel.WeekdayRate) + (weekendCount * hotel.WeekendRate);
                if (hotelRecords.Values.ToList().IndexOf(hotel) == 0 || hotelRate <= minRate)
                {
                    minRate = hotelRate;
                    MinRateHotel = hotel;
                    MinRateHotels.Add(MinRateHotel);
                }
            }
            Console.WriteLine("Cheapest Hotel :- ");
            var ratedHotel = MinRateHotels.Select(x => (x.Rating, x)).Max();
            Console.WriteLine("Hotel Name: " + ratedHotel.x.HotelName + "\t Rating: " + ratedHotel.Rating + "\t Total Rate: $" + minRate);
        }

    }
}
