using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Hotel:TourismDestination1
    {
        public Hotel(string? name, string? location, int rating, double pricePerNight,string? hotelName,int availableRooms) 
            : base(name, location, rating, pricePerNight)
        {
            HotelName = hotelName;
            AvailableRooms = availableRooms;
        }

        public string? HotelName {  get; set; }
        public int AvailableRooms {  get; set; }
    }
}
