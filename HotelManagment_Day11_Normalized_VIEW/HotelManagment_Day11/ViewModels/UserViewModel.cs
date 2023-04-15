namespace HotelManagment_Day11.ViewModels
{
    public class UserViewModel : BaseViewModel
    {

        private string username = string.Empty;
        public string user_name

        {
            get => username;
            set
            {
                username = value;
                RemoveErrorsIfExist( );
                RemoveDefaultError( );
                if ( string.IsNullOrEmpty( username ) )
                    AddError( "username field is required" );
                onPropertyChanged( );
            }
        }
        public string pass_word { get; set; }


    }
}
