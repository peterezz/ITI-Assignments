using System.Collections.Generic;

namespace HotelManagment_Day11.Models
{
    public class Reserver
    {
        public int Id { get; set; }
        public string first_name { get; set; } = string.Empty;
        public string last_name { get; set; } = string.Empty;
        public string birth_day { get; set; } = string.Empty;
        public int? gender_id { get; set; }
        public ResrverGender? gender { get; set; }
        public string phone_number { get; set; } = string.Empty;
        public string email_address { get; set; } = string.Empty;
        public int number_guest { get; set; }
        public string street_address { get; set; } = string.Empty;
        public string apt_suite { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public int? state_id { get; set; }
        public ReserverState? state { get; set; }
        public string zip_code { get; set; } = string.Empty;
        public ICollection<ReserverChoices> choices { get; set; } = new HashSet<ReserverChoices>( );
        public ICollection<Reserver_Service> services = new HashSet<Reserver_Service>( );
        public int? PaymentID { get; set; }
        public Payment? payment { get; set; } = new Payment( );
    }
}
