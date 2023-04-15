using System.Collections.Generic;

namespace HotelManagment_Day11.Models
{
    public class ReserverState
    {
        public int Id { get; set; }
        public string State { get; set; } = string.Empty;
        public ICollection<Reserver> Reservers { get; set; } = new HashSet<Reserver>( );
    }
}
