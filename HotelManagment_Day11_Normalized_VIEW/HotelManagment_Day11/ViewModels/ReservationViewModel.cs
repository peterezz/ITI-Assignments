using System.Collections.Generic;

namespace HotelManagment_Day11.ViewModels
{
    public class ReservationViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string first_name { get; set; } = string.Empty;
        public string last_name { get; set; } = string.Empty;
        public string month { get; set; } = string.Empty;
        public int day { get; set; }
        public string year { get; set; } = string.Empty;
        public string birth_day { get { return $"{month}-{day}-{year}"; } }
        public int? gender_id { get; set; }
        public string gender { get; set; } = string.Empty;
        public string phone_number { get; set; } = string.Empty;
        public string email_address { get; set; } = string.Empty;
        public int number_guest { get; set; }
        public string street_address { get; set; } = string.Empty;
        public string apt_suite { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public int? state_id { get; set; }
        public string state { get; set; } = string.Empty;
        public string zip_code { get; set; } = string.Empty;
        public string DisplayedMember { get { return $"{Id} | {first_name} | {last_name} | {phone_number}"; } }
        public ReserverChoicesViewModel reserverChoices { get; set; } = new ReserverChoicesViewModel( );
        public ICollection<Resrever_ServiceViewModel> Resrever_Service { get; set; } = new List<Resrever_ServiceViewModel>( );
        public PaymentViewModel PaymentViewModel { get; set; } = new PaymentViewModel( );
    }
}
