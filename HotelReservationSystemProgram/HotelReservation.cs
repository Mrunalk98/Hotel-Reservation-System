using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSystemProgram
{
    public class HotelReservation
    {
        Dictionary<string, Hotel> hotelRecords = new Dictionary<string, Hotel>();
        public void AddHotel(string hotelName, double weekdayRate, double weekendRate, string customerType)
        {
            Hotel hotel = new Hotel();
            hotel.HotelName = hotelName;
            hotel.WeekdayRate = weekdayRate;
            hotel.WeekendRate = weekendRate;
            hotel.CustomerType = customerType;
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

            double numberOfDays = (endDate - startDate).TotalDays + 1;
            foreach(Hotel hotel in hotelRecords.Values)
            {
                hotelRate = numberOfDays * hotel.WeekdayRate;
                if (hotelRecords.Values.ToList().IndexOf(hotel) == 0 || hotelRate < minRate)
                {
                    minRate = hotelRate;
                    MinRateHotel = hotel;
                }
            }
            Console.Write("Cheapest Hotel : \t");
            Console.WriteLine("Hotel Name: " + MinRateHotel.HotelName + "\t Total Rate: $" + minRate);

        }

    }
}
