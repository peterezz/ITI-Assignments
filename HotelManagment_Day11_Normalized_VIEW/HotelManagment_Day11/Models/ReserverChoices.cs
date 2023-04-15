using System;

namespace HotelManagment_Day11.Models
{
    public class ReserverChoices
    {
        public int Id { get; set; }
        public string room_type { get; set; } = string.Empty;
        public int room_floor { get; set; }
        public int room_number { get; set; }
        public DateTime arrival_time { get; set; } = DateTime.Now;
        public DateTime leaving_time { get; set; } = DateTime.Now.AddDays( 7 );
        public bool check_in { get; set; }
        public bool supply_status { get; set; }
        public bool send_sms { get; set; }
        public int resrver_id { get; set; }
        public Reserver Reserver { get; set; } = new Reserver( );
    }
}
