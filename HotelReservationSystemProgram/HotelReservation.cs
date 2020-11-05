using System;
using System.Collections.Generic;
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

    }
}
