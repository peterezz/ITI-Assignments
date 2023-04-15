using HotelManagment_Day11.Mappers;
using HotelManagment_Day11.Models;
using HotelManagment_Day11.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment_Day11.Managers
{
    public class ReservationManager
    {
        HotelManagmentContext hotelManagmentContext = new( );
        Reserver_ServiceManager serviceManager = new( );
        public async Task<int> CreateReservationAsync( ReservationViewModel reservationViewModel )
        {
            try
            {
                //if ( reservationViewModel.Resrever_Service.Count == 0 && reservationViewModel.PaymentViewModel.ID == 0 )
                //    return 0;
                await hotelManagmentContext.AddAsync( reservationViewModel.ToReservers( ) );
                await hotelManagmentContext.SaveChangesAsync( );
                reservationViewModel.Id = hotelManagmentContext.Reservers.OrderByDescending( reserver => reserver.Id ).FirstOrDefault( )?.Id ?? 0;
                await hotelManagmentContext.AddAsync( reservationViewModel.ToReserverChoices( ) );
                await hotelManagmentContext.SaveChangesAsync( );
                return await serviceManager.FinalizeService( );
            }
            catch ( Exception )
            {
                return 0;
            }
        }
        public async Task<List<ResrverGender>> LoadGenderAsync( ) => await hotelManagmentContext.ResrverGenders.ToListAsync( );
        public async Task<List<ReserverState>> LoadStatesAsync( ) => await hotelManagmentContext.ReserverStates.ToListAsync( );
        public async Task<List<ReservationViewModel>> RetrieveReservationsAsync( string SearchKey = "" )
        {

            if ( string.IsNullOrEmpty( SearchKey ) )
                return await hotelManagmentContext.Reservers.Include( res => res.gender ).Include( res => res.state ).Include( res => res.choices ).Select( res => res.ToReservationViewModel( ) ).ToListAsync( );
            return await hotelManagmentContext.Reservers.Include( res => res.gender ).Include( res => res.state ).Include( res => res.choices ).Where( res => res.first_name.Contains( SearchKey ) || res.last_name.Contains( SearchKey ) || res.email_address.Contains( SearchKey ) || res.gender.Gender.Contains( SearchKey ) || res.state.State.Contains( SearchKey ) ).Select( res => res.ToReservationViewModel( ) ).ToListAsync( );

        }
        public async Task<int> UpdateReservationAsync( ReservationViewModel reservationViewModel )
        {


            try
            {
                var Result = await hotelManagmentContext.Reservers.FindAsync( reservationViewModel.Id );
                #region Update values
                var ResultChoice = Result.choices.FirstOrDefault( );
                Result.first_name = reservationViewModel.first_name;
                Result.last_name = reservationViewModel.last_name;
                Result.gender_id = reservationViewModel.gender_id;
                Result.number_guest = reservationViewModel.number_guest;
                Result.phone_number = reservationViewModel.phone_number;
                Result.apt_suite = reservationViewModel.apt_suite;
                Result.birth_day = reservationViewModel.birth_day;
                Result.email_address = reservationViewModel.email_address;
                Result.street_address = reservationViewModel.street_address;
                Result.city = reservationViewModel.city;
                Result.state_id = reservationViewModel.state_id;
                Result.zip_code = reservationViewModel.zip_code;
                ResultChoice.room_number = reservationViewModel.reserverChoices.room_number;
                ResultChoice.arrival_time = reservationViewModel.reserverChoices.arrival_time;
                ResultChoice.leaving_time = reservationViewModel.reserverChoices.leaving_time;
                ResultChoice.leaving_time = reservationViewModel.reserverChoices.leaving_time;
                ResultChoice.check_in = reservationViewModel.reserverChoices.check_in;
                ResultChoice.room_floor = reservationViewModel.reserverChoices.room_floor;
                ResultChoice.supply_status = reservationViewModel.reserverChoices.supply_status;
                ResultChoice.send_sms = reservationViewModel.reserverChoices.send_sms;
                ResultChoice.room_type = reservationViewModel.reserverChoices.RoomType;
                #endregion
                return await serviceManager.FinalizeService( );


            }
            catch ( Exception ex )
            {
                return 0;
            }
        }
        public async Task<int> DeleteReservationAsync( int reserverID )
        {
            try
            {
                var data = await hotelManagmentContext.Reservers.FindAsync( reserverID );
                hotelManagmentContext.Reservers.Remove( data );
                return await hotelManagmentContext.SaveChangesAsync( );
            }
            catch ( Exception ex )
            {
                return 0;
            }
        }


    }
}
