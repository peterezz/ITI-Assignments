using HotelManagment_Day11.Models;
using System.Linq;

namespace HotelManagment_Day11.Managers
{
    public class LoginManager
    {
        FRONTEND_RESERVATIONContext _Context = new FRONTEND_RESERVATIONContext( );

        public string LoginUser( User user )
        {
            var data = _Context.Users.FirstOrDefault( userr => userr.Username.Equals( user.Username ) && userr.Passward.Equals( user.Passward ) );
            if ( data != null )
                return data.Role;
            return "NotFound";
        }
    }
}
