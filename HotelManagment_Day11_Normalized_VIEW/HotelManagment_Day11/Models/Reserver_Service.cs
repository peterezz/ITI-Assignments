namespace HotelManagment_Day11.Models
{
    public class Reserver_Service
    {
        public int ReserverID { get; set; }
        public Reserver? Reservers { get; set; } = new Reserver( );
        public int ServiceID { get; set; }
        public Service? Services { get; set; } = new Service( );
        public int Quantity { get; set; }
    }
}
