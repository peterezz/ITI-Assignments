using HotelManagment_Day11.Models;
using HotelManagment_Day11.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HotelManagment_Day11.Managers
{
    class LoginManager
    {
        HotelManagmentContext hotelManagmentContext = new HotelManagmentContext( );

        public async Task<Roles> LoginUserAsync( UserViewModel userViewModel )
        {
            var user = await hotelManagmentContext.Users.FirstOrDefaultAsync( user => user.user_name.Equals( userViewModel.user_name ) && user.pass_word.Equals( userViewModel.pass_word ) );
            if ( user == null )
                return Roles.NotFound;
            else if ( user.Role == Roles.admin )
                return Roles.admin;
            else if ( user.Role == Roles.kitchen )
                return Roles.kitchen;
            return Roles.NotFound;
        }
    }
}
