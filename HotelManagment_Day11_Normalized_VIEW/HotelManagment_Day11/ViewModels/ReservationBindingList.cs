using System;

namespace HotelManagment_Day11.ViewModels
{
    public class ReservationBindingList
    {
        public string first_name { get; set; } = string.Empty;
        public string last_name { get; set; } = string.Empty;
        public string birth_day { get; set; } = string.Empty;
        public string gender { get; set; } = string.Empty;
        public string phone_number { get; set; } = string.Empty;
        public string email_address { get; set; } = string.Empty;
        public int number_guest { get; set; }
        public string street_address { get; set; } = string.Empty;
        public string apt_suite { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public string zip_code { get; set; } = string.Empty;
        public string state { get; set; } = string.Empty;
        public string RoomType { get; set; } = string.Empty;
        public int room_floor { get; set; }
        public int room_number { get; set; }
        public DateTime arrival_time { get; set; } = DateTime.Now;
        public DateTime leaving_time { get; set; } = DateTime.Now.AddDays( 7 );
        public bool check_in { get; set; }
        public bool supply_status { get; set; }
        public bool send_sms { get; set; }
    }
}
