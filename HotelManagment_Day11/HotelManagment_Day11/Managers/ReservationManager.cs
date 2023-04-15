using HotelManagment_Day11.Models;
using System.Collections.Generic;

namespace HotelManagment_Day11.Managers
{
    public class ReservationManager
    {
        FRONTEND_RESERVATIONContext _context = new( );
        public int CreatReservation( Reservation reservation )
        {
            try
            {
                _context.Reservations.Add( reservation );
                return _context.SaveChanges( );
            }
            catch
            {
                return 0;
            }

        }
        public int UpdateReservation( Reservation reservation )
        {
            try
            {
                _context.Entry( reservation ).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges( );
                return 1;
            }
            catch { return 0; }
        }
        public List<Reservation> RetreaveReservations( ) => new AdvViewManager( ).RetrieveAllReservations( );
        public int DeleteReservation( Reservation reservation )
        {
            try
            {

                _context.Reservations.Remove( reservation );
                return _context.SaveChanges( );
            }
            catch { return 0; }
        }


    }
}
