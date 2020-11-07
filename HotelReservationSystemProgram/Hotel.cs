using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystemProgram
{
    public class Hotel
    {
        public int HotelID { get; set; }
        public string HotelName { get; set; }
        public double WeekdayRate { get; set; }
        public double WeekendRate { get; set; }
        public string CustomerType { get; set; }
        public double Rating { get; set; }
    }
}
