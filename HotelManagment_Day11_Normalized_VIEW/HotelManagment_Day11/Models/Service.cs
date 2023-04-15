using System.Collections.Generic;

namespace HotelManagment_Day11.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string service { get; set; } = string.Empty;
        public int price { get; set; }
        public ICollection<Reserver_Service> Reserver_Service { get; set; } = new HashSet<Reserver_Service>( );

    }
}
