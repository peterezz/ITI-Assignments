using HotelManagment_Day11.Models;
using HotelManagment_Day11.ViewModels;

namespace HotelManagment_Day11.Mappers
{
    public static class Reserver_ServiceMapper
    {
        public static Resrever_ServiceViewModel ToResrever_ServiceViewModel( this Reserver_Service model , int reserverid )
        {
            return new( )
            {
                Quantity = model.Quantity ,
                ReseverID = reserverid ,
                Services = model.Services.ToServiceViewModel( )
            };
        }
    }
}
