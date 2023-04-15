using HotelManagment_Day11.Managers;
using HotelManagment_Day11.Models;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace HotelManagment_Day11.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : MetroWindow
    {
        LoginManager _manager = new LoginManager( );
        public LoginWindow( )
        {
            InitializeComponent( );
        }
        private async void BtnLicense_Click( object sender , System.Windows.RoutedEventArgs e )
        {
            var message = "This program is written for educational purposes only.Open Source frameworks: Modern UI - most of the metro UI implimented using this open source framework license under: MIT - http://github.com/viperneo Twilio - this framework by twilio was used to send the Message to phone number regarding customer reservation. https://www.twilio.com/";

            await this.ShowMessageAsync( "License" , message );
            //    //new FoodAndMenuWindow( ).Show( );
            //    // new Frontend( ).Show( );
        }

        private async void BtnSignin_Click( object sender , System.Windows.RoutedEventArgs e )
        {
            var controller = await this.ShowProgressAsync( "Please wait..." , "Checking your Info" );
            User user = new User
            {
                Passward = TboxPassword.Password ,
                Username = TboxUserName.Text
            };
            string role = _manager.LoginUser( user );
            await controller.CloseAsync( );
            if ( role == "NotFound" )
            {
                await this.ShowMessageAsync( "User Not Found" , "Incorrect username or password" );
                return;
            }
            else if ( role == "admin" )
                new Frontend( ).Show( );
            else if ( role == "kitchen" )
                new KitchenWindow( ).Show( );

            this.Close( );
        }
        //LoginManager loginManager = new( );
        //UserViewModel userViewModel = new UserViewModel( );

        //private async void BtnLicense_Click( object sender , System.Windows.RoutedEventArgs e )
        //{
        //    
        //}

        //private async void BtnSignin_Click( object sender , System.Windows.RoutedEventArgs e )
        //{
        //    var controller = await this.ShowProgressAsync( "Please wait..." , "Checking your Info" );
        //    userViewModel.pass_word = TboxPassword.Password;
        //    Roles userRole = await loginManager.LoginUserAsync( userViewModel );
        //    await controller.CloseAsync( );
        //    if ( userRole == Roles.NotFound )
        //    {
        //        await this.ShowMessageAsync( "User Not Found" , "Incorrect username or password" );
        //        return;
        //    }
        //    else if ( userRole == Roles.admin )
        //        new Frontend( ).Show( );
        //    else if ( userRole == Roles.kitchen )
        //        new KitchenWindow( ).Show( );

        //    this.Close( );
        //}
    }
}
