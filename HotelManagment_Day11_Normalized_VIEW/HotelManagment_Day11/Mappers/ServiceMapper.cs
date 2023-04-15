using HotelManagment_Day11.Models;
using HotelManagment_Day11.ViewModels;

namespace HotelManagment_Day11.Mappers
{
    public static class ServiceMapper
    {
        public static ServiceViewModel ToServiceViewModel( this Service menu )
        {
            return new( )
            {
                Id = menu.Id ,
                price = menu.price ,
                service = menu.service
            };
        }
    }
}
