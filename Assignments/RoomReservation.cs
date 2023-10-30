using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class RoomReservation<T>
    {
        public static List<T> reservationList= new List<T>();
        public void AddRoom(T Room)
        {
            reservationList.Add(Room);
        }
        public void RemoveRoom(T Room)
        {
            reservationList.Remove(Room);
        }
    }
}
