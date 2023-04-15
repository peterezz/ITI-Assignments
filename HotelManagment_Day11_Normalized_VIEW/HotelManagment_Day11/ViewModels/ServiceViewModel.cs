namespace HotelManagment_Day11.ViewModels
{
    public class ServiceViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string service { get; set; } = string.Empty;
        public int price { get; set; }
        public string DisplayedService { get { return $"{service} ${price} "; } }
    }
}
