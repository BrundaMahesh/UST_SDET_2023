using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? location, int rating)
        {
            Name = name;
            Location = location;
            Rating = rating;
        }

        public string? Name { get; set; }
        public string? Location { get; set; }
        public int Rating { get; set; }


        public static void Sorting()
        {
            List<TourismDestination> tourismDestinations = new List<TourismDestination>();
            tourismDestinations.Add(new TourismDestination("Ooty","Tamilnadu",4));
            tourismDestinations.Add(new TourismDestination("Yaana", "Karnataka", 2));
            tourismDestinations.Add(new TourismDestination("Varkala", "Kerala", 3));

            var sorted=tourismDestinations.OrderByDescending(x => x.Rating);
            foreach (var item in sorted)
            {
                Console.WriteLine("Name:"+item.Name+" "+"Location:"+item.Location+" "+"Rating:"+item.Rating);

            }

        }
    
    }
}
