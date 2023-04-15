using HotelManagment_Day11.Models;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagment_Day11.Managers
{
    public class AdvViewManager
    {
        FRONTEND_RESERVATIONContext _Context = new FRONTEND_RESERVATIONContext( );
        public List<Reservation> RetrieveAllReservations( )
        {
            return _Context.Reservations.ToList( );
        }
    }
}
