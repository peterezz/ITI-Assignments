using HotelManagment_Day11.Mappers;
using HotelManagment_Day11.Models;
using HotelManagment_Day11.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment_Day11.Managers
{
    public class ServiceManager
    {
        static HotelManagmentContext hotelManagmentContext = new( );
        public static List<ServiceViewModel> models = new List<ServiceViewModel>( );
        public static async Task RetrieveMenuItemsAsync( )
        {
            models = await
                hotelManagmentContext.Services.Select( menu => menu.ToServiceViewModel( ) ).ToListAsync( );

        }
        public static ServiceViewModel RetreaveSingleSivice( int ServiceID )
        {
            return models.Find( ser => ser.Id == ServiceID ) ?? new ServiceViewModel( );



        }
    }
}
