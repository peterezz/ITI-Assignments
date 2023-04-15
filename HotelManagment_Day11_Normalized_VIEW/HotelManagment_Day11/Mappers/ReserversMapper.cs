using HotelManagment_Day11.Models;
using HotelManagment_Day11.ViewModels;
using System.Linq;

namespace HotelManagment_Day11.Mappers
{
    public static class ReserversMapper
    {
        public static Reserver ToReservers( this ReservationViewModel reservationViewModel )
        {
            return new( )
            {
                apt_suite = reservationViewModel.apt_suite ,
                birth_day = reservationViewModel.birth_day ,
                first_name = reservationViewModel.first_name ,
                last_name = reservationViewModel.last_name ,
                phone_number = reservationViewModel.phone_number ,
                gender_id = reservationViewModel.gender_id ,
                state_id = reservationViewModel.state_id ,
                city = reservationViewModel.city ,
                number_guest = reservationViewModel.number_guest ,
                zip_code = reservationViewModel.zip_code ,
                email_address = reservationViewModel.email_address ,
                street_address = reservationViewModel.street_address ,

            };
        }

        public static ReservationViewModel ToReservationViewModel( this Reserver reserver )
        {

            return new( )
            {
                apt_suite = reserver.apt_suite ,
                month = reserver.birth_day.Split( '-' )[ 0 ] ,
                day = int.Parse( reserver.birth_day.Split( '-' )[ 1 ] ) ,
                year = reserver.birth_day.Split( '-' )[ 2 ] ,
                city = reserver.city ,
                email_address = reserver.email_address ,
                first_name = reserver.first_name ,
                last_name = reserver.last_name ,
                gender_id = reserver.gender_id ,
                number_guest = reserver.number_guest ,
                phone_number = reserver.phone_number ,
                state_id = reserver.state_id ,
                street_address = reserver.street_address ,
                zip_code = reserver.zip_code ,
                Id = reserver.Id ,
                gender = reserver.gender?.Gender ?? "N/A" ,
                state = reserver.state?.State ?? "N/A" ,

                reserverChoices = reserver.choices.Select( res => res.ToReserverViewModel( ) ).FirstOrDefault( ) ?? new ReserverChoicesViewModel( ) ,







            };
        }
        public static ReservationBindingList ToBindingList( this ReservationViewModel model )
        {
            return new( )
            {
                apt_suite = model.apt_suite ,
                arrival_time = model.reserverChoices.arrival_time ,
                birth_day = model.birth_day ,
                city = model.city ,
                check_in = model.reserverChoices.check_in ,
                email_address = model.email_address ,
                first_name = model.first_name ,
                last_name = model.last_name ,
                gender = model.gender ,
                leaving_time = model.reserverChoices.leaving_time ,
                number_guest = model.number_guest ,
                phone_number = model.phone_number ,
                RoomType = model.reserverChoices.RoomType ,
                room_floor = model.reserverChoices.room_floor ,
                room_number = model.reserverChoices.room_number ,
                send_sms = model.reserverChoices.send_sms ,
                state = model.state ,
                street_address = model.street_address ,
                supply_status = model.reserverChoices.supply_status ,
                zip_code = model.zip_code

            };
        }
    }
}
