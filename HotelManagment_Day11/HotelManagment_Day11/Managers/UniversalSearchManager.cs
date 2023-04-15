using HotelManagment_Day11.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagment_Day11.Managers
{
    public class UniversalSearchManager
    {
        FRONTEND_RESERVATIONContext _context = new FRONTEND_RESERVATIONContext( );
        public List<Reservation> RestreaveReservationBySearchKey( string searchKey )
        {
            if ( string.IsNullOrEmpty( searchKey ) )
                return _context.Reservations.ToList( );
            return _context.Reservations.Where( res => res.FirstName == searchKey || res.LastName == searchKey || res.Gender == searchKey || res.EmailAddress == searchKey ).ToList( );

        }

    }
}
