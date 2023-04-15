using System;

namespace HotelManagment_Day11.ViewModels
{
    public class ReserverChoicesViewModel
    {
        public int Id { get; set; }
        public string RoomType { get; set; }
        public int room_floor { get; set; }
        public int room_number { get; set; }
        public DateTime arrival_time { get; set; } = DateTime.Now;
        public DateTime leaving_time { get; set; } = DateTime.Now.AddDays( 7 );
        public bool check_in { get; set; }
        public bool supply_status { get; set; }
        public bool send_sms { get; set; }
        public int resrver_id { get; set; }
    }
}
