using HotelManagment_Day11.Models;
using HotelManagment_Day11.ViewModels;

namespace HotelManagment_Day11.Mappers
{
    public static class ReserverChoicesMapper
    {
        public static ReserverChoices ToReserverChoices( this ReservationViewModel reservationViewModel )
        {
            return new ReserverChoices
            {
                resrver_id = reservationViewModel.Id ,
                arrival_time = reservationViewModel.reserverChoices.arrival_time ,
                check_in = reservationViewModel.reserverChoices.check_in ,
                leaving_time = reservationViewModel.reserverChoices.leaving_time ,
                room_floor = reservationViewModel.reserverChoices.room_floor ,
                room_number = reservationViewModel.reserverChoices.room_number ,
                room_type = reservationViewModel.reserverChoices.RoomType ,
                supply_status = reservationViewModel.reserverChoices.supply_status
            };
        }
        public static ReserverChoicesViewModel ToReserverViewModel( this ReserverChoices reserverChoices )
        {
            return new( )
            {
                arrival_time = reserverChoices.arrival_time ,
                leaving_time = reserverChoices.leaving_time ,
                Id = reserverChoices.Id ,
                check_in = reserverChoices.check_in ,
                resrver_id = reserverChoices.resrver_id ,
                room_floor = reserverChoices.room_floor ,
                room_number = reserverChoices.room_number ,
                RoomType = reserverChoices.room_type ,
                send_sms = reserverChoices.send_sms ,
                supply_status = reserverChoices.supply_status
            };
        }
    }
}
