using HotelManagment_Day11.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagment_Day11.Managers
{
    public class RoomAvailabiltyManager
    {
        FRONTEND_RESERVATIONContext _context = new FRONTEND_RESERVATIONContext( );
        public List<string> RetreaveOuccupiedReservers( ) => _context.Reservations.Where( res => res.CheckIn ).Select( res => $"{res.RoomNumber} |  {res.RoomType} | {res.Id} | {res.FirstName} {res.LastName} | {res.PhoneNumber}" ).ToList( );
        public List<string> RetreaveReservedReservers( ) => _context.Reservations.Where( res => !res.CheckIn ).Select( res => $"{res.RoomNumber} |  {res.RoomType} | {res.Id} | {res.FirstName} {res.LastName} | {res.PhoneNumber} | {res.ArrivalTime} | {res.LeavingTime}" ).ToList( );

    }
}
