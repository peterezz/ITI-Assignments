using HotelManagment_Day11.Mappers;
using HotelManagment_Day11.Models;
using HotelManagment_Day11.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment_Day11.Managers
{
    public class Reserver_ServiceManager
    {
        HotelManagmentContext hotelManagmentContext = new( );
        ReservationViewModel Reservation = ReservationPagePage.reservationViewModel;
        public async Task<bool> AlreadyServed( int reserverID )
        {
            if ( reserverID != 0 )
                return await hotelManagmentContext.Reservers_Services.AnyAsync( res => res.ReserverID == reserverID );
            return false;
        }
        public async Task<List<Resrever_ServiceViewModel>> GetServices( )
        {
            if ( ReservationPagePage.reservationViewModel.Resrever_Service.ToList( ).Count == 0 )
                Reservation.Resrever_Service.ToList( ).Clear( );

            await ServiceManager.RetrieveMenuItemsAsync( );
            for ( int i = 1 ; i <= ServiceManager.models.Count( ) ; i++ )
            {

                if ( !Reservation.Resrever_Service.ToList( ).Any( ser => ser.Services.Id == i ) )
                    Reservation.Resrever_Service.Add( new Resrever_ServiceViewModel( )
                    {
                        Services = ServiceManager.RetreaveSingleSivice( i ) ,
                        Quantity = 0 ,
                        ReseverID = Reservation.Id
                    } );
            }
            return Reservation.Resrever_Service.ToList( );
        }
        private int CreateReserver_ServiceAsync( )
        {
            try
            {
                var data = hotelManagmentContext.Reservers_Services.FirstOrDefault( res => res.ReserverID == Reservation.Id );
                if ( data == null )
                {
                    foreach ( var item in Reservation.Resrever_Service.ToList( ).Where( res => res.Quantity != 0 ) )
                    {
                        hotelManagmentContext.Reservers_Services.Add( new Reserver_Service
                        {
                            Quantity = item.Quantity ,
                            ReserverID = Reservation.Id ,
                            ServiceID = item.Services.Id
                        } );
                        hotelManagmentContext.SaveChanges( );
                    }
                    return 1;
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }
        public async Task<int> FinalizeService( )
        {
            var data = await hotelManagmentContext.Reservers_Services.FirstOrDefaultAsync( res => res.ReserverID == Reservation.Id );
            if ( data == null )
                return CreateReserver_ServiceAsync( );
            return await UpdateResever_serviceAsync( );
        }

        private async Task<int> UpdateResever_serviceAsync( )
        {
            try
            {
                var newdate = Reservation.Resrever_Service;
                foreach ( var data in newdate )
                {
                    var oldData = hotelManagmentContext.Reservers_Services.FirstOrDefault( res => res.ReserverID == Reservation.Id && res.ServiceID == data.Services.Id );
                    if ( oldData != null && data.Quantity == 0 )
                        hotelManagmentContext.Reservers_Services.Remove( oldData );
                    else if ( oldData != null && data.Quantity != oldData.Quantity )
                        oldData.Quantity = data.Quantity;
                    else if ( oldData == null )
                        await hotelManagmentContext.Reservers_Services.AddAsync( new Reserver_Service
                        {
                            ReserverID = Reservation.Id ,
                            ServiceID = data.Services.Id ,
                            Quantity = data.Quantity
                        } );

                    await hotelManagmentContext.SaveChangesAsync( );
                }
                return 1;

            }
            catch
            {
                return 0;
            }
        }
        public async Task<List<Resrever_ServiceViewModel>> SearchService( int reserverID )
        {
            return await hotelManagmentContext.Reservers_Services.Where( res => res.ReserverID == reserverID ).Select( res => res.ToResrever_ServiceViewModel( reserverID ) ).ToListAsync( );
        }
    }
}
